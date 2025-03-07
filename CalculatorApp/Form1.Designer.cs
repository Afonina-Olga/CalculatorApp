namespace CalculatorApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			btnClear = new Button();
			txtResult = new RichTextBox();
			txtDisplay = new TextBox();
			btnBack = new Button();
			btnSign = new Button();
			btnPlus = new Button();
			btn7 = new Button();
			btn8 = new Button();
			btn9 = new Button();
			btnMinus = new Button();
			btn4 = new Button();
			btn5 = new Button();
			btn6 = new Button();
			btnMultiply = new Button();
			btn1 = new Button();
			btn2 = new Button();
			btn3 = new Button();
			btnDivision = new Button();
			btn0 = new Button();
			btnSeparator = new Button();
			btnCalculate = new Button();
			txtStep = new TextBox();
			SuspendLayout();
			// 
			// btnClear
			// 
			btnClear.Location = new Point(33, 96);
			btnClear.Name = "btnClear";
			btnClear.Size = new Size(70, 50);
			btnClear.TabIndex = 0;
			btnClear.Text = "C";
			btnClear.UseVisualStyleBackColor = true;
			btnClear.Click += BtnClear_Click;
			// 
			// txtResult
			// 
			txtResult.Location = new Point(361, 41);
			txtResult.Name = "txtResult";
			txtResult.Size = new Size(283, 337);
			txtResult.TabIndex = 1;
			txtResult.Text = "";
			// 
			// txtDisplay
			// 
			txtDisplay.BackColor = SystemColors.Window;
			txtDisplay.BorderStyle = BorderStyle.FixedSingle;
			txtDisplay.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
			txtDisplay.Location = new Point(33, 41);
			txtDisplay.Multiline = true;
			txtDisplay.Name = "txtDisplay";
			txtDisplay.ReadOnly = true;
			txtDisplay.RightToLeft = RightToLeft.No;
			txtDisplay.Size = new Size(311, 40);
			txtDisplay.TabIndex = 2;
			txtDisplay.TextAlign = HorizontalAlignment.Right;
			// 
			// btnBack
			// 
			btnBack.Location = new Point(113, 96);
			btnBack.Name = "btnBack";
			btnBack.Size = new Size(70, 50);
			btnBack.TabIndex = 0;
			btnBack.Text = "<-";
			btnBack.UseVisualStyleBackColor = true;
			btnBack.Click += BtnBack_Click;
			// 
			// btnSign
			// 
			btnSign.Location = new Point(193, 96);
			btnSign.Name = "btnSign";
			btnSign.Size = new Size(70, 50);
			btnSign.TabIndex = 0;
			btnSign.Text = "+/-";
			btnSign.UseVisualStyleBackColor = true;
			btnSign.Click += BtnSign_Click;
			// 
			// btnPlus
			// 
			btnPlus.Location = new Point(273, 96);
			btnPlus.Name = "btnPlus";
			btnPlus.Size = new Size(70, 50);
			btnPlus.TabIndex = 0;
			btnPlus.Text = "+";
			btnPlus.UseVisualStyleBackColor = true;
			btnPlus.Click += BtnPlus_Click;
			// 
			// btn7
			// 
			btn7.Location = new Point(33, 152);
			btn7.Name = "btn7";
			btn7.Size = new Size(70, 50);
			btn7.TabIndex = 0;
			btn7.Text = "7";
			btn7.UseVisualStyleBackColor = true;
			btn7.Click += Btn7_Click;
			// 
			// btn8
			// 
			btn8.Location = new Point(113, 154);
			btn8.Name = "btn8";
			btn8.Size = new Size(70, 50);
			btn8.TabIndex = 0;
			btn8.Text = "8";
			btn8.UseVisualStyleBackColor = true;
			btn8.Click += Btn8_Click;
			// 
			// btn9
			// 
			btn9.Location = new Point(193, 154);
			btn9.Name = "btn9";
			btn9.Size = new Size(70, 50);
			btn9.TabIndex = 0;
			btn9.Text = "9";
			btn9.UseVisualStyleBackColor = true;
			btn9.Click += Btn9_Click;
			// 
			// btnMinus
			// 
			btnMinus.Location = new Point(273, 154);
			btnMinus.Name = "btnMinus";
			btnMinus.Size = new Size(70, 50);
			btnMinus.TabIndex = 0;
			btnMinus.Text = "-";
			btnMinus.UseVisualStyleBackColor = true;
			btnMinus.Click += BtnMinus_Click;
			// 
			// btn4
			// 
			btn4.Location = new Point(33, 211);
			btn4.Name = "btn4";
			btn4.Size = new Size(70, 50);
			btn4.TabIndex = 0;
			btn4.Text = "4";
			btn4.UseVisualStyleBackColor = true;
			btn4.Click += Btn4_Click;
			// 
			// btn5
			// 
			btn5.Location = new Point(113, 212);
			btn5.Name = "btn5";
			btn5.Size = new Size(70, 50);
			btn5.TabIndex = 0;
			btn5.Text = "5";
			btn5.UseVisualStyleBackColor = true;
			btn5.Click += Btn5_Click;
			// 
			// btn6
			// 
			btn6.Location = new Point(193, 212);
			btn6.Name = "btn6";
			btn6.Size = new Size(70, 50);
			btn6.TabIndex = 0;
			btn6.Text = "6";
			btn6.UseVisualStyleBackColor = true;
			btn6.Click += Btn6_Click;
			// 
			// btnMultiply
			// 
			btnMultiply.Location = new Point(273, 212);
			btnMultiply.Name = "btnMultiply";
			btnMultiply.Size = new Size(70, 50);
			btnMultiply.TabIndex = 0;
			btnMultiply.Text = "*";
			btnMultiply.UseVisualStyleBackColor = true;
			btnMultiply.Click += BtnMultiply_Click;
			// 
			// btn1
			// 
			btn1.Location = new Point(33, 270);
			btn1.Name = "btn1";
			btn1.Size = new Size(70, 50);
			btn1.TabIndex = 0;
			btn1.Text = "1";
			btn1.UseVisualStyleBackColor = true;
			btn1.Click += Btn1_Click;
			// 
			// btn2
			// 
			btn2.Location = new Point(113, 270);
			btn2.Name = "btn2";
			btn2.Size = new Size(70, 50);
			btn2.TabIndex = 0;
			btn2.Text = "2";
			btn2.UseVisualStyleBackColor = true;
			btn2.Click += Btn2_Click;
			// 
			// btn3
			// 
			btn3.Location = new Point(193, 270);
			btn3.Name = "btn3";
			btn3.Size = new Size(70, 50);
			btn3.TabIndex = 0;
			btn3.Text = "3";
			btn3.UseVisualStyleBackColor = true;
			btn3.Click += Btn3_Click;
			// 
			// btnDivision
			// 
			btnDivision.Location = new Point(273, 270);
			btnDivision.Name = "btnDivision";
			btnDivision.Size = new Size(70, 50);
			btnDivision.TabIndex = 0;
			btnDivision.Text = "/";
			btnDivision.UseVisualStyleBackColor = true;
			btnDivision.Click += BtnDivision_Click;
			// 
			// btn0
			// 
			btn0.Location = new Point(33, 329);
			btn0.Name = "btn0";
			btn0.Size = new Size(70, 50);
			btn0.TabIndex = 0;
			btn0.Text = "0";
			btn0.UseVisualStyleBackColor = true;
			btn0.Click += Btn0_Click;
			// 
			// btnSeparator
			// 
			btnSeparator.Location = new Point(113, 328);
			btnSeparator.Name = "btnSeparator";
			btnSeparator.Size = new Size(70, 50);
			btnSeparator.TabIndex = 0;
			btnSeparator.Text = ".";
			btnSeparator.UseVisualStyleBackColor = true;
			btnSeparator.Click += BtnSeparator_Click;
			// 
			// btnCalculate
			// 
			btnCalculate.Location = new Point(192, 328);
			btnCalculate.Name = "btnCalculate";
			btnCalculate.Size = new Size(151, 50);
			btnCalculate.TabIndex = 0;
			btnCalculate.Text = "=";
			btnCalculate.UseVisualStyleBackColor = true;
			btnCalculate.Click += BtnCalculate_Click;
			// 
			// txtStep
			// 
			txtStep.BorderStyle = BorderStyle.None;
			txtStep.Location = new Point(33, 1);
			txtStep.Multiline = true;
			txtStep.Name = "txtStep";
			txtStep.ReadOnly = true;
			txtStep.Size = new Size(310, 34);
			txtStep.TabIndex = 3;
			txtStep.TextAlign = HorizontalAlignment.Right;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(676, 415);
			Controls.Add(txtStep);
			Controls.Add(txtDisplay);
			Controls.Add(txtResult);
			Controls.Add(btnDivision);
			Controls.Add(btnMultiply);
			Controls.Add(btnMinus);
			Controls.Add(btnPlus);
			Controls.Add(btnCalculate);
			Controls.Add(btnSeparator);
			Controls.Add(btn3);
			Controls.Add(btn2);
			Controls.Add(btn6);
			Controls.Add(btn5);
			Controls.Add(btn0);
			Controls.Add(btn9);
			Controls.Add(btn1);
			Controls.Add(btn8);
			Controls.Add(btn4);
			Controls.Add(btnSign);
			Controls.Add(btn7);
			Controls.Add(btnBack);
			Controls.Add(btnClear);
			Name = "Form1";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Калькулятор";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnClear;
		private RichTextBox txtResult;
		private TextBox txtDisplay;
		private Button btnBack;
		private Button btnSign;
		private Button btnPlus;
		private Button btn7;
		private Button btn8;
		private Button btn9;
		private Button btnMinus;
		private Button btn4;
		private Button btn5;
		private Button btn6;
		private Button btnMultiply;
		private Button btn1;
		private Button btn2;
		private Button btn3;
		private Button btnDivision;
		private Button btn0;
		private Button btnSeparator;
		private Button btnCalculate;
		private TextBox txtStep;
	}
}
