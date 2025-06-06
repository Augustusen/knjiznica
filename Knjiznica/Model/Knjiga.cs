﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knjiznica.Model
{
    public partial class Knjiga : IComparable
    {
        public string ISBN {  get; set; }
        public string Autor { get; set; }
        public string Naslov {  get; set; }
        public int GodinaIzdanja { get; set; }
        public int BrojPrimjeraka { get; set; }
        public override string ToString()
        {
            return this.Autor + ": " + this.Naslov;
        }
        public int CompareTo(object obj)
        {
            int rez = this.Autor.CompareTo(((Knjiga)obj).Autor);
            if (rez == 0)
            {
                rez = this.Naslov.CompareTo(((Knjiga)obj).Naslov);
            }
            return rez;
        }
    }
}
