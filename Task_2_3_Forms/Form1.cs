using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_2_3_Forms
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			textBox1.Text = "";
			textBox2.Text = "";
		}

		private void button2_Click(object sender, EventArgs e)
		{
			textBox2.Text = "";

			double metrOnDum = 25.4;
			int d;

			try
			{
				d = Convert.ToInt32(textBox1.Text);

				if (d <= 0)
				{
					textBox2.Text = "Кол-во чисел не может быть меньше или равно 0";
					return;
				}

				textBox2.Text += "Дюймы (четные числа)\r\n";
				for (int j = 2; j <= d; j += 2)
				{
					textBox2.Text += j + "\t";
				}

				textBox2.Text +="\r\n";
				textBox2.Text += "For: \r\n";
				for (int j = 2; j <= d; j += 2)
				{
					textBox2.Text += String.Format("{0:f1}\t", j * metrOnDum);
				}

				textBox2.Text += "\r\n";
				textBox2.Text += "While: \r\n";

				int i = 2;
				while (i <= d)
				{
					textBox2.Text += String.Format("{0:f1}\t", i * metrOnDum);
					i += 2;
				}

				textBox2.Text += "\r\n";
				textBox2.Text += "DoWhile: \r\n";
				i = 2;

				do
				{
					textBox2.Text += String.Format("{0:f1}\t", i * metrOnDum);
					i += 2;
				} while (i <= d);
			} catch
			{
				textBox2.Text = "Число должно быть целым";
			}
		}
	}
}
