using System.Globalization;

namespace CalculatorApp
{
	public partial class Form1 : Form
	{
		private decimal value1;
		private decimal value2;
		private decimal result;
		private string? operation;
		private bool needClear = false;
		private bool sameValue = false;

		public Form1()
		{
			InitializeComponent();
		}

		#region Digits

		private void Btn7_Click(object sender, EventArgs e)
		{
			ClearDisplay();
			RemoveZero(txtDisplay);
			txtDisplay.Text += "7";
			sameValue = false;
		}

		private void Btn8_Click(object sender, EventArgs e)
		{
			ClearDisplay();
			RemoveZero(txtDisplay);
			txtDisplay.Text += "8";
			sameValue = false;
		}

		private void Btn9_Click(object sender, EventArgs e)
		{
			ClearDisplay();
			RemoveZero(txtDisplay);
			txtDisplay.Text += "9";
			sameValue = false;
		}

		private void Btn4_Click(object sender, EventArgs e)
		{
			ClearDisplay();
			RemoveZero(txtDisplay);
			txtDisplay.Text += "4";
			sameValue = false;
		}

		private void Btn5_Click(object sender, EventArgs e)
		{
			ClearDisplay();
			RemoveZero(txtDisplay);
			txtDisplay.Text += "5";
			sameValue = false;
		}

		private void Btn6_Click(object sender, EventArgs e)
		{
			ClearDisplay();
			RemoveZero(txtDisplay);
			txtDisplay.Text += "6";
			sameValue = false;
		}

		private void Btn1_Click(object sender, EventArgs e)
		{
			ClearDisplay();
			RemoveZero(txtDisplay);
			txtDisplay.Text += "1";
			sameValue = false;
		}

		private void Btn2_Click(object sender, EventArgs e)
		{
			ClearDisplay();
			RemoveZero(txtDisplay);
			txtDisplay.Text += "2";
			sameValue = false;
		}

		private void Btn3_Click(object sender, EventArgs e)
		{
			ClearDisplay();
			RemoveZero(txtDisplay);
			txtDisplay.Text += "3";
			sameValue = false;
		}

		#endregion

		private void BtnClear_Click(object sender, EventArgs e)
		{
			txtDisplay.Text = "";
			txtStep.Text = "";
			result = 0;
		}

		private void Btn0_Click(object sender, EventArgs e)
		{
			if (txtDisplay.Text != "0")
			{
				txtDisplay.Text += "0";
			}
		}

		private void BtnBack_Click(object sender, EventArgs e)
		{
			txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.TextLength - 1);
		}

		private void BtnSign_Click(object sender, EventArgs e)
		{

		}

		private void BtnPlus_Click(object sender, EventArgs e)
		{
			if (sameValue is false)
			{
				value1 = Convert.ToDecimal(txtDisplay.Text, CultureInfo.InvariantCulture);
				result += value1;
				txtStep.Text = result + " + ";
				needClear = true;
				sameValue = true;

				if (string.IsNullOrEmpty(txtDisplay.Text) is false && txtDisplay.Text.Last() == '.')
				{
					txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.TextLength - 1);
				}

				// Случай 2.0 => 2
				if (string.IsNullOrEmpty(txtDisplay.Text) is false && txtDisplay.Text.EndsWith(".0"))
				{
					txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.TextLength - 2);
				}
			}
		}

		private void BtnMinus_Click(object sender, EventArgs e)
		{

		}

		private void BtnMultiply_Click(object sender, EventArgs e)
		{

		}

		private void BtnDivision_Click(object sender, EventArgs e)
		{

		}

		private void BtnSeparator_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtDisplay.Text))
			{
				txtDisplay.Text += "0.";
			}
			else if (txtDisplay.Text == ".")
			{
				txtDisplay.Text = "0.";
			}
			else if (txtDisplay.Text.Contains('.') is false)
			{
				txtDisplay.Text += ".";
			}
		}

		private void BtnCalculate_Click(object sender, EventArgs e)
		{

		}

		private static void RemoveZero(TextBox textBox)
		{
			if (textBox.Text == "0")
			{
				textBox.Text = "";
			}
		}

		private void ClearDisplay()
		{
			if (needClear)
			{
				txtDisplay.Text = "";
				needClear = false;
			}
		}
	}
}
