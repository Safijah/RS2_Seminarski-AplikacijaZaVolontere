
namespace AplikacijaZaVolontere.UI.KorisniLinkovi
{
    partial class ArhivaKorisnihLinkova
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
            this.dgvKorisniLinkovi = new System.Windows.Forms.DataGridView();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisniLinkovi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvKorisniLinkovi);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 281);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arhiva linkova";
            // 
            // dgvKorisniLinkovi
            // 
            this.dgvKorisniLinkovi.AllowUserToAddRows = false;
            this.dgvKorisniLinkovi.AllowUserToDeleteRows = false;
            this.dgvKorisniLinkovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKorisniLinkovi.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvKorisniLinkovi.Location = new System.Drawing.Point(3, 19);
            this.dgvKorisniLinkovi.Name = "dgvKorisniLinkovi";
            this.dgvKorisniLinkovi.ReadOnly = true;
            this.dgvKorisniLinkovi.RowTemplate.Height = 25;
            this.dgvKorisniLinkovi.Size = new System.Drawing.Size(794, 256);
            this.dgvKorisniLinkovi.TabIndex = 0;
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(12, 380);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(115, 23);
            this.btnZatvori.TabIndex = 2;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // ArhivaKorisnihLinkova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.groupBox1);
            this.Name = "ArhivaKorisnihLinkova";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArhivaKorisnihLinkova";
            this.Load += new System.EventHandler(this.ArhivaKorisnihLinkova_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisniLinkovi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvKorisniLinkovi;
        private System.Windows.Forms.Button btnZatvori;
    }
}