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
    public partial class ArhivaKorisnihLinkova : Form
    {
        ApiService _apiService = new ApiService("KorisniLink");
        public ArhivaKorisnihLinkova()
        {
            InitializeComponent();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void ArhivaKorisnihLinkova_Load(object sender, EventArgs e)
        {
            var result = await _apiService.Get<List<KorisniLinkPrikazVM>>();
            dgvKorisniLinkovi.DataSource = result;
        }
    }
}
