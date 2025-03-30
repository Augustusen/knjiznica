namespace Knjiznica.Forme
{
    partial class KDetalji
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtISBN = new TextBox();
            txtAutor = new TextBox();
            txtNaslov = new TextBox();
            cbBrojPrimjeraka = new ComboBox();
            btnOK = new Button();
            nudGodinaIzdanja = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudGodinaIzdanja).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 32);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 0;
            label1.Text = "ISBN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 92);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 1;
            label2.Text = "Autor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 156);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 2;
            label3.Text = "Naslov";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 218);
            label4.Name = "label4";
            label4.Size = new Size(109, 20);
            label4.TabIndex = 3;
            label4.Text = "Godina izdanja";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 279);
            label5.Name = "label5";
            label5.Size = new Size(111, 20);
            label5.TabIndex = 4;
            label5.Text = "Broj primjeraka";
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(192, 32);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(565, 27);
            txtISBN.TabIndex = 5;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(192, 92);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(565, 27);
            txtAutor.TabIndex = 6;
            // 
            // txtNaslov
            // 
            txtNaslov.Location = new Point(192, 156);
            txtNaslov.Name = "txtNaslov";
            txtNaslov.Size = new Size(565, 27);
            txtNaslov.TabIndex = 7;
            // 
            // cbBrojPrimjeraka
            // 
            cbBrojPrimjeraka.FormattingEnabled = true;
            cbBrojPrimjeraka.Location = new Point(192, 279);
            cbBrojPrimjeraka.Name = "cbBrojPrimjeraka";
            cbBrojPrimjeraka.Size = new Size(282, 28);
            cbBrojPrimjeraka.TabIndex = 9;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(663, 279);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(94, 29);
            btnOK.TabIndex = 10;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // nudGodinaIzdanja
            // 
            nudGodinaIzdanja.Location = new Point(192, 218);
            nudGodinaIzdanja.Name = "nudGodinaIzdanja";
            nudGodinaIzdanja.Size = new Size(282, 27);
            nudGodinaIzdanja.TabIndex = 11;
            // 
            // KDetalji
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(nudGodinaIzdanja);
            Controls.Add(btnOK);
            Controls.Add(cbBrojPrimjeraka);
            Controls.Add(txtNaslov);
            Controls.Add(txtAutor);
            Controls.Add(txtISBN);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "KDetalji";
            Text = "KDetalji";
            Load += KDetalji_Load;
            ((System.ComponentModel.ISupportInitialize)nudGodinaIzdanja).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtISBN;
        private TextBox txtAutor;
        private TextBox txtNaslov;
        private ComboBox cbBrojPrimjeraka;
        private Button btnOK;
        private NumericUpDown nudGodinaIzdanja;
    }
}