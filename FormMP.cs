using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proiect_PAW
{
    public partial class FormMP : Form
    {
        public FormMP()
        {
            InitializeComponent();
        }
        private void soferiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSoferi Sofer = new FormSoferi();
            Sofer.ShowDialog();
        }
        private void masiniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMasini Masina = new FormMasini();
            Masina.ShowDialog();
        }
        private void ruteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRute Ruta = new FormRute();
            Ruta.ShowDialog();
        }
        private void FormMP_Load(object sender, EventArgs e)
        {

        }
    }
}
