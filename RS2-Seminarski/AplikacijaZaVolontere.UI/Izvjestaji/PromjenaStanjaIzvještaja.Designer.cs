
namespace AplikacijaZaVolontere.UI.Izvjestaji
{
    partial class PromjenaStanjaIzvještaja
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
            this.cmbStanje = new System.Windows.Forms.ComboBox();
            this.lblNapomena = new System.Windows.Forms.Label();
            this.txtNapomena = new System.Windows.Forms.TextBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnIzmjena = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Promjena stanja najave";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Izaberite stanje izvještaja";
            // 
            // cmbStanje
            // 
            this.cmbStanje.FormattingEnabled = true;
            this.cmbStanje.Location = new System.Drawing.Point(12, 144);
            this.cmbStanje.Name = "cmbStanje";
            this.cmbStanje.Size = new System.Drawing.Size(152, 23);
            this.cmbStanje.TabIndex = 4;
            this.cmbStanje.SelectedValueChanged += new System.EventHandler(this.cmbStanje_SelectedValueChanged);
            // 
            // lblNapomena
            // 
            this.lblNapomena.AutoSize = true;
            this.lblNapomena.Location = new System.Drawing.Point(12, 222);
            this.lblNapomena.Name = "lblNapomena";
            this.lblNapomena.Size = new System.Drawing.Size(69, 15);
            this.lblNapomena.TabIndex = 5;
            this.lblNapomena.Text = "Napomena:";
            this.lblNapomena.Visible = false;
            // 
            // txtNapomena
            // 
            this.txtNapomena.Location = new System.Drawing.Point(12, 267);
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.Size = new System.Drawing.Size(152, 23);
            this.txtNapomena.TabIndex = 6;
            this.txtNapomena.Visible = false;
            this.txtNapomena.Validating += new System.ComponentModel.CancelEventHandler(this.txtNapomena_Validating);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(12, 362);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(98, 23);
            this.btnOdustani.TabIndex = 8;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnIzmjena
            // 
            this.btnIzmjena.Location = new System.Drawing.Point(148, 362);
            this.btnIzmjena.Name = "btnIzmjena";
            this.btnIzmjena.Size = new System.Drawing.Size(98, 23);
            this.btnIzmjena.TabIndex = 7;
            this.btnIzmjena.Text = "Izmijeni stanje";
            this.btnIzmjena.UseVisualStyleBackColor = true;
            this.btnIzmjena.Click += new System.EventHandler(this.btnIzmjena_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // PromjenaStanjaIzvještaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 450);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnIzmjena);
            this.Controls.Add(this.txtNapomena);
            this.Controls.Add(this.lblNapomena);
            this.Controls.Add(this.cmbStanje);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PromjenaStanjaIzvještaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PromjenaStanjaIzvještaja";
            this.Load += new System.EventHandler(this.PromjenaStanjaIzvještaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbStanje;
        private System.Windows.Forms.Label lblNapomena;
        private System.Windows.Forms.TextBox txtNapomena;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnIzmjena;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}