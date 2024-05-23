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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void labelResult_Click(object sender, EventArgs e)
        {

        }

        private void buttonCheckSum_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxSum.Text, out double sum))
            {
                if (sum < 30)
                {
                    labelResult.Text = "Suma este mai mica de 30.";
                }
                else if(sum > 30)
                {
                    labelResult.Text = "Suma este mai mare de 30.";
                }
                else if(sum == 30)
                {
                    labelResult.Text = "Suma este egala 30.";

                }
            }
            else
            {
                labelResult.Text = "Introduceti o suma valida.";
            }
        }
    }
    
}
