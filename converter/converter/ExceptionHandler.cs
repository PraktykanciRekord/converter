namespace converter
{
    class ExceptionHandler
    {
        public double value { get; set; }
        Manager manager = new();

        public bool ExceptionHandle(Label exception_info_label, TextBox user_input_textbox, TextBox result_textbox)
        {
            if (!NotANumberException(user_input_textbox, exception_info_label, result_textbox))
            {
                return false;
            }
            if (!DotAndComaException(user_input_textbox, exception_info_label, result_textbox))
            {
                return false;
            }
            if (!TooManyComasException(user_input_textbox, exception_info_label, result_textbox))
            {
                return false;
            }
            return true;
        }
        public bool NotANumberException(TextBox user_input_textbox, Label exception_info_label, TextBox result_textbox)
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
        public bool DotAndComaException(TextBox user_input_textbox, Label exception_info_label, TextBox result_textbox)
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
        public bool TooManyComasException(TextBox user_input_textbox, Label exception_info_label, TextBox result_textbox)
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