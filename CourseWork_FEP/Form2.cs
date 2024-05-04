using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CourseWork_FEP
{
	public partial class Form2 : Form
	{
		// Константы, заданные в условии
		const double e = 1.6e-19;
		const double k = 8.617333262145e-5;
		const double T = 300;
		//const double J0 = k * T / e;
		const double Js = 2e10;

		// Ссылка на основную форму
		private Form1 mainForm;

		public Form2(Form1 mainForm)
		{
			InitializeComponent();
			this.mainForm = mainForm;
		}

		private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
		{
			char number = e.KeyChar;

			if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
			{
				e.Handled = true;
			}
		}

		private void Form2_FormClosed(object sender, FormClosedEventArgs e)
		{
			// Показываем основную форму перед закрытием второй формы
			mainForm.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();

			mainForm.Show();
		}

		//private void button4_Click(object sender, EventArgs e)
		//{
		//	try
		//	{
		//		double initialGuess = Convert.ToDouble(textBox1.Text);
		//		double endGuess = Convert.ToDouble(textBox3.Text);
		//		double step = Convert.ToDouble(textBox4.Text);
		//		int maxIter = Convert.ToInt32(textBox2.Text);

		//		// Очистим график перед построением нового
		//		chart1.Series.Clear();
		//		listBox1.Items.Clear();
		//		listBox1.ForeColor = Color.Black;

		//		// Создаем серию данных для графика
		//		Series series = new Series();
		//		series.ChartType = SeriesChartType.Line;

		//		for (double guess = initialGuess; guess <= endGuess; guess += step)
		//		{
		//			guess = Math.Round(guess, 2);
		//			double root = Newton(guess, maxIterations: maxIter);
		//			if (double.IsNaN(root))
		//				listBox1.Items.Add($"Корень не найден для значения {guess}");
		//			else
		//			{
		//				listBox1.Items.Add($"Корень {root.ToString("0.00E+0")} для значения {guess}");

		//				string exponent = root.ToString("0.00E+0").Substring(4);
		//				root = Convert.ToDouble(root.ToString("0.00E+0").Substring(0, 4));

		//				chart1.ChartAreas[0].AxisY.LabelStyle.Format = "0.00" + exponent;
		//				series.Points.AddXY(guess, root);
		//			}
		//		}

		//		// Добавляем серию данных на график
		//		chart1.Series.Add(series);
		//	}
		//	catch (Exception ex)
		//	{
		//		listBox1.ForeColor = Color.Red;
		//		listBox1.Items.Add(ex.Message);
		//	}
		//}

		// Функция f(V)

		private async void button4_Click(object sender, EventArgs e)
		{
			try
			{
				double initialGuess = Convert.ToDouble(textBox1.Text);
				double endGuess = Convert.ToDouble(textBox2.Text);
				double step = Convert.ToDouble(textBox3.Text);
				int maxIter = Convert.ToInt32(textBox4.Text);

				isDataValid(initialGuess, endGuess, step);

				// Очистим график перед построением нового
				chart1.Series.Clear();
				listBox1.Items.Clear();

				// Создаем серию данных для графика
				Series series = new Series();
				series.ChartType = SeriesChartType.Line;

				await Task.Run(() =>
				{
					for (double guess = initialGuess; guess <= endGuess; guess += step)
					{
						guess = Math.Round(guess, 4);
						double root = Newton(guess, maxIterations: maxIter);
						if (double.IsNaN(root))
						{
							listBox1.Invoke((MethodInvoker)(() => listBox1.Items.Add($"Корень НЕ найден для значения {guess}")));
						}
						else
						{
							string formattedRoot = root.ToString("0.00E+0");
							listBox1.Invoke((MethodInvoker)(() => listBox1.Items.Add($"{formattedRoot} корень для значения {guess}")));

							string exponent = formattedRoot.Substring(4);
							root = Convert.ToDouble(formattedRoot.Substring(0, 4));

							chart1.Invoke((MethodInvoker)(() => chart1.ChartAreas[0].AxisY.LabelStyle.Format = "0.00" + exponent));
							series.Points.AddXY(guess, root);
						}
					}
				});

				// Добавляем серию данных на график
				chart1.Invoke((MethodInvoker)(() => chart1.Series.Add(series)));
			}
			catch (Exception ex)
			{
				MessageBox.Show("Произошла ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		static double f(double V)
		{
			return (1 + e * V / (k * T)) * Math.Pow(e, e * V / (k * T)) - (1 + Js);
		}

		// Производная функции f(V)
		static double df(double V)
		{
			double exponent = Math.Exp(-e * V / (k * T));
			return -e * e * V / (k * k * T * T) * exponent + e / (k * T) * (1 - exponent);
		}

		// Метод Ньютона для нахождения корня
		static double Newton(double initialGuess, double tolerance = 1e-6, int maxIterations = 1000)
		{
			double V = initialGuess;
			for (int i = 0; i < maxIterations; i++)
			{
				double newValue = V - f(V) / df(V);
				if (Math.Abs(newValue - V) < tolerance)
				{
					return newValue;
				}
				V = newValue;
			}
			//throw new Exception("Не удалось найти корень с заданной точностью");
			return double.NaN;
		}

		private void Control_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Получаем TextBox, который вызвал событие
			TextBox textBox = sender as TextBox;

			// Получаем текущий текст в TextBox
			string text = textBox.Text;

			// Получаем введенный символ
			char inputChar = e.KeyChar;

			// Проверяем, является ли символ цифрой, минусом (если первым символом),
			// точкой или клавишей BackSpace
			if (Char.IsDigit(inputChar) ||
				(inputChar == '-' && text.Length == 0 && !text.Contains("-")) ||
				(inputChar == '.' && !text.Contains(".")) ||
				inputChar == 8) // Клавиша BackSpace
			{
				// Разрешаем ввод символа
				e.Handled = false;
			}
			else
			{
				// Запрещаем ввод символа
				e.Handled = true;
			}

		}

		private void isDataValid(double initialGuess, double endGuess, double step) {
			int maxItersLimit = 10_000;

			if (endGuess < initialGuess)
				throw new Exception("Начальное напряжение не может быть больше конечного.");
			else if (step < 0)
				throw new Exception("Шаг не может быть отрицательным.");
			else if (Math.Ceiling((endGuess - initialGuess) / step) + 1 > maxItersLimit)
				throw new Exception($"Разница между начальным и конечным напряжение с учетом шага не должна превышать {maxItersLimit}");

		}

		private void SaveDataButton_Click(object sender, EventArgs e)
		{
			try
			{
				if (listBox1.Items.Count < 1)
					throw new Exception("Вы не провели вычисления. Сохранять нечего.");
				
				// Создаем строку для сохранения данных
				StringBuilder dataToSave = new StringBuilder();

				dataToSave.AppendLine("Дата и время сохранения: " + DateTime.Now.ToString());

				// Добавляем данные из TextBox
				dataToSave.AppendLine("\nНачальное предположение для напряжения: " + textBox1.Text);
				dataToSave.AppendLine("Конечное предположение для напряжения: " + textBox4.Text);
				dataToSave.AppendLine("Шаг изменения напряжения: " + textBox2.Text);
				dataToSave.AppendLine("Максимальное количество итераций: " + textBox3.Text);

				// Добавляем данные из ListBox
				dataToSave.AppendLine("\nНайденые корни: ");
				foreach (string item in listBox1.Items) // Предполагается, что у вас есть ListBox с именем listBox1
				{
					dataToSave.AppendLine(item);
				}

				// Запрашиваем у пользователя путь для сохранения файла
				SaveFileDialog saveFileDialog = new SaveFileDialog();
				saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
				saveFileDialog.FilterIndex = 1;
				saveFileDialog.RestoreDirectory = true;

				saveFileDialog.FileName = $"result_{DateTime.Now.ToString("dd-MM-yyyy")}.txt";

				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					// Получаем выбранный пользователем путь к файлу
					string filePath = saveFileDialog.FileName;

					// Записываем данные в выбранный файл
					File.WriteAllText(filePath, dataToSave.ToString());

					// Показываем сообщение об успешном сохранении
					MessageBox.Show("Данные успешно сохранены.", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				// Показываем сообщение об ошибке, если что-то пошло не так
				MessageBox.Show("Ошибка при сохранении данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void buttonLoad_Click(object sender, EventArgs e)
		{
			// Вызываем диалоговое окно для выбора файла
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				// Получаем путь к выбранному файлу
				string filePath = openFileDialog.FileName;

				// Загружаем значения из файла
				LoadFromFile(filePath);
			}
		}

		private void LoadFromFile(string filePath)
		{
			try
			{
				// Проверяем, существует ли файл
				if (File.Exists(filePath))
				{
					// Читаем все строки из файла
					string[] lines = File.ReadAllLines(filePath);

					// Очищаем текстовые поля перед загрузкой новых значений
					listBox1.Items.Clear();

					List<string> nums = new List<string>();
					bool formatFlag = true;
					bool OKFlag = true;

					// Загружаем значения из файла в текстовое поле и список
					foreach (string line in lines)
					{
						if (!double.TryParse(line, out var n))
							formatFlag = false;

						nums.Add(line);
					}

					if (formatFlag)
					{
						for (int i = 0; i < nums.Count; i++)
						{
							if (nums[i].Length > 5)
								nums[i] = nums[i].Substring(0, 5);
							TextBox textBox = Controls.Find("textBox" + (i + 1), true).FirstOrDefault() as TextBox;
							if (textBox != null)
							{
								textBox.Text = nums[i];
								OKFlag = false;
							}
						}
						return;
					}

					List<TextBox> textBoxes = new List<TextBox>
					{
						textBox1,
						textBox2,
						textBox3,
						textBox4
					};
					List<string> subStrings = new List<string>
					{
						"Начальное предположение для напряжения: ",
						"Конечное предположение для напряжения: ",
						"Шаг изменения напряжения: ",
						"Максимальное количество итераций: "
					};

					for (int i = 0; i < nums.Count; i++)
					{
						string input = nums[i];
						for (int j = 0; j < subStrings.Count; j++)
						{
							string subString = subStrings[j];

							// Проверяем, содержит ли строка нужную подстроку
							if (input.Contains(subString))
							{
								// Получаем индекс начала подстроки
								int index = input.IndexOf(subString);

								// Выделяем подстроку с числом
								string numberString = input.Substring(index + subString.Length);

								if (numberString.Length > 5)
									numberString = numberString.Substring(0, 5);
								// Пытаемся преобразовать подстроку в число
								if (double.TryParse(numberString, out double number))
								{
									// Вставляем число в соответствующий текстбокс
									textBoxes[j].Text = number.ToString();
									OKFlag = false;
								}
							}
						}
					}
					if (OKFlag)
						throw new Exception("Неверный формат файла. Загрузка не выполнена.");
				}
				else
				{
					// Файл не существует, вы можете обработать это соответствующим образом
					MessageBox.Show("Файл не найден.");
				}
			}
			catch (Exception ex)
			{
				// Обработка ошибок, если что-то пошло не так
				MessageBox.Show($"Ошибка при чтении файла: {ex.Message}");
			}
		}

	}
}
