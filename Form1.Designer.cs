namespace Calculator
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
            panel1 = new Panel();
            button16 = new Button();
            button15 = new Button();
            button14 = new Button();
            button13 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            currentValue = new TextBox();
            resultValue = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button16);
            panel1.Controls.Add(button15);
            panel1.Controls.Add(button14);
            panel1.Controls.Add(button13);
            panel1.Controls.Add(button10);
            panel1.Controls.Add(button11);
            panel1.Controls.Add(button12);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button9);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(344, 392);
            panel1.TabIndex = 0;
            // 
            // button16
            // 
            button16.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button16.Location = new Point(20, 300);
            button16.Name = "button16";
            button16.Size = new Size(60, 60);
            button16.TabIndex = 15;
            button16.Text = "AC";
            button16.UseVisualStyleBackColor = true;
            button16.Click += ClickButtonClear;
            // 
            // button15
            // 
            button15.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button15.Location = new Point(250, 300);
            button15.Name = "button15";
            button15.Size = new Size(60, 60);
            button15.TabIndex = 14;
            button15.Text = "=";
            button15.UseVisualStyleBackColor = true;
            button15.Click += buttonClickEqualTo;
            // 
            // button14
            // 
            button14.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button14.Location = new Point(90, 230);
            button14.Name = "button14";
            button14.Size = new Size(60, 60);
            button14.TabIndex = 13;
            button14.Text = "0";
            button14.UseVisualStyleBackColor = true;
            button14.Click += buttonClick;
            // 
            // button13
            // 
            button13.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button13.Location = new Point(250, 230);
            button13.Name = "button13";
            button13.Size = new Size(60, 60);
            button13.TabIndex = 12;
            button13.Text = "+";
            button13.UseVisualStyleBackColor = true;
            button13.Click += buttonClickOperation;
            // 
            // button10
            // 
            button10.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button10.Location = new Point(250, 160);
            button10.Name = "button10";
            button10.Size = new Size(60, 60);
            button10.TabIndex = 11;
            button10.Text = "-";
            button10.UseVisualStyleBackColor = true;
            button10.Click += buttonClickOperation;
            // 
            // button11
            // 
            button11.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button11.Location = new Point(250, 90);
            button11.Name = "button11";
            button11.Size = new Size(60, 60);
            button11.TabIndex = 10;
            button11.Text = "*";
            button11.UseVisualStyleBackColor = true;
            button11.Click += buttonClickOperation;
            // 
            // button12
            // 
            button12.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button12.Location = new Point(250, 20);
            button12.Name = "button12";
            button12.Size = new Size(60, 60);
            button12.TabIndex = 9;
            button12.Text = "/";
            button12.UseVisualStyleBackColor = true;
            button12.Click += buttonClickOperation;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button7.Location = new Point(160, 160);
            button7.Name = "button7";
            button7.Size = new Size(60, 60);
            button7.TabIndex = 8;
            button7.Text = "3";
            button7.UseVisualStyleBackColor = true;
            button7.Click += buttonClick;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button8.Location = new Point(90, 160);
            button8.Name = "button8";
            button8.Size = new Size(60, 60);
            button8.TabIndex = 7;
            button8.Text = "2";
            button8.UseVisualStyleBackColor = true;
            button8.Click += buttonClick;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button9.Location = new Point(20, 160);
            button9.Name = "button9";
            button9.Size = new Size(60, 60);
            button9.TabIndex = 6;
            button9.Text = "1";
            button9.UseVisualStyleBackColor = true;
            button9.Click += buttonClick;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button4.Location = new Point(160, 90);
            button4.Name = "button4";
            button4.Size = new Size(60, 60);
            button4.TabIndex = 5;
            button4.Text = "6";
            button4.UseVisualStyleBackColor = true;
            button4.Click += buttonClick;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button5.Location = new Point(90, 90);
            button5.Name = "button5";
            button5.Size = new Size(60, 60);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += buttonClick;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button6.Location = new Point(20, 90);
            button6.Name = "button6";
            button6.Size = new Size(60, 60);
            button6.TabIndex = 3;
            button6.Text = "4";
            button6.UseVisualStyleBackColor = true;
            button6.Click += buttonClick;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button3.Location = new Point(160, 20);
            button3.Name = "button3";
            button3.Size = new Size(60, 60);
            button3.TabIndex = 2;
            button3.Text = "9";
            button3.UseVisualStyleBackColor = true;
            button3.Click += buttonClick;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.Location = new Point(90, 20);
            button2.Name = "button2";
            button2.Size = new Size(60, 60);
            button2.TabIndex = 1;
            button2.Text = "8";
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonClick;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(20, 20);
            button1.Name = "button1";
            button1.Size = new Size(60, 60);
            button1.TabIndex = 0;
            button1.Text = "7";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonClick;
            // 
            // currentValue
            // 
            currentValue.Location = new Point(387, 13);
            currentValue.Name = "currentValue";
            currentValue.Size = new Size(306, 23);
            currentValue.TabIndex = 1;
            currentValue.KeyDown += ProhibitInput;
            // 
            // resultValue
            // 
            resultValue.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            resultValue.Location = new Point(387, 59);
            resultValue.Name = "resultValue";
            resultValue.Size = new Size(306, 39);
            resultValue.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 416);
            Controls.Add(resultValue);
            Controls.Add(currentValue);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Click += ClickButtonClear;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Button button2;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button3;
        private TextBox currentValue;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private TextBox resultValue;
    }
}
