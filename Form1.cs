using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (cb == null)
                {
                    cb = form.contContabilitateSecundar;
                    ListViewItem lv = new ListViewItem(
                        new string[] { cb.ContId.ToString(), cb.NumeCont, cb.TipCont.ToString() });
                    lv.Tag = cb;
                    listViewConturi.Items.Add(lv);
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

                ContContabilitate contSelectat = (ContContabilitate)lv.Tag;
                // Fiecare ListViewItem stocheaza un obiect de tip ContContabilitate in proprietatea Tag. 
                // Pentru initializare iau tag-ul si ii dau cast la obiectul meu.

                FormSecundar form = new FormSecundar(contSelectat);
                if(form.ShowDialog(this) == DialogResult.OK)
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
    }
}
