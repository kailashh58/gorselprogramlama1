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
            this.SuspendLayout();
            // 
            // uyeekleveri
            // 
            this.uyeekleveri.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.uyeekleveri.Location = new System.Drawing.Point(24, 73);
            this.uyeekleveri.Name = "uyeekleveri";
            this.uyeekleveri.Size = new System.Drawing.Size(133, 48);
            this.uyeekleveri.TabIndex = 0;
            this.uyeekleveri.Text = "Üye ekle";
            this.uyeekleveri.UseVisualStyleBackColor = false;
            // 
            // uyeeklemeform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uyeekleveri);
            this.Name = "uyeeklemeform";
            this.Text = "UyeEkleme";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uyeekleveri;
    }
}