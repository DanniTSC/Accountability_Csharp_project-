using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            IncarcaDateConturi();

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

            FormSecundar form = new FormSecundar(cb, listViewConturi);
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

                FormSecundar form = new FormSecundar(contSelectat,listViewConturi);
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            double soldTotalDebitor, soldTotalCreditor, soldFinal;

            if (!double.TryParse(textBoxTSD.Text, out soldTotalDebitor))
            {
                MessageBox.Show("Introduceți un sold total debitor valid.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(textBoxTSC.Text, out soldTotalCreditor))
            {
                MessageBox.Show("Introduceți un sold total creditor valid.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string tipCont = TextBoxCONT.Text.Split(',')[2].Trim();

            if (tipCont == "Pasiv")
            {
                soldFinal = soldTotalCreditor - soldTotalDebitor;
            }
            else if (tipCont == "Activ")
            {
                soldFinal = soldTotalDebitor - soldTotalCreditor;
            }
            else
            {
                MessageBox.Show("Tipul contului este invalid.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TextBoxSoldFinal.Text = soldFinal.ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double suma;
            if (double.TryParse(textBoxRulajDebitor.Text, out suma))
            {
                listBoxRulajDebitor.Items.Add(suma);
                textBoxRulajDebitor.Clear(); //adaug in listbox si dau clean la textbox 
            }
            else
            {
                MessageBox.Show("Introduceti o suma valida pentru rulaj debitor.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double suma;
            if (double.TryParse(textBoxRulajCreditor.Text, out suma))
            {
                listBoxRulajCreditor.Items.Add(suma);
                textBoxRulajCreditor.Clear();
            }
            else
            {
                MessageBox.Show("Introduceti o suma valida pentru rulaj Creditor.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double sumaInitialaDebitor;
            if (!double.TryParse(textBoxSID.Text, out sumaInitialaDebitor))
            {
                MessageBox.Show("Introduceti o suma initiala valabila pentru Debit.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double totalDebitor = sumaInitialaDebitor;
            foreach (var item in listBoxRulajDebitor.Items)
            {
                totalDebitor += Convert.ToDouble(item);
            }

            textBoxTSD.Text = totalDebitor.ToString();
        }

        private void textBoxTSC_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double sumaInitialaCreditor;
            if (!double.TryParse(textBoxSIC.Text, out sumaInitialaCreditor))
            {
                MessageBox.Show("Introduceti o suma initiala valabila pentru Credit.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double totalCreditor = sumaInitialaCreditor;
            foreach (var item in listBoxRulajCreditor.Items)
            {
                totalCreditor += Convert.ToDouble(item);
            }

            textBoxTSC.Text = totalCreditor.ToString();
        }


        //private void UpdateComboBoxConturi()
        //{
        //    ComboBoxConturi.Items.Clear(); //clean ce exista deja 

        //    foreach (ListViewItem item in listViewConturi.Items)
        //    {
        //        ComboBoxConturi.Items.Add(item.SubItems[1].Text); //adaug nume
        //    }

        //    if (ComboBoxConturi.Items.Count > 0)
        //    {
        //        ComboBoxConturi.SelectedIndex = 0; 
        //    }
        //}

        private void ComboBoxConturi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listViewConturi_MouseDown(object sender, MouseEventArgs e)
        {
            if (listViewConturi.SelectedItems.Count > 0)
            {
                ListViewItem item = listViewConturi.SelectedItems[0];
                string data = $"{item.SubItems[0].Text}, {item.SubItems[1].Text}, {item.SubItems[2].Text}";
                listViewConturi.DoDragDrop(data, DragDropEffects.Copy);
            }
        }

        private void TextBoxCONT_DragDrop(object sender, DragEventArgs e)
        {
            string data = (string)e.Data.GetData(DataFormats.Text);
            TextBoxCONT.Text = data;

            textBoxSID.Clear();
            textBoxSIC.Clear();
            listBoxRulajDebitor.Items.Clear();
            listBoxRulajCreditor.Items.Clear();
            textBoxTSD.Clear();
            textBoxTSC.Clear();
            TextBoxSoldFinal.Clear();

            var parts = data.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length == 3)
            {
                string contId = parts[0].Trim();
                string numeCont = parts[1].Trim();
                string tipCont = parts[2].Trim();

                if (tipCont == "Pasiv")
                {
                    textBoxSID.Text = "0";
                    textBoxSID.ReadOnly = true;
                }
                else if (tipCont == "Activ")
                {
                    textBoxSIC.Text = "0";
                    textBoxSIC.ReadOnly = true;
                }
            }
        }

        private void TextBoxCONT_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxCONT_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        //OP CONT
        private void btnOpCont_Click(object sender, EventArgs e)
        {
            // Verifică dacă contul este selectat
            if (string.IsNullOrWhiteSpace(TextBoxCONT.Text))
            {
                MessageBox.Show("Selectați un cont pentru operațiune.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verifică dacă suma finală este calculată
            if (string.IsNullOrWhiteSpace(TextBoxSoldFinal.Text))
            {
                MessageBox.Show("Calculați suma finală înainte de a salva operațiunea.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Creează obiectul de tip OperatiiContabile
            var parts = TextBoxCONT.Text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            int contId = int.Parse(parts[0].Trim());
            string numeCont = parts[1].Trim();
            ContContabilitate.TipContContabilitate tipCont = (ContContabilitate.TipContContabilitate)Enum.Parse(typeof(ContContabilitate.TipContContabilitate), parts[2].Trim());

            ContContabilitate contOperatie = new ContContabilitate(contId, numeCont, tipCont);

            OperatiiContabile operatiune = new OperatiiContabile
            {
                DataOpCont = dateTimePicker1.Value,
                OperatiuneId = GetNewOperatiuneId(),
                SumaFinala = double.Parse(TextBoxSoldFinal.Text),
                ContOperatie = contOperatie
            };

            // Salvează operațiunea într-un fișier text
            SaveOperatiuneToFile(operatiune);
        }

        private int GetNewOperatiuneId()
        {
            // Generează un ID unic pentru operațiune
            // De exemplu, poți folosi un timestamp sau un GUID
            return DateTime.Now.Ticks.GetHashCode();
        }

        private void SaveOperatiuneToFile(OperatiiContabile operatiune)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // Construiește calea completă către folderul PAW/PROJ
            string folderPath = Path.Combine(desktopPath, "PAW", "PROJ");
            string filePath = Path.Combine(folderPath, "operatii_contabile.txt");
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine("Operatiune ID: " + operatiune.OperatiuneId);
                writer.WriteLine("Data: " + operatiune.DataOpCont);
                writer.WriteLine("Cont ID: " + operatiune.ContOperatie.ContId);
                writer.WriteLine("Nume Cont: " + operatiune.ContOperatie.NumeCont);
                writer.WriteLine("Tip Cont: " + operatiune.ContOperatie.TipCont);
                writer.WriteLine("Suma Finala: " + operatiune.SumaFinala);
                writer.WriteLine(new string('-', 50));
            }

            MessageBox.Show("Operațiunea a fost salvată cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'operatiiContabileDataSet.Conturi' table. You can move, or remove it, as needed.
            this.conturiTableAdapter.Fill(this.operatiiContabileDataSet.Conturi);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.conturiBindingSource.EndEdit();
                this.conturiTableAdapter.Update(this.operatiiContabileDataSet.Conturi);
                MessageBox.Show("Salvare cu succes");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void conturiBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void test_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=operatiiContabile;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                foreach (ListViewItem item in listViewConturi.Items)
                {
                    int id = int.Parse(item.SubItems[0].Text);
                    string numeCont = item.SubItems[1].Text;
                    string tipCont = item.SubItems[2].Text;

                    string query;

                    // Check if row exists in database (by Id)
                    string checkQuery = "SELECT COUNT(*) FROM Conturi WHERE ContId = @ContId";
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@ContId", id);
                        int count = (int)checkCommand.ExecuteScalar();

                        if (count > 0)
                        {
                            // Update existing row
                            query = "UPDATE Conturi SET NumeCont = @NumeCont, TipCont = @TipCont WHERE ContId = @ContId";
                        }
                        else
                        {
                            // Insert new row
                            query = "INSERT INTO Conturi (ContId, NumeCont, TipCont) VALUES (@ContId, @NumeCont, @TipCont)";
                        }
                    }

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ContId", id);
                        command.Parameters.AddWithValue("@NumeCont", numeCont);
                        command.Parameters.AddWithValue("@TipCont", tipCont);
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Datele au fost salvate cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            IncarcaDateConturi();
        }
        private void IncarcaDateConturi()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=operatiiContabile;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string selectQuery = "SELECT * FROM Conturi";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectQuery, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                conturiBindingSource.DataSource = dataTable;
                dataGridView1.DataSource = conturiBindingSource;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sunteți sigur că doriți să ștergeți toate înregistrările?", "Ștergere Totală", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=operatiiContabile;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string deleteQuery = "DELETE FROM Conturi";
                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Toate înregistrările au fost șterse cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Golește ListView-ul
                    listViewConturi.Items.Clear();

                    // Reîncarcă datele în DataGridView
                    IncarcaDateConturi();
                }
            }
        }
    }
}

