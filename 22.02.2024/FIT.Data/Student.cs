﻿using FIT.Data.IB230005;
using System.Drawing;

namespace FIT.Data
{
    public class Student
    {
        public int Id { get; set; }
        public string Indeks { get; set; }
        public string Lozinka { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public byte[] Slika { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public bool Aktivan { get; set; }        
        public int SemestarId { get; set; }
        public SemestriIB230005 Semestar {  get; set; }

        public string ImePrezime => $"{Indeks} {Ime} {Prezime}";



        public override string ToString()
        {
            return ImePrezime;
        }
    }
}
