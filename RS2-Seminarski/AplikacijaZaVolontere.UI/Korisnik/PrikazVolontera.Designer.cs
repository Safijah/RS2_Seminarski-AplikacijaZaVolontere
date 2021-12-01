
namespace AplikacijaZaVolontere.UI.Korisnik
{
    partial class PrikazVolontera
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
            this.dgvVolonteri = new System.Windows.Forms.DataGridView();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Skola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Spol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uredi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.I = new System.Windows.Forms.Label();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.cmbSkole = new System.Windows.Forms.ComboBox();
            this.cmbGradovi = new System.Windows.Forms.ComboBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVolonteri)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVolonteri
            // 
            this.dgvVolonteri.AllowUserToAddRows = false;
            this.dgvVolonteri.AllowUserToDeleteRows = false;
            this.dgvVolonteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVolonteri.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ime,
            this.Prezime,
            this.Email,
            this.Grad,
            this.Skola,
            this.Spol,
            this.Uredi});
            this.dgvVolonteri.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvVolonteri.Location = new System.Drawing.Point(0, 227);
            this.dgvVolonteri.Name = "dgvVolonteri";
            this.dgvVolonteri.ReadOnly = true;
            this.dgvVolonteri.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvVolonteri.RowTemplate.Height = 25;
            this.dgvVolonteri.Size = new System.Drawing.Size(800, 223);
            this.dgvVolonteri.TabIndex = 0;
            this.dgvVolonteri.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVolonteri_CellContentClick);
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Grad
            // 
            this.Grad.DataPropertyName = "Grad";
            this.Grad.HeaderText = "Grad";
            this.Grad.Name = "Grad";
            this.Grad.ReadOnly = true;
            // 
            // Skola
            // 
            this.Skola.DataPropertyName = "Skola";
            this.Skola.HeaderText = "Skola";
            this.Skola.Name = "Skola";
            this.Skola.ReadOnly = true;
            // 
            // Spol
            // 
            this.Spol.DataPropertyName = "Spol";
            this.Spol.HeaderText = "Spol";
            this.Spol.Name = "Spol";
            this.Spol.ReadOnly = true;
            // 
            // Uredi
            // 
            this.Uredi.DataPropertyName = "Uredi";
            this.Uredi.HeaderText = "Uredi";
            this.Uredi.Name = "Uredi";
            this.Uredi.ReadOnly = true;
            this.Uredi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDodaj);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.I);
            this.groupBox1.Controls.Add(this.btnPretrazi);
            this.groupBox1.Controls.Add(this.cmbSkole);
            this.groupBox1.Controls.Add(this.cmbGradovi);
            this.groupBox1.Controls.Add(this.txtPrezime);
            this.groupBox1.Controls.Add(this.txtIme);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 149);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filteri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(639, 22);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 9;
            this.btnDodaj.Text = "Dodaj novog";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(486, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Škola";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Grad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Prezime";
            // 
            // I
            // 
            this.I.AutoSize = true;
            this.I.Location = new System.Drawing.Point(13, 52);
            this.I.Name = "I";
            this.I.Size = new System.Drawing.Size(27, 15);
            this.I.TabIndex = 5;
            this.I.Text = "Ime";
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(639, 72);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(75, 23);
            this.btnPretrazi.TabIndex = 4;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // cmbSkole
            // 
            this.cmbSkole.FormattingEnabled = true;
            this.cmbSkole.Location = new System.Drawing.Point(486, 73);
            this.cmbSkole.Name = "cmbSkole";
            this.cmbSkole.Size = new System.Drawing.Size(121, 23);
            this.cmbSkole.TabIndex = 3;
            // 
            // cmbGradovi
            // 
            this.cmbGradovi.FormattingEnabled = true;
            this.cmbGradovi.Location = new System.Drawing.Point(317, 73);
            this.cmbGradovi.Name = "cmbGradovi";
            this.cmbGradovi.Size = new System.Drawing.Size(121, 23);
            this.cmbGradovi.TabIndex = 2;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(165, 72);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(100, 23);
            this.txtPrezime.TabIndex = 1;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(12, 73);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 23);
            this.txtIme.TabIndex = 0;
            // 
            // PrikazVolontera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvVolonteri);
            this.Name = "PrikazVolontera";
            this.Text = "PrikazVolontera";
            this.Load += new System.EventHandler(this.PrikazVolontera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVolonteri)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVolonteri;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Skola;
        private System.Windows.Forms.DataGridViewTextBoxColumn Spol;
        private System.Windows.Forms.DataGridViewButtonColumn Uredi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label I;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.ComboBox cmbSkole;
        private System.Windows.Forms.ComboBox cmbGradovi;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Button btnDodaj;
    }
}