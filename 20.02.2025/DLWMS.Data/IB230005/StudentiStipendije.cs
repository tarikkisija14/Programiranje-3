using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IB230005
{
    public class StudentiStipendije
    {
        public int Id { get; set; }
        public int StudentId {  get; set; }
        public Student Student { get; set; }
        public int StipendijaId {  get; set; }
        public Stipendije Stipendija { get; set;}
    }
}
