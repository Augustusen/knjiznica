namespace Knjiznica.Forme
{
    partial class UDetalji
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
            label1 = new Label();
            txtIme = new TextBox();
            txtOIB = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtPrezime = new TextBox();
            txtAdresa = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtTelefon = new TextBox();
            label6 = new Label();
            cbRazred = new ComboBox();
            btnOK = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 23);
            label1.Name = "label1";
            label1.Size = new Size(33, 20);
            label1.TabIndex = 0;
            label1.Text = "OIB";
            // 
            // txtIme
            // 
            txtIme.Location = new Point(124, 73);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(652, 27);
            txtIme.TabIndex = 1;
            // 
            // txtOIB
            // 
            txtOIB.Location = new Point(124, 23);
            txtOIB.Name = "txtOIB";
            txtOIB.Size = new Size(652, 27);
            txtOIB.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 73);
            label2.Name = "label2";
            label2.Size = new Size(34, 20);
            label2.TabIndex = 3;
            label2.Text = "Ime";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 121);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 7;
            label3.Text = "Prezime";
            // 
            // txtPrezime
            // 
            txtPrezime.Location = new Point(124, 121);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(652, 27);
            txtPrezime.TabIndex = 6;
            // 
            // txtAdresa
            // 
            txtAdresa.Location = new Point(124, 176);
            txtAdresa.Name = "txtAdresa";
            txtAdresa.Size = new Size(652, 27);
            txtAdresa.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 176);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 4;
            label4.Text = "Adresa";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 235);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 9;
            label5.Text = "Telefon";
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(124, 235);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(652, 27);
            txtTelefon.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 289);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 10;
            label6.Text = "Razred";
            // 
            // cbRazred
            // 
            cbRazred.FormattingEnabled = true;
            cbRazred.Location = new Point(124, 289);
            cbRazred.Name = "cbRazred";
            cbRazred.Size = new Size(237, 28);
            cbRazred.TabIndex = 11;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(682, 289);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(94, 29);
            btnOK.TabIndex = 12;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // UDetalji
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOK);
            Controls.Add(cbRazred);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtTelefon);
            Controls.Add(label3);
            Controls.Add(txtPrezime);
            Controls.Add(txtAdresa);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(txtOIB);
            Controls.Add(txtIme);
            Controls.Add(label1);
            Name = "UDetalji";
            Text = "UDetalji";
            Load += UDetalji_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIme;
        private TextBox txtOIB;
        private Label label2;
        private Label label3;
        private TextBox txtPrezime;
        private TextBox txtAdresa;
        private Label label4;
        private Label label5;
        private TextBox txtTelefon;
        private Label label6;
        private ComboBox cbRazred;
        private Button btnOK;
    }
}