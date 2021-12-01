
namespace AplikacijaZaVolontere.UI.Najave
{
    partial class Najave
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
            this.dgvNajave = new System.Windows.Forms.DataGridView();
            this.PromjenaStanja = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnVracene = new System.Windows.Forms.Button();
            this.btnPrihvaćene = new System.Windows.Forms.Button();
            this.btnPoslani = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNajave)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvNajave);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 286);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Najave";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dgvNajave
            // 
            this.dgvNajave.AllowUserToAddRows = false;
            this.dgvNajave.AllowUserToDeleteRows = false;
            this.dgvNajave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNajave.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PromjenaStanja});
            this.dgvNajave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvNajave.Location = new System.Drawing.Point(3, 24);
            this.dgvNajave.Name = "dgvNajave";
            this.dgvNajave.ReadOnly = true;
            this.dgvNajave.RowTemplate.Height = 25;
            this.dgvNajave.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNajave.Size = new System.Drawing.Size(794, 259);
            this.dgvNajave.TabIndex = 0;
            this.dgvNajave.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNajave_CellContentClick);
            // 
            // PromjenaStanja
            // 
            this.PromjenaStanja.HeaderText = "PromjenaStanja";
            this.PromjenaStanja.Name = "PromjenaStanja";
            this.PromjenaStanja.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnVracene);
            this.groupBox2.Controls.Add(this.btnPrihvaćene);
            this.groupBox2.Controls.Add(this.btnPoslani);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 61);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter";
            // 
            // btnVracene
            // 
            this.btnVracene.ForeColor = System.Drawing.Color.Red;
            this.btnVracene.Location = new System.Drawing.Point(553, 22);
            this.btnVracene.Name = "btnVracene";
            this.btnVracene.Size = new System.Drawing.Size(153, 23);
            this.btnVracene.TabIndex = 2;
            this.btnVracene.Text = "Vraćene najave";
            this.btnVracene.UseVisualStyleBackColor = true;
            this.btnVracene.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnPrihvaćene
            // 
            this.btnPrihvaćene.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPrihvaćene.Location = new System.Drawing.Point(289, 22);
            this.btnPrihvaćene.Name = "btnPrihvaćene";
            this.btnPrihvaćene.Size = new System.Drawing.Size(153, 23);
            this.btnPrihvaćene.TabIndex = 1;
            this.btnPrihvaćene.Text = "Prihvaćene najave";
            this.btnPrihvaćene.UseVisualStyleBackColor = true;
            this.btnPrihvaćene.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPoslani
            // 
            this.btnPoslani.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnPoslani.Location = new System.Drawing.Point(40, 22);
            this.btnPoslani.Name = "btnPoslani";
            this.btnPoslani.Size = new System.Drawing.Size(153, 23);
            this.btnPoslani.TabIndex = 0;
            this.btnPoslani.Text = "Poslane najave";
            this.btnPoslani.UseVisualStyleBackColor = true;
            this.btnPoslani.Click += new System.EventHandler(this.btnPoslani_Click);
            // 
            // Najave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Najave";
            this.Text = "Najave";
            this.Load += new System.EventHandler(this.Najave_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNajave)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvNajave;
        private System.Windows.Forms.DataGridViewButtonColumn PromjenaStanja;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnVracene;
        private System.Windows.Forms.Button btnPrihvaćene;
        private System.Windows.Forms.Button btnPoslani;
    }
}