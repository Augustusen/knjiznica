using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knjiznica.Model
{
    public class Factory
    {
        public IKontekst DohvatiKontekst(TipKonteksta tipKonteksta)
        {
            if (tipKonteksta == TipKonteksta.CsvKontekst)
            {
                return new CsvPodatkovniKontekst();
            }
            else 
            {
                return new PodatkovniKontekst();
            }
        }
    }
    public enum TipKonteksta
    {
        TxtKontekst,
        CsvKontekst,
        EFKontekst
    }
}
