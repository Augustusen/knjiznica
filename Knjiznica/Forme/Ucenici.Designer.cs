namespace Knjiznica.Forme
{
    partial class Ucenici
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
            lbUcenici = new ListBox();
            label1 = new Label();
            btnDodaj = new Button();
            btnUredi = new Button();
            btnBrisi = new Button();
            SuspendLayout();
            // 
            // lbUcenici
            // 
            lbUcenici.FormattingEnabled = true;
            lbUcenici.Location = new Point(12, 40);
            lbUcenici.Name = "lbUcenici";
            lbUcenici.Size = new Size(638, 384);
            lbUcenici.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 1;
            label1.Text = "Učenici";
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(682, 40);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(94, 29);
            btnDodaj.TabIndex = 2;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // btnUredi
            // 
            btnUredi.Location = new Point(682, 75);
            btnUredi.Name = "btnUredi";
            btnUredi.Size = new Size(94, 29);
            btnUredi.TabIndex = 3;
            btnUredi.Text = "Uredi";
            btnUredi.UseVisualStyleBackColor = true;
            btnUredi.Click += btnUredi_Click;
            // 
            // btnBrisi
            // 
            btnBrisi.Location = new Point(682, 110);
            btnBrisi.Name = "btnBrisi";
            btnBrisi.Size = new Size(94, 29);
            btnBrisi.TabIndex = 4;
            btnBrisi.Text = "Briši";
            btnBrisi.UseVisualStyleBackColor = true;
            btnBrisi.Click += btnBrisi_Click;
            // 
            // Ucenici
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBrisi);
            Controls.Add(btnUredi);
            Controls.Add(btnDodaj);
            Controls.Add(label1);
            Controls.Add(lbUcenici);
            Name = "Ucenici";
            Text = "Ucenici";
            Load += Ucenici_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbUcenici;
        private Label label1;
        private Button btnDodaj;
        private Button btnUredi;
        private Button btnBrisi;
    }
}