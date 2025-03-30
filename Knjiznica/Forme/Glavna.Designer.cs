namespace Knjiznica.Forme
{
    partial class Glavna
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Glavna));
            btnVrati = new Button();
            btnIzmijeni = new Button();
            btnPosudi = new Button();
            label1 = new Label();
            lbPosudbe = new ListBox();
            toolStrip1 = new ToolStrip();
            toolStripBtnUcenici = new ToolStripButton();
            toolStripBtnKnjige = new ToolStripButton();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            poDatumuToolStripMenuItem = new ToolStripMenuItem();
            poUčenikuToolStripMenuItem = new ToolStripMenuItem();
            poKnjiziToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnVrati
            // 
            btnVrati.Location = new Point(681, 147);
            btnVrati.Name = "btnVrati";
            btnVrati.Size = new Size(94, 29);
            btnVrati.TabIndex = 11;
            btnVrati.Text = "Vrati";
            btnVrati.UseVisualStyleBackColor = true;
            btnVrati.Click += btnVrati_Click;
            // 
            // btnIzmijeni
            // 
            btnIzmijeni.Location = new Point(681, 112);
            btnIzmijeni.Name = "btnIzmijeni";
            btnIzmijeni.Size = new Size(94, 29);
            btnIzmijeni.TabIndex = 10;
            btnIzmijeni.Text = "Izmijeni";
            btnIzmijeni.UseVisualStyleBackColor = true;
            btnIzmijeni.Click += btnIzmijeni_Click;
            // 
            // btnPosudi
            // 
            btnPosudi.Location = new Point(681, 77);
            btnPosudi.Name = "btnPosudi";
            btnPosudi.Size = new Size(94, 29);
            btnPosudi.TabIndex = 9;
            btnPosudi.Text = "Posudi";
            btnPosudi.UseVisualStyleBackColor = true;
            btnPosudi.Click += btnPosudi_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 40);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 8;
            label1.Text = "Posuđene knjige";
            // 
            // lbPosudbe
            // 
            lbPosudbe.FormattingEnabled = true;
            lbPosudbe.Location = new Point(25, 63);
            lbPosudbe.Name = "lbPosudbe";
            lbPosudbe.Size = new Size(617, 364);
            lbPosudbe.TabIndex = 7;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = SystemColors.ActiveCaption;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripBtnUcenici, toolStripBtnKnjige, toolStripDropDownButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RightToLeft = RightToLeft.Yes;
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 14;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripBtnUcenici
            // 
            toolStripBtnUcenici.Alignment = ToolStripItemAlignment.Right;
            toolStripBtnUcenici.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripBtnUcenici.Image = (Image)resources.GetObject("toolStripBtnUcenici.Image");
            toolStripBtnUcenici.ImageTransparentColor = Color.Magenta;
            toolStripBtnUcenici.Margin = new Padding(10, 1, 10, 2);
            toolStripBtnUcenici.Name = "toolStripBtnUcenici";
            toolStripBtnUcenici.Size = new Size(61, 24);
            toolStripBtnUcenici.Text = "Učenici";
            toolStripBtnUcenici.Click += toolStripButton1_Click;
            // 
            // toolStripBtnKnjige
            // 
            toolStripBtnKnjige.Alignment = ToolStripItemAlignment.Right;
            toolStripBtnKnjige.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripBtnKnjige.Image = (Image)resources.GetObject("toolStripBtnKnjige.Image");
            toolStripBtnKnjige.ImageTransparentColor = Color.Magenta;
            toolStripBtnKnjige.Margin = new Padding(10, 1, 10, 2);
            toolStripBtnKnjige.Name = "toolStripBtnKnjige";
            toolStripBtnKnjige.Size = new Size(55, 24);
            toolStripBtnKnjige.Text = "Knjige";
            toolStripBtnKnjige.Click += toolStripBtnKnjige_Click;
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.Alignment = ToolStripItemAlignment.Right;
            toolStripDropDownButton1.AutoSize = false;
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { poDatumuToolStripMenuItem, poUčenikuToolStripMenuItem, poKnjiziToolStripMenuItem });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Margin = new Padding(10, 1, 10, 2);
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.RightToLeft = RightToLeft.No;
            toolStripDropDownButton1.Size = new Size(96, 24);
            toolStripDropDownButton1.Text = "Usporedba";
            // 
            // poDatumuToolStripMenuItem
            // 
            poDatumuToolStripMenuItem.Name = "poDatumuToolStripMenuItem";
            poDatumuToolStripMenuItem.Size = new Size(224, 26);
            poDatumuToolStripMenuItem.Text = "Po datumu";
            poDatumuToolStripMenuItem.Click += poDatumuToolStripMenuItem_Click;
            // 
            // poUčenikuToolStripMenuItem
            // 
            poUčenikuToolStripMenuItem.Name = "poUčenikuToolStripMenuItem";
            poUčenikuToolStripMenuItem.Size = new Size(224, 26);
            poUčenikuToolStripMenuItem.Text = "Po učeniku";
            poUčenikuToolStripMenuItem.Click += poUčenikuToolStripMenuItem_Click;
            // 
            // poKnjiziToolStripMenuItem
            // 
            poKnjiziToolStripMenuItem.Name = "poKnjiziToolStripMenuItem";
            poKnjiziToolStripMenuItem.Size = new Size(224, 26);
            poKnjiziToolStripMenuItem.Text = "Po knjizi";
            poKnjiziToolStripMenuItem.Click += poKnjiziToolStripMenuItem_Click;
            // 
            // Glavna
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(btnVrati);
            Controls.Add(btnIzmijeni);
            Controls.Add(btnPosudi);
            Controls.Add(label1);
            Controls.Add(lbPosudbe);
            Name = "Glavna";
            Text = "Glavnacs";
            Load += Glavna_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnVrati;
        private Button btnIzmijeni;
        private Button btnPosudi;
        private Label label1;
        private ListBox lbPosudbe;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem poDatumuToolStripMenuItem;
        private ToolStripMenuItem poUčenikuToolStripMenuItem;
        private ToolStripMenuItem poKnjiziToolStripMenuItem;
        private ToolStripButton toolStripBtnUcenici;
        private ToolStripButton toolStripBtnKnjige;
    }
}