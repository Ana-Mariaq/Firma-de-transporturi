using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proiect_PAW
{
    public partial class FormMasini : Form
    {
        private List<Masini> listaMasini;
        public FormMasini()
        {
            InitializeComponent();
            listaMasini = new List<Masini>();
        }

        private void tbIdRuta_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbLPlecare_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOKM_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbNrInm.Text))
            {
                MessageBox.Show("Introduceti numarul de inmatriculare.", "Eroare");
                return;
            }

            if (cbMarca.SelectedIndex == -1)
            {
                MessageBox.Show("Selectati o marca de masina.", "Eroare");
                return;
            }

            if (string.IsNullOrEmpty(tbCapacitate.Text) || !int.TryParse(tbCapacitate.Text, out _))
            {
                MessageBox.Show("Introduceți o capacitate validă.", "Eroare");
                return;
            }

            Masini masinaNoua = new Masini();
            masinaNoua.NrInmatriculare = tbNrInm.Text;
            masinaNoua.Marca = cbMarca.Text;
            masinaNoua.Capacitate = int.Parse(tbCapacitate.Text);

            ListViewItem item = new ListViewItem(new string[] 
            { masinaNoua.NrInmatriculare, masinaNoua.Marca, masinaNoua.Capacitate.ToString() });
            listViewM.Items.Add(item);

            listaMasini.Add(masinaNoua);

            FileStream fisMasini = new FileStream("Masini.dat", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fisMasini, listaMasini);
            fisMasini.Close();
            MessageBox.Show($"Au fost salvate {listaMasini.Count} inregistrari.");


        }
        private void btnCancelM_Click(object sender, EventArgs e)
        {
            tbNrInm.Text = "";
            cbMarca.Text = "";
            tbCapacitate.Text = "";
        }

        private void btnAfiseazaM_Click(object sender, EventArgs e)
        {
            FileStream fisMasini = new FileStream("Masini.dat", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            listaMasini = (List<Masini>)bf.Deserialize(fisMasini);
            fisMasini.Close();
            listViewM.Items.Clear();
            foreach (Masini masina in listaMasini)
            {
                ListViewItem itm = new ListViewItem(masina.NrInmatriculare);
                itm.SubItems.Add(masina.Marca);
                itm.SubItems.Add(masina.Capacitate.ToString());
                listViewM.Items.Add(itm);
            }
        }
    }
}
