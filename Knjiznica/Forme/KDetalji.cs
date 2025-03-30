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
    public partial class KDetalji : Form
    {
        public KDetalji()
        {
            InitializeComponent();
        }

        public Knjiga K;

        private void KDetalji_Load(object sender, EventArgs e)
        {
            nudGodinaIzdanja.Maximum = DateTime.Now.Year;
            nudGodinaIzdanja.Value = DateTime.Now.Year;

            if (this.K != null)
            {
                txtISBN.Text = this.K.ISBN;
                txtAutor.Text = this.K.Autor;
                txtNaslov.Text = this.K.Naslov;
                nudGodinaIzdanja.Value = (decimal)this.K.GodinaIzdanja;
                cbBrojPrimjeraka.Text = this.K.BrojPrimjeraka.ToString();
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtISBN.Text == "" || txtAutor.Text == "" || txtNaslov.Text == "" || cbBrojPrimjeraka.Text == "")
            {
                MessageBox.Show("Sve podatke morate unijeti!");
                this.DialogResult = DialogResult.None;
            }
            else
            {
                if (this.K == null)
                {
                    this.K = new Knjiga();
                }
                    this.K.ISBN = txtISBN.Text;
                    this.K.Autor = txtAutor.Text;
                    this.K.Naslov = txtNaslov.Text;
                    this.K.GodinaIzdanja = (int)nudGodinaIzdanja.Value;
                    this.K.BrojPrimjeraka = int.Parse(cbBrojPrimjeraka.Text);
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
