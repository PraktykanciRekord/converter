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
            Manager manager = new Manager(userInputTextbox, resultTextbox, toUnitListbox, fromUnitListbox, exceptionInfoLabel, unitTypeListbox);

            unitTypeListbox.SelectedIndex = (int)Enum.Parse(typeof(Manager.selectedUnitTypes), Manager.selectedUnitTypes.weight.ToString());
            manager.SetValuesInListboxes();
            ActiveControl = unitTypeListbox;
        }

        private void calculate_button_Click(object sender, EventArgs e)
        {
            Manager manager = new Manager(userInputTextbox, resultTextbox, toUnitListbox, fromUnitListbox, exceptionInfoLabel, unitTypeListbox);
            ExceptionHandler exceptionHandler = new ExceptionHandler(exceptionInfoLabel, userInputTextbox, resultTextbox, manager);
            Converter converter = new Converter();
            if (exceptionHandler.ExceptionHandle())
            {
                resultTextbox.Text = converter.Convert(fromUnitListbox.SelectedItem.ToString(), toUnitListbox.SelectedItem.ToString(), manager.FormatUserValue()).ToString();
                manager.CopyResultToClipboard();
            }
        }
        private void unitTypeListboxSelectedIndexChanged(object sender, EventArgs e)
        {
            Manager manager = new Manager(userInputTextbox, resultTextbox, toUnitListbox, fromUnitListbox, exceptionInfoLabel, unitTypeListbox);
            manager.SetValuesInListboxes();
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            Manager manager = new Manager(userInputTextbox, resultTextbox, toUnitListbox, fromUnitListbox, exceptionInfoLabel, unitTypeListbox);
            manager.Clear();
        }
    }
}