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
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonCheckSum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxSum
            // 
            this.textBoxSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSum.Location = new System.Drawing.Point(113, 23);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.Size = new System.Drawing.Size(172, 22);
            this.textBoxSum.TabIndex = 0;
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
            // buttonCheckSum
            // 
            this.buttonCheckSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCheckSum.Location = new System.Drawing.Point(3, 3);
            this.buttonCheckSum.Name = "buttonCheckSum";
            this.buttonCheckSum.Size = new System.Drawing.Size(104, 50);
            this.buttonCheckSum.TabIndex = 2;
            this.buttonCheckSum.Text = "UserCtrl Suma";
            this.buttonCheckSum.UseVisualStyleBackColor = true;
            this.buttonCheckSum.Click += new System.EventHandler(this.buttonCheckSum_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonCheckSum);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.textBoxSum);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(306, 133);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonCheckSum;
    }
}
