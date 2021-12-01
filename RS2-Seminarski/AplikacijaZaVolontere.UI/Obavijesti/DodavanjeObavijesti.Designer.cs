
namespace AplikacijaZaVolontere.UI.Obavijesti
{
    partial class DodavanjeObavijesti
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.txtSadrzaj = new System.Windows.Forms.TextBox();
            this.cmbSekcija = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.Arhiva = new System.Windows.Forms.GroupBox();
            this.btnArhiva = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.Arhiva.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naslov:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sadržaj:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(396, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sekcija:";
            // 
            // txtNaslov
            // 
            this.txtNaslov.Location = new System.Drawing.Point(12, 61);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(248, 23);
            this.txtNaslov.TabIndex = 3;
            this.txtNaslov.Validating += new System.ComponentModel.CancelEventHandler(this.txtNaslov_Validating);
            // 
            // txtSadrzaj
            // 
            this.txtSadrzaj.Location = new System.Drawing.Point(6, 116);
            this.txtSadrzaj.Multiline = true;
            this.txtSadrzaj.Name = "txtSadrzaj";
            this.txtSadrzaj.Size = new System.Drawing.Size(254, 134);
            this.txtSadrzaj.TabIndex = 4;
            this.txtSadrzaj.TextChanged += new System.EventHandler(this.txtSadrzaj_TextChanged);
            this.txtSadrzaj.Validating += new System.ComponentModel.CancelEventHandler(this.txtSadrzaj_Validating);
            // 
            // cmbSekcija
            // 
            this.cmbSekcija.FormattingEnabled = true;
            this.cmbSekcija.Location = new System.Drawing.Point(396, 61);
            this.cmbSekcija.Name = "cmbSekcija";
            this.cmbSekcija.Size = new System.Drawing.Size(248, 23);
            this.cmbSekcija.TabIndex = 5;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSpremi);
            this.groupBox1.Controls.Add(this.txtNaslov);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbSekcija);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSadrzaj);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(0, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 263);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodavanje obavijesti";
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(396, 227);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(119, 23);
            this.btnSpremi.TabIndex = 6;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // Arhiva
            // 
            this.Arhiva.Controls.Add(this.btnArhiva);
            this.Arhiva.Dock = System.Windows.Forms.DockStyle.Top;
            this.Arhiva.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Arhiva.Location = new System.Drawing.Point(0, 0);
            this.Arhiva.Name = "Arhiva";
            this.Arhiva.Size = new System.Drawing.Size(800, 100);
            this.Arhiva.TabIndex = 7;
            this.Arhiva.TabStop = false;
            this.Arhiva.Text = "Arhiva";
            // 
            // btnArhiva
            // 
            this.btnArhiva.Location = new System.Drawing.Point(589, 12);
            this.btnArhiva.Name = "btnArhiva";
            this.btnArhiva.Size = new System.Drawing.Size(119, 72);
            this.btnArhiva.TabIndex = 7;
            this.btnArhiva.Text = "Arhiva obavijesti";
            this.btnArhiva.UseVisualStyleBackColor = true;
            this.btnArhiva.Click += new System.EventHandler(this.btnArhiva_Click);
            // 
            // DodavanjeObavijesti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Arhiva);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "DodavanjeObavijesti";
            this.Text = "DodavanjeObavijesti";
            this.Load += new System.EventHandler(this.DodavanjeObavijesti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Arhiva.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.TextBox txtSadrzaj;
        private System.Windows.Forms.ComboBox cmbSekcija;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox Arhiva;
        private System.Windows.Forms.Button btnArhiva;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSpremi;
    }
}