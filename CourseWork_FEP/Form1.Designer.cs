namespace CourseWork_FEP
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Location = new System.Drawing.Point(522, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(150, 291);
			this.button1.TabIndex = 0;
			this.button1.Text = "Вычисления";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.BackColor = System.Drawing.Color.White;
			this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.button2.ForeColor = System.Drawing.Color.Black;
			this.button2.Location = new System.Drawing.Point(522, 309);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(150, 38);
			this.button2.TabIndex = 1;
			this.button2.Text = "Помощь";
			this.button2.UseVisualStyleBackColor = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(324, 25);
			this.label1.TabIndex = 2;
			this.label1.Text = "Елисова Виктория Ивановна";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(14, 87);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(401, 90);
			this.label2.TabIndex = 3;
			this.label2.Text = "При проектировании фотоэлектрического \r\nпреобразователя (солнечной батареи) \r\nс м" +
    "аксимальным коэффициентом полезного действия \r\nпо энергоотдаче необходимо \r\nреши" +
    "ть следующее уравнение:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(14, 267);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(464, 72);
			this.label3.TabIndex = 4;
			this.label3.Text = "при Т = 300 К (КТ/е = 0,0259 В) и =2*10^10 (отношение плотности \r\nтока короткого " +
    "замыкания к плотности тока насыщения). \r\nНайти оптимальное напряжение, используя" +
    " метод Ньютона. \r\nПостроить график.\r\n";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(17, 190);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(212, 63);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(12, 46);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(114, 25);
			this.label4.TabIndex = 6;
			this.label4.Text = "Вариант 7";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(684, 359);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.MaximumSize = new System.Drawing.Size(700, 400);
			this.MinimumSize = new System.Drawing.Size(700, 400);
			this.Name = "Form1";
			this.Text = "Main";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label4;
	}
}

