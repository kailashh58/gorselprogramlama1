namespace gorselprogramlama1
{
    partial class kitapeklemeform
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
            this.Kitapeklemeveri = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Kitapeklemeveri
            // 
            this.Kitapeklemeveri.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Kitapeklemeveri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kitapeklemeveri.Location = new System.Drawing.Point(12, 99);
            this.Kitapeklemeveri.Name = "Kitapeklemeveri";
            this.Kitapeklemeveri.Size = new System.Drawing.Size(298, 50);
            this.Kitapeklemeveri.TabIndex = 0;
            this.Kitapeklemeveri.Text = "Kütüphaneye kitap ekle ";
            this.Kitapeklemeveri.UseVisualStyleBackColor = false;
            this.Kitapeklemeveri.Click += new System.EventHandler(this.button1_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Back.Location = new System.Drawing.Point(12, 29);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(120, 37);
            this.Back.TabIndex = 2;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.button3_Click);
            // 
            // kitapeklemeform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Kitapeklemeveri);
            this.Name = "kitapeklemeform";
            this.Text = "KitapEkleme";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Kitapeklemeveri;
        private System.Windows.Forms.Button Back;
    }
}