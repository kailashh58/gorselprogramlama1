namespace gorselprogramlama1
{
    partial class emanetislemleriverigirisi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kitapteslimTextBox = new System.Windows.Forms.TextBox();
            this.uyeliknoTextBox = new System.Windows.Forms.TextBox();
            this.Kaydet = new System.Windows.Forms.Button();
            this.goruntule = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitabı teslim alan kişi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(186, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Üyelik No:";
            // 
            // kitapteslimTextBox
            // 
            this.kitapteslimTextBox.Location = new System.Drawing.Point(312, 107);
            this.kitapteslimTextBox.Name = "kitapteslimTextBox";
            this.kitapteslimTextBox.Size = new System.Drawing.Size(239, 22);
            this.kitapteslimTextBox.TabIndex = 1;
            // 
            // uyeliknoTextBox
            // 
            this.uyeliknoTextBox.Location = new System.Drawing.Point(312, 147);
            this.uyeliknoTextBox.Name = "uyeliknoTextBox";
            this.uyeliknoTextBox.Size = new System.Drawing.Size(239, 22);
            this.uyeliknoTextBox.TabIndex = 1;
            // 
            // Kaydet
            // 
            this.Kaydet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Kaydet.Location = new System.Drawing.Point(303, 226);
            this.Kaydet.Name = "Kaydet";
            this.Kaydet.Size = new System.Drawing.Size(109, 43);
            this.Kaydet.TabIndex = 2;
            this.Kaydet.Text = "Kaydet";
            this.Kaydet.UseVisualStyleBackColor = false;
            this.Kaydet.Click += new System.EventHandler(this.Kaydet_Click);
            // 
            // goruntule
            // 
            this.goruntule.BackColor = System.Drawing.Color.IndianRed;
            this.goruntule.Location = new System.Drawing.Point(427, 226);
            this.goruntule.Name = "goruntule";
            this.goruntule.Size = new System.Drawing.Size(109, 43);
            this.goruntule.TabIndex = 2;
            this.goruntule.Text = "Görüntüle";
            this.goruntule.UseVisualStyleBackColor = false;
            this.goruntule.Click += new System.EventHandler(this.goruntule_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(615, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(623, 362);
            this.dataGridView1.TabIndex = 3;
            // 
            // emanetislemleriverigirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 491);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.goruntule);
            this.Controls.Add(this.Kaydet);
            this.Controls.Add(this.uyeliknoTextBox);
            this.Controls.Add(this.kitapteslimTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "emanetislemleriverigirisi";
            this.Text = "emanetislemleriverigirisi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kitapteslimTextBox;
        private System.Windows.Forms.TextBox uyeliknoTextBox;
        private System.Windows.Forms.Button Kaydet;
        private System.Windows.Forms.Button goruntule;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}