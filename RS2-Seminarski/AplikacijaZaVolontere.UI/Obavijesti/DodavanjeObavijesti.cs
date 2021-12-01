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

namespace AplikacijaZaVolontere.UI.Obavijesti
{
    public partial class DodavanjeObavijesti : Form
    {
        ApiService _apiServiceSekcija = new ApiService("Sekcija");
        ApiService _apiServiceObavijest = new ApiService("Obavijest");
        public DodavanjeObavijesti()
        {
            InitializeComponent();
        }

        private async void DodavanjeObavijesti_Load(object sender, EventArgs e)
        {
            await LoadSekcija();
            
        }
        private async Task LoadSekcija()
        {
            var result = await _apiServiceSekcija.Get<List<Sekcija>>();
            cmbSekcija.DataSource = result;
            cmbSekcija.ValueMember = "ID";
            cmbSekcija.DisplayMember = "Naziv";
            cmbSekcija.RightToLeft = RightToLeft.No;
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

        private void txtSadrzaj_Validating(object sender, CancelEventArgs e)
        {
            if (txtSadrzaj.Text == string.Empty)
            {
                e.Cancel = true;
                txtSadrzaj.Focus();
                errorProvider1.SetError(txtSadrzaj, "Morate unijeti sadržaj.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtSadrzaj, null);
            }
        }

        private async  void btnSpremi_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                var Obavijest = new ObavijestVM()
                {
                    Sadrzaj = txtSadrzaj.Text,
                    Naslov = txtNaslov.Text,
                    SekcijaID = Int32.Parse(cmbSekcija.SelectedValue.ToString())
                };
                var result = await _apiServiceObavijest.Insert<RezultatVM>(Obavijest);
                MessageBox.Show(result.Poruka);
               
               
            }
        }

        private void btnArhiva_Click(object sender, EventArgs e)
        {
            ArhivaObavijesti frm = new ArhivaObavijesti();
            frm.ShowDialog();
        }

        private void txtSadrzaj_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
