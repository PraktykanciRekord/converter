namespace converter
{
    class ExceptionHandler
    {
        public double value { get; set; }
        Label exception_info_label;
        TextBox user_input_textbox;
        TextBox result_textbox;
        Manager manager;
        public ExceptionHandler(Label exception_info_label, TextBox user_input_textbox, TextBox result_textbox, Manager manager)
        {
            this.value = value;
            this.exception_info_label = exception_info_label;
            this.user_input_textbox = user_input_textbox;
            this.result_textbox = result_textbox;
            this.manager = manager;
        }

        public bool ExceptionHandle()
        {
            if (!NotANumberException())
            {
                return false;
            }
            if (!DotAndComaException())
            {
                return false;
            }
            if (!TooManyComasException())
            {
                return false;
            }
            if (!TooManyComasException())
            {
                return false;
            }
            return true;
        }
        public bool NotANumberException()
        {
            if (user_input_textbox.Text == "")
            {
                manager.WriteInLabel(exception_info_label, "Enter value!", Color.Red);
                result_textbox.Text = "";
                return false;
            }
            else
            {
                try
                {
                    value = double.Parse(user_input_textbox.Text);
                }
                catch (FormatException)
                {
                    manager.WriteInLabel(exception_info_label, "Incorrect value!", Color.Red);
                    user_input_textbox.Text = "";
                    result_textbox.Text = "";
                    return false;
                }
            }
            return true;
        }
        public bool DotAndComaException()
        {

            if (user_input_textbox.Text.Contains('.') && user_input_textbox.Text.Contains(','))
            {
                manager.WriteInLabel(exception_info_label, "Incorrect value!", Color.Red);
                user_input_textbox.Text = "";
                result_textbox.Text = "";
                return false;
            }
            return true;
        }
        public bool TooManyComasException()
        {
            int comaCounter = 0;
            foreach (char letter in user_input_textbox.Text)
            {
                if (letter == ',')
                {
                    comaCounter++;
                }
            }
            if (comaCounter > 1)
            {
                manager.WriteInLabel(exception_info_label, "Incorrect value!", Color.Red);
                user_input_textbox.Text = "";
                result_textbox.Text = "";
                return false;
            }
            return true;
        }
    }
}