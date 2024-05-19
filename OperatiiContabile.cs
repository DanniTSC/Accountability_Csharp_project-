using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROIECT_PAW
{
    [Serializable]

    public class OperatiiContabile 
    {
        private DateTime dataOpCont;//data realizarii tranzactiei in acel cont
        private int operatiuneId;
        private double sumaFinala;
        private ContContabilitate contOperatie;
      
  
        public OperatiiContabile()
        {
           
            
        }

        public OperatiiContabile(DateTime dataOpCont, int operatiuneId, double sumaFinala, ContContabilitate contOperatie)
        {
            DataOpCont = dataOpCont;
            OperatiuneId = operatiuneId;
            SumaFinala = sumaFinala;
            this.contOperatie = contOperatie;
        }

        public ContContabilitate ContOperatie
        {
            get { return contOperatie; }
            set { this.contOperatie = value; }
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
