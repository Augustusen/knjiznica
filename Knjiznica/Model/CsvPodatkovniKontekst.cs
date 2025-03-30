using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knjiznica.Model
{
    class CsvPodatkovniKontekst : IKontekst
    {
        private List<Ucenik> _ucenici;
        private List<Knjiga> _knjige;
        private List<Posudba> _posudbe;

        public List<Ucenik> Ucenici { get { return this._ucenici; } }
        public List<Knjiga> Knjige { get { return this._knjige; } }
        public List<Posudba> Posudbe { get { return this._posudbe; } }

        public CsvPodatkovniKontekst()
        {
            this._ucenici = UcitajUcenike();
            this._knjige = UcitajKnjige();
            this._posudbe = UcitajPosudbe();
        }

        private string datUcenici = "ucenici.csv";
        private string datKnjige = "knjige.csv";
        private string datPosudbe = "posudbe.csv";

        private List<Ucenik> UcitajUcenike()
        {
            List<Ucenik> ucenici = new List<Ucenik>();

            if (File.Exists(datUcenici))
            {
                using (StreamReader sr = new StreamReader(datUcenici))
                {
                    while (!sr.EndOfStream)
                    {
                        string linija = sr.ReadLine();
                        string[] polja = linija.Split(';');

                        Ucenik u = new Ucenik();
                        u.OIB = polja[0];
                        u.Ime = polja[1];
                        u.Prezime = polja[2];
                        u.Adresa = polja[3];
                        u.Telefon = polja[4];
                        u.Razred = int.Parse(polja[5]);

                        ucenici.Add(u);
                    }
                }
            }
            return ucenici;
        }
        private List<Knjiga> UcitajKnjige()
        {
            List<Knjiga> knjige = new List<Knjiga>();

            if (File.Exists(datKnjige))
            {
                using (StreamReader sr = new StreamReader(datKnjige))
                {
                    while (!sr.EndOfStream)
                    {
                        string linija = sr.ReadLine();
                        string[] polja = linija.Split(';');

                        Knjiga k = new Knjiga();
                        k.ISBN = polja[0];
                        k.Autor = polja[1];
                        k.Naslov = polja[2];
                        k.GodinaIzdanja = int.Parse(polja[3]);
                        k.BrojPrimjeraka = int.Parse(polja[4]);

                        knjige.Add(k);
                    }
                }
            }
            return knjige;
        }
        private List<Posudba> UcitajPosudbe()
        {
            List<Posudba> posudbe = new List<Posudba>();

            if (File.Exists(datPosudbe))
            {
                using (StreamReader sr = new StreamReader(datPosudbe))
                {
                    while (!sr.EndOfStream)
                    {
                        string linija = sr.ReadLine();
                        string[] polja = linija.Split(';');

                        Posudba p = new Posudba();

                        p.Ucenik = this.Ucenici.Find(delegate (Ucenik u)
                        {
                            return u.OIB == polja[0];
                        });

                        p.Knjiga = this.Knjige.Find(delegate (Knjiga k)
                        {
                            return k.ISBN == polja[1];
                        });

                        p.DatumPosudbe = DateTime.Parse(polja[2]);
                        p.BrojDana = int.Parse(polja[3]);

                        posudbe.Add(p);
                    }
                }
            }
            return posudbe;
        }
        public void SpremiUcenike()
        {
            using (StreamWriter sw = new StreamWriter(datUcenici))
            {
                foreach (Ucenik u in this.Ucenici)
                {
                    sw.WriteLine("{0};{1};{2};{3};{4};{5}",
                        u.OIB, u.Ime, u.Prezime, u.Adresa, u.Telefon, u.Razred);
                }
            }
        }
        public void SpremiKnjige()
        {
            using (StreamWriter sw = new StreamWriter(datKnjige))
            {
                foreach (Knjiga k in this.Knjige)
                {
                    sw.WriteLine("{0};{1};{2};{3};{4}",
                        k.ISBN, k.Autor, k.Naslov, k.GodinaIzdanja, k.BrojPrimjeraka);
                }
            }
        }
        public void SpremiPosudbe()
        {
            using (StreamWriter sw = new StreamWriter(datPosudbe))
            {
                foreach (Posudba p in this.Posudbe)
                {
                    sw.WriteLine("{0};{1};{2};{3}",
                        p.Ucenik.OIB, p.Knjiga.ISBN, p.DatumPosudbe.ToShortDateString(), p.BrojDana);
                }
            }
        }
        public void DodajUcenika(Ucenik u)
        {
            this.Ucenici.Add(u);
            SpremiUcenike();
        }
        public void BrisiUcenika(Ucenik u)
        {
            this.Ucenici.Remove(u);
            SpremiUcenike();
        }
        public void DodajKnjigu(Knjiga k)
        {
            this.Knjige.Add(k);
            SpremiKnjige();
        }
        public void BrisiKnjigu(Knjiga k)
        {
            this.Knjige.Remove(k);
            SpremiKnjige();
        }
        public void DodajPosudbu(Posudba p)
        {
            this.Posudbe.Add(p);
            SpremiPosudbe();
        }
        public void BrisiPosudbu(Posudba p)
        {
            this.Posudbe.Remove(p);
            SpremiPosudbe();
        }
    }
}
