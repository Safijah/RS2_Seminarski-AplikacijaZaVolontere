using Data.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AplikacijaZaVolontere.UI.Izvjestaji
{
    public partial class Izvještaji : Form
    {
        ApiService _apiService = new ApiService("Izvještaj");
        ApiService _apiServiceStanje = new ApiService("Izvještaj/GetByStanje");
        public Izvještaji()
        {
            InitializeComponent();
        }

        private async void Izvještaji_Load(object sender, EventArgs e)
        {
            dgvIzvjestaji.DataSource = await _apiService.Get<List<IzvjestajPrikazVM>>();
            dgvIzvjestaji.RightToLeft = RightToLeft.No;
            dgvIzvjestaji.Columns["PromjenaStanja"].DisplayIndex = 9;
        }

        private async void dgvIzvjestaji_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                var result = dgvIzvjestaji.SelectedRows[0].DataBoundItem as IzvjestajPrikazVM;
                if (result != null)
                {
                    PromjenaStanjaIzvještaja frm = new PromjenaStanjaIzvještaja(result.Id);
                    frm.ShowDialog();
                    dgvIzvjestaji.DataSource = await _apiService.Get<List<IzvjestajPrikazVM>>();
                }
            }
        }

        private async void btnPoslani_Click(object sender, EventArgs e)
        {
            var result = await _apiServiceStanje.GetByID<List<IzvjestajPrikazVM>>(1);
            dgvIzvjestaji.DataSource = result;
            groupBox1.Text = "Poslani izvještaji";
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var result = await _apiServiceStanje.GetByID<List<IzvjestajPrikazVM>>(3);
            dgvIzvjestaji.DataSource = result;
            groupBox1.Text = "Prihvaćeni izvještaji";
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            var result = await _apiServiceStanje.GetByID<List<IzvjestajPrikazVM>>(2);
            dgvIzvjestaji.DataSource = result;
            groupBox1.Text = "Vraćeni izvještaji";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
