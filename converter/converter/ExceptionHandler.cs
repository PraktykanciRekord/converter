namespace converter
{
    class ExceptionHandler
    {
        public double value { get; set; }

        public bool ExceptionHandle(Label exception_info_label, TextBox user_input_textbox, TextBox result_textbox)
        {
            if (!NotANumber(user_input_textbox, exception_info_label, result_textbox))
            {
                return false;
            }
            return true;
        }
        public bool NotANumber(TextBox user_input_textbox, Label exception_info_label, TextBox result_textbox)
        {
            if (user_input_textbox.Text == "")
            {
                exception_info_label.Text = "Enter value!";
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
                    exception_info_label.Text = "Incorrect value!";
                    user_input_textbox.Text = "";
                    result_textbox.Text = "";
                    return false;
                }
            }
            return true;
        }
    }
}