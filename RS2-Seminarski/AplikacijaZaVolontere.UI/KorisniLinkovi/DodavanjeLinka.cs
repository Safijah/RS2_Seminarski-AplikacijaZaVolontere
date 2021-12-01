using Data.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AplikacijaZaVolontere.UI.KorisniLinkovi
{
    public partial class DodavanjeLinka : Form
    {
        ApiService _apiService = new ApiService("KorisniLink");
        public DodavanjeLinka()
        {
            InitializeComponent();
        }

        private void txtNaslov_Validating(object sender, CancelEventArgs e)
        {
            if (txtNaslov.Text == string.Empty)
            {
                e.Cancel = true;
                txtNaslov.Focus();
                errorProvider1.SetError(txtNaslov, "Morate unijeti naslov.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNaslov, null);
            }
        }

        private void txtLink_Validating(object sender, CancelEventArgs e)
        {
            if (txtLink.Text == string.Empty)
            {
                e.Cancel = true;
                txtLink.Focus();
                errorProvider1.SetError(txtLink, "Morate unijeti link.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtLink, null);
            }
        }

        private async void btnSpremi_Click(object sender, EventArgs e)
        {

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                var Link = new KorisniLinkVM()
                {
                    Link = txtLink.Text,
                    Naziv = txtNaslov.Text
                };
                var result = await _apiService.Insert<RezultatVM>(Link);
                MessageBox.Show(result.Poruka);
            }
        }

        private void btnArhiva_Click(object sender, EventArgs e)
        {
            ArhivaKorisnihLinkova frm = new ArhivaKorisnihLinkova();
            frm.ShowDialog();
        }
    }
}
