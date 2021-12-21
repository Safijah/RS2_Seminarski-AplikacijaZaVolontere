using Data.EntityModels;
using Data.ViewModels;
using Flurl.Http;
using LiveCharts;
using LiveCharts.Wpf;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Office.Interop.Excel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace AplikacijaZaVolontere.UI.Uplata
{
    public partial class PrikazUplata : Form
    {
        ApiService _apiServiceKorisnik = new ApiService("Korisnik/GetKorisnikaZaListu");
        ApiService _apiServiceMjesec = new ApiService("Mjesec");
        ApiService _apiService = new ApiService("Uplata");
        ApiService _apiServiceReport = new ApiService("Uplata/Report");

        public PrikazUplata()
        {
            InitializeComponent();
        }
        Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);
        private void LoadChart(List<PrikazUplataVM> lista)
        {
            LiveCharts.SeriesCollection series = new LiveCharts.SeriesCollection();
            foreach (var x in lista)
            {
                series.Add(new PieSeries() { Title = x.ImeiPrezime, Values = new ChartValues<int> { x.UkupnoUplaceno }, DataLabels = true, LabelPoint = labelPoint });
                pieChart1.Series = series;
            }
            pieChart1.LegendLocation = LegendLocation.Bottom;
        }
        private bool LoadReport()
        {
            if (_parametri.lista != null)
            {
                try
                {

                    Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                    Workbook wb = excel.Workbooks.Add(XlSheetType.xlWorksheet);
                    Worksheet ws = (Worksheet)excel.ActiveSheet;
                    excel.Visible = false;
                    ws.Cells[1, 1] = "Ime i prezime";
                    ws.Cells[1, 2] = "Ukupno potroseno";
                    ws.Cells[1, 3] = "Status studenta";
                    ws.Cells[1, 4] = "VolonterUD";
                    int index = 1;
                    foreach (var x in _parametri.lista)
                    {
                        index++;
                        ws.Cells[index, 1] = x.ImeiPrezime;
                        ws.Cells[index, 2] = x.UkupnoUplaceno;
                        ws.Cells[index, 3] = x.StatusVolontera;
                        ws.Cells[index, 4] = x.VolonterID;
                    }
                    ws.SaveAs(_parametri.FileName, XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                    excel.Quit();
                    return true;
                }
                catch (Exception)
                {

                    return false;
                }
            }
            else
            {
                MessageBox.Show("Nema podataka za preuzimanje");
                return false;
            }
        }
        struct Parametri
        {
            public string FileName { get; set; }
            public List<PrikazUplataVM> lista { get; set; }
        }
        Parametri _parametri;
        private async void PrikazUplata_Load(object sender, EventArgs e)
        {
            await LoadVolontera();
            await LoadMjeseci();
            LoadTipova();
            var result= await _apiService.Get<List<PrikazUplataVM>>();
            dgvUplate.DataSource = result;
            LoadChart(result);
           
        }
        private async Task LoadMjeseci()
        {
            var result = await _apiServiceMjesec.Get<List<Mjesec>>();
            result.Insert(0, new Mjesec());
            cmbMjeseci.DataSource = result;
            cmbMjeseci.DisplayMember = "Naziv";
            cmbMjeseci.ValueMember = "ID";
        }
        private async Task LoadVolontera()
        {
            var result = await _apiServiceKorisnik.Get<List<KorisniciZaListuVM>>();
            result.Insert(0, new KorisniciZaListuVM());
            cmbStudenti.DataSource = result;
            cmbStudenti.DisplayMember = "Naziv";
            cmbStudenti.ValueMember = "ID";
        }
        private void  LoadTipova()
        {
            var result = Iznosi();
            cmbTip.DataSource = result;
            cmbTip.DisplayMember = "Naziv";
            cmbTip.ValueMember = "ID";
        }
        private List<Iznosi> Iznosi()
        {
            List<Iznosi> lista = new List<Iznosi>();
            lista.Add(new Iznosi() { ID = 1, Naziv = "Godišnji" });
            lista.Add(new Iznosi() { ID = 2, Naziv = "Mjesečni" });
            return lista;
        }

        private async void cmbTip_TextChanged(object sender, EventArgs e)
        {
            if (cmbTip.SelectedValue.ToString() == "2")
            {
                cmbMjeseci.Visible = true;
                lblMjesec.Visible = true;
            }
            else
            {
                cmbMjeseci.Visible = false;
                lblMjesec.Visible = false;
                var result = await _apiService.Get<List<PrikazUplataVM>>();
                dgvUplate.DataSource = result;
                LoadChart(result);
            }
        }

        private async  void btnDodaj_Click(object sender, EventArgs e)
        {
            EvidencijaUplata evidencijaUplata = new EvidencijaUplata();
            evidencijaUplata.ShowDialog();
            var result = await _apiService.Get<List<PrikazUplataVM>>();
            dgvUplate.DataSource = result;
        }

        private async void cmbStudenti_SelectedValueChanged(object sender, EventArgs e)
        {
            var result = new List<PrikazUplataVM>();
            string id = " ";
            if (cmbStudenti.SelectedIndex.ToString()!="0")
            {
                 id = cmbStudenti.SelectedValue.ToString();
            }
            if(cmbMjeseci.SelectedIndex.ToString()=="0" && cmbStudenti.SelectedIndex.ToString()=="0")
            {
                 result = await _apiService.Get<List<PrikazUplataVM>>();
                dgvUplate.DataSource = result;
                LoadChart(result);
            }
            else
            {

            int mjesecid =Int32.Parse( cmbMjeseci.SelectedIndex.ToString());
            var url = $"{Properties.Settings.Default.ApiURL}/Uplata/{id}/{mjesecid}";
            result = await url.WithOAuthBearerToken(ApiService.Token).GetJsonAsync<List<PrikazUplataVM>>();
            dgvUplate.DataSource = result;
            LoadChart(result);
            }

        }

        private async void cmbMjeseci_SelectedValueChanged(object sender, EventArgs e)
        {
            var result = new List<PrikazUplataVM>();
            string id = " ";
            if (cmbStudenti.SelectedIndex.ToString() != "0")
            {
                 id = cmbStudenti.SelectedValue.ToString();
            }
            if (cmbMjeseci.SelectedIndex.ToString() == "0" && cmbStudenti.SelectedIndex.ToString() == "0")
            {
                result = await _apiService.Get<List<PrikazUplataVM>>();
                dgvUplate.DataSource = result;
                LoadChart(result);
            }
            else
            {

            int mjesecid = Int32.Parse(cmbMjeseci.SelectedIndex.ToString());
            var url = $"{Properties.Settings.Default.ApiURL}/Uplata/{id}/{mjesecid}";
            result = await url.WithOAuthBearerToken(ApiService.Token).GetJsonAsync<List<PrikazUplataVM>>();
            dgvUplate.DataSource = result;
            LoadChart(result);
            }
        }

        private  void btnSnimi_Click(object sender, EventArgs e)
        {
            var lista= dgvUplate.DataSource as List<PrikazUplataVM>;
            if(lista!=null)
            {

                using (SaveFileDialog fileDialog= new SaveFileDialog() { Filter="Izvještaj uplata|*.xls"})
                {
                    if(fileDialog.ShowDialog()==DialogResult.OK)
                    {

                        _parametri.FileName = fileDialog.FileName;
                        _parametri.lista = lista;
                        var rezultat = LoadReport();
                        if(rezultat)
                        {
                        MessageBox.Show("Uspješno spremljen izvještaj");

                        }
                        else
                        {
                            MessageBox.Show("Nešto je pošlo po zlu");
                        }
                        
                    }
                }
               
            }
            else
            {
                MessageBox.Show("Nema podataka za preuzimanje");
            }
        }

        private void pieChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
    }
}
