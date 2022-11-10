namespace converter
{
    class Manager
    {
        public string[] weight_units = { "t", "kg", "g", "mg" };
        public string[] distance_units = { "km", "m", "cm", "mm" };
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

                from_listbox.SelectedItem = weight_units[1];
                to_listbox.SelectedItem = weight_units[1];
            }
            else if (selected_unit_type == selected_unit_types.distance.ToString())
            {
                from_listbox.Items.AddRange(distance_units);
                to_listbox.Items.AddRange(distance_units);

                from_listbox.SelectedItem = distance_units[1];
                to_listbox.SelectedItem = distance_units[1];
            }
        }
        public double FormatUserValue(TextBox user_input_textbox)
        {
            if (user_input_textbox.Text.Contains(','))
            {
                return double.Parse(user_input_textbox.Text.Replace(',', '.'));
            }
            return double.Parse(user_input_textbox.Text);
        }
        public void CopyResultToClipboard(TextBox result_textbox, Label exception_info_label)
        {
            Clipboard.SetText(result_textbox.Text);
            WriteInLabel(exception_info_label, "Copied!", Color.Black);
        }

        public void Clear(TextBox user_input_textbox, TextBox result_textbox, Label exception_info_label)
        {
            WriteInLabel(exception_info_label, "Cleared!", Color.Black);
            user_input_textbox.Text = "";
            result_textbox.Text = "";
        }
        public void WriteInLabel(Label label, string text, Color color)
        {
            label.ForeColor = color;
            label.Text = text;
        }
    }
}