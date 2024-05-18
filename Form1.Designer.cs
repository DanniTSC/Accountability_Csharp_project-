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
            this.button1 = new System.Windows.Forms.Button();
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
            this.listViewConturi.Size = new System.Drawing.Size(495, 97);
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
            this.buttonDeschidereForm2.Location = new System.Drawing.Point(48, 225);
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
            this.buttonSterge.Location = new System.Drawing.Point(48, 285);
            this.buttonSterge.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSterge.Name = "buttonSterge";
            this.buttonSterge.Size = new System.Drawing.Size(133, 36);
            this.buttonSterge.TabIndex = 4;
            this.buttonSterge.Text = "Stergere Cont";
            this.buttonSterge.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(48, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "Modificare Cont";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ContPtOperatiune
            // 
            this.ContPtOperatiune.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ContPtOperatiune.FormattingEnabled = true;
            this.ContPtOperatiune.Location = new System.Drawing.Point(734, 123);
            this.ContPtOperatiune.Name = "ContPtOperatiune";
            this.ContPtOperatiune.Size = new System.Drawing.Size(236, 28);
            this.ContPtOperatiune.TabIndex = 7;
            this.ContPtOperatiune.Text = "Alege Cont Pentru Operatiune:";
            // 
            // SumaInit
            // 
            this.SumaInit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SumaInit.Location = new System.Drawing.Point(734, 381);
            this.SumaInit.Name = "SumaInit";
            this.SumaInit.Size = new System.Drawing.Size(212, 36);
            this.SumaInit.TabIndex = 10;
            this.SumaInit.Text = "Adaugare Suma Initiala";
            this.SumaInit.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(591, 423);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(224, 36);
            this.button2.TabIndex = 11;
            this.button2.Text = "Adaugare Rulaj Debitor";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(821, 423);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(224, 36);
            this.button3.TabIndex = 12;
            this.button3.Text = "Adaugare Rulaj Creditor";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.Location = new System.Drawing.Point(591, 465);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(224, 36);
            this.button4.TabIndex = 13;
            this.button4.Text = "Calculare Sold Total Debitor";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.Location = new System.Drawing.Point(821, 465);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(224, 36);
            this.button5.TabIndex = 14;
            this.button5.Text = "Calculare Sold Total Creditor";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button6.Location = new System.Drawing.Point(734, 507);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(212, 36);
            this.button6.TabIndex = 15;
            this.button6.Text = "Calculare Suma Finala";
            this.button6.UseVisualStyleBackColor = true;
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
            this.label2.Location = new System.Drawing.Point(730, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Debit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(905, 175);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 573);
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
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
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
    }
}

