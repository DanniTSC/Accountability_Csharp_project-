using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROIECT_PAW
{
    public class ContContabilitate
    {
        private int ContId;
        private string NumeCont;
        private string TipCont;
    
        public ContContabilitate(int contId, string numeCont, string tipCont)
        {
            ContId = contId;
            NumeCont = numeCont;
            TipCont = tipCont;
        }

        public int ID
        {  get { return ContId; } 
            set { ContId = value; }
        }

        public string Nume
        {
            get { return NumeCont; }
            set { NumeCont = value; }
        }

        public string Tip
        {
            get { return TipCont; }
            set {  TipCont = value; }
        }

    } //END OF CLASS
}
