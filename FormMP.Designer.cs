namespace Proiect_PAW
{
    partial class FormMP
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ruteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masiniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soferiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblMP = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ruteToolStripMenuItem,
            this.masiniToolStripMenuItem,
            this.soferiToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 281);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(610, 138);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ruteToolStripMenuItem
            // 
            this.ruteToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ruteToolStripMenuItem.Name = "ruteToolStripMenuItem";
            this.ruteToolStripMenuItem.Size = new System.Drawing.Size(604, 44);
            this.ruteToolStripMenuItem.Text = "Rute";
            this.ruteToolStripMenuItem.Click += new System.EventHandler(this.ruteToolStripMenuItem_Click);
            // 
            // masiniToolStripMenuItem
            // 
            this.masiniToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masiniToolStripMenuItem.Name = "masiniToolStripMenuItem";
            this.masiniToolStripMenuItem.Size = new System.Drawing.Size(604, 44);
            this.masiniToolStripMenuItem.Text = "Masini";
            this.masiniToolStripMenuItem.Click += new System.EventHandler(this.masiniToolStripMenuItem_Click);
            // 
            // soferiToolStripMenuItem
            // 
            this.soferiToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soferiToolStripMenuItem.Name = "soferiToolStripMenuItem";
            this.soferiToolStripMenuItem.Size = new System.Drawing.Size(604, 44);
            this.soferiToolStripMenuItem.Text = "Soferi";
            this.soferiToolStripMenuItem.Click += new System.EventHandler(this.soferiToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblMP
            // 
            this.lblMP.AutoSize = true;
            this.lblMP.BackColor = System.Drawing.Color.LightSlateGray;
            this.lblMP.Font = new System.Drawing.Font("Microsoft Uighur", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMP.Location = new System.Drawing.Point(173, 123);
            this.lblMP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMP.Name = "lblMP";
            this.lblMP.Size = new System.Drawing.Size(309, 61);
            this.lblMP.TabIndex = 1;
            this.lblMP.Text = "MENIU PRINCIPAL";
        
            // 
            // FormMP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(610, 419);
            this.Controls.Add(this.lblMP);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Uighur", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "FormMP";
            this.Text = "FIRMA DE TRANSPORT";
            this.Load += new System.EventHandler(this.FormMP_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ruteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masiniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soferiToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblMP;
    }
}

