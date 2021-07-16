
namespace Personal_Budget_finance
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
            this.Submit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Pemasukkan = new System.Windows.Forms.RadioButton();
            this.Pengeluaran = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.Deskripsi = new System.Windows.Forms.TextBox();
            this.Jumlah = new System.Windows.Forms.NumericUpDown();
            this.Tipe = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TanggalDari = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TanggalSampai = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Selisih = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Terapkan = new System.Windows.Forms.Button();
            this.TotalPengeluaran = new System.Windows.Forms.ListBox();
            this.TotalPemasukkan = new System.Windows.Forms.ListBox();
            this.Hapus = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Jumlah)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.SteelBlue;
            this.Submit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Submit.Location = new System.Drawing.Point(11, 214);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 30);
            this.Submit.TabIndex = 0;
            this.Submit.Text = "Simpan";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(-4, 19);
            this.label1.MaximumSize = new System.Drawing.Size(300, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jumlah";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Pemasukkan
            // 
            this.Pemasukkan.AutoSize = true;
            this.Pemasukkan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pemasukkan.ForeColor = System.Drawing.Color.Silver;
            this.Pemasukkan.Location = new System.Drawing.Point(11, 102);
            this.Pemasukkan.Name = "Pemasukkan";
            this.Pemasukkan.Size = new System.Drawing.Size(97, 17);
            this.Pemasukkan.TabIndex = 3;
            this.Pemasukkan.TabStop = true;
            this.Pemasukkan.Text = "Pemasukkan";
            this.Pemasukkan.UseVisualStyleBackColor = true;
            // 
            // Pengeluaran
            // 
            this.Pengeluaran.AutoSize = true;
            this.Pengeluaran.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pengeluaran.ForeColor = System.Drawing.Color.Silver;
            this.Pengeluaran.Location = new System.Drawing.Point(114, 102);
            this.Pengeluaran.Name = "Pengeluaran";
            this.Pengeluaran.Size = new System.Drawing.Size(96, 17);
            this.Pengeluaran.TabIndex = 4;
            this.Pengeluaran.TabStop = true;
            this.Pengeluaran.Text = "Pengeluaran";
            this.Pengeluaran.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(3, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Deskripsi";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Deskripsi
            // 
            this.Deskripsi.BackColor = System.Drawing.Color.Silver;
            this.Deskripsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deskripsi.ForeColor = System.Drawing.Color.Black;
            this.Deskripsi.Location = new System.Drawing.Point(88, 151);
            this.Deskripsi.Name = "Deskripsi";
            this.Deskripsi.Size = new System.Drawing.Size(374, 22);
            this.Deskripsi.TabIndex = 7;
            // 
            // Jumlah
            // 
            this.Jumlah.BackColor = System.Drawing.Color.LightGray;
            this.Jumlah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jumlah.ForeColor = System.Drawing.Color.Black;
            this.Jumlah.Location = new System.Drawing.Point(88, 25);
            this.Jumlah.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.Jumlah.Name = "Jumlah";
            this.Jumlah.Size = new System.Drawing.Size(374, 22);
            this.Jumlah.TabIndex = 8;
            this.Jumlah.ThousandsSeparator = true;
            // 
            // Tipe
            // 
            this.Tipe.AutoSize = true;
            this.Tipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tipe.ForeColor = System.Drawing.Color.Silver;
            this.Tipe.Location = new System.Drawing.Point(12, 73);
            this.Tipe.Name = "Tipe";
            this.Tipe.Size = new System.Drawing.Size(40, 16);
            this.Tipe.TabIndex = 9;
            this.Tipe.Text = "Tipe";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 302);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(553, 313);
            this.dataGridView1.TabIndex = 10;
            // 
            // TanggalDari
            // 
            this.TanggalDari.CalendarForeColor = System.Drawing.Color.CornflowerBlue;
            this.TanggalDari.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TanggalDari.Location = new System.Drawing.Point(830, 69);
            this.TanggalDari.Name = "TanggalDari";
            this.TanggalDari.Size = new System.Drawing.Size(202, 20);
            this.TanggalDari.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(7, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Data";
            // 
            // TanggalSampai
            // 
            this.TanggalSampai.Location = new System.Drawing.Point(830, 117);
            this.TanggalSampai.Name = "TanggalSampai";
            this.TanggalSampai.Size = new System.Drawing.Size(202, 20);
            this.TanggalSampai.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(730, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(705, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Dari tanggal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(705, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Sampai tanggal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(705, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Pemasukkan :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(705, 292);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Pengeluaran :";
            // 
            // Selisih
            // 
            this.Selisih.BackColor = System.Drawing.Color.Silver;
            this.Selisih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Selisih.FormattingEnabled = true;
            this.Selisih.ItemHeight = 20;
            this.Selisih.Location = new System.Drawing.Point(830, 424);
            this.Selisih.Name = "Selisih";
            this.Selisih.Size = new System.Drawing.Size(202, 24);
            this.Selisih.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Silver;
            this.label10.Location = new System.Drawing.Point(969, 393);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "Selisih :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Terapkan
            // 
            this.Terapkan.BackColor = System.Drawing.Color.SteelBlue;
            this.Terapkan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Terapkan.Location = new System.Drawing.Point(960, 164);
            this.Terapkan.Name = "Terapkan";
            this.Terapkan.Size = new System.Drawing.Size(72, 27);
            this.Terapkan.TabIndex = 24;
            this.Terapkan.Text = "Terapkan";
            this.Terapkan.UseVisualStyleBackColor = false;
            this.Terapkan.Click += new System.EventHandler(this.Terapkan_Click);
            // 
            // TotalPengeluaran
            // 
            this.TotalPengeluaran.BackColor = System.Drawing.Color.Silver;
            this.TotalPengeluaran.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPengeluaran.FormattingEnabled = true;
            this.TotalPengeluaran.ItemHeight = 16;
            this.TotalPengeluaran.Location = new System.Drawing.Point(830, 291);
            this.TotalPengeluaran.Name = "TotalPengeluaran";
            this.TotalPengeluaran.Size = new System.Drawing.Size(202, 20);
            this.TotalPengeluaran.TabIndex = 21;
            // 
            // TotalPemasukkan
            // 
            this.TotalPemasukkan.BackColor = System.Drawing.Color.Silver;
            this.TotalPemasukkan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPemasukkan.FormattingEnabled = true;
            this.TotalPemasukkan.ItemHeight = 16;
            this.TotalPemasukkan.Location = new System.Drawing.Point(830, 230);
            this.TotalPemasukkan.Name = "TotalPemasukkan";
            this.TotalPemasukkan.Size = new System.Drawing.Size(202, 20);
            this.TotalPemasukkan.TabIndex = 18;
            this.TotalPemasukkan.SelectedIndexChanged += new System.EventHandler(this.TotalPemasukkan_SelectedIndexChanged);
            // 
            // Hapus
            // 
            this.Hapus.BackColor = System.Drawing.Color.SteelBlue;
            this.Hapus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Hapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hapus.Location = new System.Drawing.Point(484, 634);
            this.Hapus.Name = "Hapus";
            this.Hapus.Size = new System.Drawing.Size(75, 31);
            this.Hapus.TabIndex = 25;
            this.Hapus.Text = "HapusData";
            this.Hapus.UseVisualStyleBackColor = false;
            this.Hapus.Click += new System.EventHandler(this.Hapus_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Silver;
            this.label11.Location = new System.Drawing.Point(3, 618);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(436, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Silahkan pilih data yang ingin anda hapus dari data yang di atas lalu klik tombol" +
    " HapusData";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1040, 709);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Hapus);
            this.Controls.Add(this.Terapkan);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Selisih);
            this.Controls.Add(this.TotalPengeluaran);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TotalPemasukkan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TanggalSampai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TanggalDari);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Tipe);
            this.Controls.Add(this.Jumlah);
            this.Controls.Add(this.Deskripsi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Pengeluaran);
            this.Controls.Add(this.Pemasukkan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Submit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Jumlah)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Pemasukkan;
        private System.Windows.Forms.RadioButton Pengeluaran;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Deskripsi;
        private System.Windows.Forms.NumericUpDown Jumlah;
        private System.Windows.Forms.Label Tipe;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker TanggalDari;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker TanggalSampai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox Selisih;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Terapkan;
        private System.Windows.Forms.ListBox TotalPengeluaran;
        private System.Windows.Forms.ListBox TotalPemasukkan;
        private System.Windows.Forms.Button Hapus;
        private System.Windows.Forms.Label label11;
    }
}

