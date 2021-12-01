using Data.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacijaZaVolontere.UI.Monitoring
{
    public partial class Monitoring : Form
    {
        ApiService _apiServiceKorisnik = new ApiService("Korisnik/GetKorisnikaZaListu");
        ApiService _apiService = new ApiService("Monitoring");
        public Monitoring()
        {
            InitializeComponent();
        }

        private async void Monitoring_Load(object sender, EventArgs e)
        {
            await LoadVolontera();
        }
        private async Task LoadVolontera()
        {
            var result = await _apiServiceKorisnik.Get<List<KorisniciZaListuVM>>();
            cmbStipendisti.DataSource = result;
            cmbStipendisti.DisplayMember = "Naziv";
            cmbStipendisti.ValueMember = "ID";
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

        private async  void btnZakaži_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                var MonitoringVM = new MonitoringVM()
                {
                    VolonterID = cmbStipendisti.SelectedValue.ToString(),
                    link = txtLink.Text
                };
                var result = await _apiService.Insert<RezultatVM>(MonitoringVM);
                MessageBox.Show(result.Poruka);
            }

        }
    }
}
