
namespace AS2122_4E_INF_MabroukiYoussra_GestioneArticoli
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCodice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUnita = new System.Windows.Forms.Label();
            this.lblPrezzo = new System.Windows.Forms.Label();
            this.lblArticoli = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.cmbVisualizza = new System.Windows.Forms.ComboBox();
            this.cmbUnita = new System.Windows.Forms.ComboBox();
            this.txtPrezzo = new System.Windows.Forms.TextBox();
            this.txtDescrizione = new System.Windows.Forms.TextBox();
            this.txtCodice = new System.Windows.Forms.TextBox();
            this.btnMostra = new System.Windows.Forms.Button();
            this.grbDettagli = new System.Windows.Forms.GroupBox();
            this.lstMostra = new System.Windows.Forms.ListBox();
            this.grbDettagli.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodice
            // 
            this.lblCodice.AutoSize = true;
            this.lblCodice.Location = new System.Drawing.Point(21, 47);
            this.lblCodice.Name = "lblCodice";
            this.lblCodice.Size = new System.Drawing.Size(55, 20);
            this.lblCodice.TabIndex = 0;
            this.lblCodice.Text = "Codice";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrizione";
            // 
            // lblUnita
            // 
            this.lblUnita.AutoSize = true;
            this.lblUnita.Location = new System.Drawing.Point(21, 132);
            this.lblUnita.Name = "lblUnita";
            this.lblUnita.Size = new System.Drawing.Size(109, 20);
            this.lblUnita.TabIndex = 2;
            this.lblUnita.Text = "Unità di misura";
            // 
            // lblPrezzo
            // 
            this.lblPrezzo.AutoSize = true;
            this.lblPrezzo.Location = new System.Drawing.Point(23, 175);
            this.lblPrezzo.Name = "lblPrezzo";
            this.lblPrezzo.Size = new System.Drawing.Size(53, 20);
            this.lblPrezzo.TabIndex = 3;
            this.lblPrezzo.Text = "Prezzo";
            // 
            // lblArticoli
            // 
            this.lblArticoli.AutoSize = true;
            this.lblArticoli.Location = new System.Drawing.Point(24, 380);
            this.lblArticoli.Name = "lblArticoli";
            this.lblArticoli.Size = new System.Drawing.Size(57, 20);
            this.lblArticoli.TabIndex = 4;
            this.lblArticoli.Text = "Articoli";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(83, 380);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(27, 20);
            this.lblNum.TabIndex = 5;
            this.lblNum.Text = "(0)";
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Location = new System.Drawing.Point(83, 227);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(285, 42);
            this.btnAggiungi.TabIndex = 6;
            this.btnAggiungi.Text = "Aggiungi/modifica articolo";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // cmbVisualizza
            // 
            this.cmbVisualizza.FormattingEnabled = true;
            this.cmbVisualizza.Items.AddRange(new object[] {
            "Visualizza articoli"});
            this.cmbVisualizza.Location = new System.Drawing.Point(514, 44);
            this.cmbVisualizza.Name = "cmbVisualizza";
            this.cmbVisualizza.Size = new System.Drawing.Size(179, 28);
            this.cmbVisualizza.TabIndex = 7;
            // 
            // cmbUnita
            // 
            this.cmbUnita.FormattingEnabled = true;
            this.cmbUnita.Items.AddRange(new object[] {
            "NR",
            "KG",
            "Q",
            "T"});
            this.cmbUnita.Location = new System.Drawing.Point(154, 129);
            this.cmbUnita.Name = "cmbUnita";
            this.cmbUnita.Size = new System.Drawing.Size(125, 28);
            this.cmbUnita.TabIndex = 8;
            // 
            // txtPrezzo
            // 
            this.txtPrezzo.Location = new System.Drawing.Point(154, 172);
            this.txtPrezzo.Name = "txtPrezzo";
            this.txtPrezzo.Size = new System.Drawing.Size(125, 27);
            this.txtPrezzo.TabIndex = 9;
            // 
            // txtDescrizione
            // 
            this.txtDescrizione.Location = new System.Drawing.Point(154, 86);
            this.txtDescrizione.Name = "txtDescrizione";
            this.txtDescrizione.Size = new System.Drawing.Size(125, 27);
            this.txtDescrizione.TabIndex = 10;
            // 
            // txtCodice
            // 
            this.txtCodice.Location = new System.Drawing.Point(154, 44);
            this.txtCodice.Name = "txtCodice";
            this.txtCodice.Size = new System.Drawing.Size(125, 27);
            this.txtCodice.TabIndex = 11;
            // 
            // btnMostra
            // 
            this.btnMostra.Location = new System.Drawing.Point(698, 44);
            this.btnMostra.Name = "btnMostra";
            this.btnMostra.Size = new System.Drawing.Size(58, 29);
            this.btnMostra.TabIndex = 12;
            this.btnMostra.Text = "...";
            this.btnMostra.UseVisualStyleBackColor = true;
            this.btnMostra.Click += new System.EventHandler(this.btnMostra_Click);
            // 
            // grbDettagli
            // 
            this.grbDettagli.Controls.Add(this.txtCodice);
            this.grbDettagli.Controls.Add(this.txtDescrizione);
            this.grbDettagli.Controls.Add(this.cmbUnita);
            this.grbDettagli.Controls.Add(this.btnAggiungi);
            this.grbDettagli.Controls.Add(this.txtPrezzo);
            this.grbDettagli.Controls.Add(this.lblCodice);
            this.grbDettagli.Controls.Add(this.label2);
            this.grbDettagli.Controls.Add(this.lblUnita);
            this.grbDettagli.Controls.Add(this.lblPrezzo);
            this.grbDettagli.Location = new System.Drawing.Point(24, 67);
            this.grbDettagli.Name = "grbDettagli";
            this.grbDettagli.Size = new System.Drawing.Size(460, 293);
            this.grbDettagli.TabIndex = 13;
            this.grbDettagli.TabStop = false;
            this.grbDettagli.Text = "Dettagli articolo";
            // 
            // lstMostra
            // 
            this.lstMostra.FormattingEnabled = true;
            this.lstMostra.ItemHeight = 20;
            this.lstMostra.Location = new System.Drawing.Point(514, 84);
            this.lstMostra.Name = "lstMostra";
            this.lstMostra.Size = new System.Drawing.Size(242, 304);
            this.lstMostra.TabIndex = 0;
            this.lstMostra.SelectedIndexChanged += new System.EventHandler(this.lstMostra_SelectedIndexChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstMostra);
            this.Controls.Add(this.btnMostra);
            this.Controls.Add(this.cmbVisualizza);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.lblArticoli);
            this.Controls.Add(this.grbDettagli);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grbDettagli.ResumeLayout(false);
            this.grbDettagli.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUnita;
        private System.Windows.Forms.Label lblPrezzo;
        private System.Windows.Forms.Label lblArticoli;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.ComboBox cmbVisualizza;
        private System.Windows.Forms.ComboBox cmbUnita;
        private System.Windows.Forms.TextBox txtPrezzo;
        private System.Windows.Forms.TextBox txtDescrizione;
        private System.Windows.Forms.TextBox txtCodice;
        private System.Windows.Forms.Button btnMostra;
        private System.Windows.Forms.GroupBox grbDettagli;
        private System.Windows.Forms.ListBox lstMostra;
    }
}

