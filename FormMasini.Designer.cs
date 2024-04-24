namespace Proiect_PAW
{
    partial class FormMasini
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
            this.lblPersoane = new System.Windows.Forms.Label();
            this.btnCancelM = new System.Windows.Forms.Button();
            this.btnOKM = new System.Windows.Forms.Button();
            this.tbNrInm = new System.Windows.Forms.TextBox();
            this.lblCapacitate = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblNrInm = new System.Windows.Forms.Label();
            this.tbCapacitate = new System.Windows.Forms.TextBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.listViewM = new System.Windows.Forms.ListView();
            this.chNrInm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMarca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCapacitate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblInfoM = new System.Windows.Forms.Label();
            this.lblAdaugaM = new System.Windows.Forms.Label();
            this.btnAfiseazaM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPersoane
            // 
            this.lblPersoane.AutoSize = true;
            this.lblPersoane.Location = new System.Drawing.Point(277, 163);
            this.lblPersoane.Name = "lblPersoane";
            this.lblPersoane.Size = new System.Drawing.Size(65, 16);
            this.lblPersoane.TabIndex = 32;
            this.lblPersoane.Text = "persoane";
            // 
            // btnCancelM
            // 
            this.btnCancelM.Location = new System.Drawing.Point(235, 212);
            this.btnCancelM.Name = "btnCancelM";
            this.btnCancelM.Size = new System.Drawing.Size(86, 30);
            this.btnCancelM.TabIndex = 31;
            this.btnCancelM.Text = "Anuleaza";
            this.btnCancelM.UseVisualStyleBackColor = true;
            this.btnCancelM.Click += new System.EventHandler(this.btnCancelM_Click);
            // 
            // btnOKM
            // 
            this.btnOKM.Location = new System.Drawing.Point(102, 212);
            this.btnOKM.Name = "btnOKM";
            this.btnOKM.Size = new System.Drawing.Size(76, 30);
            this.btnOKM.TabIndex = 30;
            this.btnOKM.Text = "OK";
            this.btnOKM.UseVisualStyleBackColor = true;
            this.btnOKM.Click += new System.EventHandler(this.btnOKM_Click);
            // 
            // tbNrInm
            // 
            this.tbNrInm.Location = new System.Drawing.Point(218, 86);
            this.tbNrInm.Name = "tbNrInm";
            this.tbNrInm.Size = new System.Drawing.Size(111, 22);
            this.tbNrInm.TabIndex = 27;
            this.tbNrInm.TextChanged += new System.EventHandler(this.tbIdRuta_TextChanged);
            // 
            // lblCapacitate
            // 
            this.lblCapacitate.AutoSize = true;
            this.lblCapacitate.Location = new System.Drawing.Point(112, 157);
            this.lblCapacitate.Name = "lblCapacitate";
            this.lblCapacitate.Size = new System.Drawing.Size(75, 16);
            this.lblCapacitate.TabIndex = 26;
            this.lblCapacitate.Text = "Capacitate:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(139, 125);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(48, 16);
            this.lblMarca.TabIndex = 25;
            this.lblMarca.Text = "Marca:";
            // 
            // lblNrInm
            // 
            this.lblNrInm.AutoSize = true;
            this.lblNrInm.Location = new System.Drawing.Point(45, 89);
            this.lblNrInm.Name = "lblNrInm";
            this.lblNrInm.Size = new System.Drawing.Size(151, 16);
            this.lblNrInm.TabIndex = 24;
            this.lblNrInm.Text = "Numar de inmatriculare: ";
            // 
            // tbCapacitate
            // 
            this.tbCapacitate.Location = new System.Drawing.Point(218, 157);
            this.tbCapacitate.Name = "tbCapacitate";
            this.tbCapacitate.Size = new System.Drawing.Size(53, 22);
            this.tbCapacitate.TabIndex = 28;
            this.tbCapacitate.TextChanged += new System.EventHandler(this.tbLPlecare_TextChanged);
            // 
            // cbMarca
            // 
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Items.AddRange(new object[] {
            "Renault",
            "Mercedes",
            "Peugeot",
            "Audi",
            "Dacia",
            "Toyota"});
            this.cbMarca.Location = new System.Drawing.Point(218, 125);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(121, 24);
            this.cbMarca.TabIndex = 33;
            this.cbMarca.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listViewM
            // 
            this.listViewM.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNrInm,
            this.chMarca,
            this.chCapacitate});
            this.listViewM.HideSelection = false;
            this.listViewM.Location = new System.Drawing.Point(442, 81);
            this.listViewM.Name = "listViewM";
            this.listViewM.Size = new System.Drawing.Size(471, 256);
            this.listViewM.TabIndex = 34;
            this.listViewM.UseCompatibleStateImageBehavior = false;
            this.listViewM.View = System.Windows.Forms.View.Details;
            // 
            // chNrInm
            // 
            this.chNrInm.Text = "Numar de inmatriculare";
            this.chNrInm.Width = 154;
            // 
            // chMarca
            // 
            this.chMarca.Text = "Marca";
            this.chMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chMarca.Width = 85;
            // 
            // chCapacitate
            // 
            this.chCapacitate.Text = "Capacitate(persoane)";
            this.chCapacitate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chCapacitate.Width = 120;
            // 
            // lblInfoM
            // 
            this.lblInfoM.AutoSize = true;
            this.lblInfoM.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblInfoM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoM.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblInfoM.Location = new System.Drawing.Point(610, 30);
            this.lblInfoM.Name = "lblInfoM";
            this.lblInfoM.Size = new System.Drawing.Size(132, 20);
            this.lblInfoM.TabIndex = 36;
            this.lblInfoM.Text = "Informatii masini";
            // 
            // lblAdaugaM
            // 
            this.lblAdaugaM.AutoSize = true;
            this.lblAdaugaM.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblAdaugaM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdaugaM.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAdaugaM.Location = new System.Drawing.Point(142, 30);
            this.lblAdaugaM.Name = "lblAdaugaM";
            this.lblAdaugaM.Size = new System.Drawing.Size(124, 20);
            this.lblAdaugaM.TabIndex = 35;
            this.lblAdaugaM.Text = "Adauga masina";
            // 
            // btnAfiseazaM
            // 
            this.btnAfiseazaM.Location = new System.Drawing.Point(637, 366);
            this.btnAfiseazaM.Name = "btnAfiseazaM";
            this.btnAfiseazaM.Size = new System.Drawing.Size(81, 41);
            this.btnAfiseazaM.TabIndex = 37;
            this.btnAfiseazaM.Text = "Afiseaza ";
            this.btnAfiseazaM.UseVisualStyleBackColor = true;
            this.btnAfiseazaM.Click += new System.EventHandler(this.btnAfiseazaM_Click);
            // 
            // FormMasini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(969, 451);
            this.Controls.Add(this.btnAfiseazaM);
            this.Controls.Add(this.lblInfoM);
            this.Controls.Add(this.lblAdaugaM);
            this.Controls.Add(this.listViewM);
            this.Controls.Add(this.cbMarca);
            this.Controls.Add(this.lblPersoane);
            this.Controls.Add(this.btnCancelM);
            this.Controls.Add(this.btnOKM);
            this.Controls.Add(this.tbCapacitate);
            this.Controls.Add(this.tbNrInm);
            this.Controls.Add(this.lblCapacitate);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblNrInm);
            this.Name = "FormMasini";
            this.Text = "Gestiune masini";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPersoane;
        private System.Windows.Forms.Button btnCancelM;
        private System.Windows.Forms.Button btnOKM;
        private System.Windows.Forms.TextBox tbNrInm;
        private System.Windows.Forms.Label lblCapacitate;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblNrInm;
        private System.Windows.Forms.TextBox tbCapacitate;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.ListView listViewM;
        private System.Windows.Forms.ColumnHeader chNrInm;
        private System.Windows.Forms.ColumnHeader chMarca;
        private System.Windows.Forms.ColumnHeader chCapacitate;
        private System.Windows.Forms.Label lblInfoM;
        private System.Windows.Forms.Label lblAdaugaM;
        private System.Windows.Forms.Button btnAfiseazaM;
    }
}