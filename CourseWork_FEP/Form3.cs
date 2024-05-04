using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork_FEP
{
	public partial class Form3 : Form
	{
		public Form3()
		{
			InitializeComponent();
		}

		private void linkLabel1_Click(object sender, EventArgs e)
		{
			// Получение адреса электронной почты из Label
			string emailAddress = linkLabel1.Text;

			// Запуск программы почты с указанием адреса в качестве получателя
			Process.Start("mailto:" + emailAddress);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
