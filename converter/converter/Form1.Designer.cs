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
            this.user_input_textbox = new System.Windows.Forms.TextBox();
            this.calculate_button = new System.Windows.Forms.Button();
            this.result_textbox = new System.Windows.Forms.TextBox();
            this.unit_type_listbox = new System.Windows.Forms.ListBox();
            this.from_unit_listbox = new System.Windows.Forms.ListBox();
            this.to_unit_listbox = new System.Windows.Forms.ListBox();
            this.error_info_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // user_input_textbox
            // 
            this.user_input_textbox.Location = new System.Drawing.Point(310, 45);
            this.user_input_textbox.Name = "user_input_textbox";
            this.user_input_textbox.PlaceholderText = "Enter Value";
            this.user_input_textbox.Size = new System.Drawing.Size(100, 23);
            this.user_input_textbox.TabIndex = 0;
            // 
            // calculate_button
            // 
            this.calculate_button.Location = new System.Drawing.Point(320, 224);
            this.calculate_button.Name = "calculate_button";
            this.calculate_button.Size = new System.Drawing.Size(75, 23);
            this.calculate_button.TabIndex = 1;
            this.calculate_button.Text = "Calculate";
            this.calculate_button.UseVisualStyleBackColor = true;
            this.calculate_button.Click += new System.EventHandler(this.calculate_button_Click);
            // 
            // result_textbox
            // 
            this.result_textbox.Location = new System.Drawing.Point(310, 107);
            this.result_textbox.Name = "result_textbox";
            this.result_textbox.PlaceholderText = "Your Result";
            this.result_textbox.ReadOnly = true;
            this.result_textbox.Size = new System.Drawing.Size(100, 23);
            this.result_textbox.TabIndex = 2;
            // 
            // unit_type_listbox
            // 
            this.unit_type_listbox.FormattingEnabled = true;
            this.unit_type_listbox.ItemHeight = 15;
            this.unit_type_listbox.Items.AddRange(new object[] {
            "weight",
            "distance"});
            this.unit_type_listbox.Location = new System.Drawing.Point(114, 12);
            this.unit_type_listbox.Name = "unit_type_listbox";
            this.unit_type_listbox.Size = new System.Drawing.Size(120, 94);
            this.unit_type_listbox.TabIndex = 4;
            this.unit_type_listbox.SelectedIndexChanged += new System.EventHandler(this.unit_type_listbox_SelectedIndexChanged);
            // 
            // from_unit_listbox
            // 
            this.from_unit_listbox.FormattingEnabled = true;
            this.from_unit_listbox.ItemHeight = 15;
            this.from_unit_listbox.Location = new System.Drawing.Point(129, 162);
            this.from_unit_listbox.Name = "from_unit_listbox";
            this.from_unit_listbox.Size = new System.Drawing.Size(120, 94);
            this.from_unit_listbox.TabIndex = 5;
            // 
            // to_unit_listbox
            // 
            this.to_unit_listbox.FormattingEnabled = true;
            this.to_unit_listbox.ItemHeight = 15;
            this.to_unit_listbox.Location = new System.Drawing.Point(495, 162);
            this.to_unit_listbox.Name = "to_unit_listbox";
            this.to_unit_listbox.Size = new System.Drawing.Size(120, 94);
            this.to_unit_listbox.TabIndex = 6;
            // 
            // error_info_label
            // 
            this.error_info_label.AutoSize = true;
            this.error_info_label.Location = new System.Drawing.Point(382, 357);
            this.error_info_label.Name = "error_info_label";
            this.error_info_label.Size = new System.Drawing.Size(0, 15);
            this.error_info_label.TabIndex = 7;
            // 
            // main_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.error_info_label);
            this.Controls.Add(this.to_unit_listbox);
            this.Controls.Add(this.from_unit_listbox);
            this.Controls.Add(this.unit_type_listbox);
            this.Controls.Add(this.result_textbox);
            this.Controls.Add(this.calculate_button);
            this.Controls.Add(this.user_input_textbox);
            this.Name = "main_window";
            this.Text = "Converter";
            this.Load += new System.EventHandler(this.main_window_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox user_input_textbox;
        private Button calculate_button;
        private TextBox result_textbox;
        private ListBox unit_type_listbox;
        private ListBox from_unit_listbox;
        private ListBox to_unit_listbox;
        private Label error_info_label;
    }
}