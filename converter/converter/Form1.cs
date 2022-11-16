using converter.Core;
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
            Manager manager = new Manager(user_input_textbox, result_textbox, to_unit_listbox, from_unit_listbox, exception_info_label, unit_type_listbox);

            unit_type_listbox.SelectedIndex = (int)Enum.Parse(typeof(Manager.selected_unit_types), Manager.selected_unit_types.weight.ToString());
            manager.SetValuesInListboxes();
            ActiveControl = unit_type_listbox;
        }

        private void calculate_button_Click(object sender, EventArgs e)
        {
            Manager manager = new Manager(user_input_textbox, result_textbox, to_unit_listbox, from_unit_listbox, exception_info_label, unit_type_listbox);
            ExceptionHandler exceptionHandler = new ExceptionHandler(exception_info_label, user_input_textbox, result_textbox, manager);
            Converter converter = new Converter();
            if (exceptionHandler.ExceptionHandle())
            {
                result_textbox.Text = converter.Convert(from_unit_listbox.SelectedItem.ToString(), to_unit_listbox.SelectedItem.ToString(), unit_type_listbox.SelectedItem.ToString(), manager.FormatUserValue()).ToString();
                manager.CopyResultToClipboard();
            }
        }
        private void unit_type_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Manager manager = new Manager(user_input_textbox, result_textbox, to_unit_listbox, from_unit_listbox, exception_info_label, unit_type_listbox);
            manager.SetValuesInListboxes();
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            Manager manager = new Manager(user_input_textbox, result_textbox, to_unit_listbox, from_unit_listbox, exception_info_label, unit_type_listbox);
            manager.Clear();
        }
    }
}