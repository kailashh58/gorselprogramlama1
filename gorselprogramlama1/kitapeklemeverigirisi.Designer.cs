namespace gorselprogramlama1
{
    partial class kitapeklemeverigirisi
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.kitapadiTextBox = new System.Windows.Forms.TextBox();
            this.yazaradiTextBox = new System.Windows.Forms.TextBox();
            this.turTextBox = new System.Windows.Forms.TextBox();
            this.kaydetbutton = new System.Windows.Forms.Button();
            this.Goruntule = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kitap adı:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 37);
            this.label3.TabIndex = 1;
            this.label3.Text = "Yazar adı:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(88, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 37);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tür:";
            // 
            // kitapadiTextBox
            // 
            this.kitapadiTextBox.Location = new System.Drawing.Point(146, 94);
            this.kitapadiTextBox.Name = "kitapadiTextBox";
            this.kitapadiTextBox.Size = new System.Drawing.Size(188, 22);
            this.kitapadiTextBox.TabIndex = 2;
            this.kitapadiTextBox.TextChanged += new System.EventHandler(this.kitapadiTextBox_TextChanged);
            // 
            // yazaradiTextBox
            // 
            this.yazaradiTextBox.Location = new System.Drawing.Point(146, 147);
            this.yazaradiTextBox.Name = "yazaradiTextBox";
            this.yazaradiTextBox.Size = new System.Drawing.Size(188, 22);
            this.yazaradiTextBox.TabIndex = 2;
            // 
            // turTextBox
            // 
            this.turTextBox.Location = new System.Drawing.Point(146, 193);
            this.turTextBox.Name = "turTextBox";
            this.turTextBox.Size = new System.Drawing.Size(188, 22);
            this.turTextBox.TabIndex = 2;
            // 
            // kaydetbutton
            // 
            this.kaydetbutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.kaydetbutton.Location = new System.Drawing.Point(145, 251);
            this.kaydetbutton.Name = "kaydetbutton";
            this.kaydetbutton.Size = new System.Drawing.Size(124, 35);
            this.kaydetbutton.TabIndex = 3;
            this.kaydetbutton.Text = "Kaydet";
            this.kaydetbutton.UseVisualStyleBackColor = false;
            this.kaydetbutton.Click += new System.EventHandler(this.kaydetButton_Click);
            // 
            // Goruntule
            // 
            this.Goruntule.BackColor = System.Drawing.Color.Salmon;
            this.Goruntule.Location = new System.Drawing.Point(275, 251);
            this.Goruntule.Name = "Goruntule";
            this.Goruntule.Size = new System.Drawing.Size(124, 35);
            this.Goruntule.TabIndex = 3;
            this.Goruntule.Text = "Görüntüle";
            this.Goruntule.UseVisualStyleBackColor = false;
            this.Goruntule.Click += new System.EventHandler(this.goruntuleButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(450, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(484, 271);
            this.dataGridView1.TabIndex = 4;
            // 
            // kitapeklemeverigirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 406);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Goruntule);
            this.Controls.Add(this.kaydetbutton);
            this.Controls.Add(this.turTextBox);
            this.Controls.Add(this.yazaradiTextBox);
            this.Controls.Add(this.kitapadiTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "kitapeklemeverigirisi";
            this.Text = "kitapeklemeverigirisi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox kitapadiTextBox;
        private System.Windows.Forms.TextBox yazaradiTextBox;
        private System.Windows.Forms.TextBox turTextBox;
        private System.Windows.Forms.Button kaydetbutton;
        private System.Windows.Forms.Button Goruntule;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}