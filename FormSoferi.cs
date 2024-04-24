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
    public partial class FormSoferi : Form
    {
        private List<Soferi> listaSoferi;
        public FormSoferi()
        {
            InitializeComponent();
            listaSoferi = new List<Soferi>();
        }
        private void tbIdRuta_TextChanged(object sender, EventArgs e)
        {

        }
        private void tbDistanta_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbLPlecare_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOKS_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbIdSofer.Text) || !int.TryParse(tbIdSofer.Text, out _))
            {
                MessageBox.Show("Introduceti un ID sofer valid.", "Eroare");
                return;
            }

            if (string.IsNullOrEmpty(tbNume.Text))
            {
                MessageBox.Show("Introduceti numele soferului.", "Eroare");
                return;
            }

            if (string.IsNullOrEmpty(tbExperienta.Text))
            {
                MessageBox.Show("Introduceti experienta soferului.", "Eroare");
                return;
            }

            Soferi soferNou = new Soferi();
            soferNou.IdSofer = int.Parse(tbIdSofer.Text);
            soferNou.Nume = tbNume.Text;
            soferNou.Experienta = int.Parse(tbExperienta.Text);

            ListViewItem item = new ListViewItem(new string[]
            { soferNou.IdSofer.ToString(), soferNou.Nume, soferNou.Experienta.ToString() });
            listViewSS.Items.Add(item);

            listaSoferi.Add(soferNou);

            FileStream fisSoferi = new FileStream("Soferi.dat", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fisSoferi, listaSoferi);
            fisSoferi.Close();
            MessageBox.Show($"Au fost salvate {listaSoferi.Count} inregistrari.");

        }
        private void btnCancelS_Click(object sender, EventArgs e)
        {
                tbIdSofer.Text = "";
                tbNume.Text = "";
                tbExperienta.Text = "";
        }
        private void btnAfiseazaS_Click(object sender, EventArgs e)
        {
            FileStream fisSoferi = new FileStream("Soferi.dat", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            listaSoferi = (List<Soferi>)bf.Deserialize(fisSoferi);
            fisSoferi.Close();
            listViewSS.Items.Clear();
            foreach (Soferi sofer in listaSoferi)
            {
                ListViewItem itm = new ListViewItem(sofer.IdSofer.ToString());
                itm.SubItems.Add(sofer.Nume);
                itm.SubItems.Add(sofer.Experienta.ToString());
                listViewSS.Items.Add(itm);
            }
        }
    }
}
