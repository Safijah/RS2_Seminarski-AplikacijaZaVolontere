
namespace AplikacijaZaVolontere.UI.KorisniLinkovi
{
    partial class DodavanjeLinka
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnArhiva = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnArhiva);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arhiva linkova";
            // 
            // btnArhiva
            // 
            this.btnArhiva.Location = new System.Drawing.Point(544, 22);
            this.btnArhiva.Name = "btnArhiva";
            this.btnArhiva.Size = new System.Drawing.Size(119, 72);
            this.btnArhiva.TabIndex = 8;
            this.btnArhiva.Text = "Arhiva linkova";
            this.btnArhiva.UseVisualStyleBackColor = true;
            this.btnArhiva.Click += new System.EventHandler(this.btnArhiva_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSpremi);
            this.groupBox2.Controls.Add(this.txtLink);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtNaslov);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 263);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(431, 228);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(129, 23);
            this.btnSpremi.TabIndex = 7;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(12, 152);
            this.txtLink.Multiline = true;
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(254, 99);
            this.txtLink.TabIndex = 6;
            this.txtLink.Validating += new System.ComponentModel.CancelEventHandler(this.txtLink_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Link:";
            // 
            // txtNaslov
            // 
            this.txtNaslov.Location = new System.Drawing.Point(12, 77);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(248, 23);
            this.txtNaslov.TabIndex = 4;
            this.txtNaslov.Validating += new System.ComponentModel.CancelEventHandler(this.txtNaslov_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naslov:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // DodavanjeLinka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DodavanjeLinka";
            this.Text = "DodavanjeLinka";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Spremi;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnArhiva;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}