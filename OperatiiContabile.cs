﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROIECT_PAW
{
    public class OperatiiContabile 
    {
        private DateTime dataOpCont;//data realizarii tranzactiei in acel cont
  
      
  
        public OperatiiContabile()
        {
           
            
        }
        public DateTime DataOpCont
        {
            get { return dataOpCont; }
            set { dataOpCont = value; }
        }

    }//END OF CLASS
}