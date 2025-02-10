using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IB230005
{
    public class PrisustvoIB230005
    {
        public int Id {  get; set; }
        public int NastavaId {  get; set; }
        public NastavaIB230005 Nastava { get; set; }
        public int StudentId {  get; set; }
        public Student Student { get; set; }
    }
}
