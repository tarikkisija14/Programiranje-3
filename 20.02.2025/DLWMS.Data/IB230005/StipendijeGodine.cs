﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IB230005
{
    public class StipendijeGodine
    {
        public int Id {  get; set; }
        public int StipendijaId {  get; set; }
        public Stipendije Stipendija { get; set; }
        public int Iznos {  get; set; }
        public int Godina {  get; set; }
        public bool Aktivna {  get; set; }
        public override string ToString()
        {
            return Stipendija.Naziv!;
        }
    }
}
