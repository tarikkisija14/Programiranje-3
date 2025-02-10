using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IB230005
{
    public class StudentiPorukeIB230005
    {
        public int Id {  get; set; }
        public int StudentId {  get; set; }
        public Student Student { get; set; }
        public int PredmetId {  get; set; }
        public PredmetiIB230005 Predmet { get; set; }
        public DateTime Validnost {  get; set; }
        public string Sadrzaj {  get; set; }
        public byte[] Slika { get; set; }

       
    }
}
