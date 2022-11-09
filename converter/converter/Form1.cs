using System.Windows.Forms;

namespace converter
{
    public partial class main_window : Form
    {
        public main_window()
        {
            InitializeComponent();
        }

        private void main_window_Load(object sender, EventArgs e)
        {
            string defaultUnitType = "weight";
            Main main = new Main();
            main.SetValuesInListboxes(from_unit_listbox, to_unit_listbox, defaultUnitType);
        }

        private void calculate_button_Click(object sender, EventArgs e)
        {
            bool success = true;

            string rawUserValue = user_input_textbox.Text;
            double numericUserValue = 0;



            if (rawUserValue == "")
            {
                success = false;
                error_info_label.Text = "Enter value!";
            }
            else
            {
                try
                {
                    numericUserValue = double.Parse(rawUserValue);
                }
                catch (FormatException)
                {
                    success = false;
                    error_info_label.Text = "Incorrect value!";
                    user_input_textbox.Text = "";
                }

            }
        }

        private void unit_type_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Main main = new Main();
            main.SetValuesInListboxes(from_unit_listbox, to_unit_listbox, unit_type_listbox.SelectedItem.ToString());
        }
    }
}