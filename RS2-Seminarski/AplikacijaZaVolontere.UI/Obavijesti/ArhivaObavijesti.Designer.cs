
namespace AplikacijaZaVolontere.UI.Obavijesti
{
    partial class ArhivaObavijesti
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
            this.dgvObavijesti = new System.Windows.Forms.DataGridView();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObavijesti)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvObavijesti);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 281);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arhiva obavijesti";
            // 
            // dgvObavijesti
            // 
            this.dgvObavijesti.AllowUserToAddRows = false;
            this.dgvObavijesti.AllowUserToDeleteRows = false;
            this.dgvObavijesti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObavijesti.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvObavijesti.Location = new System.Drawing.Point(3, 19);
            this.dgvObavijesti.Name = "dgvObavijesti";
            this.dgvObavijesti.ReadOnly = true;
            this.dgvObavijesti.RowTemplate.Height = 25;
            this.dgvObavijesti.Size = new System.Drawing.Size(794, 256);
            this.dgvObavijesti.TabIndex = 0;
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(12, 361);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(115, 23);
            this.btnZatvori.TabIndex = 1;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // ArhivaObavijesti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.groupBox1);
            this.Name = "ArhivaObavijesti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArhivaObavijesti";
            this.Load += new System.EventHandler(this.ArhivaObavijesti_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObavijesti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvObavijesti;
        private System.Windows.Forms.Button btnZatvori;
    }
}