
namespace AplikacijaZaVolontere.UI.Uplata
{
    partial class PrikazUplata
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvUplate = new System.Windows.Forms.DataGridView();
            this.cmbTip = new System.Windows.Forms.ComboBox();
            this.cmbMjeseci = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMjesec = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbStudenti = new System.Windows.Forms.ComboBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUplate)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvUplate);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 260);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 190);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prikaz uplata";
            // 
            // dgvUplate
            // 
            this.dgvUplate.AllowUserToAddRows = false;
            this.dgvUplate.AllowUserToDeleteRows = false;
            this.dgvUplate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUplate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvUplate.Location = new System.Drawing.Point(3, 22);
            this.dgvUplate.Name = "dgvUplate";
            this.dgvUplate.ReadOnly = true;
            this.dgvUplate.RowTemplate.Height = 25;
            this.dgvUplate.Size = new System.Drawing.Size(794, 165);
            this.dgvUplate.TabIndex = 0;
            // 
            // cmbTip
            // 
            this.cmbTip.FormattingEnabled = true;
            this.cmbTip.Location = new System.Drawing.Point(12, 41);
            this.cmbTip.Name = "cmbTip";
            this.cmbTip.Size = new System.Drawing.Size(121, 23);
            this.cmbTip.TabIndex = 1;
            this.cmbTip.TextChanged += new System.EventHandler(this.cmbTip_TextChanged);
            // 
            // cmbMjeseci
            // 
            this.cmbMjeseci.FormattingEnabled = true;
            this.cmbMjeseci.Location = new System.Drawing.Point(12, 114);
            this.cmbMjeseci.Name = "cmbMjeseci";
            this.cmbMjeseci.Size = new System.Drawing.Size(121, 23);
            this.cmbMjeseci.TabIndex = 2;
            this.cmbMjeseci.Visible = false;
            this.cmbMjeseci.SelectedValueChanged += new System.EventHandler(this.cmbMjeseci_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tip izvještaja:";
            // 
            // lblMjesec
            // 
            this.lblMjesec.AutoSize = true;
            this.lblMjesec.Location = new System.Drawing.Point(12, 81);
            this.lblMjesec.Name = "lblMjesec";
            this.lblMjesec.Size = new System.Drawing.Size(47, 15);
            this.lblMjesec.TabIndex = 4;
            this.lblMjesec.Text = "Mjesec:";
            this.lblMjesec.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Student:";
            // 
            // cmbStudenti
            // 
            this.cmbStudenti.FormattingEnabled = true;
            this.cmbStudenti.Location = new System.Drawing.Point(161, 41);
            this.cmbStudenti.Name = "cmbStudenti";
            this.cmbStudenti.Size = new System.Drawing.Size(121, 23);
            this.cmbStudenti.TabIndex = 6;
            this.cmbStudenti.SelectedValueChanged += new System.EventHandler(this.cmbStudenti_SelectedValueChanged);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(13, 164);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(120, 23);
            this.btnDodaj.TabIndex = 7;
            this.btnDodaj.Text = "Dodaj novu uplatu";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // pieChart1
            // 
            this.pieChart1.Location = new System.Drawing.Point(380, 12);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(386, 196);
            this.pieChart1.TabIndex = 8;
            this.pieChart1.Text = "pieChart1";
            this.pieChart1.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.pieChart1_ChildChanged);
            // 
            // btnSnimi
            // 
            this.btnSnimi.Location = new System.Drawing.Point(13, 207);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(120, 23);
            this.btnSnimi.TabIndex = 9;
            this.btnSnimi.Text = "Snimi izvještaj";
            this.btnSnimi.UseVisualStyleBackColor = true;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // PrikazUplata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.pieChart1);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.cmbStudenti);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMjesec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMjeseci);
            this.Controls.Add(this.cmbTip);
            this.Controls.Add(this.groupBox1);
            this.Name = "PrikazUplata";
            this.Text = "PrikazUplata";
            this.Load += new System.EventHandler(this.PrikazUplata_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUplate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvUplate;
        private System.Windows.Forms.ComboBox cmbTip;
        private System.Windows.Forms.ComboBox cmbMjeseci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMjesec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbStudenti;
        private System.Windows.Forms.Button btnDodaj;
        private LiveCharts.WinForms.PieChart pieChart1;
        private System.Windows.Forms.Button btnSnimi;
    }
}