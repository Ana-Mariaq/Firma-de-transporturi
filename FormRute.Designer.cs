namespace Proiect_PAW
{
    partial class FormRute
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
            this.lblIdRuta = new System.Windows.Forms.Label();
            this.lblDistanta = new System.Windows.Forms.Label();
            this.lblLPlecare = new System.Windows.Forms.Label();
            this.lblLSososire = new System.Windows.Forms.Label();
            this.tbIdRuta = new System.Windows.Forms.TextBox();
            this.tbLSosire = new System.Windows.Forms.TextBox();
            this.tbLPlecare = new System.Windows.Forms.TextBox();
            this.tbDistanta = new System.Windows.Forms.TextBox();
            this.lblkm = new System.Windows.Forms.Label();
            this.btnOKR = new System.Windows.Forms.Button();
            this.btnCancelR = new System.Windows.Forms.Button();
            this.listViewR = new System.Windows.Forms.ListView();
            this.chIdRuta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDistanta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLPlecare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLSosire = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblInfoR = new System.Windows.Forms.Label();
            this.lblAdaugaR = new System.Windows.Forms.Label();
            this.btnAfiseazaR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIdRuta
            // 
            this.lblIdRuta.AutoSize = true;
            this.lblIdRuta.Location = new System.Drawing.Point(66, 85);
            this.lblIdRuta.Name = "lblIdRuta";
            this.lblIdRuta.Size = new System.Drawing.Size(51, 16);
            this.lblIdRuta.TabIndex = 0;
            this.lblIdRuta.Text = "ID ruta: ";
            // 
            // lblDistanta
            // 
            this.lblDistanta.AutoSize = true;
            this.lblDistanta.Location = new System.Drawing.Point(58, 123);
            this.lblDistanta.Name = "lblDistanta";
            this.lblDistanta.Size = new System.Drawing.Size(59, 16);
            this.lblDistanta.TabIndex = 1;
            this.lblDistanta.Text = "Distanta:";
            // 
            // lblLPlecare
            // 
            this.lblLPlecare.AutoSize = true;
            this.lblLPlecare.Location = new System.Drawing.Point(36, 162);
            this.lblLPlecare.Name = "lblLPlecare";
            this.lblLPlecare.Size = new System.Drawing.Size(81, 16);
            this.lblLPlecare.TabIndex = 2;
            this.lblLPlecare.Text = "Loc plecare:";
            // 
            // lblLSososire
            // 
            this.lblLSososire.AutoSize = true;
            this.lblLSososire.Location = new System.Drawing.Point(43, 197);
            this.lblLSososire.Name = "lblLSososire";
            this.lblLSososire.Size = new System.Drawing.Size(72, 16);
            this.lblLSososire.TabIndex = 3;
            this.lblLSososire.Text = "Loc sosire:";
            // 
            // tbIdRuta
            // 
            this.tbIdRuta.Location = new System.Drawing.Point(143, 82);
            this.tbIdRuta.Name = "tbIdRuta";
            this.tbIdRuta.Size = new System.Drawing.Size(86, 22);
            this.tbIdRuta.TabIndex = 4;
            this.tbIdRuta.TextChanged += new System.EventHandler(this.tbIdRuta_TextChanged);
            // 
            // tbLSosire
            // 
            this.tbLSosire.Location = new System.Drawing.Point(143, 197);
            this.tbLSosire.Name = "tbLSosire";
            this.tbLSosire.Size = new System.Drawing.Size(187, 22);
            this.tbLSosire.TabIndex = 6;
            this.tbLSosire.TextChanged += new System.EventHandler(this.tbLSosire_TextChanged);
            // 
            // tbLPlecare
            // 
            this.tbLPlecare.Location = new System.Drawing.Point(143, 162);
            this.tbLPlecare.Name = "tbLPlecare";
            this.tbLPlecare.Size = new System.Drawing.Size(187, 22);
            this.tbLPlecare.TabIndex = 7;
            this.tbLPlecare.TextChanged += new System.EventHandler(this.tbLPlecare_TextChanged);
            // 
            // tbDistanta
            // 
            this.tbDistanta.Location = new System.Drawing.Point(143, 123);
            this.tbDistanta.Name = "tbDistanta";
            this.tbDistanta.Size = new System.Drawing.Size(86, 22);
            this.tbDistanta.TabIndex = 8;
            this.tbDistanta.TextChanged += new System.EventHandler(this.tbDistanta_TextChanged);
            // 
            // lblkm
            // 
            this.lblkm.AutoSize = true;
            this.lblkm.Location = new System.Drawing.Point(234, 128);
            this.lblkm.Name = "lblkm";
            this.lblkm.Size = new System.Drawing.Size(25, 16);
            this.lblkm.TabIndex = 9;
            this.lblkm.Text = "km";
            // 
            // btnOKR
            // 
            this.btnOKR.Location = new System.Drawing.Point(89, 254);
            this.btnOKR.Name = "btnOKR";
            this.btnOKR.Size = new System.Drawing.Size(78, 30);
            this.btnOKR.TabIndex = 10;
            this.btnOKR.Text = "OK";
            this.btnOKR.UseVisualStyleBackColor = true;
            this.btnOKR.Click += new System.EventHandler(this.btnOKR_Click);
            // 
            // btnCancelR
            // 
            this.btnCancelR.Location = new System.Drawing.Point(222, 254);
            this.btnCancelR.Name = "btnCancelR";
            this.btnCancelR.Size = new System.Drawing.Size(84, 30);
            this.btnCancelR.TabIndex = 11;
            this.btnCancelR.Text = "Anuleaza";
            this.btnCancelR.UseVisualStyleBackColor = true;
            this.btnCancelR.Click += new System.EventHandler(this.btnCancelR_Click);
            // 
            // listViewR
            // 
            this.listViewR.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chIdRuta,
            this.chDistanta,
            this.chLPlecare,
            this.chLSosire});
            this.listViewR.HideSelection = false;
            this.listViewR.Location = new System.Drawing.Point(388, 85);
            this.listViewR.Name = "listViewR";
            this.listViewR.Size = new System.Drawing.Size(567, 265);
            this.listViewR.TabIndex = 13;
            this.listViewR.UseCompatibleStateImageBehavior = false;
            this.listViewR.View = System.Windows.Forms.View.Details;
            // 
            // chIdRuta
            // 
            this.chIdRuta.Text = "ID ruta";
            this.chIdRuta.Width = 71;
            // 
            // chDistanta
            // 
            this.chDistanta.Text = "Distanta (km)";
            this.chDistanta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chDistanta.Width = 102;
            // 
            // chLPlecare
            // 
            this.chLPlecare.Text = "Loc plecare";
            this.chLPlecare.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chLPlecare.Width = 144;
            // 
            // chLSosire
            // 
            this.chLSosire.Text = "Loc sosire";
            this.chLSosire.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chLSosire.Width = 134;
            // 
            // lblInfoR
            // 
            this.lblInfoR.AutoSize = true;
            this.lblInfoR.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblInfoR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblInfoR.Location = new System.Drawing.Point(588, 23);
            this.lblInfoR.Name = "lblInfoR";
            this.lblInfoR.Size = new System.Drawing.Size(112, 20);
            this.lblInfoR.TabIndex = 38;
            this.lblInfoR.Text = "Informatii rute";
            // 
            // lblAdaugaR
            // 
            this.lblAdaugaR.AutoSize = true;
            this.lblAdaugaR.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblAdaugaR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdaugaR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAdaugaR.Location = new System.Drawing.Point(130, 23);
            this.lblAdaugaR.Name = "lblAdaugaR";
            this.lblAdaugaR.Size = new System.Drawing.Size(99, 20);
            this.lblAdaugaR.TabIndex = 37;
            this.lblAdaugaR.Text = "Adauga ruta";
            // 
            // btnAfiseazaR
            // 
            this.btnAfiseazaR.Location = new System.Drawing.Point(613, 369);
            this.btnAfiseazaR.Name = "btnAfiseazaR";
            this.btnAfiseazaR.Size = new System.Drawing.Size(87, 35);
            this.btnAfiseazaR.TabIndex = 39;
            this.btnAfiseazaR.Text = "Afiseaza";
            this.btnAfiseazaR.UseVisualStyleBackColor = true;
            this.btnAfiseazaR.Click += new System.EventHandler(this.btnAfiseazaR_Click);
            // 
            // FormRute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(993, 434);
            this.Controls.Add(this.btnAfiseazaR);
            this.Controls.Add(this.lblInfoR);
            this.Controls.Add(this.lblAdaugaR);
            this.Controls.Add(this.listViewR);
            this.Controls.Add(this.btnCancelR);
            this.Controls.Add(this.btnOKR);
            this.Controls.Add(this.lblkm);
            this.Controls.Add(this.tbDistanta);
            this.Controls.Add(this.tbLPlecare);
            this.Controls.Add(this.tbLSosire);
            this.Controls.Add(this.tbIdRuta);
            this.Controls.Add(this.lblLSososire);
            this.Controls.Add(this.lblLPlecare);
            this.Controls.Add(this.lblDistanta);
            this.Controls.Add(this.lblIdRuta);
            this.Name = "FormRute";
            this.Text = "Gestiune rute";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdRuta;
        private System.Windows.Forms.Label lblDistanta;
        private System.Windows.Forms.Label lblLPlecare;
        private System.Windows.Forms.Label lblLSososire;
        private System.Windows.Forms.TextBox tbIdRuta;
        private System.Windows.Forms.TextBox tbLSosire;
        private System.Windows.Forms.TextBox tbLPlecare;
        private System.Windows.Forms.TextBox tbDistanta;
        private System.Windows.Forms.Label lblkm;
        private System.Windows.Forms.Button btnOKR;
        private System.Windows.Forms.Button btnCancelR;
        private System.Windows.Forms.ListView listViewR;
        private System.Windows.Forms.ColumnHeader chIdRuta;
        private System.Windows.Forms.ColumnHeader chDistanta;
        private System.Windows.Forms.ColumnHeader chLPlecare;
        private System.Windows.Forms.ColumnHeader chLSosire;
        private System.Windows.Forms.Label lblInfoR;
        private System.Windows.Forms.Label lblAdaugaR;
        private System.Windows.Forms.Button btnAfiseazaR;
    }
}