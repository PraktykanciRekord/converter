using System.Windows.Forms;

namespace converter
{
    class Main
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
            }
            else if (selected_unit_type == selected_unit_types.distance.ToString())
            {
                from_listbox.Items.AddRange(distance_units);
                to_listbox.Items.AddRange(distance_units);
            }
        }

    }
    class Convert
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
                    if (to_listbox.SelectedItem.ToString() == "kg")
                    {
                        res = val * 1_000;
                    }
                    else if (to_listbox.SelectedItem.ToString() == "kg")
                    {
                        res = val * 1_000;
                    }
                    else if (to_listbox.SelectedItem.ToString() == "kg")
                    {
                        res = val * 1_000;
                    }
                    else if (to_listbox.SelectedItem.ToString() == "kg")
                    {
                        res = val * 1_000;
                    }
                }
                else if (from_listbox.SelectedItem.ToString() == "t")
                {
                    if (to_listbox.SelectedItem.ToString() == "kg")
                    {
                        res = val * 1_000;
                    }
                    else if (to_listbox.SelectedItem.ToString() == "kg")
                    {
                        res = val * 1_000;
                    }
                    else if (to_listbox.SelectedItem.ToString() == "kg")
                    {
                        res = val * 1_000;
                    }
                    else if (to_listbox.SelectedItem.ToString() == "kg")
                    {
                        res = val * 1_000;
                    }
                }
                else if (from_listbox.SelectedItem.ToString() == "t")
                {
                    if (to_listbox.SelectedItem.ToString() == "kg")
                    {
                        res = val * 1_000;
                    }
                    else if (to_listbox.SelectedItem.ToString() == "kg")
                    {
                        res = val * 1_000;
                    }
                    else if (to_listbox.SelectedItem.ToString() == "kg")
                    {
                        res = val * 1_000;
                    }
                    else if (to_listbox.SelectedItem.ToString() == "kg")
                    {
                        res = val * 1_000;
                    }
                }
                else if (from_listbox.SelectedItem.ToString() == "t")
                {
                    if (to_listbox.SelectedItem.ToString() == "kg")
                    {
                        res = val * 1_000;
                    }
                    else if (to_listbox.SelectedItem.ToString() == "kg")
                    {
                        res = val * 1_000;
                    }
                    else if (to_listbox.SelectedItem.ToString() == "kg")
                    {
                        res = val * 1_000;
                    }
                    else if (to_listbox.SelectedItem.ToString() == "kg")
                    {
                        res = val * 1_000;
                    }
                }
            }
            else if (unit_type_listbox.SelectedItem.ToString() == Main.selected_unit_types.distance.ToString())
            {
                //distance
            }

            return res;
        }
        


    }
}