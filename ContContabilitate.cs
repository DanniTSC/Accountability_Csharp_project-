using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROIECT_PAW
{
    [Serializable]
    public class ContContabilitate
    {
        public enum TipContContabilitate { Activ, Pasiv};
        private int contId;//371
        private string numeCont;//marfuri
        private TipContContabilitate tipCont;//ori debit ori credit 


        public ContContabilitate() { }
        public ContContabilitate(int ContId, string NumeCont, TipContContabilitate TipCont)
        {
            contId = ContId;
            numeCont = NumeCont;
            tipCont = TipCont;
           
        }

        public int ContId
        {  
            get { return contId; } 
            set { contId = value; }
        }

        public string NumeCont
        {
            get { return numeCont; }
            set { numeCont = value; }
        }

        public TipContContabilitate TipCont
        {
            get { return tipCont; }
            set {  tipCont = value; }
        }

    
     } //END OF CLASS
}
