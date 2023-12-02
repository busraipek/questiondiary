
namespace question_diary
{
    partial class şifredeğiştir
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
            this.button2 = new System.Windows.Forms.Button();
            this.şifre = new System.Windows.Forms.Label();
            this.kullanıcıadı = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.girişbuton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(441, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 31);
            this.button2.TabIndex = 10;
            this.button2.Text = " X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // şifre
            // 
            this.şifre.AutoSize = true;
            this.şifre.BackColor = System.Drawing.Color.Silver;
            this.şifre.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.şifre.ForeColor = System.Drawing.Color.Black;
            this.şifre.Location = new System.Drawing.Point(37, 116);
            this.şifre.Name = "şifre";
            this.şifre.Size = new System.Drawing.Size(85, 22);
            this.şifre.TabIndex = 14;
            this.şifre.Text = "Yeni Şifre";
            // 
            // kullanıcıadı
            // 
            this.kullanıcıadı.AutoSize = true;
            this.kullanıcıadı.BackColor = System.Drawing.Color.Silver;
            this.kullanıcıadı.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanıcıadı.ForeColor = System.Drawing.Color.Black;
            this.kullanıcıadı.Location = new System.Drawing.Point(37, 70);
            this.kullanıcıadı.Name = "kullanıcıadı";
            this.kullanıcıadı.Size = new System.Drawing.Size(85, 22);
            this.kullanıcıadı.TabIndex = 13;
            this.kullanıcıadı.Text = "Eski Şifre";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Silver;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(198, 114);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(215, 29);
            this.textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Silver;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(198, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 29);
            this.textBox1.TabIndex = 11;
            // 
            // girişbuton
            // 
            this.girişbuton.BackColor = System.Drawing.Color.Silver;
            this.girişbuton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.girişbuton.FlatAppearance.BorderSize = 0;
            this.girişbuton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.girişbuton.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girişbuton.ForeColor = System.Drawing.Color.Black;
            this.girişbuton.Location = new System.Drawing.Point(87, 171);
            this.girişbuton.Name = "girişbuton";
            this.girişbuton.Size = new System.Drawing.Size(326, 51);
            this.girişbuton.TabIndex = 15;
            this.girişbuton.Text = "Şifreyi Değiştir";
            this.girişbuton.UseVisualStyleBackColor = false;
            this.girişbuton.Click += new System.EventHandler(this.girişbuton_Click);
            // 
            // şifredeğiştir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(492, 262);
            this.Controls.Add(this.girişbuton);
            this.Controls.Add(this.şifre);
            this.Controls.Add(this.kullanıcıadı);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "şifredeğiştir";
            this.Text = "şifredeğiştir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label şifre;
        private System.Windows.Forms.Label kullanıcıadı;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button girişbuton;
    }
}