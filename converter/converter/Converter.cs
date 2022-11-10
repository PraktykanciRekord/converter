namespace converter
{
    class Converter
    {
        ListBox from_listbox;
        ListBox to_listbox;
        ListBox unit_type_listbox;
        Manager manager;
        public string[] weight_units;
        public string[] distance_units;
        public int[] weight_units_convert_ratio = {
            1, 1_000, 1_000_000, 1_000_000_000, //t
            1_000, 1, 1_000, 1_000_000,         //kg
            1_000_000, 1_000, 1, 1_000_000,     //g
            1_000_000_000, 1_000_000, 1_000, 1  //mg
        };
        public int[] distance_units_convert_ratio = {
            1, 1_000, 100_000, 1_000_000,       //km
            1_000, 1, 100, 10_000,              //m
            100_000, 100, 1, 10,                //cm
            1_000_000, 1_000, 10, 1             //mm
        };
        public char[] units_convert_sign = {
        '*', '*', '*', '*',
        '/', '*', '*', '*',
        '/', '/', '*', '*',
        '/', '/', '/', '*'
        };
        public Converter(ListBox from_listbox, ListBox to_listbox, ListBox unit_type_listbox, Manager manager)
        {
            this.from_listbox = from_listbox;
            this.to_listbox = to_listbox;
            this.unit_type_listbox = unit_type_listbox;
            this.manager = manager;
            weight_units = manager.weight_units;
            distance_units = manager.distance_units;
        }
        public double Convert(double val)
        {
            double res = 0;
            string[] units = new string[0];
            int counter = 0;
            int[] units_convert_ratio = new int[0];
            string unit_type__selected_item = unit_type_listbox.SelectedItem.ToString();
            if (unit_type_listbox.SelectedItem.ToString() == Manager.selected_unit_types.weight.ToString())
            {
                units = weight_units;
                units_convert_ratio = weight_units_convert_ratio;
            }
            else if (unit_type_listbox.SelectedItem.ToString() == Manager.selected_unit_types.distance.ToString())
            {
                units = distance_units;
                units_convert_ratio = distance_units_convert_ratio;
            }

            foreach (string unit in units)
            {
                foreach (string secondary_unit in units)
                {
                    if (unit == from_listbox.SelectedItem.ToString() && secondary_unit == to_listbox.SelectedItem.ToString())
                    {
                        if (units_convert_sign[counter] == '*')
                        {
                            res = val * units_convert_ratio[counter];
                        }
                        else if (units_convert_sign[counter] == '/')
                        {
                            res = val / units_convert_ratio[counter];
                        }
                    }
                    counter++;
                }
            }
            return res;
        }
    }
}