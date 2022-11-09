namespace converter
{
    class Main
    {
        public string[] weight_units = { "t", "kg", "g", "mg" };
        public string[] distance_units = { "km", "m", "cm", "mm" };
        public double val { get; set; }
        public bool success { get; set; } = true;
        public enum selected_unit_types
        {
            weight,
            distance
        }

        public void SetValuesInListboxes(ListBox from_listbox, ListBox to_listbox, string selected_unit_type)
        {
            from_listbox.Items.Clear();
            to_listbox.Items.Clear();

            if (selected_unit_type == selected_unit_types.weight.ToString())
            {
                from_listbox.Items.AddRange(weight_units);
                to_listbox.Items.AddRange(weight_units);
            }
            else if (selected_unit_type == selected_unit_types.distance.ToString())
            {
                from_listbox.Items.AddRange(distance_units);
                to_listbox.Items.AddRange(distance_units);
            }
        }

        public double FormatUserValue(TextBox user_input_textbox, Label error_info_label)
        {
            string rawUserValue = user_input_textbox.Text;

            if (rawUserValue == "")
            {
                error_info_label.Text = "Enter value!";
            }
            else
            {
                try
                {
                    val = double.Parse(rawUserValue);
                }
                catch (FormatException)
                {
                    error_info_label.Text = "Incorrect value!";
                    user_input_textbox.Text = "";
                }
            }

            return val;
        }

        public bool ErrorHandler(Label error_info_label, ListBox from_unit_listbox, ListBox to_unit_listbox)
        {
            ErrorHandling errorHandling = new ErrorHandling();
            if (!errorHandling.ListsNotSelected(error_info_label, from_unit_listbox, to_unit_listbox))
            {
                success = false;
            }
            return success ? true : false;
        }

    }
}