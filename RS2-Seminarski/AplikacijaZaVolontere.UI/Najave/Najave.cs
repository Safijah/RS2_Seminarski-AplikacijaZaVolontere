using Data.EntityModels;
using Data.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AplikacijaZaVolontere.UI.Najave
{
    public partial class Najave : Form
    {
        ApiService _apiService = new ApiService("Najava");
        ApiService _apiServiceStanje = new ApiService("Najava/GetByStanje");
        public Najave()
        {
            InitializeComponent();
        }

        

        private async  void Najave_Load(object sender, EventArgs e)
        {
            dgvNajave.DataSource = await _apiService.Get<List<NajavaPrikazVM>>();
            dgvNajave.RightToLeft = RightToLeft.No;
            dgvNajave.Columns["PromjenaStanja"].DisplayIndex = 10;
        }

        private async  void dgvNajave_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==0)
            {
                var result = dgvNajave.SelectedRows[0].DataBoundItem as NajavaPrikazVM;
                if(result!=null)
                {
                    PromjenaStanjaNajave frm = new PromjenaStanjaNajave(result.ID);
                    frm.ShowDialog();
                    dgvNajave.DataSource = await _apiService.Get<List<NajavaPrikazVM>>();
                }
            }
        }

        private async  void btnPoslani_Click(object sender, EventArgs e)
        {
            var result = await _apiServiceStanje.GetByID<List<NajavaPrikazVM>>(1);
            dgvNajave.DataSource = result;
            groupBox1.Text = "Poslane najave";
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var result = await _apiServiceStanje.GetByID<List<NajavaPrikazVM>>(3);
            dgvNajave.DataSource = result;
            groupBox1.Text = "Prihvaćene najave";
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            var result = await _apiServiceStanje.GetByID<List<NajavaPrikazVM>>(2);
            dgvNajave.DataSource = result;
            groupBox1.Text = "Vraćene najave";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
