namespace gorselprogramlama1
{
    partial class kitapemanetislemleriform4
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
            this.emanetislemleributton = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // emanetislemleributton
            // 
            this.emanetislemleributton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.emanetislemleributton.Location = new System.Drawing.Point(12, 86);
            this.emanetislemleributton.Name = "emanetislemleributton";
            this.emanetislemleributton.Size = new System.Drawing.Size(146, 61);
            this.emanetislemleributton.TabIndex = 0;
            this.emanetislemleributton.Text = "Emanet İşlemleri";
            this.emanetislemleributton.UseVisualStyleBackColor = false;
            this.emanetislemleributton.Click += new System.EventHandler(this.button1_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.back.Location = new System.Drawing.Point(12, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(99, 40);
            this.back.TabIndex = 1;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // kitapemanetislemleriform4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.emanetislemleributton);
            this.Name = "kitapemanetislemleriform4";
            this.Text = "KitapEmanetIslemleri";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button emanetislemleributton;
        private System.Windows.Forms.Button back;
    }
}