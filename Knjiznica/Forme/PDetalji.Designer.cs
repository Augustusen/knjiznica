namespace Knjiznica.Forme
{
    partial class PDetalji
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
            lbUcenici = new ListBox();
            lbKnjige = new ListBox();
            label3 = new Label();
            label4 = new Label();
            btnOK = new Button();
            nudBrojDana = new NumericUpDown();
            dtpDatumPosudbe = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)nudBrojDana).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 0;
            label1.Text = "Učenik";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 219);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 1;
            label2.Text = "Knjiga";
            // 
            // lbUcenici
            // 
            lbUcenici.FormattingEnabled = true;
            lbUcenici.Location = new Point(12, 33);
            lbUcenici.Name = "lbUcenici";
            lbUcenici.Size = new Size(465, 184);
            lbUcenici.TabIndex = 2;
            // 
            // lbKnjige
            // 
            lbKnjige.FormattingEnabled = true;
            lbKnjige.Location = new Point(12, 242);
            lbKnjige.Name = "lbKnjige";
            lbKnjige.Size = new Size(465, 204);
            lbKnjige.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(535, 33);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 4;
            label3.Text = "Datum posudbe";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(535, 114);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 5;
            label4.Text = "Broj dana";
            // 
            // btnOK
            // 
            btnOK.Location = new Point(638, 380);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(150, 58);
            btnOK.TabIndex = 8;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // nudBrojDana
            // 
            nudBrojDana.Location = new Point(535, 137);
            nudBrojDana.Name = "nudBrojDana";
            nudBrojDana.Size = new Size(233, 27);
            nudBrojDana.TabIndex = 9;
            // 
            // dtpDatumPosudbe
            // 
            dtpDatumPosudbe.Location = new Point(535, 56);
            dtpDatumPosudbe.Name = "dtpDatumPosudbe";
            dtpDatumPosudbe.Size = new Size(233, 27);
            dtpDatumPosudbe.TabIndex = 10;
            // 
            // PDetalji
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtpDatumPosudbe);
            Controls.Add(nudBrojDana);
            Controls.Add(btnOK);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lbKnjige);
            Controls.Add(lbUcenici);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PDetalji";
            Text = "PDetalji";
            Load += PDetalji_Load;
            ((System.ComponentModel.ISupportInitialize)nudBrojDana).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox lbUcenici;
        private ListBox lbKnjige;
        private Label label3;
        private Label label4;
        private Button btnOK;
        private NumericUpDown nudBrojDana;
        private DateTimePicker dtpDatumPosudbe;
    }
}