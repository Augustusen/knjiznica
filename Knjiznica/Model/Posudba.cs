using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knjiznica.Model
{
    public partial class Posudba : IComparable
    {
        public Ucenik Ucenik { get; set; }
        public Knjiga Knjiga { get; set; }
        public DateTime DatumPosudbe { get; set; }
        public int BrojDana { get; set; }
        public DateTime DatumVracanja
        {
            get
            {
                return this.DatumPosudbe.AddDays(this.BrojDana);
            }
        }
        public override string ToString()
        {
            return this.DatumPosudbe.ToShortDateString()
                + " - " + this.DatumVracanja.ToShortDateString()
                + ": " + this.Knjiga.ToString()
                + " -> " + this.Ucenik.ToString();
        }
        public int CompareTo(object obj)
        {
            return Posudba.Usporedba.Usporedi(this, (Posudba)obj);
        }

        public static IStrategy Usporedba = new UsporedbaPoDatumu();
    }
}
