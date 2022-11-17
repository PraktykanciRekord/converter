namespace converter
{
    partial class main_window
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.userInputTextbox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.resultTextbox = new System.Windows.Forms.TextBox();
            this.unitTypeListbox = new System.Windows.Forms.ListBox();
            this.fromUnitListbox = new System.Windows.Forms.ListBox();
            this.toUnitListbox = new System.Windows.Forms.ListBox();
            this.exceptionInfoLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.textFromLabel = new System.Windows.Forms.Label();
            this.textToLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // user_input_textbox
            // 
            this.userInputTextbox.Location = new System.Drawing.Point(94, 32);
            this.userInputTextbox.MaxLength = 15;
            this.userInputTextbox.Name = "user_input_textbox";
            this.userInputTextbox.PlaceholderText = "Enter Value";
            this.userInputTextbox.Size = new System.Drawing.Size(131, 23);
            this.userInputTextbox.TabIndex = 0;
            // 
            // calculate_button
            // 
            this.calculateButton.Location = new System.Drawing.Point(104, 119);
            this.calculateButton.Name = "calculate_button";
            this.calculateButton.Size = new System.Drawing.Size(113, 30);
            this.calculateButton.TabIndex = 1;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculate_button_Click);
            // 
            // result_textbox
            // 
            this.resultTextbox.Location = new System.Drawing.Point(95, 90);
            this.resultTextbox.Name = "result_textbox";
            this.resultTextbox.PlaceholderText = "Your Result";
            this.resultTextbox.ReadOnly = true;
            this.resultTextbox.Size = new System.Drawing.Size(131, 23);
            this.resultTextbox.TabIndex = 2;
            // 
            // unit_type_listbox
            // 
            this.unitTypeListbox.FormattingEnabled = true;
            this.unitTypeListbox.ItemHeight = 15;
            this.unitTypeListbox.Items.AddRange(new object[] {
            "weight",
            "distance"});
            this.unitTypeListbox.Location = new System.Drawing.Point(18, 27);
            this.unitTypeListbox.Name = "unit_type_listbox";
            this.unitTypeListbox.Size = new System.Drawing.Size(70, 34);
            this.unitTypeListbox.TabIndex = 4;
            this.unitTypeListbox.SelectedIndexChanged += new System.EventHandler(this.unitTypeListboxSelectedIndexChanged);
            // 
            // from_unit_listbox
            // 
            this.fromUnitListbox.FormattingEnabled = true;
            this.fromUnitListbox.ItemHeight = 15;
            this.fromUnitListbox.Location = new System.Drawing.Point(25, 88);
            this.fromUnitListbox.Name = "from_unit_listbox";
            this.fromUnitListbox.Size = new System.Drawing.Size(54, 64);
            this.fromUnitListbox.TabIndex = 5;
            // 
            // to_unit_listbox
            // 
            this.toUnitListbox.FormattingEnabled = true;
            this.toUnitListbox.ItemHeight = 15;
            this.toUnitListbox.Location = new System.Drawing.Point(241, 88);
            this.toUnitListbox.Name = "to_unit_listbox";
            this.toUnitListbox.Size = new System.Drawing.Size(54, 64);
            this.toUnitListbox.TabIndex = 6;
            // 
            // exception_info_label
            // 
            this.exceptionInfoLabel.BackColor = System.Drawing.Color.Transparent;
            this.exceptionInfoLabel.ForeColor = System.Drawing.Color.Black;
            this.exceptionInfoLabel.Location = new System.Drawing.Point(109, 9);
            this.exceptionInfoLabel.Name = "exception_info_label";
            this.exceptionInfoLabel.Size = new System.Drawing.Size(100, 15);
            this.exceptionInfoLabel.TabIndex = 7;
            this.exceptionInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clear_button
            // 
            this.clearButton.Location = new System.Drawing.Point(229, 32);
            this.clearButton.Name = "clear_button";
            this.clearButton.Size = new System.Drawing.Size(56, 23);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // text_from_label
            // 
            this.textFromLabel.AutoSize = true;
            this.textFromLabel.Location = new System.Drawing.Point(32, 69);
            this.textFromLabel.Name = "text_from_label";
            this.textFromLabel.Size = new System.Drawing.Size(38, 15);
            this.textFromLabel.TabIndex = 9;
            this.textFromLabel.Text = "From:";
            // 
            // text_to_label
            // 
            this.textToLabel.AutoSize = true;
            this.textToLabel.Location = new System.Drawing.Point(256, 69);
            this.textToLabel.Name = "text_to_label";
            this.textToLabel.Size = new System.Drawing.Size(22, 15);
            this.textToLabel.TabIndex = 10;
            this.textToLabel.Text = "To:";
            // 
            // main_window
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 161);
            this.Controls.Add(this.textToLabel);
            this.Controls.Add(this.textFromLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.exceptionInfoLabel);
            this.Controls.Add(this.toUnitListbox);
            this.Controls.Add(this.fromUnitListbox);
            this.Controls.Add(this.unitTypeListbox);
            this.Controls.Add(this.resultTextbox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.userInputTextbox);
            this.MaximumSize = new System.Drawing.Size(335, 200);
            this.MinimumSize = new System.Drawing.Size(335, 200);
            this.Name = "main_window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Converter";
            this.Load += new System.EventHandler(this.main_window_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox userInputTextbox;
        private Button calculateButton;
        private TextBox resultTextbox;
        private ListBox fromUnitListbox;
        private ListBox toUnitListbox;
        private Label exceptionInfoLabel;
        private ListBox unitTypeListbox;
        private Button clearButton;
        private Label textFromLabel;
        private Label textToLabel;
    }
}