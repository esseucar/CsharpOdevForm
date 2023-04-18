namespace EFramwork
{
    partial class Form1
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
            this.btnsil = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtadguncelle = new System.Windows.Forms.TextBox();
            this.txtadetguncelle = new System.Windows.Forms.TextBox();
            this.txtfiyatguncelle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtadekle = new System.Windows.Forms.TextBox();
            this.txtadetekle = new System.Windows.Forms.TextBox();
            this.txtfiyatekle = new System.Windows.Forms.TextBox();
            this.txt_stok = new System.Windows.Forms.Label();
            this.btnekle = new System.Windows.Forms.Button();
            this.txt_fiyat = new System.Windows.Forms.Label();
            this.txt_ad = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsil
            // 
            this.btnsil.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnsil.Location = new System.Drawing.Point(280, 353);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(75, 23);
            this.btnsil.TabIndex = 14;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtadguncelle);
            this.groupBox2.Controls.Add(this.txtadetguncelle);
            this.groupBox2.Controls.Add(this.txtfiyatguncelle);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnguncelle);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(382, 206);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(229, 197);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kurabiye Güncelleme";
            // 
            // txtadguncelle
            // 
            this.txtadguncelle.Location = new System.Drawing.Point(91, 35);
            this.txtadguncelle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtadguncelle.Name = "txtadguncelle";
            this.txtadguncelle.Size = new System.Drawing.Size(116, 20);
            this.txtadguncelle.TabIndex = 0;
            // 
            // txtadetguncelle
            // 
            this.txtadetguncelle.Location = new System.Drawing.Point(91, 110);
            this.txtadetguncelle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtadetguncelle.Name = "txtadetguncelle";
            this.txtadetguncelle.Size = new System.Drawing.Size(116, 20);
            this.txtadetguncelle.TabIndex = 7;
            // 
            // txtfiyatguncelle
            // 
            this.txtfiyatguncelle.Location = new System.Drawing.Point(91, 71);
            this.txtfiyatguncelle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtfiyatguncelle.Name = "txtfiyatguncelle";
            this.txtfiyatguncelle.Size = new System.Drawing.Size(116, 20);
            this.txtfiyatguncelle.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 117);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Urun Stok";
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(106, 147);
            this.btnguncelle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(88, 23);
            this.btnguncelle.TabIndex = 2;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 73);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Urun Fiyat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 38);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Urun Ad";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtadekle);
            this.groupBox1.Controls.Add(this.txtadetekle);
            this.groupBox1.Controls.Add(this.txtfiyatekle);
            this.groupBox1.Controls.Add(this.txt_stok);
            this.groupBox1.Controls.Add(this.btnekle);
            this.groupBox1.Controls.Add(this.txt_fiyat);
            this.groupBox1.Controls.Add(this.txt_ad);
            this.groupBox1.Location = new System.Drawing.Point(23, 206);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(229, 197);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kurabiye Ekleme";
            // 
            // txtadekle
            // 
            this.txtadekle.Location = new System.Drawing.Point(91, 35);
            this.txtadekle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtadekle.Name = "txtadekle";
            this.txtadekle.Size = new System.Drawing.Size(116, 20);
            this.txtadekle.TabIndex = 0;
            // 
            // txtadetekle
            // 
            this.txtadetekle.Location = new System.Drawing.Point(91, 110);
            this.txtadetekle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtadetekle.Name = "txtadetekle";
            this.txtadetekle.Size = new System.Drawing.Size(116, 20);
            this.txtadetekle.TabIndex = 7;
            // 
            // txtfiyatekle
            // 
            this.txtfiyatekle.Location = new System.Drawing.Point(91, 71);
            this.txtfiyatekle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtfiyatekle.Name = "txtfiyatekle";
            this.txtfiyatekle.Size = new System.Drawing.Size(116, 20);
            this.txtfiyatekle.TabIndex = 1;
            // 
            // txt_stok
            // 
            this.txt_stok.AutoSize = true;
            this.txt_stok.Location = new System.Drawing.Point(14, 117);
            this.txt_stok.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_stok.Name = "txt_stok";
            this.txt_stok.Size = new System.Drawing.Size(55, 13);
            this.txt_stok.TabIndex = 6;
            this.txt_stok.Text = "Urun Stok";
            // 
            // btnekle
            // 
            this.btnekle.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnekle.Location = new System.Drawing.Point(106, 147);
            this.btnekle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(88, 23);
            this.btnekle.TabIndex = 2;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // txt_fiyat
            // 
            this.txt_fiyat.AutoSize = true;
            this.txt_fiyat.Location = new System.Drawing.Point(14, 73);
            this.txt_fiyat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_fiyat.Name = "txt_fiyat";
            this.txt_fiyat.Size = new System.Drawing.Size(55, 13);
            this.txt_fiyat.TabIndex = 5;
            this.txt_fiyat.Text = "Urun Fiyat";
            // 
            // txt_ad
            // 
            this.txt_ad.AutoSize = true;
            this.txt_ad.Location = new System.Drawing.Point(14, 38);
            this.txt_ad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(46, 13);
            this.txt_ad.TabIndex = 4;
            this.txt_ad.Text = "Urun Ad";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 150);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtadguncelle;
        private System.Windows.Forms.TextBox txtadetguncelle;
        private System.Windows.Forms.TextBox txtfiyatguncelle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtadekle;
        private System.Windows.Forms.TextBox txtadetekle;
        private System.Windows.Forms.TextBox txtfiyatekle;
        private System.Windows.Forms.Label txt_stok;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Label txt_fiyat;
        private System.Windows.Forms.Label txt_ad;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

