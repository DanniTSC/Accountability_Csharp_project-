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
    public partial class FormSecundar : Form
    {
        public ContContabilitate contContabilitateSecundar;
        //Prin constructor transmitere parametrii
        public FormSecundar(ContContabilitate cb)
        {
            InitializeComponent();
            if(cb == null)
            {
                cb = new ContContabilitate();
                adaugaBtn.Text = "Adaugare";
            }
            else
            {
                adaugaBtn.Text = "Modifica Cont";
                textBoxID.Text = cb.ContId.ToString();
                textBoxNume.Text = cb.NumeCont;
                comboBoxTip.Text = cb.TipCont.ToString();
            }
            contContabilitateSecundar = cb;
        }

        private void textBoxSus_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //Dau valori transmise prin formularul secundar
        private void adaugaBtn_Click(object sender, EventArgs e)
        {
            int contId;
            if (int.TryParse(textBoxID.Text, out contId))
            {
                contContabilitateSecundar.ContId = contId;
            }
            else
            {
                MessageBox.Show("Id-ul nu este valid");
                return; 
            }

            contContabilitateSecundar.NumeCont = textBoxNume.Text;

            ContContabilitate.TipContContabilitate tipCont;
            if (Enum.TryParse(comboBoxTip.SelectedItem.ToString(), out tipCont))
            {
                contContabilitateSecundar.TipCont = tipCont;
            }
            else
            {
                MessageBox.Show("Tip Invalid");
                return; 
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
