using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IB230005
{
    public class DrzaveIB230005
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public byte[] Zastava { get; set; }
        public bool Status { get; set; }
        public override string ToString()
        {
            return Naziv;
        }
    }

}
