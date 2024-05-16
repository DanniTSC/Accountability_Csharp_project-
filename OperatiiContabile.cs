using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROIECT_PAW
{
    public class OperatiiContabile 
    {
        private DateTime dataOpCont;//data realizarii tranzactiei in acel cont
        private int operatiuneId;
        private double sumaFinala;

      
  
        public OperatiiContabile()
        {
           
            
        }

        public double SumaFinala
        {
            get { return this.sumaFinala; }
            set { this.sumaFinala = value;}
        }

        public int OperatiuneId
        {
            get { return this.operatiuneId; }
            set { this.operatiuneId = value; }
        }
        public DateTime DataOpCont
        {
            get { return dataOpCont; }
            set { dataOpCont = value; }
        }

    }//END OF CLASS
}
