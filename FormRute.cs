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
    public partial class FormRute : Form
    {
        private List<Rute> listaRute;
        public FormRute()
        {
            InitializeComponent();
            listaRute = new List<Rute>();

        }

        private void tbIdRuta_TextChanged(object sender, EventArgs e)
        {

        }
        private void tbIdRuta_KeyDown(object sender, KeyEventArgs e)
        {
         
        }

        private void tbDistanta_TextChanged(object sender, EventArgs e)
        {

        }
        private void tbDistanta_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
        private void tbLPlecare_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbLPlecare_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void tbLSosire_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOKR_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbIdRuta.Text) || !int.TryParse(tbIdRuta.Text, out _))
            {
                MessageBox.Show("Introduceti un ID ruta valid.", "Eroare");
                return;
            }

            if (string.IsNullOrEmpty(tbDistanta.Text))
            {
                MessageBox.Show("Introduceti distanta rutei.", "Eroare");
                return;
            }

            if (string.IsNullOrEmpty(tbLPlecare.Text))
            {
                MessageBox.Show("Introduceti locul de plecare.", "Eroare");
                return;
            }

            if (string.IsNullOrEmpty(tbLSosire.Text))
            {
                MessageBox.Show("Introduceti locul de sosire.", "Eroare");
                return;
            }

            Rute rutaNoua = new Rute();
            rutaNoua.IdRuta = int.Parse(tbIdRuta.Text);
            rutaNoua.Distanta = tbDistanta.Text;
            rutaNoua.LocPlecare = tbLPlecare.Text;
            rutaNoua.LocSosire = tbLSosire.Text;

            ListViewItem item = new ListViewItem(new string[]
            { rutaNoua.IdRuta.ToString(), rutaNoua.Distanta, rutaNoua.LocPlecare, rutaNoua.LocSosire });
            listViewR.Items.Add(item);
            listaRute.Add(rutaNoua);

            FileStream fisRute = new FileStream("Rute.dat", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fisRute, listaRute);
            fisRute.Close();
            MessageBox.Show($"Au fost salvate {listaRute.Count} inregistrari.");

        }

        private void btnCancelR_Click(object sender, EventArgs e)
        {
            tbIdRuta.Text = "";
            tbDistanta.Text = "";
            tbLPlecare.Text = "";
            tbLSosire.Text = "";
        }

        private void btnAfiseazaR_Click(object sender, EventArgs e)
        {
            FileStream fisRute = new FileStream("Rute.dat", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            listaRute = (List<Rute>)bf.Deserialize(fisRute);
            fisRute.Close();
            listViewR.Items.Clear();
            foreach (Rute ruta in listaRute)
            {
                ListViewItem itm = new ListViewItem(ruta.IdRuta.ToString());
                itm.SubItems.Add(ruta.Distanta);
                itm.SubItems.Add(ruta.LocPlecare);
                itm.SubItems.Add(ruta.LocSosire);
                listViewR.Items.Add(itm);
            }
        }
    }
}
