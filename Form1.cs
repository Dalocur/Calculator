namespace Calculator
{
    public partial class Form1 : Form
    {
        int result = 0;
        string operation = "";
        string input = "";
        string value1 = "";
        string value2 = "";

        delegate void OnTypeSignature ();
        Dictionary<string, OnTypeSignature> OnTypeFunctions = new Dictionary<string, OnTypeSignature>();

        public Form1 ()
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

        public void UpdateValues ()
        {
            currentValue.Text = value1 + " " + operation;
            resultValue.Text = value2;
        }

        public void OnType9 ()
        {
            value2 += "9";
            UpdateValues();
        }
        public void OnType8 ()
        {
            value2 += "8";
            UpdateValues();
        }
        public void OnType7 ()
        {
            value2 += "7";
            UpdateValues();
        }
        public void OnType6 ()
        {
            value2 += "6";
            UpdateValues();
        }
        public void OnType5 ()
        {
            value2 += "5";
            UpdateValues();
        }
        public void OnType4 ()
        {
            value2 += "4";
            UpdateValues();
        }
        public void OnType3 ()
        {
            value2 += "3";
            UpdateValues();
        }
        public void OnType2 ()
        {
            value2 += "2";
            UpdateValues();
        }
        public void OnType1 ()
        {
            value2 += "1";
            UpdateValues();
        }
        public void OnType0 ()
        {
            value2 += "0";
            UpdateValues();
        }


        public void OnTypeDivision ()
        {
            OnTypeFunctions["="]();
            operation = "/";
            UpdateValues();
        }
        public void OnTypeMultiplication ()
        {
            OnTypeFunctions["="]();
            operation = "*";
            UpdateValues();
        }
        public void OnTypeSubtraction ()
        {
            OnTypeFunctions["="]();
            operation = "-";
            UpdateValues();
        }
        public void OnTypeAddition ()
        {
            OnTypeFunctions["="]();
            operation = "+";
            UpdateValues();
        }

        public void OnTypeEqualTo ()
        {
            if (value2 != "")
            {
                try
                {
                    float v1;
                    if (value1 == "")
                        v1 = operation == "*" || operation == "/" ? 1 : 0;
                    else
                        v1 = float.Parse(value1);

                    float v2 = float.Parse(value2);

                    switch (operation)
                    {
                        case "+":
                            v1 += v2;
                            break;
                        case "-":
                            v1 -= v2;
                            break;
                        case "*":
                            v1 *= v2;
                            break;
                        case "/":
                            v1 /= v2;
                            break;
                        default:
                            v1 = v2;
                    }
                    value1 = v1.ToString();
                    value2 = v2.ToString();
                }
                catch (Exception e)
                {
                    // e.Message;
                }
            }

            operation = "";
            UpdateValues();
        }
        public void OnTypeAllClear ()
        {
            value1 = "";
            value2 = "";
            operation = "";
            UpdateValues();
        }
        private void buttonClick (object sender, EventArgs e)
        {
            Button Me = (Button)sender;
            if (OnTypeFunctions.ContainsKey(Me.Text))
            {
                OnTypeFunctions[Me.Text]();
            }
        }
        private void buttonClickOperation (object sender, EventArgs e)
        {
            Button Me = (Button)sender;
            if (OnTypeFunctions.ContainsKey(Me.Text))
            {
                OnTypeFunctions[Me.Text]();
                resultValue.Text = "";
            }
        }
        private void buttonClickEqualTo (object sender, EventArgs e)
        {
            Button Me = (Button)sender;
            if (OnTypeFunctions.ContainsKey(Me.Text))
            {
                OnTypeFunctions[Me.Text]();
            }
        }
        private void ClickButtonClear (object sender, EventArgs e)
        {
            Button Me = (Button)sender;
            if (OnTypeFunctions.ContainsKey(Me.Text))
            {
                OnTypeFunctions[Me.Text]();
            }
        }
        private void ProhibitInput (object sender, KeyEventArgs e)
        {
            resultValue.Text = "Input is not valid!";
            throw new Exception("Input is not valid");
        }
    }
}
