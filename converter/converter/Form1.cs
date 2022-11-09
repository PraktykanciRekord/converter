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
            Main main = new Main();
            main.SetValuesInListboxes(from_unit_listbox, to_unit_listbox, Main.selected_unit_types.weight.ToString());

            unit_type_listbox.SelectedIndex = (int)Enum.Parse(typeof(Main.selected_unit_types), Main.selected_unit_types.weight.ToString());
        }

        private void calculate_button_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            
            Converter main_converter = new Converter();
            if (main.ErrorHandler(error_info_label, from_unit_listbox, to_unit_listbox))
            {
                result_textbox.Text = main_converter.ConvertUnit(main.FormatUserValue(user_input_textbox, error_info_label), from_unit_listbox, to_unit_listbox, unit_type_listbox).ToString();
            }
        }

        private void unit_type_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Main main = new Main();
            main.SetValuesInListboxes(from_unit_listbox, to_unit_listbox, unit_type_listbox.SelectedItem.ToString());
        }
    }
}