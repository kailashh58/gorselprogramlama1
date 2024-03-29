namespace gorselprogramlama1
{
    partial class uyeeklemeverigirisi
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
            this.Uyeadsoyad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uyeadTextBox = new System.Windows.Forms.TextBox();
            this.uyenoTextBox = new System.Windows.Forms.TextBox();
            this.kaydet = new System.Windows.Forms.Button();
            this.goruntule = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Uyeadsoyad
            // 
            this.Uyeadsoyad.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Uyeadsoyad.Location = new System.Drawing.Point(65, 103);
            this.Uyeadsoyad.Name = "Uyeadsoyad";
            this.Uyeadsoyad.Size = new System.Drawing.Size(154, 43);
            this.Uyeadsoyad.TabIndex = 0;
            this.Uyeadsoyad.Text = "Üye Ad Soyad:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Üye No";
            // 
            // uyeadTextBox
            // 
            this.uyeadTextBox.Location = new System.Drawing.Point(225, 104);
            this.uyeadTextBox.Name = "uyeadTextBox";
            this.uyeadTextBox.Size = new System.Drawing.Size(196, 22);
            this.uyeadTextBox.TabIndex = 1;
            // 
            // uyenoTextBox
            // 
            this.uyenoTextBox.Location = new System.Drawing.Point(225, 146);
            this.uyenoTextBox.Name = "uyenoTextBox";
            this.uyenoTextBox.Size = new System.Drawing.Size(196, 22);
            this.uyenoTextBox.TabIndex = 1;
            // 
            // kaydet
            // 
            this.kaydet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.kaydet.Location = new System.Drawing.Point(143, 224);
            this.kaydet.Name = "kaydet";
            this.kaydet.Size = new System.Drawing.Size(120, 38);
            this.kaydet.TabIndex = 2;
            this.kaydet.Text = "Kaydet";
            this.kaydet.UseVisualStyleBackColor = false;
            this.kaydet.Click += new System.EventHandler(this.kaydet_Click);
            // 
            // goruntule
            // 
            this.goruntule.BackColor = System.Drawing.Color.IndianRed;
            this.goruntule.Location = new System.Drawing.Point(278, 224);
            this.goruntule.Name = "goruntule";
            this.goruntule.Size = new System.Drawing.Size(120, 38);
            this.goruntule.TabIndex = 2;
            this.goruntule.Text = "Görüntüle";
            this.goruntule.UseVisualStyleBackColor = false;
            this.goruntule.Click += new System.EventHandler(this.goruntule_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(485, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(441, 366);
            this.dataGridView1.TabIndex = 3;
            // 
            // uyeeklemeverigirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.goruntule);
            this.Controls.Add(this.kaydet);
            this.Controls.Add(this.uyenoTextBox);
            this.Controls.Add(this.uyeadTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Uyeadsoyad);
            this.Name = "uyeeklemeverigirisi";
            this.Text = "uyeeklemeverigirisi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Uyeadsoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uyeadTextBox;
        private System.Windows.Forms.TextBox uyenoTextBox;
        private System.Windows.Forms.Button kaydet;
        private System.Windows.Forms.Button goruntule;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}