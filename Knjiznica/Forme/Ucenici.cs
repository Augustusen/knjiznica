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
    public partial class Ucenici : Form
    {
        public Ucenici(IKontekst kontekst)
        {
            InitializeComponent();
            this.kontekst = kontekst;
        }

        private IKontekst kontekst;
        private void PrikaziUcenike()
        {
            Forme.Pomocna.PrikaziListuUListBoxu<Ucenik>(
                this.kontekst.Ucenici, lbUcenici);
        }

        private void Ucenici_Load(object sender, EventArgs e)
        {
            PrikaziUcenike();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            UDetalji frmUDetalji = new UDetalji();
            if (frmUDetalji.ShowDialog() == DialogResult.OK)
            {
                this.kontekst.DodajUcenika(frmUDetalji.U);
                PrikaziUcenike();
            }
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            if (lbUcenici.SelectedIndex < 0)
            {
                MessageBox.Show("Niste odabrali učenika!");
            }
            else
            {
                UDetalji frmUDetalji = new UDetalji();
                frmUDetalji.U = (Ucenik)lbUcenici.SelectedItem;
                if (frmUDetalji.ShowDialog() == DialogResult.OK)
                {
                    this.kontekst.SpremiUcenike();
                    PrikaziUcenike();
                }
            }
        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            if (lbUcenici.SelectedIndex < 0)
            {
                MessageBox.Show("Niste odabrali učenika!");
            }
            else
            {
                this.kontekst.BrisiUcenika((Ucenik)lbUcenici.SelectedItem);
                PrikaziUcenike();
            }
        }
    }
}
