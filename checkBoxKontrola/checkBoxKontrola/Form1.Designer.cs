
namespace checkBoxKontrola
{
    partial class Form1
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
            this.btnPosalji = new System.Windows.Forms.Button();
            this.chkDorucak = new System.Windows.Forms.CheckBox();
            this.chkSakrij = new System.Windows.Forms.CheckBox();
            this.chkVečera = new System.Windows.Forms.CheckBox();
            this.chkRucak = new System.Windows.Forms.CheckBox();
            this.txtIspis = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPosalji
            // 
            this.btnPosalji.Location = new System.Drawing.Point(66, 213);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(75, 23);
            this.btnPosalji.TabIndex = 0;
            this.btnPosalji.Text = "Pošalji";
            this.btnPosalji.UseVisualStyleBackColor = true;
            this.btnPosalji.Click += new System.EventHandler(this.btnPosalji_Click);
            // 
            // chkDorucak
            // 
            this.chkDorucak.AutoSize = true;
            this.chkDorucak.Location = new System.Drawing.Point(66, 54);
            this.chkDorucak.Name = "chkDorucak";
            this.chkDorucak.Size = new System.Drawing.Size(83, 21);
            this.chkDorucak.TabIndex = 1;
            this.chkDorucak.Text = "Doručak";
            this.chkDorucak.UseVisualStyleBackColor = true;
            this.chkDorucak.CheckedChanged += new System.EventHandler(this.chkDorucak_CheckedChanged);
            // 
            // chkSakrij
            // 
            this.chkSakrij.AutoSize = true;
            this.chkSakrij.Location = new System.Drawing.Point(224, 215);
            this.chkSakrij.Name = "chkSakrij";
            this.chkSakrij.Size = new System.Drawing.Size(109, 21);
            this.chkSakrij.TabIndex = 2;
            this.chkSakrij.Text = "Sakrij odabir";
            this.chkSakrij.UseVisualStyleBackColor = true;
            // 
            // chkVečera
            // 
            this.chkVečera.AutoSize = true;
            this.chkVečera.Location = new System.Drawing.Point(66, 134);
            this.chkVečera.Name = "chkVečera";
            this.chkVečera.Size = new System.Drawing.Size(75, 21);
            this.chkVečera.TabIndex = 3;
            this.chkVečera.Text = "Večera";
            this.chkVečera.UseVisualStyleBackColor = true;
            this.chkVečera.CheckedChanged += new System.EventHandler(this.chkVečera_CheckedChanged);
            // 
            // chkRucak
            // 
            this.chkRucak.AutoSize = true;
            this.chkRucak.Location = new System.Drawing.Point(66, 93);
            this.chkRucak.Name = "chkRucak";
            this.chkRucak.Size = new System.Drawing.Size(70, 21);
            this.chkRucak.TabIndex = 4;
            this.chkRucak.Text = "Ručak";
            this.chkRucak.UseVisualStyleBackColor = true;
            this.chkRucak.CheckedChanged += new System.EventHandler(this.chkRucak_CheckedChanged);
            // 
            // txtIspis
            // 
            this.txtIspis.Location = new System.Drawing.Point(224, 52);
            this.txtIspis.Multiline = true;
            this.txtIspis.Name = "txtIspis";
            this.txtIspis.Size = new System.Drawing.Size(130, 103);
            this.txtIspis.TabIndex = 5;
            this.txtIspis.Text = "Vaš odabir je:";
            this.txtIspis.TextChanged += new System.EventHandler(this.txtIspis_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtIspis);
            this.Controls.Add(this.chkRucak);
            this.Controls.Add(this.chkVečera);
            this.Controls.Add(this.chkSakrij);
            this.Controls.Add(this.chkDorucak);
            this.Controls.Add(this.btnPosalji);
            this.Name = "Form1";
            this.Text = "Check Box kontrola";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPosalji;
        private System.Windows.Forms.CheckBox chkDorucak;
        private System.Windows.Forms.CheckBox chkSakrij;
        private System.Windows.Forms.CheckBox chkVečera;
        private System.Windows.Forms.CheckBox chkRucak;
        private System.Windows.Forms.TextBox txtIspis;
    }
}

