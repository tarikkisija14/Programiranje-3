using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IB230005
{
    public class PredmetiIB230005
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public int SemestarId {  get; set; }
        public SemestriIB230005 Semestar { get; set; }
    }
}
