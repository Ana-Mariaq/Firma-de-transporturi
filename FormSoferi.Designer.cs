namespace Proiect_PAW
{
    partial class FormSoferi
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
            this.btnCancelS = new System.Windows.Forms.Button();
            this.btnOKS = new System.Windows.Forms.Button();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbExperienta = new System.Windows.Forms.TextBox();
            this.tbIdSofer = new System.Windows.Forms.TextBox();
            this.lblExperienta = new System.Windows.Forms.Label();
            this.lblNume = new System.Windows.Forms.Label();
            this.lblIdSofer = new System.Windows.Forms.Label();
            this.lblAni = new System.Windows.Forms.Label();
            this.chIdSofer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chExperienta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewSS = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAfiseazaS = new System.Windows.Forms.Button();
            this.lblAdaugaS = new System.Windows.Forms.Label();
            this.lblInfoS = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelS
            // 
            this.btnCancelS.Location = new System.Drawing.Point(213, 212);
            this.btnCancelS.Name = "btnCancelS";
            this.btnCancelS.Size = new System.Drawing.Size(85, 30);
            this.btnCancelS.TabIndex = 22;
            this.btnCancelS.Text = "Anuleaza";
            this.btnCancelS.UseVisualStyleBackColor = true;
            this.btnCancelS.Click += new System.EventHandler(this.btnCancelS_Click);
            // 
            // btnOKS
            // 
            this.btnOKS.Location = new System.Drawing.Point(90, 212);
            this.btnOKS.Name = "btnOKS";
            this.btnOKS.Size = new System.Drawing.Size(78, 30);
            this.btnOKS.TabIndex = 21;
            this.btnOKS.Text = "OK";
            this.btnOKS.UseVisualStyleBackColor = true;
            this.btnOKS.Click += new System.EventHandler(this.btnOKS_Click);
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(142, 110);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(181, 22);
            this.tbNume.TabIndex = 19;
            this.tbNume.TextChanged += new System.EventHandler(this.tbDistanta_TextChanged);
            // 
            // tbExperienta
            // 
            this.tbExperienta.Location = new System.Drawing.Point(142, 149);
            this.tbExperienta.Name = "tbExperienta";
            this.tbExperienta.Size = new System.Drawing.Size(62, 22);
            this.tbExperienta.TabIndex = 18;
            this.tbExperienta.TextChanged += new System.EventHandler(this.tbLPlecare_TextChanged);
            // 
            // tbIdSofer
            // 
            this.tbIdSofer.Location = new System.Drawing.Point(142, 69);
            this.tbIdSofer.Name = "tbIdSofer";
            this.tbIdSofer.Size = new System.Drawing.Size(62, 22);
            this.tbIdSofer.TabIndex = 16;
            this.tbIdSofer.TextChanged += new System.EventHandler(this.tbIdRuta_TextChanged);
            // 
            // lblExperienta
            // 
            this.lblExperienta.AutoSize = true;
            this.lblExperienta.Location = new System.Drawing.Point(42, 152);
            this.lblExperienta.Name = "lblExperienta";
            this.lblExperienta.Size = new System.Drawing.Size(74, 16);
            this.lblExperienta.TabIndex = 14;
            this.lblExperienta.Text = "Experienta:";
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(70, 110);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(46, 16);
            this.lblNume.TabIndex = 13;
            this.lblNume.Text = "Nume:";
            // 
            // lblIdSofer
            // 
            this.lblIdSofer.AutoSize = true;
            this.lblIdSofer.Location = new System.Drawing.Point(65, 72);
            this.lblIdSofer.Name = "lblIdSofer";
            this.lblIdSofer.Size = new System.Drawing.Size(59, 16);
            this.lblIdSofer.TabIndex = 12;
            this.lblIdSofer.Text = "ID sofer: ";
            // 
            // lblAni
            // 
            this.lblAni.AutoSize = true;
            this.lblAni.Location = new System.Drawing.Point(210, 155);
            this.lblAni.Name = "lblAni";
            this.lblAni.Size = new System.Drawing.Size(25, 16);
            this.lblAni.TabIndex = 23;
            this.lblAni.Text = "ani";
            // 
            // chIdSofer
            // 
            this.chIdSofer.Text = "ID sofer";
            this.chIdSofer.Width = 67;
            // 
            // chNume
            // 
            this.chNume.Text = "Nume";
            this.chNume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chNume.Width = 176;
            // 
            // chExperienta
            // 
            this.chExperienta.Text = "Experienta";
            this.chExperienta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chExperienta.Width = 108;
            // 
            // listViewSS
            // 
            this.listViewSS.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewSS.HideSelection = false;
            this.listViewSS.Location = new System.Drawing.Point(394, 69);
            this.listViewSS.Name = "listViewSS";
            this.listViewSS.Size = new System.Drawing.Size(405, 287);
            this.listViewSS.TabIndex = 24;
            this.listViewSS.UseCompatibleStateImageBehavior = false;
            this.listViewSS.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID Sofer";
            this.columnHeader1.Width = 61;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nume";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Experienta (ani)";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 130;
            // 
            // btnAfiseazaS
            // 
            this.btnAfiseazaS.Location = new System.Drawing.Point(546, 368);
            this.btnAfiseazaS.Name = "btnAfiseazaS";
            this.btnAfiseazaS.Size = new System.Drawing.Size(81, 41);
            this.btnAfiseazaS.TabIndex = 26;
            this.btnAfiseazaS.Text = "Afiseaza ";
            this.btnAfiseazaS.UseVisualStyleBackColor = true;
            this.btnAfiseazaS.Click += new System.EventHandler(this.btnAfiseazaS_Click);
            // 
            // lblAdaugaS
            // 
            this.lblAdaugaS.AutoSize = true;
            this.lblAdaugaS.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblAdaugaS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdaugaS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAdaugaS.Location = new System.Drawing.Point(138, 29);
            this.lblAdaugaS.Name = "lblAdaugaS";
            this.lblAdaugaS.Size = new System.Drawing.Size(113, 20);
            this.lblAdaugaS.TabIndex = 27;
            this.lblAdaugaS.Text = "Adauga sofer ";
            // 
            // lblInfoS
            // 
            this.lblInfoS.AutoSize = true;
            this.lblInfoS.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblInfoS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblInfoS.Location = new System.Drawing.Point(528, 29);
            this.lblInfoS.Name = "lblInfoS";
            this.lblInfoS.Size = new System.Drawing.Size(125, 20);
            this.lblInfoS.TabIndex = 28;
            this.lblInfoS.Text = "Informatii soferi";
            // 
            // FormSoferi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(832, 444);
            this.Controls.Add(this.lblInfoS);
            this.Controls.Add(this.lblAdaugaS);
            this.Controls.Add(this.btnAfiseazaS);
            this.Controls.Add(this.listViewSS);
            this.Controls.Add(this.lblAni);
            this.Controls.Add(this.btnCancelS);
            this.Controls.Add(this.btnOKS);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.tbExperienta);
            this.Controls.Add(this.tbIdSofer);
            this.Controls.Add(this.lblExperienta);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.lblIdSofer);
            this.Name = "FormSoferi";
            this.Text = "Gestiune soferi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelS;
        private System.Windows.Forms.Button btnOKS;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.TextBox tbExperienta;
        private System.Windows.Forms.TextBox tbIdSofer;
        private System.Windows.Forms.Label lblExperienta;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblIdSofer;
        private System.Windows.Forms.Label lblAni;
        private System.Windows.Forms.ListView listViewS;
        private System.Windows.Forms.ColumnHeader chIdSofer;
        private System.Windows.Forms.ColumnHeader chNume;
        private System.Windows.Forms.ColumnHeader chExperienta;
        private System.Windows.Forms.ListView listViewSS;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnAfiseazaS;
        private System.Windows.Forms.Label lblAdaugaS;
        private System.Windows.Forms.Label lblInfoS;
    }
}