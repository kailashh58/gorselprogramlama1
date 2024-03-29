namespace gorselprogramlama1
{
    partial class uyeeklemeform
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
            this.uyeekleveri = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uyeekleveri
            // 
            this.uyeekleveri.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.uyeekleveri.Location = new System.Drawing.Point(24, 87);
            this.uyeekleveri.Name = "uyeekleveri";
            this.uyeekleveri.Size = new System.Drawing.Size(150, 54);
            this.uyeekleveri.TabIndex = 0;
            this.uyeekleveri.Text = "Üye ekle";
            this.uyeekleveri.UseVisualStyleBackColor = false;
            this.uyeekleveri.Click += new System.EventHandler(this.uyeekleveri_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.back.Location = new System.Drawing.Point(12, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(106, 37);
            this.back.TabIndex = 1;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // uyeeklemeform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.uyeekleveri);
            this.Name = "uyeeklemeform";
            this.Text = "UyeEkleme";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uyeekleveri;
        private System.Windows.Forms.Button back;
    }
}