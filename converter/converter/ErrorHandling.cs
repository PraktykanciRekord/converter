namespace converter
{
    class ErrorHandling
    {
        public bool success { get; set; } = true;
        public bool ListsNotSelected(Label error_info_label, ListBox from_listbox, ListBox to_listbox)
        {
            if (from_listbox.SelectedIndex == -1 || to_listbox.SelectedIndex == -1)
            {
                error_info_label.Text = "Select units!";
                return false;
            }
            return true;
        }
    }
}