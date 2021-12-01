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

namespace AplikacijaZaVolontere.UI.Najave
{
    public partial class PromjenaStanjaNajave : Form
    {
        ApiService _apiServiceStanje = new ApiService("Stanje");
        ApiService _apiServiceNajavaStanje = new ApiService("Najava/PromjenaStanja");
        private int IdNajave;
        public PromjenaStanjaNajave(int id)
        {
            InitializeComponent();
            IdNajave = id;
        }

        private async  void PromjenaStanjaNajave_Load(object sender, EventArgs e)
        {
            await LoadStanja();
        }
        private async Task LoadStanja()
        {
           var result  = await _apiServiceStanje.Get<List<Stanje>>();
            cmbStanje.DataSource = result;
            cmbStanje.DisplayMember = "Naziv";
            cmbStanje.ValueMember = "ID";
            cmbStanje.RightToLeft = RightToLeft.No;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnIzmjena_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                var Izmjena = new StanjeVM()
                {
                    Id = IdNajave,
                    StanjeID = Int32.Parse(cmbStanje.SelectedValue.ToString())
                };
                if (txtNapomena.Text != String.Empty)
                {
                    Izmjena.Napomena = txtNapomena.Text;
                }
                var result = await _apiServiceNajavaStanje.Insert<RezultatVM>(Izmjena);
                if (result.ISUspjesno)
                {
                    MessageBox.Show(result.Poruka);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(result.Poruka);
                }
            }
        }

        private void txtNapomena_Validating(object sender, CancelEventArgs e)
        {
            if (txtNapomena.Visible == true)
            {
                if (txtNapomena.Text == string.Empty)
                {
                    e.Cancel = true;
                    txtNapomena.Focus();
                    errorProvider1.SetError(txtNapomena, "Morate unijeti napomenu.");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(txtNapomena, null);
                }
            }
        }

        private void cmbStanje_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cmbStanje.SelectedValue.ToString()=="2")
            {
                txtNapomena.Visible = true;
                lblNapomena.Visible = true;
            }
            else
            {
                txtNapomena.Visible = false;
                lblNapomena.Visible = false;
            }
        }
    }
}
