using Knjiznica.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Knjiznica.Forme
{
    public partial class Glavna : Form
    {
        public Glavna()
        {
            InitializeComponent();
        }

        public IKontekst Kontekst;

        private void PrikaziPosudbe()
        {
            Forme.Pomocna.PrikaziListuUListBoxu<Posudba>(
                this.Kontekst.Posudbe, lbPosudbe);
        }

        private void Glavna_Load(object sender, EventArgs e)
        {
            try
            {
                Factory f = new Factory();
                this.Kontekst = f.DohvatiKontekst(TipKonteksta.CsvKontekst);
                PrikaziPosudbe();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnUcenici_Click(object sender, EventArgs e)
        {
        }

        private void btnKnjige_Click(object sender, EventArgs e)
        {
        }

        private void btnPosudi_Click(object sender, EventArgs e)
        {
            PDetalji frmPDetalji = new PDetalji(this.Kontekst);

            if (frmPDetalji.ShowDialog() == DialogResult.OK)
            {
                this.Kontekst.DodajPosudbu(frmPDetalji.P);
                PrikaziPosudbe();
            }
        }

        private void btnIzmijeni_Click(object sender, EventArgs e)
        {
            if (lbPosudbe.SelectedIndex < 0)
            {
                MessageBox.Show("Niste odabrali posudbu!");
            }
            else
            {
                PDetalji frmPDetalji = new PDetalji(this.Kontekst);

                frmPDetalji.P = (Posudba)lbPosudbe.SelectedItem;

                if (frmPDetalji.ShowDialog() == DialogResult.OK)
                {
                    this.Kontekst.SpremiPosudbe();
                    PrikaziPosudbe();
                }
            }
        }

        private void btnVrati_Click(object sender, EventArgs e)
        {
            if (lbPosudbe.SelectedIndex < 0)
            {
                MessageBox.Show("Niste odabrali posudbu!");
            }
            else
            {
                this.Kontekst.BrisiPosudbu((Posudba)lbPosudbe.SelectedItem);
                PrikaziPosudbe();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Ucenici frmUcenici = new Ucenici(this.Kontekst);
            frmUcenici.ShowDialog();
        }

        private void toolStripBtnKnjige_Click(object sender, EventArgs e)
        {
            Knjige frmKnjige = new Knjige(this.Kontekst);
            frmKnjige.ShowDialog();
        }

        private void poDatumuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Posudba.Usporedba = new UsporedbaPoDatumu();
            PrikaziPosudbe();
        }

        private void poUčenikuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Posudba.Usporedba = new UsporedbaPoUceniku();
            PrikaziPosudbe();
        }

        private void poKnjiziToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Posudba.Usporedba = new UsporedbaPoKnjizi();
            PrikaziPosudbe();
        }
    }
}
