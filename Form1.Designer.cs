namespace PROIECT_PAW
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listViewConturi = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TipCont = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonDeschidereForm2 = new System.Windows.Forms.Button();
            this.buttonSterge = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.XMLSavebtn = new System.Windows.Forms.Button();
            this.XMLrestorebtn = new System.Windows.Forms.Button();
            this.textBoxTSD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxTSC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxSID = new System.Windows.Forms.TextBox();
            this.textBoxSIC = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TextBoxSoldFinal = new System.Windows.Forms.TextBox();
            this.listBoxRulajDebitor = new System.Windows.Forms.ListBox();
            this.listBoxRulajCreditor = new System.Windows.Forms.ListBox();
            this.textBoxRulajDebitor = new System.Windows.Forms.TextBox();
            this.textBoxRulajCreditor = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TextBoxCONT = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnOpCont = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeContDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipContDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conturiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.operatiiContabileDataSet = new PROIECT_PAW.OperatiiContabileDataSet();
            this.conturiTableAdapter = new PROIECT_PAW.OperatiiContabileDataSetTableAdapters.ConturiTableAdapter();
            this.test = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.print = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conturiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operatiiContabileDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewConturi
            // 
            this.listViewConturi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Nume,
            this.TipCont});
            this.listViewConturi.HideSelection = false;
            this.listViewConturi.Location = new System.Drawing.Point(12, 65);
            this.listViewConturi.Name = "listViewConturi";
            this.listViewConturi.Size = new System.Drawing.Size(445, 232);
            this.listViewConturi.TabIndex = 2;
            this.listViewConturi.UseCompatibleStateImageBehavior = false;
            this.listViewConturi.View = System.Windows.Forms.View.Details;
            this.listViewConturi.SelectedIndexChanged += new System.EventHandler(this.listViewConturi_SelectedIndexChanged);
            this.listViewConturi.DoubleClick += new System.EventHandler(this.listViewConturi_DoubleClick);
            this.listViewConturi.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listViewConturi_MouseDown);
            // 
            // ID
            // 
            this.ID.Text = "ID Cont";
            this.ID.Width = 64;
            // 
            // Nume
            // 
            this.Nume.Text = "Nume Cont";
            this.Nume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Nume.Width = 186;
            // 
            // TipCont
            // 
            this.TipCont.Text = "Tipul Contului";
            this.TipCont.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TipCont.Width = 192;
            // 
            // buttonDeschidereForm2
            // 
            this.buttonDeschidereForm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDeschidereForm2.Location = new System.Drawing.Point(48, 317);
            this.buttonDeschidereForm2.Name = "buttonDeschidereForm2";
            this.buttonDeschidereForm2.Size = new System.Drawing.Size(153, 36);
            this.buttonDeschidereForm2.TabIndex = 3;
            this.buttonDeschidereForm2.Text = "Adaugare Cont ";
            this.buttonDeschidereForm2.UseVisualStyleBackColor = true;
            this.buttonDeschidereForm2.Click += new System.EventHandler(this.buttonDeschidereForm2_Click);
            // 
            // buttonSterge
            // 
            this.buttonSterge.BackColor = System.Drawing.Color.Brown;
            this.buttonSterge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSterge.ForeColor = System.Drawing.Color.White;
            this.buttonSterge.Location = new System.Drawing.Point(48, 371);
            this.buttonSterge.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSterge.Name = "buttonSterge";
            this.buttonSterge.Size = new System.Drawing.Size(153, 36);
            this.buttonSterge.TabIndex = 4;
            this.buttonSterge.Text = "Stergere Cont";
            this.buttonSterge.UseVisualStyleBackColor = false;
            this.buttonSterge.Click += new System.EventHandler(this.buttonSterge_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(518, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 31);
            this.button2.TabIndex = 11;
            this.button2.Text = "Adaugare Rulaj Debitor";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(776, 250);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 32);
            this.button3.TabIndex = 12;
            this.button3.Text = "Adaugare Rulaj Creditor";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.Location = new System.Drawing.Point(499, 467);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(224, 36);
            this.button4.TabIndex = 13;
            this.button4.Text = "Calculare Sold Total Debitor";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.Location = new System.Drawing.Point(743, 464);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(224, 36);
            this.button5.TabIndex = 14;
            this.button5.Text = "Calculare Sold Total Creditor";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button6.Location = new System.Drawing.Point(630, 563);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(212, 36);
            this.button6.TabIndex = 15;
            this.button6.Text = "Calculare Sold Final";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 31);
            this.label1.TabIndex = 16;
            this.label1.Text = "Gestionare Operatii Contabile";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(552, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Debit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(811, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "Credit";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // XMLSavebtn
            // 
            this.XMLSavebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.XMLSavebtn.Location = new System.Drawing.Point(231, 317);
            this.XMLSavebtn.Name = "XMLSavebtn";
            this.XMLSavebtn.Size = new System.Drawing.Size(153, 36);
            this.XMLSavebtn.TabIndex = 19;
            this.XMLSavebtn.Text = "Salvare XML";
            this.XMLSavebtn.UseVisualStyleBackColor = true;
            this.XMLSavebtn.Click += new System.EventHandler(this.XMLSavebtn_Click);
            // 
            // XMLrestorebtn
            // 
            this.XMLrestorebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.XMLrestorebtn.Location = new System.Drawing.Point(231, 371);
            this.XMLrestorebtn.Name = "XMLrestorebtn";
            this.XMLrestorebtn.Size = new System.Drawing.Size(153, 36);
            this.XMLrestorebtn.TabIndex = 20;
            this.XMLrestorebtn.Text = "Restaurare XML";
            this.XMLrestorebtn.UseVisualStyleBackColor = true;
            this.XMLrestorebtn.Click += new System.EventHandler(this.XMLrestorebtn_Click);
            // 
            // textBoxTSD
            // 
            this.textBoxTSD.Location = new System.Drawing.Point(540, 509);
            this.textBoxTSD.Name = "textBoxTSD";
            this.textBoxTSD.ReadOnly = true;
            this.textBoxTSD.Size = new System.Drawing.Size(100, 20);
            this.textBoxTSD.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(514, 440);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 24);
            this.label5.TabIndex = 23;
            this.label5.Text = "Total Sold Debitor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(759, 437);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 24);
            this.label6.TabIndex = 24;
            this.label6.Text = "Total Sold Creditor";
            // 
            // textBoxTSC
            // 
            this.textBoxTSC.Location = new System.Drawing.Point(801, 509);
            this.textBoxTSC.Name = "textBoxTSC";
            this.textBoxTSC.ReadOnly = true;
            this.textBoxTSC.Size = new System.Drawing.Size(100, 20);
            this.textBoxTSC.TabIndex = 25;
            this.textBoxTSC.TextChanged += new System.EventHandler(this.textBoxTSC_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(514, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 24);
            this.label7.TabIndex = 26;
            this.label7.Text = "Sold Initial Debitor";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(757, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 24);
            this.label8.TabIndex = 27;
            this.label8.Text = "Sold Initial Creditor";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // textBoxSID
            // 
            this.textBoxSID.Location = new System.Drawing.Point(518, 161);
            this.textBoxSID.Name = "textBoxSID";
            this.textBoxSID.Size = new System.Drawing.Size(100, 20);
            this.textBoxSID.TabIndex = 28;
            // 
            // textBoxSIC
            // 
            this.textBoxSIC.Location = new System.Drawing.Point(823, 161);
            this.textBoxSIC.Name = "textBoxSIC";
            this.textBoxSIC.Size = new System.Drawing.Size(100, 20);
            this.textBoxSIC.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(677, 536);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 24);
            this.label9.TabIndex = 30;
            this.label9.Text = "Sold Final";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // TextBoxSoldFinal
            // 
            this.TextBoxSoldFinal.Location = new System.Drawing.Point(681, 605);
            this.TextBoxSoldFinal.Name = "TextBoxSoldFinal";
            this.TextBoxSoldFinal.ReadOnly = true;
            this.TextBoxSoldFinal.Size = new System.Drawing.Size(100, 20);
            this.TextBoxSoldFinal.TabIndex = 31;
            // 
            // listBoxRulajDebitor
            // 
            this.listBoxRulajDebitor.FormattingEnabled = true;
            this.listBoxRulajDebitor.Location = new System.Drawing.Point(518, 288);
            this.listBoxRulajDebitor.Name = "listBoxRulajDebitor";
            this.listBoxRulajDebitor.Size = new System.Drawing.Size(173, 134);
            this.listBoxRulajDebitor.TabIndex = 32;
            this.listBoxRulajDebitor.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBoxRulajCreditor
            // 
            this.listBoxRulajCreditor.FormattingEnabled = true;
            this.listBoxRulajCreditor.Location = new System.Drawing.Point(761, 288);
            this.listBoxRulajCreditor.Name = "listBoxRulajCreditor";
            this.listBoxRulajCreditor.Size = new System.Drawing.Size(182, 134);
            this.listBoxRulajCreditor.TabIndex = 33;
            // 
            // textBoxRulajDebitor
            // 
            this.textBoxRulajDebitor.Location = new System.Drawing.Point(518, 210);
            this.textBoxRulajDebitor.Name = "textBoxRulajDebitor";
            this.textBoxRulajDebitor.Size = new System.Drawing.Size(100, 20);
            this.textBoxRulajDebitor.TabIndex = 34;
            this.textBoxRulajDebitor.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxRulajCreditor
            // 
            this.textBoxRulajCreditor.Location = new System.Drawing.Point(823, 210);
            this.textBoxRulajCreditor.Name = "textBoxRulajCreditor";
            this.textBoxRulajCreditor.Size = new System.Drawing.Size(100, 20);
            this.textBoxRulajCreditor.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(626, 210);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(174, 20);
            this.label11.TabIndex = 37;
            this.label11.Text = "<-Introduceti Rulajele->";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // TextBoxCONT
            // 
            this.TextBoxCONT.AllowDrop = true;
            this.TextBoxCONT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxCONT.Location = new System.Drawing.Point(490, 61);
            this.TextBoxCONT.Name = "TextBoxCONT";
            this.TextBoxCONT.ReadOnly = true;
            this.TextBoxCONT.Size = new System.Drawing.Size(233, 29);
            this.TextBoxCONT.TabIndex = 39;
            this.TextBoxCONT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxCONT.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.TextBoxCONT_MaskInputRejected);
            this.TextBoxCONT.DragDrop += new System.Windows.Forms.DragEventHandler(this.TextBoxCONT_DragDrop);
            this.TextBoxCONT.DragEnter += new System.Windows.Forms.DragEventHandler(this.TextBoxCONT_DragEnter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(512, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(411, 31);
            this.label10.TabIndex = 40;
            this.label10.Text = "Drag Drop Contul Din ListView";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(641, 161);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(159, 20);
            this.label12.TabIndex = 41;
            this.label12.Text = "<-Introduceti Sume->";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(743, 70);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 42;
            // 
            // btnOpCont
            // 
            this.btnOpCont.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOpCont.Location = new System.Drawing.Point(618, 645);
            this.btnOpCont.Name = "btnOpCont";
            this.btnOpCont.Size = new System.Drawing.Size(224, 52);
            this.btnOpCont.TabIndex = 43;
            this.btnOpCont.Text = "Salvare si Export Operatie Contabila in Fisier Text";
            this.btnOpCont.UseVisualStyleBackColor = true;
            this.btnOpCont.Click += new System.EventHandler(this.btnOpCont_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.contIdDataGridViewTextBoxColumn,
            this.numeContDataGridViewTextBoxColumn,
            this.tipContDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.conturiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(48, 437);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(348, 140);
            this.dataGridView1.TabIndex = 44;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // contIdDataGridViewTextBoxColumn
            // 
            this.contIdDataGridViewTextBoxColumn.DataPropertyName = "ContId";
            this.contIdDataGridViewTextBoxColumn.HeaderText = "ContId";
            this.contIdDataGridViewTextBoxColumn.Name = "contIdDataGridViewTextBoxColumn";
            this.contIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeContDataGridViewTextBoxColumn
            // 
            this.numeContDataGridViewTextBoxColumn.DataPropertyName = "NumeCont";
            this.numeContDataGridViewTextBoxColumn.HeaderText = "NumeCont";
            this.numeContDataGridViewTextBoxColumn.Name = "numeContDataGridViewTextBoxColumn";
            // 
            // tipContDataGridViewTextBoxColumn
            // 
            this.tipContDataGridViewTextBoxColumn.DataPropertyName = "TipCont";
            this.tipContDataGridViewTextBoxColumn.HeaderText = "TipCont";
            this.tipContDataGridViewTextBoxColumn.Name = "tipContDataGridViewTextBoxColumn";
            // 
            // conturiBindingSource
            // 
            this.conturiBindingSource.DataMember = "Conturi";
            this.conturiBindingSource.DataSource = this.operatiiContabileDataSet;
            this.conturiBindingSource.CurrentChanged += new System.EventHandler(this.conturiBindingSource_CurrentChanged);
            // 
            // operatiiContabileDataSet
            // 
            this.operatiiContabileDataSet.DataSetName = "OperatiiContabileDataSet";
            this.operatiiContabileDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // conturiTableAdapter
            // 
            this.conturiTableAdapter.ClearBeforeFill = true;
            // 
            // test
            // 
            this.test.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.test.Location = new System.Drawing.Point(48, 587);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(178, 52);
            this.test.TabIndex = 47;
            this.test.Text = "Trimitere Date din ListView in Baza de Date";
            this.test.UseVisualStyleBackColor = true;
            this.test.Click += new System.EventHandler(this.test_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Brown;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(231, 587);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 52);
            this.button1.TabIndex = 48;
            this.button1.Text = "Stergere Totala Baza de date";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // print
            // 
            this.print.Location = new System.Drawing.Point(915, 605);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(75, 37);
            this.print.TabIndex = 49;
            this.print.Text = "Printare Sold Final";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 718);
            this.Controls.Add(this.print);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.test);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnOpCont);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TextBoxCONT);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxRulajCreditor);
            this.Controls.Add(this.textBoxRulajDebitor);
            this.Controls.Add(this.listBoxRulajCreditor);
            this.Controls.Add(this.listBoxRulajDebitor);
            this.Controls.Add(this.TextBoxSoldFinal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxSIC);
            this.Controls.Add(this.textBoxSID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxTSC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxTSD);
            this.Controls.Add(this.XMLrestorebtn);
            this.Controls.Add(this.XMLSavebtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonSterge);
            this.Controls.Add(this.buttonDeschidereForm2);
            this.Controls.Add(this.listViewConturi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conturiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operatiiContabileDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listViewConturi;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Nume;
        private System.Windows.Forms.ColumnHeader TipCont;
        private System.Windows.Forms.Button buttonDeschidereForm2;
        private System.Windows.Forms.Button buttonSterge;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button XMLSavebtn;
        private System.Windows.Forms.Button XMLrestorebtn;
        private System.Windows.Forms.TextBox textBoxTSD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxTSC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxSID;
        private System.Windows.Forms.TextBox textBoxSIC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TextBoxSoldFinal;
        private System.Windows.Forms.ListBox listBoxRulajDebitor;
        private System.Windows.Forms.ListBox listBoxRulajCreditor;
        private System.Windows.Forms.TextBox textBoxRulajDebitor;
        private System.Windows.Forms.TextBox textBoxRulajCreditor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox TextBoxCONT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnOpCont;
        private System.Windows.Forms.DataGridView dataGridView1;
        private OperatiiContabileDataSet operatiiContabileDataSet;
        private System.Windows.Forms.BindingSource conturiBindingSource;
        private OperatiiContabileDataSetTableAdapters.ConturiTableAdapter conturiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn contIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeContDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipContDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button test;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button print;
    }
}

