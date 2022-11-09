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
            Manager main = new Manager();

            main.SetValuesInListboxes(from_unit_listbox, to_unit_listbox, Manager.selected_unit_types.weight.ToString());
            unit_type_listbox.SelectedIndex = (int)Enum.Parse(typeof(Manager.selected_unit_types), Manager.selected_unit_types.weight.ToString());
        }

        private void calculate_button_Click(object sender, EventArgs e)
        {
            Manager manager = new Manager();
            Converter converter = new Converter();
            ExceptionHandler exceptionHandler = new ExceptionHandler();

            if (exceptionHandler.ExceptionHandle(exception_info_label, user_input_textbox, result_textbox))
            {
                result_textbox.Text = converter.ConvertUnit(manager.FormatUserValue(user_input_textbox, exception_info_label), from_unit_listbox, to_unit_listbox, unit_type_listbox, result_textbox).ToString();
                manager.CopyResultToClipboard(result_textbox, exception_info_label);
            }
        }
        private void unit_type_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Manager main = new Manager();

            main.SetValuesInListboxes(from_unit_listbox, to_unit_listbox, unit_type_listbox.SelectedItem.ToString());
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            Manager manager = new Manager();
            manager.Clear(user_input_textbox, result_textbox, exception_info_label);
        }
    }
}