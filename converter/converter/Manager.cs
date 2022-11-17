namespace converter
{
    class Manager
    {
        public string[] weightUnits = { "t", "kg", "g", "mg" };
        public string[] distanceUnits = { "km", "m", "cm", "mm" };
        TextBox userInputTextbox;
        TextBox resultTextbox;
        ListBox fromUnitListbox;
        ListBox toUnitListbox;
        Label exceptionInfoLabel;
        ListBox unitTypeListbox;
        public Manager(TextBox userInputTextbox, TextBox resultTextbox, ListBox fromListbox, ListBox toListbox, Label exceptionInfoLabel, ListBox unitTypeListbox)
        {
            this.userInputTextbox = userInputTextbox;
            this.resultTextbox = resultTextbox;
            this.fromUnitListbox = fromListbox;
            this.toUnitListbox = toListbox;
            this.exceptionInfoLabel = exceptionInfoLabel;
            this.unitTypeListbox = unitTypeListbox;
        }
        public enum selectedUnitTypes
        {
            weight,
            distance
        }

        public bool IsUnitWeight()
        {
            return unitTypeListbox.SelectedItem.ToString() == selectedUnitTypes.weight.ToString();
        }
        public bool IsUnitDistance()
        {
            return unitTypeListbox.SelectedItem.ToString() == selectedUnitTypes.distance.ToString();
        }
        public void SetValuesInListboxes()
        {
            fromUnitListbox.Items.Clear();
            toUnitListbox.Items.Clear();

            if (IsUnitWeight())
            {
                fromUnitListbox.Items.AddRange(weightUnits);
                toUnitListbox.Items.AddRange(weightUnits);

                fromUnitListbox.SelectedItem = weightUnits[1];
                toUnitListbox.SelectedItem = weightUnits[1];
            }
            else if (IsUnitDistance())
            {
                fromUnitListbox.Items.AddRange(distanceUnits);
                toUnitListbox.Items.AddRange(distanceUnits);

                fromUnitListbox.SelectedItem = distanceUnits[1];
                toUnitListbox.SelectedItem = distanceUnits[1];
            }
        }
        public double FormatUserValue()
        {
            if (userInputTextbox.Text.Contains(','))
            {
                return double.Parse(userInputTextbox.Text.Replace(',', '.'));
            }
            return double.Parse(userInputTextbox.Text);
        }
        public void CopyResultToClipboard()
        {
            Clipboard.SetText(resultTextbox.Text);
            WriteInLabel(exceptionInfoLabel, "Copied!", Color.Black);
        }

        public void Clear()
        {
            WriteInLabel(exceptionInfoLabel, "Cleared!", Color.Black);
            userInputTextbox.Text = "";
            resultTextbox.Text = "";
        }
        public void WriteInLabel(Label label, string text, Color color)
        {
            label.ForeColor = color;
            label.Text = text;
        }
    }
}