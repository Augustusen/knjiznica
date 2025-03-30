using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knjiznica.Model
{
    public interface IKontekst
    {
        List<Ucenik> Ucenici { get; }
        List<Knjiga> Knjige { get; }
        List<Posudba> Posudbe {  get; }

        void DodajUcenika(Ucenik u);
        void DodajKnjigu(Knjiga k);
        void DodajPosudbu(Posudba p);

        void BrisiUcenika(Ucenik u);
        void BrisiKnjigu(Knjiga k);
        void BrisiPosudbu(Posudba p);

        void SpremiUcenike();
        void SpremiKnjige();
        void SpremiPosudbe();
    }
}
