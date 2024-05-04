using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork_FEP
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			// Создаем новую форму
			Form2 from2 = new Form2(this);

			// Скрываем текущую (основную) форму
			this.Hide();

			// Отображаем новую форму
			from2.Show();
		}

		private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void openHelp(object sender, EventArgs e)
		{
			Form3 form3 = new Form3();
			form3.Show();
		}
	}
}
