using Data.EntityModels;
using Data.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public PrikazUplata()
        {
            InitializeComponent();
        }

        private async void PrikazUplata_Load(object sender, EventArgs e)
        {
            await LoadMjeseci();
            await LoadVolontera();
            LoadTipova();
            var result= await _apiService.Get<List<PrikazUplataVM>>();
            dgvUplate.DataSource = result;
        }
        private async Task LoadMjeseci()
        {
            var result = await _apiServiceMjesec.Get<List<Mjesec>>();
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

        private void cmbTip_TextChanged(object sender, EventArgs e)
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
            if (cmbStudenti.SelectedIndex.ToString() != "0")
            {
                 var id = cmbStudenti.SelectedValue.ToString();
                 var result1 = await _apiService.GetByID<PrikazUplataVM>(id);
                result.Add(result1);
                 dgvUplate.DataSource = result;
            }
            else
            {
                 result = await _apiService.Get<List<PrikazUplataVM>>();
                dgvUplate.DataSource = result;
            }
        }

        //private async void cmbStudenti_TextChanged(object sender, EventArgs e)
        //{
        //    if (cmbStudenti.SelectedValue.ToString() != "0")
        //    {

        //        var id = cmbStudenti.SelectedValue.ToString();
        //        var result = await _apiService.GetByID<PrikazUplata>(id);
        //        dgvUplate.DataSource = result;
        //    }
        //}
    }
}
