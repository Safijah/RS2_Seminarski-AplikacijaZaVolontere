using Data.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AplikacijaZaVolontere.UI
{
    public partial class frmLogin : Form
    {
        ApiService _apiService = new ApiService("Korisnik/Login");
        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (txtEmail.Text == string.Empty)
            {
                e.Cancel = true;
                txtEmail.Focus();
                errorProvider1.SetError(txtEmail, "Morate unijeti email");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtEmail, null);
            }
        }

        private void txtSifra_Validating(object sender, CancelEventArgs e)
        {
            if (txtSifra.Text == string.Empty)
            {
                e.Cancel = true;
                txtSifra.Focus();
                errorProvider1.SetError(txtSifra, "Morate unijeti šifru.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtSifra, null);
            }
        }

        private async void btnPrijava_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                LoginVM vm = new LoginVM()
                {
                    Email = txtEmail.Text,
                    Sifra = txtSifra.Text
                };
                var rezultat = new RezultatVM();
                try
                {

                  rezultat= await _apiService.Prijava<RezultatVM>(vm);
                if(rezultat.ISUspjesno)
                {
                    ApiService.Token = rezultat.Poruka;
                    frmPocetna form = new frmPocetna();
                    MessageBox.Show("Uspješna prijava");
                    form.ShowDialog();
                    this.Close();
                }
                }
                catch (Exception)
                {

                    MessageBox.Show("Neuspješna prijava.");
                }
                
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
