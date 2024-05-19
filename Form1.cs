using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace PROIECT_PAW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            toolTip1 = new ToolTip();
            toolTip1.SetToolTip(listViewConturi, "Double-click pe Id-ul unui cont pentru a fi modificat");
        }




        private void textBoxSus_TextChanged(object sender, EventArgs e)
        {

        }

        private void listViewConturi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Adaugare modificare Cont 
        private void buttonDeschidereForm2_Click(object sender, EventArgs e)
        {
            ContContabilitate cb = null;
            if (listViewConturi.SelectedItems.Count > 0)
            {
                cb = (ContContabilitate)listViewConturi.SelectedItems[0].Tag;
                // Fiecare ListViewItem stocheaza un obiect de tip ContContabilitate in proprietatea Tag. 
                // Pentru initializare iau tag-ul si ii dau cast la obiectul meu.

            }

            FormSecundar form = new FormSecundar(cb);
            //creaza formular secundar nou cu obiectul meu ca parametru
            if (form.ShowDialog() == DialogResult.OK)//daca dialogul este ok
            {
                if (cb == null)
                {
                    cb = form.contContabilitateSecundar;
                    ListViewItem lv = new ListViewItem(
                        new string[] { cb.ContId.ToString(), cb.NumeCont, cb.TipCont.ToString() });
                    lv.Tag = cb;
                    listViewConturi.Items.Add(lv);
                    //creeaza un nou item list view si l stocheaza in acesta 
                }
                else
                {
                    cb.ContId = form.contContabilitateSecundar.ContId;
                    cb.NumeCont = form.contContabilitateSecundar.NumeCont;
                    cb.TipCont = form.contContabilitateSecundar.TipCont;
                    ListViewItem itemSelectat = listViewConturi.SelectedItems[0];
                    itemSelectat.SubItems[0].Text = cb.ContId.ToString();
                    itemSelectat.SubItems[1].Text = cb.NumeCont;
                    itemSelectat.SubItems[2].Text = cb.TipCont.ToString();
                }
            }
        }

        //Modificare Cont
        private void listViewConturi_DoubleClick(object sender, EventArgs e)
        {
            if (listViewConturi.SelectedItems.Count > 0)
            {
                ListViewItem lv = listViewConturi.SelectedItems[0];
                //obtine primul item selectat

                ContContabilitate contSelectat = (ContContabilitate)lv.Tag;
                // Fiecare ListViewItem stocheaza un obiect de tip ContContabilitate in proprietatea Tag. 
                // Pentru initializare iau tag-ul si ii dau cast la obiectul meu.

                FormSecundar form = new FormSecundar(contSelectat);
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    lv.SubItems[0].Text = contSelectat.ContId.ToString();
                    lv.SubItems[1].Text = contSelectat.NumeCont;
                    lv.SubItems[2].Text = contSelectat.TipCont.ToString();
                }
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void XMLrestorebtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "fisier xml | *.xml";
            fd.CheckFileExists = true;

            if (fd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Stream fisier = File.OpenRead(fd.FileName);
                    XmlSerializer serializer = new XmlSerializer(typeof(List<ContContabilitate>));
                    List<ContContabilitate> lista = (List<ContContabilitate>)serializer.Deserialize(fisier);
                    if (listViewConturi.Items.Count > 0)
                    {
                        if (MessageBox.Show("Vrei sa stergi conturile existente?", "Posibilitate Sterge", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            listViewConturi.Items.Clear();
                        }
                    }
                    foreach (ContContabilitate cont in lista)
                    {
                        ListViewItem lvi = new ListViewItem(new string[]
                        {cont.ContId.ToString(), cont.NumeCont, cont.TipCont.ToString()
                        });
                        lvi.Tag = cont;
                        listViewConturi.Items.Add(lvi);
                    }
                    fisier.Close();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }

            }

        }

        private void XMLSavebtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "salvare xml|*.xml"; //ce insemna asta
            fd.CheckPathExists = true;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                List<ContContabilitate> lista = new List<ContContabilitate>();
                foreach (ListViewItem lvi in listViewConturi.Items)
                    lista.Add((ContContabilitate)lvi.Tag);
                try
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<ContContabilitate>));
                    Stream fisier = File.Create(fd.FileName);
                    serializer.Serialize(fisier, lista);
                    MessageBox.Show("Lista de Conturi a fost salvata in format XML!", "Serializare cu Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fisier.Close();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }

            }
        }

        private void buttonSterge_Click(object sender, EventArgs e)
        {
            if(listViewConturi.SelectedItems.Count > 0) 
            {
                if (MessageBox.Show("Sunteti sigur ca doriti stergerea acestui cont ?", "Stergere Cont", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) 
                listViewConturi.SelectedItems[0].Remove();
            }
            else
            {
                MessageBox.Show("Selectati un cont pentru a-l sterge !");
            }
        }
    }
}
