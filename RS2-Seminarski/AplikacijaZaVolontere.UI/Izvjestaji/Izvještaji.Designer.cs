
namespace AplikacijaZaVolontere.UI.Izvjestaji
{
    partial class Izvještaji
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
            this.dgvIzvjestaji = new System.Windows.Forms.DataGridView();
            this.PromjenaStanja = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnVraceni = new System.Windows.Forms.Button();
            this.Prihvaceni = new System.Windows.Forms.Button();
            this.btnPoslani = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzvjestaji)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvIzvjestaji);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 286);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Izvještaji";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dgvIzvjestaji
            // 
            this.dgvIzvjestaji.AllowUserToAddRows = false;
            this.dgvIzvjestaji.AllowUserToDeleteRows = false;
            this.dgvIzvjestaji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIzvjestaji.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PromjenaStanja});
            this.dgvIzvjestaji.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvIzvjestaji.Location = new System.Drawing.Point(3, 24);
            this.dgvIzvjestaji.Name = "dgvIzvjestaji";
            this.dgvIzvjestaji.ReadOnly = true;
            this.dgvIzvjestaji.RowTemplate.Height = 25;
            this.dgvIzvjestaji.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIzvjestaji.Size = new System.Drawing.Size(794, 259);
            this.dgvIzvjestaji.TabIndex = 0;
            this.dgvIzvjestaji.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIzvjestaji_CellContentClick);
            // 
            // PromjenaStanja
            // 
            this.PromjenaStanja.HeaderText = "PromjenaStanja";
            this.PromjenaStanja.Name = "PromjenaStanja";
            this.PromjenaStanja.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnVraceni);
            this.groupBox2.Controls.Add(this.Prihvaceni);
            this.groupBox2.Controls.Add(this.btnPoslani);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 61);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter";
            // 
            // btnVraceni
            // 
            this.btnVraceni.ForeColor = System.Drawing.Color.Red;
            this.btnVraceni.Location = new System.Drawing.Point(553, 22);
            this.btnVraceni.Name = "btnVraceni";
            this.btnVraceni.Size = new System.Drawing.Size(153, 23);
            this.btnVraceni.TabIndex = 2;
            this.btnVraceni.Text = "Vraćeni izvještaji";
            this.btnVraceni.UseVisualStyleBackColor = true;
            this.btnVraceni.Click += new System.EventHandler(this.button3_Click);
            // 
            // Prihvaceni
            // 
            this.Prihvaceni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Prihvaceni.Location = new System.Drawing.Point(289, 22);
            this.Prihvaceni.Name = "Prihvaceni";
            this.Prihvaceni.Size = new System.Drawing.Size(153, 23);
            this.Prihvaceni.TabIndex = 1;
            this.Prihvaceni.Text = "Prihvaćeni izvještaji";
            this.Prihvaceni.UseVisualStyleBackColor = true;
            this.Prihvaceni.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPoslani
            // 
            this.btnPoslani.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnPoslani.Location = new System.Drawing.Point(40, 22);
            this.btnPoslani.Name = "btnPoslani";
            this.btnPoslani.Size = new System.Drawing.Size(153, 23);
            this.btnPoslani.TabIndex = 0;
            this.btnPoslani.Text = "Poslani izvještaji";
            this.btnPoslani.UseVisualStyleBackColor = true;
            this.btnPoslani.Click += new System.EventHandler(this.btnPoslani_Click);
            // 
            // Izvještaji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Izvještaji";
            this.Text = "Izvještaji";
            this.Load += new System.EventHandler(this.Izvještaji_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzvjestaji)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvIzvjestaji;
        private System.Windows.Forms.DataGridViewButtonColumn PromjenaStanja;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Prihvaceni;
        private System.Windows.Forms.Button btnPoslani;
        private System.Windows.Forms.Button btnVraceni;
    }
}