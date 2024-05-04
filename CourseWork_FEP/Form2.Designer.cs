namespace CourseWork_FEP
{
	partial class Form2
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
			this.назадToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox1.Location = new System.Drawing.Point(228, 84);
			this.textBox1.MaxLength = 5;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(131, 22);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "9";
			this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Control_KeyPress);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(9, 78);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(191, 32);
			this.label1.TabIndex = 1;
			this.label1.Text = "Начальное предположение \r\nдля напряжения";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(9, 237);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(184, 32);
			this.label2.TabIndex = 3;
			this.label2.Text = "Максимальное количество\r\nитераций";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBox4
			// 
			this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox4.Location = new System.Drawing.Point(228, 243);
			this.textBox4.Margin = new System.Windows.Forms.Padding(10);
			this.textBox4.MaxLength = 5;
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(131, 22);
			this.textBox4.TabIndex = 2;
			this.textBox4.Text = "1000";
			this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button1.Location = new System.Drawing.Point(12, 444);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(80, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "Назад";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.BackColor = System.Drawing.Color.White;
			this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.button2.ForeColor = System.Drawing.Color.Black;
			this.button2.Location = new System.Drawing.Point(552, 427);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(150, 40);
			this.button2.TabIndex = 5;
			this.button2.Text = "Помощь";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.openHelp);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(12, 28);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(347, 30);
			this.button3.TabIndex = 6;
			this.button3.Text = "Загрузить значения\r\n";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.buttonLoad_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(12, 317);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(96, 82);
			this.button4.TabIndex = 7;
			this.button4.Text = "Вычислить";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(114, 404);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(245, 29);
			this.button5.TabIndex = 8;
			this.button5.Text = "Сохранить результат\r\n";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.SaveDataButton_Click);
			// 
			// chart1
			// 
			this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			chartArea1.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea1);
			legend1.Enabled = false;
			legend1.Name = "Legend1";
			this.chart1.Legends.Add(legend1);
			this.chart1.Location = new System.Drawing.Point(384, 28);
			this.chart1.Name = "chart1";
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			this.chart1.Series.Add(series1);
			this.chart1.Size = new System.Drawing.Size(318, 371);
			this.chart1.TabIndex = 11;
			this.chart1.Text = "chart1";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(9, 132);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(182, 32);
			this.label5.TabIndex = 13;
			this.label5.Text = "Конечное предположение \r\nдля напряжения";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox2.Location = new System.Drawing.Point(228, 138);
			this.textBox2.MaxLength = 5;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(131, 22);
			this.textBox2.TabIndex = 12;
			this.textBox2.Text = "14";
			this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Control_KeyPress);
			// 
			// listBox1
			// 
			this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 15;
			this.listBox1.Location = new System.Drawing.Point(114, 317);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(245, 79);
			this.listBox1.TabIndex = 14;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(9, 194);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(189, 16);
			this.label3.TabIndex = 16;
			this.label3.Text = "Шаг изменения напряжения";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBox3
			// 
			this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox3.Location = new System.Drawing.Point(228, 194);
			this.textBox3.MaxLength = 5;
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(131, 22);
			this.textBox3.TabIndex = 15;
			this.textBox3.Text = "1";
			this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Control_KeyPress);
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripButton1});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(714, 25);
			this.toolStrip1.TabIndex = 17;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripDropDownButton1
			// 
			this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.назадToolStripMenuItem,
            this.выйтиToolStripMenuItem});
			this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
			this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
			this.toolStripDropDownButton1.Size = new System.Drawing.Size(59, 22);
			this.toolStripDropDownButton1.Text = "Меню";
			// 
			// назадToolStripMenuItem
			// 
			this.назадToolStripMenuItem.Name = "назадToolStripMenuItem";
			this.назадToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
			this.назадToolStripMenuItem.Text = "Назад";
			this.назадToolStripMenuItem.Click += new System.EventHandler(this.button1_Click);
			// 
			// выйтиToolStripMenuItem
			// 
			this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
			this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
			this.выйтиToolStripMenuItem.Text = "Выйти";
			this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(64, 22);
			this.toolStripButton1.Text = "Помощь";
			this.toolStripButton1.Click += new System.EventHandler(this.openHelp);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(714, 479);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.chart1);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(730, 520);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(730, 520);
			this.Name = "Form2";
			this.Text = "Form2";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
		private System.Windows.Forms.ToolStripMenuItem назадToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
	}
}