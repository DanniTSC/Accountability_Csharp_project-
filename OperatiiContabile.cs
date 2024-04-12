using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROIECT_PAW
{
    public class OperatiiContabile 
    {
        private ContContabilitate listaCredit;//lista 
        private ContContabilitate listaDebit;//lista
        //FIX T 
        //sume ca n T 
        //emulare de T 
        //metoda pentru calculare 
        //DATA !!
        //T si sa adauga sau sa editez, adaugare operatie
        //totaluri
        private float soldInitial;
        private float soldFinal;//far astea 
  
        public OperatiiContabile(ContContabilitate credit, ContContabilitate debit, float SoldInitial, float SoldFinal)
        {
            listaCredit = credit;
            listaDebit = debit;
            soldInitial = SoldInitial;
            soldFinal = SoldFinal;
        }

        public ContContabilitate ContCredit
        {
            get { return listaCredit; }
            set
            {
                listaCredit = value;
            }
        }


            public ContContabilitate ContDebit
        {
            get { return listaDebit; }
            set { listaDebit = value;}
        }

        public float SoldInitial
        {
            get { return SoldInitial; }
               set { SoldInitial = value;}
        }

        public float SoldFinal
        {
            get { return SoldFinal; }
            set { SoldFinal = value;}
        }
    }//END OF CLASS
}
