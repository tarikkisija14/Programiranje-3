﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data
{
    public class Univerziteti
    {
      public int Id {  get; set; }
        public string Naziv { get; set; }
        public int DrzavaId {  get; set; }
        public Drzava Drzava { get; set; }
        public override string ToString()
        {
            return Naziv;
        }

    }
}
