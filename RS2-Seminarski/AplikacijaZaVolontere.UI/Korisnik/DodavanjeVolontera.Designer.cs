
namespace AplikacijaZaVolontere.UI.Korisnik
{
    partial class DodavanjeVolontera
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
            this.components = new System.ComponentModel.Container();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.KorisničkiPodaci = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbSpol = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbGradovi = new System.Windows.Forms.ComboBox();
            this.cmbSkole = new System.Windows.Forms.ComboBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.KorisničkiPodaci.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(136, 22);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 23);
            this.txtIme.TabIndex = 0;
            this.txtIme.TextChanged += new System.EventHandler(this.txtIme_TextChanged);
            this.txtIme.Validating += new System.ComponentModel.CancelEventHandler(this.txtIme_Validating);
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(136, 70);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(100, 23);
            this.txtPrezime.TabIndex = 1;
            this.txtPrezime.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrezime_Validating);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(136, 119);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 23);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // txtSifra
            // 
            this.txtSifra.Location = new System.Drawing.Point(136, 173);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.Size = new System.Drawing.Size(100, 23);
            this.txtSifra.TabIndex = 3;
            // 
            // KorisničkiPodaci
            // 
            this.KorisničkiPodaci.Controls.Add(this.label4);
            this.KorisničkiPodaci.Controls.Add(this.label3);
            this.KorisničkiPodaci.Controls.Add(this.label2);
            this.KorisničkiPodaci.Controls.Add(this.label1);
            this.KorisničkiPodaci.Controls.Add(this.txtIme);
            this.KorisničkiPodaci.Controls.Add(this.txtSifra);
            this.KorisničkiPodaci.Controls.Add(this.txtPrezime);
            this.KorisničkiPodaci.Controls.Add(this.txtEmail);
            this.KorisničkiPodaci.Location = new System.Drawing.Point(12, 12);
            this.KorisničkiPodaci.Name = "KorisničkiPodaci";
            this.KorisničkiPodaci.Size = new System.Drawing.Size(253, 248);
            this.KorisničkiPodaci.TabIndex = 4;
            this.KorisničkiPodaci.TabStop = false;
            this.KorisničkiPodaci.Text = "Korisnički Podaci";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Šifra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Prezime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ime";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbSpol);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbGradovi);
            this.groupBox1.Controls.Add(this.cmbSkole);
            this.groupBox1.Location = new System.Drawing.Point(392, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 247);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci volontera";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Spol";
            // 
            // cmbSpol
            // 
            this.cmbSpol.FormattingEnabled = true;
            this.cmbSpol.Location = new System.Drawing.Point(126, 126);
            this.cmbSpol.Name = "cmbSpol";
            this.cmbSpol.Size = new System.Drawing.Size(121, 23);
            this.cmbSpol.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Grad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Škola";
            // 
            // cmbGradovi
            // 
            this.cmbGradovi.FormattingEnabled = true;
            this.cmbGradovi.Location = new System.Drawing.Point(126, 77);
            this.cmbGradovi.Name = "cmbGradovi";
            this.cmbGradovi.Size = new System.Drawing.Size(121, 23);
            this.cmbGradovi.TabIndex = 9;
            this.cmbGradovi.SelectedIndexChanged += new System.EventHandler(this.cmbGradovi_SelectedIndexChanged);
            // 
            // cmbSkole
            // 
            this.cmbSkole.FormattingEnabled = true;
            this.cmbSkole.Location = new System.Drawing.Point(126, 29);
            this.cmbSkole.Name = "cmbSkole";
            this.cmbSkole.Size = new System.Drawing.Size(121, 23);
            this.cmbSkole.TabIndex = 10;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(148, 316);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(136, 23);
            this.btnOdustani.TabIndex = 6;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(509, 316);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(136, 23);
            this.btnSpremi.TabIndex = 7;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // DodavanjeVolontera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.KorisničkiPodaci);
            this.Controls.Add(this.groupBox1);
            this.Name = "DodavanjeVolontera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DodavanjeVolontera";
            this.Load += new System.EventHandler(this.DodavanjeVolontera_LoadAsync);
            this.KorisničkiPodaci.ResumeLayout(false);
            this.KorisničkiPodaci.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSifra;
        private System.Windows.Forms.GroupBox KorisničkiPodaci;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbSkole;
        private System.Windows.Forms.ComboBox cmbGradovi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbSpol;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}