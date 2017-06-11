namespace _123301034
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownnpop = new System.Windows.Forms.NumericUpDown();
            this.numericUpDowncaprazlama = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownmutasyon_oranı = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownjenerasyon_sayısı = new System.Windows.Forms.NumericUpDown();
            this.buttonbasla = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownnpop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowncaprazlama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownmutasyon_oranı)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownjenerasyon_sayısı)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(301, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "EGGHOLDER FUNCTION";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(460, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title1.Name = "EGGHOLDER FUNCTION YAKINSAMA GRAFİĞİ";
            this.chart1.Titles.Add(title1);
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(30, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mutasyon Oranı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = " Çaprazlama Oranı :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(12, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "Jenerasyon Sayısı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(4, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = " Popülasyon Boyutu :";
            // 
            // numericUpDownnpop
            // 
            this.numericUpDownnpop.Location = new System.Drawing.Point(143, 40);
            this.numericUpDownnpop.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownnpop.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownnpop.Name = "numericUpDownnpop";
            this.numericUpDownnpop.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownnpop.TabIndex = 8;
            this.numericUpDownnpop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownnpop.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDowncaprazlama
            // 
            this.numericUpDowncaprazlama.DecimalPlaces = 1;
            this.numericUpDowncaprazlama.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDowncaprazlama.Location = new System.Drawing.Point(143, 66);
            this.numericUpDowncaprazlama.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDowncaprazlama.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDowncaprazlama.Name = "numericUpDowncaprazlama";
            this.numericUpDowncaprazlama.Size = new System.Drawing.Size(120, 20);
            this.numericUpDowncaprazlama.TabIndex = 8;
            this.numericUpDowncaprazlama.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDowncaprazlama.Value = new decimal(new int[] {
            7,
            0,
            0,
            65536});
            // 
            // numericUpDownmutasyon_oranı
            // 
            this.numericUpDownmutasyon_oranı.DecimalPlaces = 3;
            this.numericUpDownmutasyon_oranı.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDownmutasyon_oranı.Location = new System.Drawing.Point(143, 92);
            this.numericUpDownmutasyon_oranı.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDownmutasyon_oranı.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDownmutasyon_oranı.Name = "numericUpDownmutasyon_oranı";
            this.numericUpDownmutasyon_oranı.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownmutasyon_oranı.TabIndex = 8;
            this.numericUpDownmutasyon_oranı.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownmutasyon_oranı.Value = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            // 
            // numericUpDownjenerasyon_sayısı
            // 
            this.numericUpDownjenerasyon_sayısı.Location = new System.Drawing.Point(143, 118);
            this.numericUpDownjenerasyon_sayısı.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownjenerasyon_sayısı.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownjenerasyon_sayısı.Name = "numericUpDownjenerasyon_sayısı";
            this.numericUpDownjenerasyon_sayısı.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownjenerasyon_sayısı.TabIndex = 8;
            this.numericUpDownjenerasyon_sayısı.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownjenerasyon_sayısı.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // buttonbasla
            // 
            this.buttonbasla.Location = new System.Drawing.Point(15, 191);
            this.buttonbasla.Name = "buttonbasla";
            this.buttonbasla.Size = new System.Drawing.Size(75, 23);
            this.buttonbasla.TabIndex = 9;
            this.buttonbasla.Text = "ÇÖZ";
            this.buttonbasla.UseVisualStyleBackColor = true;
            this.buttonbasla.Click += new System.EventHandler(this.buttonbasla_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 346);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(165, 303);
            this.listBox1.TabIndex = 10;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(208, 346);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(165, 303);
            this.listBox2.TabIndex = 10;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(402, 346);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(165, 303);
            this.listBox3.TabIndex = 10;
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(596, 346);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(165, 303);
            this.listBox4.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "En Son Oluşan Duruma Göre : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(9, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = " İlk Oluşan Jenerasyon";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(205, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Sıralanmış Hali";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(399, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Sıralanmış Hali";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(399, 315);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 15);
            this.label10.TabIndex = 11;
            this.label10.Text = "Çaprazlama Sonucu";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(593, 330);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 15);
            this.label11.TabIndex = 11;
            this.label11.Text = "Sıralanmış Hali";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(593, 315);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 15);
            this.label12.TabIndex = 11;
            this.label12.Text = "Mutasyon Sonucu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 655);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonbasla);
            this.Controls.Add(this.numericUpDownmutasyon_oranı);
            this.Controls.Add(this.numericUpDowncaprazlama);
            this.Controls.Add(this.numericUpDownjenerasyon_sayısı);
            this.Controls.Add(this.numericUpDownnpop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownnpop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowncaprazlama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownmutasyon_oranı)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownjenerasyon_sayısı)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownnpop;
        private System.Windows.Forms.NumericUpDown numericUpDowncaprazlama;
        private System.Windows.Forms.NumericUpDown numericUpDownmutasyon_oranı;
        private System.Windows.Forms.NumericUpDown numericUpDownjenerasyon_sayısı;
        private System.Windows.Forms.Button buttonbasla;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

