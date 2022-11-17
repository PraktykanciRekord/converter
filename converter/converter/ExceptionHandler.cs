namespace converter
{
    class ExceptionHandler
    {
        public double value { get; set; }
        Label exceptionInfoLabel;
        TextBox userInputTextbox;
        TextBox resultTextbox;
        Manager manager;
        public ExceptionHandler(Label exceptionInfoLabel, TextBox userInputTextbox, TextBox resultTextbox, Manager manager)
        {
            this.value = value;
            this.exceptionInfoLabel = exceptionInfoLabel;
            this.userInputTextbox = userInputTextbox;
            this.resultTextbox = resultTextbox;
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
            if (userInputTextbox.Text == "")
            {
                manager.WriteInLabel(exceptionInfoLabel, "Enter value!", Color.Red);
                resultTextbox.Text = "";
                return false;
            }
            else
            {
                try
                {
                    value = double.Parse(userInputTextbox.Text);
                }
                catch (FormatException)
                {
                    manager.WriteInLabel(exceptionInfoLabel, "Incorrect value!", Color.Red);
                    userInputTextbox.Text = "";
                    resultTextbox.Text = "";
                    return false;
                }
            }
            return true;
        }
        public bool DotAndComaException()
        {

            if (userInputTextbox.Text.Contains('.') && userInputTextbox.Text.Contains(','))
            {
                manager.WriteInLabel(exceptionInfoLabel, "Incorrect value!", Color.Red);
                userInputTextbox.Text = "";
                resultTextbox.Text = "";
                return false;
            }
            return true;
        }
        public bool TooManyComasException()
        {
            int comaCounter = 0;
            foreach (char letter in userInputTextbox.Text)
            {
                if (letter == ',')
                {
                    comaCounter++;
                }
            }
            if (comaCounter > 1)
            {
                manager.WriteInLabel(exceptionInfoLabel, "Incorrect value!", Color.Red);
                userInputTextbox.Text = "";
                resultTextbox.Text = "";
                return false;
            }
            return true;
        }
    }
}