namespace CourseWork_FEP
{
	partial class Form3
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// richTextBox1
			// 
			this.richTextBox1.BackColor = System.Drawing.SystemColors.Menu;
			this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.richTextBox1.ForeColor = System.Drawing.Color.Black;
			this.richTextBox1.Location = new System.Drawing.Point(13, 13);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ReadOnly = true;
			this.richTextBox1.Size = new System.Drawing.Size(854, 220);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.TabStop = false;
			this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.linkLabel1.LinkColor = System.Drawing.Color.DodgerBlue;
			this.linkLabel1.Location = new System.Drawing.Point(10, 236);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(414, 16);
			this.linkLabel1.TabIndex = 1;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "По всем вопросам обращаться на почту: dobro9179@gmail.com\r\n";
			this.linkLabel1.Click += new System.EventHandler(this.linkLabel1_Click);
			// 
			// button1
			// 
			this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button1.Location = new System.Drawing.Point(382, 272);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(108, 25);
			this.button1.TabIndex = 2;
			this.button1.Text = "OK";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.button1;
			this.ClientSize = new System.Drawing.Size(884, 309);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.richTextBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(900, 350);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(900, 350);
			this.Name = "Form3";
			this.Text = "Form3";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Button button1;
	}
}