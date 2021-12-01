using Data.EntityModels;
using Data.ViewModels;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacijaZaVolontere.UI.Korisnik
{
    public partial class PrikazVolontera : Form
    {
        ApiService _apiService = new ApiService("Korisnik");
        ApiService _apiServiceGrad = new ApiService("Grad");
        ApiService _apiServiceSkola = new ApiService("Skola");

        public PrikazVolontera()
        {
            InitializeComponent();
        }

        private async void PrikazVolontera_Load(object sender, EventArgs e)
        {
            await LoadSkola();
            await LoadGradova();
            cmbGradovi.RightToLeft = RightToLeft.No;
            cmbSkole.RightToLeft = RightToLeft.No;
            txtIme.RightToLeft = RightToLeft.No;
            txtPrezime.RightToLeft = RightToLeft.No;
            var filter = new FilterVM()
            {
                SkolaID = Int32.Parse(cmbSkole.SelectedValue.ToString()),
                GradID = Int32.Parse(cmbGradovi.SelectedValue.ToString()),
                Ime=txtIme.Text,
                Prezime=txtPrezime.Text
            };
            var url = $"{Properties.Settings.Default.ApiURL}/Korisnik/ / /{filter.GradID}/{filter.SkolaID}";
            dgvVolonteri.DataSource = await url.WithOAuthBearerToken(ApiService.Token).GetJsonAsync<List<GetKorisnikaVM>>();
            dgvVolonteri.RightToLeft = RightToLeft.No;
            dgvVolonteri.Columns["Uredi"].DisplayIndex = 6;

        }
        private async Task LoadSkola()
        {
            var result = await _apiServiceSkola.Get<List<Skola>>();
            result.Insert(0, new Skola());
            cmbSkole.DataSource = result;
            cmbSkole.DisplayMember = "Naziv";
            cmbSkole.ValueMember = "ID";

        }
        private async Task LoadGradova()
        {
            var result = await _apiServiceGrad.Get<List<Grad>>();
            result.Insert(0, new Grad());
            cmbGradovi.DataSource = result;
           cmbGradovi.DisplayMember = "Naziv";
            cmbGradovi.ValueMember = "ID";

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            this.Hide();
            DodavanjeVolontera form = new DodavanjeVolontera();
            form.ShowDialog();
        }

       

        private async void btnPretrazi_Click(object sender, EventArgs e)
        {
            var filter = new FilterVM()
            {
                SkolaID = Int32.Parse(cmbSkole.SelectedValue.ToString()),
                GradID = Int32.Parse(cmbGradovi.SelectedValue.ToString()),
            };
            if (txtPrezime.Text == string.Empty)
            {
                filter.Prezime = " ";
            }
            else
                filter.Prezime = txtPrezime.Text;
            if (txtIme.Text == string.Empty)
            {
                filter.Ime = " ";
            }
            else
                filter.Ime = txtIme.Text;
            var url = $"{Properties.Settings.Default.ApiURL}/Korisnik/{filter.Ime}/{filter.Prezime}/{filter.GradID}/{filter.SkolaID}";
            dgvVolonteri.DataSource = await url.WithOAuthBearerToken(ApiService.Token).GetJsonAsync<List<GetKorisnikaVM>>();
            dgvVolonteri.RightToLeft = RightToLeft.No;
            dgvVolonteri.Columns["Uredi"].DisplayIndex = 6;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgvVolonteri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
