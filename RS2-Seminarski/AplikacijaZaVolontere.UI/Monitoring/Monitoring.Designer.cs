
namespace AplikacijaZaVolontere.UI.Monitoring
{
    partial class Monitoring
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
            this.txtLink = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnZakaži = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbStipendisti
            // 
            this.cmbStipendisti.FormattingEnabled = true;
            this.cmbStipendisti.Location = new System.Drawing.Point(316, 73);
            this.cmbStipendisti.Name = "cmbStipendisti";
            this.cmbStipendisti.Size = new System.Drawing.Size(121, 23);
            this.cmbStipendisti.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Odaberite stipendistu:";
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(316, 188);
            this.txtLink.Multiline = true;
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(121, 93);
            this.txtLink.TabIndex = 2;
            this.txtLink.Validating += new System.ComponentModel.CancelEventHandler(this.txtLink_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Unesite link sastanka:";
            // 
            // btnZakaži
            // 
            this.btnZakaži.Location = new System.Drawing.Point(316, 323);
            this.btnZakaži.Name = "btnZakaži";
            this.btnZakaži.Size = new System.Drawing.Size(121, 23);
            this.btnZakaži.TabIndex = 4;
            this.btnZakaži.Text = "Zakaži";
            this.btnZakaži.UseVisualStyleBackColor = true;
            this.btnZakaži.Click += new System.EventHandler(this.btnZakaži_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Monitoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnZakaži);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbStipendisti);
            this.Name = "Monitoring";
            this.Text = "Monitoring";
            this.Load += new System.EventHandler(this.Monitoring_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbStipendisti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnZakaži;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}