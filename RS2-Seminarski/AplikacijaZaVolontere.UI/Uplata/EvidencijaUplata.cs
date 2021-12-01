using Data.EntityModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.ViewModels;
namespace AplikacijaZaVolontere.UI.Uplata
{
    public partial class EvidencijaUplata : Form
    {
        ApiService _apiService = new ApiService("Uplata");
        ApiService _apiServiceKorisnik = new ApiService("Korisnik/GetKorisnikaZaListu");
        ApiService _apiServiceMjesec = new ApiService("Mjesec");


        public EvidencijaUplata()
        {
            InitializeComponent();
        }

        private async void EvidencijaUplata_Load(object sender, EventArgs e)
        {
            await LoadMjeseci();
            await LoadVolontera();
             LoadIznosa();
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
            cmbStipendisti.DataSource = result;
            cmbStipendisti.DisplayMember = "Naziv";
            cmbStipendisti.ValueMember = "ID";
        }
        private  void LoadIznosa()
        {
            var result = Iznosi();
            cmbIznos.DataSource = result;
            cmbIznos.DisplayMember = "Naziv";
            cmbIznos.ValueMember = "Naziv";
        }
        private List<Iznosi> Iznosi()
        {
            List<Iznosi> lista = new List<Iznosi>();
            lista.Add(new Iznosi() { ID = 1, Naziv = "100" });
            lista.Add(new Iznosi() { ID = 2, Naziv = "150" });
            lista.Add(new Iznosi() { ID = 3, Naziv = "250" });
            return lista;
        }

        private void txtNapomena_Validating(object sender, CancelEventArgs e)
        {
            if (txtNapomena.Text == string.Empty)
            {
                e.Cancel = true;
                txtNapomena.Focus();
                errorProvider1.SetError(txtNapomena, "Morate unijeti sadržaj.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNapomena, null);
            }
        }

        private async void btnEvidentiraj_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                var Uplata = new UplataVM()
                {
                    VolonterID = cmbStipendisti.SelectedValue.ToString(),
                    Iznos = Int32.Parse(cmbIznos.SelectedValue.ToString()),
                    MjesecID = Int32.Parse(cmbMjeseci.SelectedValue.ToString()),
                    Napomena = txtNapomena.Text
                };
                var result = await _apiService.Insert<RezultatVM>(Uplata);
                MessageBox.Show(result.Poruka);
                this.Close();
            }

        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
