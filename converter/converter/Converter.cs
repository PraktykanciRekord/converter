using System.Windows.Forms;

namespace converter
{
    class Main
    {
        public string[] weight_units = { "t", "kg", "g", "mg" };
        public string[] distance_units = { "km", "m", "cm", "mm" };
        public bool success { get; set; } = true;
        public double val { get; set; }
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
                success = false;
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
                    success = false;
                    error_info_label.Text = "Incorrect value!";
                    user_input_textbox.Text = "";
                }

            }

            return val;
        }

    }
    class Converter
    {
        public double res { get; set; }
        public double val { get; set; }
        public double ConvertUnit(double _val, ListBox from_listbox, ListBox to_listbox, ListBox unit_type_listbox)
        {
            val = _val;

            if (unit_type_listbox.SelectedItem.ToString() == Main.selected_unit_types.weight.ToString())
            {
                if (from_listbox.SelectedItem.ToString() == "t")
                {
                    if (to_listbox.SelectedItem.ToString() == "t")
                    {
                        res = val;
                    }
                    else if (to_listbox.SelectedItem.ToString() == "kg")
                    {
                        res = val * 1_000;
                    }
                    else if (to_listbox.SelectedItem.ToString() == "g")
                    {
                        res = val * 1_000_000;
                    }
                    else if (to_listbox.SelectedItem.ToString() == "mg")
                    {
                        res = val * 1_000_000_000;
                    }
                }
                else if (from_listbox.SelectedItem.ToString() == "kg")
                {
                    if (to_listbox.SelectedItem.ToString() == "t")
                    {
                        res = val / 1_000;
                    }
                    else if (to_listbox.SelectedItem.ToString() == "kg")
                    {
                        res = val;
                    }
                    else if (to_listbox.SelectedItem.ToString() == "g")
                    {
                        res = val * 1_000;
                    }
                    else if (to_listbox.SelectedItem.ToString() == "mg")
                    {
                        res = val * 1_000_000;
                    }
                }
                else if (from_listbox.SelectedItem.ToString() == "g")
                {
                    if (to_listbox.SelectedItem.ToString() == "t")
                    {
                        res = val / 1_000_000;
                    }
                    else if (to_listbox.SelectedItem.ToString() == "kg")
                    {
                        res = val / 1_000;
                    }
                    else if (to_listbox.SelectedItem.ToString() == "g")
                    {
                        res = val;
                    }
                    else if (to_listbox.SelectedItem.ToString() == "mg")
                    {
                        res = val * 1_000;
                    }
                }
                else if (from_listbox.SelectedItem.ToString() == "mg")
                {
                    if (to_listbox.SelectedItem.ToString() == "t")
                    {
                        res = val / 1_000_000_000;
                    }
                    else if (to_listbox.SelectedItem.ToString() == "kg")
                    {
                        res = val / 1_000_000;
                    }
                    else if (to_listbox.SelectedItem.ToString() == "g")
                    {
                        res = val / 1_000;
                    }
                    else if (to_listbox.SelectedItem.ToString() == "mg")
                    {
                        res = val;
                    }
                }
            }
            else if (unit_type_listbox.SelectedItem.ToString() == Main.selected_unit_types.distance.ToString())
            {
                if (from_listbox.SelectedItem.ToString() == "km")
                {
                    if (to_listbox.SelectedItem.ToString() == "km")
                    {
                        res = val;
                    }
                    else if (to_listbox.SelectedItem.ToString() == "m")
                    {
                        res = val * 1_000;
                    }
                    else if (to_listbox.SelectedItem.ToString() == "cm")
                    {
                        res = val * 100_000;
                    }
                    else if (to_listbox.SelectedItem.ToString() == "mm")
                    {
                        res = val * 1_000_000;
                    }
                }
                else if (from_listbox.SelectedItem.ToString() == "m")
                {
                    if (to_listbox.SelectedItem.ToString() == "km")
                    {
                        res = val / 1_000;
                    }
                    else if (to_listbox.SelectedItem.ToString() == "m")
                    {
                        res = val;
                    }
                    else if (to_listbox.SelectedItem.ToString() == "cm")
                    {
                        res = val * 100;
                    }
                    else if (to_listbox.SelectedItem.ToString() == "mm")
                    {
                        res = val * 10_000;
                    }
                }
                else if (from_listbox.SelectedItem.ToString() == "cm")
                {
                    if (to_listbox.SelectedItem.ToString() == "km")
                    {
                        res = val / 100_000;
                    }
                    else if (to_listbox.SelectedItem.ToString() == "m")
                    {
                        res = val / 100;
                    }
                    else if (to_listbox.SelectedItem.ToString() == "cm")
                    {
                        res = val;
                    }
                    else if (to_listbox.SelectedItem.ToString() == "mm")
                    {
                        res = val * 10;
                    }
                }
                else if (from_listbox.SelectedItem.ToString() == "mm")
                {
                    if (to_listbox.SelectedItem.ToString() == "km")
                    {
                        res = val / 1_000_000;
                    }
                    else if (to_listbox.SelectedItem.ToString() == "m")
                    {
                        res = val / 1_000;
                    }
                    else if (to_listbox.SelectedItem.ToString() == "cm")
                    {
                        res = val / 10;
                    }
                    else if (to_listbox.SelectedItem.ToString() == "mm")
                    {
                        res = val;
                    }
                }
            }

            return res;
        }
        


    }
}