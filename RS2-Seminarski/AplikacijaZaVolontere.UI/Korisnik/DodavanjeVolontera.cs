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

namespace AplikacijaZaVolontere.UI.Korisnik
{
    public partial class DodavanjeVolontera : Form
    {
        ApiService _apiService = new ApiService("Korisnik");
        ApiService _apiKorisnik = new ApiService("Korisnik/Registracija");
        ApiService _apiServiceGrad = new ApiService("Grad");
        ApiService _apiServiceSkola = new ApiService("Skola");
        ApiService _apiServiceSpol = new ApiService("Spol");
        public DodavanjeVolontera()
        {
            InitializeComponent();
            RightToLeft = RightToLeft.No;
        }

        private void cmbGradovi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void DodavanjeVolontera_LoadAsync(object sender, EventArgs e)
        {
            await LoadSkola();
            await LoadGradova();
            await LoadSpolova();
            txtSifra.Text = NewPassword(8);
            txtSifra.ReadOnly = true;
            cmbGradovi.RightToLeft = RightToLeft.No;
            cmbSkole.RightToLeft = RightToLeft.No;
            cmbSpol.RightToLeft = RightToLeft.No;
        }
        private async Task LoadSkola()
        {
            var result = await _apiServiceSkola.Get<List<Skola>>();
            cmbSkole.DataSource = result;
            cmbSkole.DisplayMember = "Naziv";
            cmbSkole.ValueMember = "ID";

        }
        private async Task LoadGradova()
        {
            var result = await _apiServiceGrad.Get<List<Grad>>();
            cmbGradovi.DataSource = result;
            cmbGradovi.DisplayMember = "Naziv";
            cmbGradovi.ValueMember = "ID";

        }
        private async Task LoadSpolova()
        {
            var result = await _apiServiceSpol.Get<List<Spol>>();
            cmbSpol.DataSource = result;
            cmbSpol.DisplayMember = "Naziv";
            cmbSpol.ValueMember = "ID";

        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

       
        private string NewPassword(int length)
        {
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = uppercase.ToLower();
            string special = "!@#$%^&*()_+=-";
            string numbers = "0123456789";
            return Random(numbers, 1) + Random(uppercase, 1) + Random(special, 1)
                + Random(lowercase, length - 3);
        }

        private string Random(string text, int length)
        {
            Random random = new Random();
            string result = "";
            for (int i = 0; i < length; i++)
            {
                result += text[random.Next(text.Length)];
            }
            return result;
        }

        private async void btnSpremi_Click(object sender, EventArgs e)
        {
            if(ValidateChildren(ValidationConstraints.Enabled))
            {

            var KorisnikVM = new RegistracijaVM()
            {
                Ime = txtIme.Text,
                Prezime = txtPrezime.Text,
                Email = txtEmail.Text,
                Sifra = txtSifra.Text,
                SkolaID = Int32.Parse(cmbSkole.SelectedValue.ToString()),
                GradID = Int32.Parse(cmbGradovi.SelectedValue.ToString()),
                SpolID = Int32.Parse(cmbSpol.SelectedValue.ToString()),
                PotvrdjenaSifra=txtSifra.Text
            };
            
            var  rezultat= await _apiKorisnik.Insert<RezultatVM>(KorisnikVM);
            if(rezultat.ISUspjesno==true)
            {
                MessageBox.Show(rezultat.Poruka);
                this.Close();
            }
            else
            {
                MessageBox.Show(rezultat.Poruka);
            }
            }
        }

        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            if (txtIme.Text == string.Empty)
            {
                e.Cancel = true;
                txtIme.Focus();
                errorProvider1.SetError(txtIme, "Morate unijeti ime volontera.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtIme, null);
            }
        }

        private void txtPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (txtPrezime.Text == string.Empty)
            {
                e.Cancel = true;
                txtPrezime.Focus();
                errorProvider1.SetError(txtPrezime, "Morate unijeti prezime volontera.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPrezime, null);
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (txtEmail.Text == string.Empty)
            {
                e.Cancel = true;
                txtEmail.Focus();
                errorProvider1.SetError(txtEmail, "Morate unijeti email volontera.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtEmail, null);
            }
        }

        private void txtIme_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
