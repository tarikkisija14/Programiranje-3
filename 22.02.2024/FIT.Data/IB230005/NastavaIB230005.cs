using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IB230005
{
    public class NastavaIB230005
    {
        public int Id {  get; set; }
        public int ProstorijaId {  get; set; }
        public ProstorijeIB230005 Prostorija { get; set; }  
        public int PredmetId {  get; set; }
        public PredmetiIB230005 Predmet {  get; set; }  
        public string Vrijeme {  get; set; }
        public string DanOdrzavanja {  get; set; }
        public string Oznaka {  get; set; }
    }
}
