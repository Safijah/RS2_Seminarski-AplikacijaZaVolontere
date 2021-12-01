
namespace AplikacijaZaVolontere.UI.Uplata
{
    partial class EvidencijaUplata
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
            this.cmbStipendisti = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbIznos = new System.Windows.Forms.ComboBox();
            this.txtNapomena = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMjeseci = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnEvidentiraj = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbStipendisti
            // 
            this.cmbStipendisti.FormattingEnabled = true;
            this.cmbStipendisti.Location = new System.Drawing.Point(21, 68);
            this.cmbStipendisti.Name = "cmbStipendisti";
            this.cmbStipendisti.Size = new System.Drawing.Size(121, 23);
            this.cmbStipendisti.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Odaberite stipendistu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Odaberite iznos uplate:";
            // 
            // cmbIznos
            // 
            this.cmbIznos.FormattingEnabled = true;
            this.cmbIznos.Location = new System.Drawing.Point(21, 163);
            this.cmbIznos.Name = "cmbIznos";
            this.cmbIznos.Size = new System.Drawing.Size(121, 23);
            this.cmbIznos.TabIndex = 3;
            // 
            // txtNapomena
            // 
            this.txtNapomena.Location = new System.Drawing.Point(21, 355);
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.Size = new System.Drawing.Size(121, 23);
            this.txtNapomena.TabIndex = 4;
            this.txtNapomena.Validating += new System.ComponentModel.CancelEventHandler(this.txtNapomena_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-324, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Napomena:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Odaberite mjesec uplate:";
            // 
            // cmbMjeseci
            // 
            this.cmbMjeseci.FormattingEnabled = true;
            this.cmbMjeseci.Location = new System.Drawing.Point(21, 255);
            this.cmbMjeseci.Name = "cmbMjeseci";
            this.cmbMjeseci.Size = new System.Drawing.Size(121, 23);
            this.cmbMjeseci.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Napomena";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnEvidentiraj
            // 
            this.btnEvidentiraj.Location = new System.Drawing.Point(110, 415);
            this.btnEvidentiraj.Name = "btnEvidentiraj";
            this.btnEvidentiraj.Size = new System.Drawing.Size(75, 23);
            this.btnEvidentiraj.TabIndex = 9;
            this.btnEvidentiraj.Text = "Evidentiraj";
            this.btnEvidentiraj.UseVisualStyleBackColor = true;
            this.btnEvidentiraj.Click += new System.EventHandler(this.btnEvidentiraj_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(12, 415);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 10;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // EvidencijaUplata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 450);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnEvidentiraj);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbMjeseci);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNapomena);
            this.Controls.Add(this.cmbIznos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbStipendisti);
            this.Name = "EvidencijaUplata";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EvidencijaUplata";
            this.Load += new System.EventHandler(this.EvidencijaUplata_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbStipendisti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbIznos;
        private System.Windows.Forms.TextBox txtNapomena;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMjeseci;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnEvidentiraj;
        private System.Windows.Forms.Button btnOdustani;
    }
}