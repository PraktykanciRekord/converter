namespace converter
{
    class Manager
    {
        public string[] weight_units = { "t", "kg", "g", "mg" };
        public string[] distance_units = { "km", "m", "cm", "mm" };
        TextBox user_input_textbox;
        TextBox result_textbox;
        ListBox from_unit_listbox;
        ListBox to_unit_listbox;
        Label exception_info_label;
        ListBox unit_type_listbox;
        public Manager(TextBox user_input_textbox, TextBox result_textbox, ListBox from_listbox, ListBox to_listbox, Label exception_info_label, ListBox unit_type_listbox)
        {
            this.user_input_textbox = user_input_textbox;
            this.result_textbox = result_textbox;
            this.from_unit_listbox = from_listbox;
            this.to_unit_listbox = to_listbox;
            this.exception_info_label = exception_info_label;
            this.unit_type_listbox = unit_type_listbox;
        }
        public enum selected_unit_types
        {
            weight,
            distance
        }

        public bool IsUnitWeight()
        {
            return unit_type_listbox.SelectedItem.ToString() == selected_unit_types.weight.ToString();
        }
        public bool IsUnitDistance()
        {
            return unit_type_listbox.SelectedItem.ToString() == selected_unit_types.distance.ToString();
        }
        public void SetValuesInListboxes()
        {
            from_unit_listbox.Items.Clear();
            to_unit_listbox.Items.Clear();

            if (IsUnitWeight())
            {
                from_unit_listbox.Items.AddRange(weight_units);
                to_unit_listbox.Items.AddRange(weight_units);

                from_unit_listbox.SelectedItem = weight_units[1];
                to_unit_listbox.SelectedItem = weight_units[1];
            }
            else if (IsUnitDistance())
            {
                from_unit_listbox.Items.AddRange(distance_units);
                to_unit_listbox.Items.AddRange(distance_units);

                from_unit_listbox.SelectedItem = distance_units[1];
                to_unit_listbox.SelectedItem = distance_units[1];
            }
        }
        public double FormatUserValue()
        {
            if (user_input_textbox.Text.Contains(','))
            {
                return double.Parse(user_input_textbox.Text.Replace(',', '.'));
            }
            return double.Parse(user_input_textbox.Text);
        }
        public void CopyResultToClipboard()
        {
            Clipboard.SetText(result_textbox.Text);
            WriteInLabel(exception_info_label, "Copied!", Color.Black);
        }

        public void Clear()
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