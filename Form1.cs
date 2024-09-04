namespace Calculator
{
    public partial class Form1 : Form
    {
        int result = 0;
        string operation = "";
        string input = "";
        string value1 = "";
        string value2 = "";

        delegate void OnTypeSignature();
        Dictionary<string, OnTypeSignature> OnTypeFunctions = new Dictionary<string, OnTypeSignature>();

        public Form1()
        {
            InitializeComponent();
            OnTypeFunctions = new Dictionary<string, OnTypeSignature>
            {
                { "9", OnType9 },
                { "8", OnType8 },
                { "7", OnType7 },
                { "6", OnType6 },
                { "5", OnType5 },
                { "4", OnType4 },
                { "3", OnType3 },
                { "2", OnType2 },
                { "1", OnType1 },
                { "0", OnType0 },
                { "/", OnTypeDivision },
                { "*", OnTypeMultiplication },
                { "-", OnTypeSubtraction },
                { "+", OnTypeAddition },
                { "=", OnTypeEqualTo },
                { "AC", OnTypeAllClear },
            };
        }

        public void OnType9()
        {
            if (operation == "")
            {
                currentValue.Text += "9";
            }
            input += "9";
            resultValue.Text += "9";
        }
        public void OnType8()
        {
            if (operation == "")
            {
                currentValue.Text += "8";
            }
            input += "8";
            resultValue.Text += "8";
        }
        public void OnType7()
        {
            if (operation == "")
            {
                currentValue.Text += "7";
            }
            input += "7";
            resultValue.Text += "7";
        }
        public void OnType6()
        {
            if (operation == "")
            {
                currentValue.Text += "6";
            }
            input += "6";
            resultValue.Text += "6";
        }
        public void OnType5()
        {
            if (operation == "")
            {
                currentValue.Text += "5";
            }
            input += "5";
            resultValue.Text += "5";
        }
        public void OnType4()
        {
            if (operation == "")
            {
                currentValue.Text += "4";
            }
            input += "4";
            resultValue.Text += "4";
        }
        public void OnType3()
        {
            if (operation == "")
            {
                currentValue.Text += "3";
            }
            input += "3";
            resultValue.Text += "3";
        }
        public void OnType2()
        {
            if (operation == "")
            {
                currentValue.Text += "2";
            }
            input += "2";
            resultValue.Text += "2";
        }
        public void OnType1()
        {
            if (operation == "")
            {
                currentValue.Text += "1";
            }
            input += "1";
            resultValue.Text += "1";
        }
        public void OnType0()
        {
            if (operation == "")
            {
                currentValue.Text += "0";
            }
            input += "0";
            resultValue.Text += "0";
        }
        public void OnTypeDivision()
        {
            if (currentValue.Text.Contains("="))
            {
                value1 = result.ToString();
                value2 = input;
                operation = "/";
                currentValue.Text = value1;
                currentValue.Text += "/";
                input = "";
            }
            else 
            {
                currentValue.Text += "/";
                value1 = input;
                operation = "/";
                input = "";
            }
        }
        public void OnTypeMultiplication()
        {
            if (currentValue.Text.Contains("="))
            {
                value1 = result.ToString();
                value2 = input;
                operation = "*";
                currentValue.Text = value1;
                currentValue.Text += "*";
                input = "";
            }
            else
            {
                currentValue.Text += "*";
                value1 = input;
                operation = "*";
                input = "";
            }
        }
        public void OnTypeSubtraction()
        {
            if (currentValue.Text.Contains("="))
            {
                value1 = result.ToString();
                value2 = input;
                operation = "-";
                currentValue.Text = value1;
                currentValue.Text += "-";
                input = "";
            }
            else
            {
                currentValue.Text += "-";
                value1 = input;
                operation = "-";
                input = "";
            }
        }
        public void OnTypeAddition()
        {
            if (currentValue.Text.Contains("="))
            {
                value1 = result.ToString();
                value2 = input;
                operation = "+";
                currentValue.Text = value1;
                currentValue.Text += "+";
                input = "";
            }
            else
            {
                currentValue.Text += "+";
                value1 = input;
                operation = "+";
                input = "";
            }
        }
        public void OnTypeEqualTo()
        {
            value2 = input;
            currentValue.Text += value2;
            currentValue.Text += "=";
            if (operation == "/")
            {
                if (value2 == "0")
                {
                    resultValue.Text = "Cannot divide by zero!";
                    throw new Exception("Cannot divide by zero");
                }
                {
                    result = int.Parse(value1) / int.Parse(value2);
                    resultValue.Text = result.ToString();
                }
            }
            else if (operation == "*")
            {
                result = int.Parse(value1) * int.Parse(value2);
                resultValue.Text = result.ToString();
            }
            else if (operation == "-")
            {
                result = int.Parse(value1) - int.Parse(value2);
                resultValue.Text = result.ToString();
            }
            else if (operation == "+")
            {
                result = int.Parse(value1) + int.Parse(value2);
                //currentValue.Text += result.ToString();
                resultValue.Text = result.ToString();
            }
            operation = "";
        }
        public void OnTypeAllClear()
        {
            currentValue.Text = string.Empty;
            resultValue.Text = string.Empty;
            input = "";
            value1 = "";
            value2 = "";
            operation = "";
        }
        private void buttonClick(object sender, EventArgs e)
        {
            Button Me = (Button)sender;
            if (OnTypeFunctions.ContainsKey(Me.Text))
            {
                OnTypeFunctions[Me.Text]();
            }
        }
        private void buttonClickOperation(object sender, EventArgs e)
        {
            Button Me = (Button)sender;
            if (OnTypeFunctions.ContainsKey(Me.Text))
            {
                OnTypeFunctions[Me.Text]();
                resultValue.Text = "";
            }
        }
        private void buttonClickEqualTo(object sender, EventArgs e)
        {
            Button Me = (Button)sender;
            if (OnTypeFunctions.ContainsKey(Me.Text))
            {
                OnTypeFunctions[Me.Text]();
            }
        }
        private void ClickButtonClear(object sender, EventArgs e)
        {
            Button Me = (Button)sender;
            if (OnTypeFunctions.ContainsKey(Me.Text))
            {
                OnTypeFunctions[Me.Text]();
            }
        }
        private void ProhibitInput(object sender, KeyEventArgs e)
        {
            resultValue.Text = "Input is not valid!";
            throw new Exception("Input is not valid");
        }
    }
}
