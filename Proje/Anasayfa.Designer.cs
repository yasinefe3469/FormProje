
namespace Proje
{
    partial class Anasayfa
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnDers = new System.Windows.Forms.Button();
            this.btnOgrenci = new System.Windows.Forms.Button();
            this.btnOkulYonetim = new System.Windows.Forms.Button();
            this.btnOgrenciDers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(117, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(477, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "ANASAYFAYA HOŞGELDİNİZ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnDers
            // 
            this.btnDers.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnDers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDers.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDers.ForeColor = System.Drawing.Color.Navy;
            this.btnDers.Location = new System.Drawing.Point(12, 104);
            this.btnDers.Name = "btnDers";
            this.btnDers.Size = new System.Drawing.Size(139, 50);
            this.btnDers.TabIndex = 1;
            this.btnDers.Text = "DERS";
            this.btnDers.UseVisualStyleBackColor = false;
            this.btnDers.Click += new System.EventHandler(this.btnDers_Click);
            // 
            // btnOgrenci
            // 
            this.btnOgrenci.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnOgrenci.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOgrenci.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrenci.ForeColor = System.Drawing.Color.Navy;
            this.btnOgrenci.Location = new System.Drawing.Point(200, 104);
            this.btnOgrenci.Name = "btnOgrenci";
            this.btnOgrenci.Size = new System.Drawing.Size(139, 50);
            this.btnOgrenci.TabIndex = 2;
            this.btnOgrenci.Text = "ÖĞRENCİ";
            this.btnOgrenci.UseVisualStyleBackColor = false;
            this.btnOgrenci.Click += new System.EventHandler(this.btnOgrenci_Click);
            // 
            // btnOkulYonetim
            // 
            this.btnOkulYonetim.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnOkulYonetim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOkulYonetim.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOkulYonetim.ForeColor = System.Drawing.Color.Navy;
            this.btnOkulYonetim.Location = new System.Drawing.Point(383, 104);
            this.btnOkulYonetim.Name = "btnOkulYonetim";
            this.btnOkulYonetim.Size = new System.Drawing.Size(139, 50);
            this.btnOkulYonetim.TabIndex = 3;
            this.btnOkulYonetim.Text = "OKUL YÖNETİM";
            this.btnOkulYonetim.UseVisualStyleBackColor = false;
            this.btnOkulYonetim.Click += new System.EventHandler(this.btnOkulYonetim_Click);
            // 
            // btnOgrenciDers
            // 
            this.btnOgrenciDers.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnOgrenciDers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOgrenciDers.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrenciDers.ForeColor = System.Drawing.Color.Navy;
            this.btnOgrenciDers.Location = new System.Drawing.Point(563, 104);
            this.btnOgrenciDers.Name = "btnOgrenciDers";
            this.btnOgrenciDers.Size = new System.Drawing.Size(139, 50);
            this.btnOgrenciDers.TabIndex = 4;
            this.btnOgrenciDers.Text = "ÖĞRENCİ DERS";
            this.btnOgrenciDers.UseVisualStyleBackColor = false;
            this.btnOgrenciDers.Click += new System.EventHandler(this.btnOgrenciDers_Click);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(714, 259);
            this.Controls.Add(this.btnOgrenciDers);
            this.Controls.Add(this.btnOkulYonetim);
            this.Controls.Add(this.btnOgrenci);
            this.Controls.Add(this.btnDers);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ANA SAYFA";
            this.Load += new System.EventHandler(this.Anasayfa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDers;
        private System.Windows.Forms.Button btnOgrenci;
        private System.Windows.Forms.Button btnOkulYonetim;
        private System.Windows.Forms.Button btnOgrenciDers;
    }
}

