namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.openBracket = new System.Windows.Forms.Button();
            this.closeBracket = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.multiple = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.pow = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox1.Location = new System.Drawing.Point(33, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(258, 30);
            this.textBox1.TabIndex = 0;
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(33, 139);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(55, 55);
            this.seven.TabIndex = 1;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(101, 139);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(55, 55);
            this.eight.TabIndex = 2;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(167, 139);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(55, 55);
            this.nine.TabIndex = 3;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(33, 207);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(55, 55);
            this.four.TabIndex = 4;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(101, 207);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(55, 55);
            this.five.TabIndex = 5;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(167, 207);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(55, 55);
            this.six.TabIndex = 6;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(33, 275);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(55, 55);
            this.one.TabIndex = 7;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(101, 275);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(55, 55);
            this.two.TabIndex = 8;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(167, 275);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(55, 55);
            this.three.TabIndex = 9;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(33, 343);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(55, 55);
            this.zero.TabIndex = 10;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // openBracket
            // 
            this.openBracket.Location = new System.Drawing.Point(33, 68);
            this.openBracket.Name = "openBracket";
            this.openBracket.Size = new System.Drawing.Size(55, 55);
            this.openBracket.TabIndex = 11;
            this.openBracket.Text = "(";
            this.openBracket.UseVisualStyleBackColor = true;
            this.openBracket.Click += new System.EventHandler(this.openBracket_Click);
            // 
            // closeBracket
            // 
            this.closeBracket.Enabled = false;
            this.closeBracket.Location = new System.Drawing.Point(101, 68);
            this.closeBracket.Name = "closeBracket";
            this.closeBracket.Size = new System.Drawing.Size(55, 55);
            this.closeBracket.TabIndex = 12;
            this.closeBracket.Text = ")";
            this.closeBracket.UseVisualStyleBackColor = true;
            this.closeBracket.Click += new System.EventHandler(this.closeBracket_Click);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(167, 68);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(55, 55);
            this.plus.TabIndex = 13;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(236, 68);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(55, 55);
            this.minus.TabIndex = 14;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // multiple
            // 
            this.multiple.Location = new System.Drawing.Point(236, 139);
            this.multiple.Name = "multiple";
            this.multiple.Size = new System.Drawing.Size(55, 55);
            this.multiple.TabIndex = 15;
            this.multiple.Text = "*";
            this.multiple.UseVisualStyleBackColor = true;
            this.multiple.Click += new System.EventHandler(this.multiple_Click);
            // 
            // division
            // 
            this.division.Location = new System.Drawing.Point(236, 207);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(55, 55);
            this.division.TabIndex = 16;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.division_Click);
            // 
            // pow
            // 
            this.pow.Location = new System.Drawing.Point(236, 275);
            this.pow.Name = "pow";
            this.pow.Size = new System.Drawing.Size(55, 55);
            this.pow.TabIndex = 17;
            this.pow.Text = "^";
            this.pow.UseVisualStyleBackColor = true;
            this.pow.Click += new System.EventHandler(this.pow_Click);
            // 
            // equals
            // 
            this.equals.Location = new System.Drawing.Point(167, 343);
            this.equals.Name = "equals";
            this.equals.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.equals.Size = new System.Drawing.Size(124, 55);
            this.equals.TabIndex = 18;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = true;
            this.equals.Click += new System.EventHandler(this.equals_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 408);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.pow);
            this.Controls.Add(this.division);
            this.Controls.Add(this.multiple);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.closeBracket);
            this.Controls.Add(this.openBracket);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button openBracket;
        private System.Windows.Forms.Button closeBracket;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button multiple;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button pow;
        private System.Windows.Forms.Button equals;
    }
}

