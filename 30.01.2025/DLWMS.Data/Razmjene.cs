using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data
{
    public class Razmjene
    {
		public int Id {  get; set; }
		public int StudentId {  get; set; }
		public Student Student { get; set; }
		public int UniverzitetId {  get; set; }
		public Univerziteti Univerzitet { get; set; }
		public string Pocetak {  get; set; }
		public string Kraj {  get; set; }
		public int ECTS {  get; set; }
		public bool Okoncana {  get; set; }
    }
}
