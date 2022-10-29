
namespace takipotomasyonu
{

    
        partial class Form1
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
            this.kullanıcıtextbox = new System.Windows.Forms.TextBox();
            this.sifretextbox = new System.Windows.Forms.TextBox();
            this.kullanıcılabel = new System.Windows.Forms.Label();
            this.sifrelabel = new System.Windows.Forms.Label();
            this.girisbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kullanıcıtextbox
            // 
            this.kullanıcıtextbox.Location = new System.Drawing.Point(167, 80);
            this.kullanıcıtextbox.Multiline = true;
            this.kullanıcıtextbox.Name = "kullanıcıtextbox";
            this.kullanıcıtextbox.Size = new System.Drawing.Size(169, 28);
            this.kullanıcıtextbox.TabIndex = 0;
            // 
            // sifretextbox
            // 
            this.sifretextbox.Location = new System.Drawing.Point(167, 129);
            this.sifretextbox.Multiline = true;
            this.sifretextbox.Name = "sifretextbox";
            this.sifretextbox.PasswordChar = '*';
            this.sifretextbox.Size = new System.Drawing.Size(169, 28);
            this.sifretextbox.TabIndex = 1;
            // 
            // kullanıcılabel
            // 
            this.kullanıcılabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanıcılabel.Location = new System.Drawing.Point(45, 80);
            this.kullanıcılabel.Name = "kullanıcılabel";
            this.kullanıcılabel.Size = new System.Drawing.Size(116, 28);
            this.kullanıcılabel.TabIndex = 2;
            this.kullanıcılabel.Text = "Kullancı Adı";
            // 
            // sifrelabel
            // 
            this.sifrelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifrelabel.Location = new System.Drawing.Point(45, 129);
            this.sifrelabel.Name = "sifrelabel";
            this.sifrelabel.Size = new System.Drawing.Size(116, 28);
            this.sifrelabel.TabIndex = 3;
            this.sifrelabel.Text = "Şifre";
            // 
            // girisbutton
            // 
            this.girisbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.girisbutton.Location = new System.Drawing.Point(398, 189);
            this.girisbutton.Name = "girisbutton";
            this.girisbutton.Size = new System.Drawing.Size(134, 87);
            this.girisbutton.TabIndex = 4;
            this.girisbutton.Text = "GİRİŞ";
            this.girisbutton.UseVisualStyleBackColor = true;
            this.girisbutton.Click += new System.EventHandler(this.girisbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(602, 341);
            this.Controls.Add(this.girisbutton);
            this.Controls.Add(this.sifrelabel);
            this.Controls.Add(this.kullanıcılabel);
            this.Controls.Add(this.sifretextbox);
            this.Controls.Add(this.kullanıcıtextbox);
            this.Name = "Form1";
            this.Text = "Stok Takibi";
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion

            private System.Windows.Forms.TextBox kullanıcıtextbox;
            private System.Windows.Forms.TextBox sifretextbox;
            private System.Windows.Forms.Label kullanıcılabel;
            private System.Windows.Forms.Label sifrelabel;
            private System.Windows.Forms.Button girisbutton;
        }
    



}

