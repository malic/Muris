namespace Geoizmjera_PI
{
    partial class cestice_izmjena
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
            this.lblIdPosla = new System.Windows.Forms.Label();
            this.lblCestica = new System.Windows.Forms.Label();
            this.btnPotvrdiUnos = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblIdPosla
            // 
            this.lblIdPosla.AutoSize = true;
            this.lblIdPosla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIdPosla.Location = new System.Drawing.Point(135, 153);
            this.lblIdPosla.Name = "lblIdPosla";
            this.lblIdPosla.Size = new System.Drawing.Size(68, 20);
            this.lblIdPosla.TabIndex = 0;
            this.lblIdPosla.Text = "ID posla";
            // 
            // lblCestica
            // 
            this.lblCestica.AutoSize = true;
            this.lblCestica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCestica.Location = new System.Drawing.Point(315, 155);
            this.lblCestica.Name = "lblCestica";
            this.lblCestica.Size = new System.Drawing.Size(62, 20);
            this.lblCestica.TabIndex = 1;
            this.lblCestica.Text = "Čestica";
            // 
            // btnPotvrdiUnos
            // 
            this.btnPotvrdiUnos.Location = new System.Drawing.Point(194, 232);
            this.btnPotvrdiUnos.Name = "btnPotvrdiUnos";
            this.btnPotvrdiUnos.Size = new System.Drawing.Size(112, 66);
            this.btnPotvrdiUnos.TabIndex = 4;
            this.btnPotvrdiUnos.Text = "Potvrdi unos";
            this.btnPotvrdiUnos.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(120, 178);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(296, 178);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // cestice_izmjena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 454);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnPotvrdiUnos);
            this.Controls.Add(this.lblCestica);
            this.Controls.Add(this.lblIdPosla);
            this.Name = "cestice_izmjena";
            this.Text = "Izmjena čestica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdPosla;
        private System.Windows.Forms.Label lblCestica;
        private System.Windows.Forms.Button btnPotvrdiUnos;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}