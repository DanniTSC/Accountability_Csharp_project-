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
        private ListView listViewConturi;
        //Prin constructor transmitere parametrii
        public FormSecundar(ContContabilitate cb, ListView listViewConturi)
        {
            InitializeComponent();
            if (cb == null)
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
            this.listViewConturi = listViewConturi;
        }
        //Formul secundar primeste un obiect ca parametru daca acest obiect e null creez unul nou,
        //daca nu este null text box urile iau deja valorile existente in acest obiect 
        //stochez referinta obiectului primit ca parametru in ce am luat eu public pentru a l folosi mai departe

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
        private bool ExistaContCuId(int contId)
        {
            foreach(ListViewItem item in listViewConturi.Items)
            {
                ContContabilitate cont = (ContContabilitate)item.Tag;
                if(cont.ContId == contId)
                {
                       return true;
                }
            }
            return false;
        }
        //Dau valori transmise prin formularul secundar
        private void adaugaBtn_Click(object sender, EventArgs e)
        {
            bool valid = true;
            if(!textBoxID.Text.All(char.IsDigit) || string.IsNullOrEmpty(textBoxID.Text))
            {
                errorProvider1.SetError(textBoxID, "ID-ul trebuie sa fie format doar din cifre !");
                valid = false;
            }

            if(!textBoxNume.Text.All(char.IsLetter) || string.IsNullOrEmpty(textBoxNume.Text))
            {
                errorProvider1.SetError(textBoxNume, "Numele trebuie sa fie format doar din Litere!");
                valid = false;
            }

            if(comboBoxTip.SelectedItem == null)
            {
                errorProvider1.SetError(comboBoxTip, "Trebuie sa selectati un tip de Cont !");
                    valid = false;
            }

            if(!valid)
            {
                return;
            }
            int contId;
            if (int.TryParse(textBoxID.Text, out contId))
            {
                if(ExistaContCuId(contId) && contContabilitateSecundar.ContId != contId)
                {
                    MessageBox.Show("Un cont cu acest ID există deja.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //incearca sa converteasca din text in int si daca reuseste il pune in contId
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
            //seteza rezultatul dialogului la ok si inchide formularul 
            //aici doar iau datele din textboxes
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();

        }
    }
}
