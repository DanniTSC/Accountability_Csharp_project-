using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        public void ActualizeazaSumar(string contId, string numeCont, string tipCont, double soldDebitor, double soldCreditor)
        {
            //textul din fiecare label va lua valorile din constructori
            lblContId.Text = contId;
            lblNumeCont.Text = numeCont;
            lblTipCont.Text = tipCont;
            //format C pentru afisarea unei sume ca moneda, utilizand CultureInfo Ro ofera Lei.
            //Culture info specifica informatii culturale cum ar fi format de data sau moneda
            lblSoldDebitor.Text = soldDebitor.ToString("C", new CultureInfo("ro-RO"));
            lblSoldCreditor.Text = soldCreditor.ToString("C", new CultureInfo("ro-RO"));
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void labelResult_Click(object sender, EventArgs e)
        {

        }

        //private void buttonCheckSum_Click(object sender, EventArgs e)
        //{
        //    if (double.TryParse(textBoxSum.Text, out double sum))
        //    {
        //        if (sum < 30)
        //        {
        //            labelResult.Text = "Suma este mai mica de 30.";
        //        }
        //        else if(sum > 30)
        //        {
        //            labelResult.Text = "Suma este mai mare de 30.";
        //        }
        //        else if(sum == 30)
        //        {
        //            labelResult.Text = "Suma este egala 30.";

        //        }
        //    }
        //    else
        //    {
        //        labelResult.Text = "Introduceti o suma valida.";
        //    }
        //}

    }
    
}
