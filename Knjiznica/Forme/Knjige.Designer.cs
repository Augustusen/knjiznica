namespace Knjiznica.Forme
{
    partial class Knjige
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
            btnBrisi = new Button();
            btnUredi = new Button();
            btnDodaj = new Button();
            label1 = new Label();
            lbKnjige = new ListBox();
            SuspendLayout();
            // 
            // btnBrisi
            // 
            btnBrisi.Location = new Point(688, 115);
            btnBrisi.Name = "btnBrisi";
            btnBrisi.Size = new Size(94, 29);
            btnBrisi.TabIndex = 9;
            btnBrisi.Text = "Briši";
            btnBrisi.UseVisualStyleBackColor = true;
            btnBrisi.Click += btnBrisi_Click;
            // 
            // btnUredi
            // 
            btnUredi.Location = new Point(688, 80);
            btnUredi.Name = "btnUredi";
            btnUredi.Size = new Size(94, 29);
            btnUredi.TabIndex = 8;
            btnUredi.Text = "Uredi";
            btnUredi.UseVisualStyleBackColor = true;
            btnUredi.Click += btnUredi_Click;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(688, 45);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(94, 29);
            btnDodaj.TabIndex = 7;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 22);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 6;
            label1.Text = "Knjige";
            // 
            // lbKnjige
            // 
            lbKnjige.FormattingEnabled = true;
            lbKnjige.Location = new Point(18, 45);
            lbKnjige.Name = "lbKnjige";
            lbKnjige.Size = new Size(638, 384);
            lbKnjige.TabIndex = 5;
            // 
            // Knjige
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBrisi);
            Controls.Add(btnUredi);
            Controls.Add(btnDodaj);
            Controls.Add(label1);
            Controls.Add(lbKnjige);
            Name = "Knjige";
            Text = "Knjige";
            Load += Knjige_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBrisi;
        private Button btnUredi;
        private Button btnDodaj;
        private Label label1;
        private ListBox lbKnjige;
    }
}