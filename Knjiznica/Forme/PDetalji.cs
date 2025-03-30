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
    public partial class PDetalji : Form
    {
        public PDetalji(IKontekst kontekst)
        {
            InitializeComponent();
            this.kontekst = kontekst;
        }

        public Posudba P;

        private IKontekst kontekst;

        private void PrikaziUcenike()
        {
            Forme.Pomocna.PrikaziListuUListBoxu<Ucenik>(
                this.kontekst.Ucenici, lbUcenici);
        }

        private void PrikaziKnjige()
        {
            Forme.Pomocna.PrikaziListuUListBoxu<Knjiga>(
                this.kontekst.Knjige, lbKnjige);
        }

        private void PDetalji_Load(object sender, EventArgs e)
        {
            PrikaziUcenike();
            PrikaziKnjige();

            if (this.P != null)
            {
                lbUcenici.SelectedItem = this.P.Ucenik;
                lbKnjige.SelectedItem = this.P.Knjiga;
                dtpDatumPosudbe.Value = this.P.DatumPosudbe;
                nudBrojDana.Value = this.P.BrojDana;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (lbUcenici.SelectedIndex < 0 || lbKnjige.SelectedIndex < 0)
            {
                MessageBox.Show("Učenika i knjigu morate odabrati!");
                this.DialogResult = DialogResult.None;
            }
            else
            {
                if (this.P == null)
                {
                    this.P = new Posudba();
                }
                this.P.Ucenik = (Ucenik)lbUcenici.SelectedItem;
                this.P.Knjiga = (Knjiga)lbKnjige.SelectedItem;
                this.P.DatumPosudbe = dtpDatumPosudbe.Value;
                this.P.BrojDana = (int)nudBrojDana.Value;
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
