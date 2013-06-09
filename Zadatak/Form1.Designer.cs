namespace Samostalna_vježba_4_labosa
{
    partial class izrSvojstavaKruga
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
            this.checkDodajUListu = new System.Windows.Forms.CheckBox();
            this.btnIzračunaj = new System.Windows.Forms.Button();
            this.btnOčisti = new System.Windows.Forms.Button();
            this.lblPolumjer = new System.Windows.Forms.Label();
            this.lblPovršina = new System.Windows.Forms.Label();
            this.lblOpseg = new System.Windows.Forms.Label();
            this.txtPolumjer = new System.Windows.Forms.TextBox();
            this.txtPovršina = new System.Windows.Forms.TextBox();
            this.txtOpseg = new System.Windows.Forms.TextBox();
            this.listLista = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkDodajUListu
            // 
            this.checkDodajUListu.AutoSize = true;
            this.checkDodajUListu.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkDodajUListu.ForeColor = System.Drawing.Color.DarkOrange;
            this.checkDodajUListu.Location = new System.Drawing.Point(43, 142);
            this.checkDodajUListu.Name = "checkDodajUListu";
            this.checkDodajUListu.Size = new System.Drawing.Size(141, 22);
            this.checkDodajUListu.TabIndex = 0;
            this.checkDodajUListu.Text = "Dodaj u Listu";
            this.checkDodajUListu.UseVisualStyleBackColor = true;
            // 
            // btnIzračunaj
            // 
            this.btnIzračunaj.Font = new System.Drawing.Font("Bookman Old Style", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzračunaj.ForeColor = System.Drawing.Color.Olive;
            this.btnIzračunaj.Location = new System.Drawing.Point(43, 219);
            this.btnIzračunaj.Name = "btnIzračunaj";
            this.btnIzračunaj.Size = new System.Drawing.Size(107, 40);
            this.btnIzračunaj.TabIndex = 1;
            this.btnIzračunaj.Text = "Izračunaj";
            this.btnIzračunaj.UseVisualStyleBackColor = true;
            this.btnIzračunaj.Click += new System.EventHandler(this.btnIzračunaj_Click);
            // 
            // btnOčisti
            // 
            this.btnOčisti.Font = new System.Drawing.Font("Bookman Old Style", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOčisti.ForeColor = System.Drawing.Color.Olive;
            this.btnOčisti.Location = new System.Drawing.Point(165, 219);
            this.btnOčisti.Name = "btnOčisti";
            this.btnOčisti.Size = new System.Drawing.Size(87, 40);
            this.btnOčisti.TabIndex = 2;
            this.btnOčisti.Text = "Očisti";
            this.btnOčisti.UseVisualStyleBackColor = true;
            this.btnOčisti.Click += new System.EventHandler(this.btnOčisti_Click);
            // 
            // lblPolumjer
            // 
            this.lblPolumjer.AutoSize = true;
            this.lblPolumjer.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPolumjer.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblPolumjer.Location = new System.Drawing.Point(46, 31);
            this.lblPolumjer.Name = "lblPolumjer";
            this.lblPolumjer.Size = new System.Drawing.Size(90, 22);
            this.lblPolumjer.TabIndex = 3;
            this.lblPolumjer.Text = "Polumjer:";
            this.lblPolumjer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPovršina
            // 
            this.lblPovršina.AutoSize = true;
            this.lblPovršina.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPovršina.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblPovršina.Location = new System.Drawing.Point(46, 68);
            this.lblPovršina.Name = "lblPovršina";
            this.lblPovršina.Size = new System.Drawing.Size(87, 22);
            this.lblPovršina.TabIndex = 4;
            this.lblPovršina.Text = "Površina:";
            // 
            // lblOpseg
            // 
            this.lblOpseg.AutoSize = true;
            this.lblOpseg.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOpseg.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblOpseg.Location = new System.Drawing.Point(46, 104);
            this.lblOpseg.Name = "lblOpseg";
            this.lblOpseg.Size = new System.Drawing.Size(67, 22);
            this.lblOpseg.TabIndex = 5;
            this.lblOpseg.Text = "Opseg:";
            // 
            // txtPolumjer
            // 
            this.txtPolumjer.Location = new System.Drawing.Point(143, 33);
            this.txtPolumjer.Name = "txtPolumjer";
            this.txtPolumjer.Size = new System.Drawing.Size(100, 20);
            this.txtPolumjer.TabIndex = 6;
            // 
            // txtPovršina
            // 
            this.txtPovršina.Location = new System.Drawing.Point(143, 70);
            this.txtPovršina.Name = "txtPovršina";
            this.txtPovršina.ReadOnly = true;
            this.txtPovršina.Size = new System.Drawing.Size(100, 20);
            this.txtPovršina.TabIndex = 7;
            // 
            // txtOpseg
            // 
            this.txtOpseg.Location = new System.Drawing.Point(143, 106);
            this.txtOpseg.Name = "txtOpseg";
            this.txtOpseg.ReadOnly = true;
            this.txtOpseg.Size = new System.Drawing.Size(100, 20);
            this.txtOpseg.TabIndex = 8;
            // 
            // listLista
            // 
            this.listLista.BackColor = System.Drawing.Color.Orange;
            this.listLista.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listLista.FormattingEnabled = true;
            this.listLista.ItemHeight = 18;
            this.listLista.Location = new System.Drawing.Point(393, 13);
            this.listLista.Name = "listLista";
            this.listLista.ScrollAlwaysVisible = true;
            this.listLista.Size = new System.Drawing.Size(349, 148);
            this.listLista.TabIndex = 9;
            this.listLista.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listLista_MouseDoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Samostalna_vježba_4_labosa.Properties.Resources.tumblr_m6x1v9i4gu1roew1yo1_500;
            this.pictureBox1.Location = new System.Drawing.Point(393, 180);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(349, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // izrSvojstavaKruga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(774, 392);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listLista);
            this.Controls.Add(this.txtOpseg);
            this.Controls.Add(this.txtPovršina);
            this.Controls.Add(this.txtPolumjer);
            this.Controls.Add(this.lblOpseg);
            this.Controls.Add(this.lblPovršina);
            this.Controls.Add(this.lblPolumjer);
            this.Controls.Add(this.btnOčisti);
            this.Controls.Add(this.btnIzračunaj);
            this.Controls.Add(this.checkDodajUListu);
            this.Name = "izrSvojstavaKruga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izračunavanje svojstava Kruga";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkDodajUListu;
        private System.Windows.Forms.Button btnIzračunaj;
        private System.Windows.Forms.Button btnOčisti;
        private System.Windows.Forms.Label lblPolumjer;
        private System.Windows.Forms.Label lblPovršina;
        private System.Windows.Forms.Label lblOpseg;
        private System.Windows.Forms.TextBox txtPolumjer;
        private System.Windows.Forms.TextBox txtPovršina;
        private System.Windows.Forms.TextBox txtOpseg;
        private System.Windows.Forms.ListBox listLista;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

