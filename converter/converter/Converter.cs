namespace converter
{
    class Converter
    {
        public double res { get; set; }
        public double ConvertUnit(double val, ListBox from_listbox, ListBox to_listbox, ListBox unit_type_listbox, TextBox result_textbox)
        {
            if (unit_type_listbox.SelectedItem.ToString() == Manager.selected_unit_types.weight.ToString())
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
            else if (unit_type_listbox.SelectedItem.ToString() == Manager.selected_unit_types.distance.ToString())
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