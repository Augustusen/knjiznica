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
    public partial class Knjige : Form
    {
        public Knjige(IKontekst kontekst)
        {
            InitializeComponent();
            this.kontekst = kontekst;
        }

        private IKontekst kontekst;
        private void PrikaziKnjige()
        {
            Forme.Pomocna.PrikaziListuUListBoxu<Knjiga>(
                this.kontekst.Knjige, lbKnjige);
        }

        private void Knjige_Load(object sender, EventArgs e)
        {
            PrikaziKnjige();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            KDetalji frmKDetalji = new KDetalji();
            if (frmKDetalji.ShowDialog() == DialogResult.OK)
            {
                this.kontekst.DodajKnjigu(frmKDetalji.K);
                PrikaziKnjige();
            }
        }
        private void btnUredi_Click(object sender, EventArgs e)
        {
            if (lbKnjige.SelectedIndex < 0)
            {
                MessageBox.Show("Niste odabrali knjigu!");
            }
            else
            {
                KDetalji frmKDetalji = new KDetalji();
                frmKDetalji.K = (Knjiga)lbKnjige.SelectedItem;
                if (frmKDetalji.ShowDialog() == DialogResult.OK)
                {
                    this.kontekst.SpremiKnjige();
                    PrikaziKnjige();
                }
            }
        }
        private void btnBrisi_Click(object sender, EventArgs e)
        {
            if (lbKnjige.SelectedIndex < 0)
            {
                MessageBox.Show("Niste odabrali knjigu!");
            }
            else
            {
                this.kontekst.BrisiKnjigu((Knjiga)lbKnjige.SelectedItem);
                PrikaziKnjige();
            }
        }
    }
}
