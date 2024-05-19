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
            this.listViewConturi = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TipCont = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonDeschidereForm2 = new System.Windows.Forms.Button();
            this.buttonSterge = new System.Windows.Forms.Button();
            this.ContPtOperatiune = new System.Windows.Forms.ComboBox();
            this.SumaInit = new System.Windows.Forms.Button();
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
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTSD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxTSC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxSID = new System.Windows.Forms.TextBox();
            this.textBoxSIC = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxSOLDFINAL = new System.Windows.Forms.TextBox();
            this.listBoxRulajDebitor = new System.Windows.Forms.ListBox();
            this.listBoxRulajCreditor = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listViewConturi
            // 
            this.listViewConturi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Nume,
            this.TipCont});
            this.listViewConturi.HideSelection = false;
            this.listViewConturi.Location = new System.Drawing.Point(48, 102);
            this.listViewConturi.Name = "listViewConturi";
            this.listViewConturi.Size = new System.Drawing.Size(445, 232);
            this.listViewConturi.TabIndex = 2;
            this.listViewConturi.UseCompatibleStateImageBehavior = false;
            this.listViewConturi.View = System.Windows.Forms.View.Details;
            this.listViewConturi.SelectedIndexChanged += new System.EventHandler(this.listViewConturi_SelectedIndexChanged);
            this.listViewConturi.DoubleClick += new System.EventHandler(this.listViewConturi_DoubleClick);
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
            this.buttonDeschidereForm2.Location = new System.Drawing.Point(103, 340);
            this.buttonDeschidereForm2.Name = "buttonDeschidereForm2";
            this.buttonDeschidereForm2.Size = new System.Drawing.Size(133, 36);
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
            this.buttonSterge.Location = new System.Drawing.Point(269, 340);
            this.buttonSterge.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSterge.Name = "buttonSterge";
            this.buttonSterge.Size = new System.Drawing.Size(133, 36);
            this.buttonSterge.TabIndex = 4;
            this.buttonSterge.Text = "Stergere Cont";
            this.buttonSterge.UseVisualStyleBackColor = false;
            this.buttonSterge.Click += new System.EventHandler(this.buttonSterge_Click);
            // 
            // ContPtOperatiune
            // 
            this.ContPtOperatiune.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ContPtOperatiune.FormattingEnabled = true;
            this.ContPtOperatiune.Location = new System.Drawing.Point(636, 102);
            this.ContPtOperatiune.Name = "ContPtOperatiune";
            this.ContPtOperatiune.Size = new System.Drawing.Size(236, 28);
            this.ContPtOperatiune.TabIndex = 7;
            this.ContPtOperatiune.Text = "Alege Cont Pentru Operatiune:";
            // 
            // SumaInit
            // 
            this.SumaInit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SumaInit.Location = new System.Drawing.Point(112, 524);
            this.SumaInit.Name = "SumaInit";
            this.SumaInit.Size = new System.Drawing.Size(212, 36);
            this.SumaInit.TabIndex = 10;
            this.SumaInit.Text = "Adaugare Suma Initiala";
            this.SumaInit.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(12, 566);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(224, 36);
            this.button2.TabIndex = 11;
            this.button2.Text = "Adaugare Rulaj Debitor";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(269, 566);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(224, 36);
            this.button3.TabIndex = 12;
            this.button3.Text = "Adaugare Rulaj Creditor";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.Location = new System.Drawing.Point(12, 608);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(224, 36);
            this.button4.TabIndex = 13;
            this.button4.Text = "Calculare Sold Total Debitor";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.Location = new System.Drawing.Point(269, 608);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(224, 36);
            this.button5.TabIndex = 14;
            this.button5.Text = "Calculare Sold Total Creditor";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button6.Location = new System.Drawing.Point(112, 650);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(212, 36);
            this.button6.TabIndex = 15;
            this.button6.Text = "Calculare Sold Finala";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(335, 31);
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
            this.label2.Location = new System.Drawing.Point(589, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Debit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(839, 142);
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
            this.XMLSavebtn.Location = new System.Drawing.Point(103, 403);
            this.XMLSavebtn.Name = "XMLSavebtn";
            this.XMLSavebtn.Size = new System.Drawing.Size(133, 36);
            this.XMLSavebtn.TabIndex = 19;
            this.XMLSavebtn.Text = "Salvare XML";
            this.XMLSavebtn.UseVisualStyleBackColor = true;
            this.XMLSavebtn.Click += new System.EventHandler(this.XMLSavebtn_Click);
            // 
            // XMLrestorebtn
            // 
            this.XMLrestorebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.XMLrestorebtn.Location = new System.Drawing.Point(269, 403);
            this.XMLrestorebtn.Name = "XMLrestorebtn";
            this.XMLrestorebtn.Size = new System.Drawing.Size(153, 36);
            this.XMLrestorebtn.TabIndex = 20;
            this.XMLrestorebtn.Text = "Restaurare XML";
            this.XMLrestorebtn.UseVisualStyleBackColor = true;
            this.XMLrestorebtn.Click += new System.EventHandler(this.XMLrestorebtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(41, 470);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(381, 31);
            this.label4.TabIndex = 21;
            this.label4.Text = "Realizare Operatii Contabile";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxTSD
            // 
            this.textBoxTSD.Location = new System.Drawing.Point(571, 403);
            this.textBoxTSD.Name = "textBoxTSD";
            this.textBoxTSD.Size = new System.Drawing.Size(100, 20);
            this.textBoxTSD.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(543, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 24);
            this.label5.TabIndex = 23;
            this.label5.Text = "Total Sold Debitor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(797, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 24);
            this.label6.TabIndex = 24;
            this.label6.Text = "Total Sold Creditor";
            // 
            // textBoxTSC
            // 
            this.textBoxTSC.Location = new System.Drawing.Point(843, 403);
            this.textBoxTSC.Name = "textBoxTSC";
            this.textBoxTSC.Size = new System.Drawing.Size(100, 20);
            this.textBoxTSC.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(541, 166);
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
            this.label8.Location = new System.Drawing.Point(795, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 24);
            this.label8.TabIndex = 27;
            this.label8.Text = "Sold Initial Creditor";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // textBoxSID
            // 
            this.textBoxSID.Location = new System.Drawing.Point(571, 193);
            this.textBoxSID.Name = "textBoxSID";
            this.textBoxSID.Size = new System.Drawing.Size(100, 20);
            this.textBoxSID.TabIndex = 28;
            // 
            // textBoxSIC
            // 
            this.textBoxSIC.Location = new System.Drawing.Point(843, 193);
            this.textBoxSIC.Name = "textBoxSIC";
            this.textBoxSIC.Size = new System.Drawing.Size(100, 20);
            this.textBoxSIC.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(711, 429);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 24);
            this.label9.TabIndex = 30;
            this.label9.Text = "Sold Final";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // textBoxSOLDFINAL
            // 
            this.textBoxSOLDFINAL.Location = new System.Drawing.Point(715, 470);
            this.textBoxSOLDFINAL.Name = "textBoxSOLDFINAL";
            this.textBoxSOLDFINAL.Size = new System.Drawing.Size(100, 20);
            this.textBoxSOLDFINAL.TabIndex = 31;
            // 
            // listBoxRulajDebitor
            // 
            this.listBoxRulajDebitor.FormattingEnabled = true;
            this.listBoxRulajDebitor.Location = new System.Drawing.Point(545, 219);
            this.listBoxRulajDebitor.Name = "listBoxRulajDebitor";
            this.listBoxRulajDebitor.Size = new System.Drawing.Size(173, 134);
            this.listBoxRulajDebitor.TabIndex = 32;
            this.listBoxRulajDebitor.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBoxRulajCreditor
            // 
            this.listBoxRulajCreditor.FormattingEnabled = true;
            this.listBoxRulajCreditor.Location = new System.Drawing.Point(799, 219);
            this.listBoxRulajCreditor.Name = "listBoxRulajCreditor";
            this.listBoxRulajCreditor.Size = new System.Drawing.Size(182, 134);
            this.listBoxRulajCreditor.TabIndex = 33;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 824);
            this.Controls.Add(this.listBoxRulajCreditor);
            this.Controls.Add(this.listBoxRulajDebitor);
            this.Controls.Add(this.textBoxSOLDFINAL);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxSIC);
            this.Controls.Add(this.textBoxSID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxTSC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxTSD);
            this.Controls.Add(this.label4);
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
            this.Controls.Add(this.SumaInit);
            this.Controls.Add(this.ContPtOperatiune);
            this.Controls.Add(this.buttonSterge);
            this.Controls.Add(this.buttonDeschidereForm2);
            this.Controls.Add(this.listViewConturi);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.ComboBox ContPtOperatiune;
        private System.Windows.Forms.Button SumaInit;
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTSD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxTSC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxSID;
        private System.Windows.Forms.TextBox textBoxSIC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxSOLDFINAL;
        private System.Windows.Forms.ListBox listBoxRulajDebitor;
        private System.Windows.Forms.ListBox listBoxRulajCreditor;
    }
}

