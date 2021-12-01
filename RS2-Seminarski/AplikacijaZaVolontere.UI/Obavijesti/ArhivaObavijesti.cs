using Data.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacijaZaVolontere.UI.Obavijesti
{
    public partial class ArhivaObavijesti : Form
    {
        ApiService _apiService = new ApiService("Obavijest");
        public ArhivaObavijesti()
        {
            InitializeComponent();
        }

        private async void ArhivaObavijesti_Load(object sender, EventArgs e)
        {
            await LoadObavijesti();
        }
        private async Task LoadObavijesti()
        {
            var result = await _apiService.Get<List<ObavijestPrikazVM>>();
            dgvObavijesti.DataSource = result;
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
