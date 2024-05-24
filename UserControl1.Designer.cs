namespace PROIECT_PAW
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelResult = new System.Windows.Forms.Label();
            this.lblNumeCont = new System.Windows.Forms.Label();
            this.lblContId = new System.Windows.Forms.Label();
            this.lblTipCont = new System.Windows.Forms.Label();
            this.lblSoldCreditor = new System.Windows.Forms.Label();
            this.lblSoldDebitor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelResult.Location = new System.Drawing.Point(14, 56);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 20);
            this.labelResult.TabIndex = 1;
            this.labelResult.Click += new System.EventHandler(this.labelResult_Click);
            // 
            // lblNumeCont
            // 
            this.lblNumeCont.AutoSize = true;
            this.lblNumeCont.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNumeCont.Location = new System.Drawing.Point(23, 17);
            this.lblNumeCont.Name = "lblNumeCont";
            this.lblNumeCont.Size = new System.Drawing.Size(70, 16);
            this.lblNumeCont.TabIndex = 2;
            this.lblNumeCont.Text = "NumeCont";
            // 
            // lblContId
            // 
            this.lblContId.AutoSize = true;
            this.lblContId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblContId.Location = new System.Drawing.Point(65, 43);
            this.lblContId.Name = "lblContId";
            this.lblContId.Size = new System.Drawing.Size(45, 16);
            this.lblContId.TabIndex = 3;
            this.lblContId.Text = "ContId";
            // 
            // lblTipCont
            // 
            this.lblTipCont.AutoSize = true;
            this.lblTipCont.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTipCont.Location = new System.Drawing.Point(99, 17);
            this.lblTipCont.Name = "lblTipCont";
            this.lblTipCont.Size = new System.Drawing.Size(54, 16);
            this.lblTipCont.TabIndex = 4;
            this.lblTipCont.Text = "TipCont";
            // 
            // lblSoldCreditor
            // 
            this.lblSoldCreditor.AutoSize = true;
            this.lblSoldCreditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSoldCreditor.Location = new System.Drawing.Point(156, 43);
            this.lblSoldCreditor.Name = "lblSoldCreditor";
            this.lblSoldCreditor.Size = new System.Drawing.Size(82, 16);
            this.lblSoldCreditor.TabIndex = 5;
            this.lblSoldCreditor.Text = "SoldCreditor";
            // 
            // lblSoldDebitor
            // 
            this.lblSoldDebitor.AutoSize = true;
            this.lblSoldDebitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSoldDebitor.Location = new System.Drawing.Point(159, 17);
            this.lblSoldDebitor.Name = "lblSoldDebitor";
            this.lblSoldDebitor.Size = new System.Drawing.Size(79, 16);
            this.lblSoldDebitor.TabIndex = 6;
            this.lblSoldDebitor.Text = "SoldDebitor";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblSoldDebitor);
            this.Controls.Add(this.lblSoldCreditor);
            this.Controls.Add(this.lblTipCont);
            this.Controls.Add(this.lblContId);
            this.Controls.Add(this.lblNumeCont);
            this.Controls.Add(this.labelResult);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(258, 76);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label lblNumeCont;
        private System.Windows.Forms.Label lblContId;
        private System.Windows.Forms.Label lblTipCont;
        private System.Windows.Forms.Label lblSoldCreditor;
        private System.Windows.Forms.Label lblSoldDebitor;
    }
}
