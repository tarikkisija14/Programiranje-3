using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DLWMS.Data.IB230005
{
    public class Stipendije
    {
        public int Id { get; set; }
        public string Naziv {  get; set; }
        public override string ToString()
        {
            return Naziv;
        }

    }
   

}
