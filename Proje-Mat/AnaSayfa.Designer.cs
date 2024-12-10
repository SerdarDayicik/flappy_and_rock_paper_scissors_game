namespace Proje_Mat
{
    partial class AnaSayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFlapy = new System.Windows.Forms.Button();
            this.btnPing = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFlapy
            // 
            this.btnFlapy.BackColor = System.Drawing.Color.GhostWhite;
            this.btnFlapy.Location = new System.Drawing.Point(105, 187);
            this.btnFlapy.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnFlapy.Name = "btnFlapy";
            this.btnFlapy.Size = new System.Drawing.Size(253, 62);
            this.btnFlapy.TabIndex = 0;
            this.btnFlapy.Text = "Flapyy Bird";
            this.btnFlapy.UseVisualStyleBackColor = false;
            this.btnFlapy.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPing
            // 
            this.btnPing.BackColor = System.Drawing.Color.GhostWhite;
            this.btnPing.Location = new System.Drawing.Point(105, 308);
            this.btnPing.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(253, 63);
            this.btnPing.TabIndex = 1;
            this.btnPing.Text = "taş-kagıt-makas";
            this.btnPing.UseVisualStyleBackColor = false;
            this.btnPing.Click += new System.EventHandler(this.btnPing_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(119, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Oyun Seçiniz";
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(450, 492);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPing);
            this.Controls.Add(this.btnFlapy);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "AnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFlapy;
        private System.Windows.Forms.Button btnPing;
        private System.Windows.Forms.Label label1;
    }
}

