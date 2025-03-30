using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knjiznica.Model
{
    public interface IStrategy
    {
        int Usporedi(Posudba p1, Posudba p2);
    }
    public class UsporedbaPoDatumu : IStrategy
    {
        public int Usporedi(Posudba p1, Posudba p2)
        {
            return p1.DatumPosudbe.CompareTo(p2.DatumPosudbe);
        }
    }
    
    public class UsporedbaPoUceniku : IStrategy
    {
        public int Usporedi(Posudba p1, Posudba p2)
        {
            return p1.Ucenik.CompareTo(p2.Ucenik);
        }
    }
    public class UsporedbaPoKnjizi : IStrategy
    {
        public int Usporedi(Posudba p1, Posudba p2)
        {
            return p1.Knjiga.CompareTo(p2.Knjiga);
        }
    }
}
