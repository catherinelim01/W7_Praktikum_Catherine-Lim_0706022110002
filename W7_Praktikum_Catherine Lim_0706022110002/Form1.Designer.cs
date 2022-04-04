
namespace W7_Praktikum_Catherine_Lim_0706022110002
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
            this.buttonKonversi = new System.Windows.Forms.Button();
            this.labelMskanKal = new System.Windows.Forms.Label();
            this.textBoxHuruf = new System.Windows.Forms.TextBox();
            this.textBoxHurGanti = new System.Windows.Forms.TextBox();
            this.textBoxKalimat = new System.Windows.Forms.TextBox();
            this.labelMsknHur = new System.Windows.Forms.Label();
            this.labelMenjd = new System.Windows.Forms.Label();
            this.labelHsl = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonKonversi
            // 
            this.buttonKonversi.Location = new System.Drawing.Point(180, 126);
            this.buttonKonversi.Name = "buttonKonversi";
            this.buttonKonversi.Size = new System.Drawing.Size(354, 30);
            this.buttonKonversi.TabIndex = 0;
            this.buttonKonversi.Text = "Konversi";
            this.buttonKonversi.UseVisualStyleBackColor = true;
            this.buttonKonversi.Click += new System.EventHandler(this.buttonKonversi_Click);
            // 
            // labelMskanKal
            // 
            this.labelMskanKal.AutoSize = true;
            this.labelMskanKal.Location = new System.Drawing.Point(40, 33);
            this.labelMskanKal.Name = "labelMskanKal";
            this.labelMskanKal.Size = new System.Drawing.Size(134, 20);
            this.labelMskanKal.TabIndex = 1;
            this.labelMskanKal.Text = "Masukan Kalimat:";
            // 
            // textBoxHuruf
            // 
            this.textBoxHuruf.Location = new System.Drawing.Point(180, 74);
            this.textBoxHuruf.Name = "textBoxHuruf";
            this.textBoxHuruf.Size = new System.Drawing.Size(128, 26);
            this.textBoxHuruf.TabIndex = 2;
            // 
            // textBoxHurGanti
            // 
            this.textBoxHurGanti.Location = new System.Drawing.Point(415, 74);
            this.textBoxHurGanti.Name = "textBoxHurGanti";
            this.textBoxHurGanti.Size = new System.Drawing.Size(119, 26);
            this.textBoxHurGanti.TabIndex = 3;
            // 
            // textBoxKalimat
            // 
            this.textBoxKalimat.Location = new System.Drawing.Point(180, 27);
            this.textBoxKalimat.Name = "textBoxKalimat";
            this.textBoxKalimat.Size = new System.Drawing.Size(354, 26);
            this.textBoxKalimat.TabIndex = 4;
            // 
            // labelMsknHur
            // 
            this.labelMsknHur.AutoSize = true;
            this.labelMsknHur.Location = new System.Drawing.Point(40, 80);
            this.labelMsknHur.Name = "labelMsknHur";
            this.labelMsknHur.Size = new System.Drawing.Size(122, 20);
            this.labelMsknHur.TabIndex = 5;
            this.labelMsknHur.Text = "Masukan Huruf:";
            // 
            // labelMenjd
            // 
            this.labelMenjd.AutoSize = true;
            this.labelMenjd.Location = new System.Drawing.Point(324, 80);
            this.labelMenjd.Name = "labelMenjd";
            this.labelMenjd.Size = new System.Drawing.Size(64, 20);
            this.labelMenjd.TabIndex = 6;
            this.labelMenjd.Text = "Menjadi";
            // 
            // labelHsl
            // 
            this.labelHsl.AutoSize = true;
            this.labelHsl.Location = new System.Drawing.Point(40, 193);
            this.labelHsl.Name = "labelHsl";
            this.labelHsl.Size = new System.Drawing.Size(48, 20);
            this.labelHsl.TabIndex = 7;
            this.labelHsl.Text = "Hasil:";
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(176, 193);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(29, 20);
            this.labelOutput.TabIndex = 8;
            this.labelOutput.Text = "[...]";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 246);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.labelHsl);
            this.Controls.Add(this.labelMenjd);
            this.Controls.Add(this.labelMsknHur);
            this.Controls.Add(this.textBoxKalimat);
            this.Controls.Add(this.textBoxHurGanti);
            this.Controls.Add(this.textBoxHuruf);
            this.Controls.Add(this.labelMskanKal);
            this.Controls.Add(this.buttonKonversi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonKonversi;
        private System.Windows.Forms.Label labelMskanKal;
        private System.Windows.Forms.TextBox textBoxHuruf;
        private System.Windows.Forms.TextBox textBoxHurGanti;
        private System.Windows.Forms.TextBox textBoxKalimat;
        private System.Windows.Forms.Label labelMsknHur;
        private System.Windows.Forms.Label labelMenjd;
        private System.Windows.Forms.Label labelHsl;
        private System.Windows.Forms.Label labelOutput;
    }
}

