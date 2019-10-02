using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_SYSTEM
{
    class Transact
    {
        public static double Total { get; set; }
        public static double Cash { get; set; }
        public static double Change { get; set; }
        public static double VATable { get; set; }
        public static double VatAmt { get; set; }
        public static double ComputeVATable()
        {
            return Total / 1.12;
        }
        public static double ComputeVATAmt()
        {
            return Total * 0.12;
        }
        public static double ComputeChange()
        {
            return Cash - Total;
        }
    
    }
}
