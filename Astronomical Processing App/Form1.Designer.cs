namespace Astronomical_Processing_App
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.displayData = new System.Windows.Forms.ListBox();
            this.txtboxInput = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.displaydata1 = new System.Windows.Forms.Button();
            this.mode_groupbox = new System.Windows.Forms.GroupBox();
            this.sequentialSearch_button = new System.Windows.Forms.RadioButton();
            this.sortmode_btn = new System.Windows.Forms.RadioButton();
            this.editmode_btn = new System.Windows.Forms.RadioButton();
            this.searchmode_btn = new System.Windows.Forms.RadioButton();
            this.edit_input = new System.Windows.Forms.TextBox();
            this.display_searchbox = new System.Windows.Forms.TextBox();
            this.value_label = new System.Windows.Forms.Label();
            this.index_label = new System.Windows.Forms.Label();
            this.txtbox_search = new System.Windows.Forms.TextBox();
            this.randomise_data = new System.Windows.Forms.Button();
            this.result_label = new System.Windows.Forms.Label();
            this.Options_groupbox = new System.Windows.Forms.GroupBox();
            this.range_button = new System.Windows.Forms.RadioButton();
            this.average_button = new System.Windows.Forms.RadioButton();
            this.mode_button = new System.Windows.Forms.RadioButton();
            this.mid_button = new System.Windows.Forms.RadioButton();
            this.calculateButton = new System.Windows.Forms.Button();
            this.calculate_resultbox = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.mode_groupbox.SuspendLayout();
            this.Options_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // displayData
            // 
            this.displayData.FormattingEnabled = true;
            this.displayData.ItemHeight = 16;
            this.displayData.Location = new System.Drawing.Point(29, 65);
            this.displayData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.displayData.Name = "displayData";
            this.displayData.Size = new System.Drawing.Size(159, 116);
            this.displayData.TabIndex = 0;
            this.toolTip1.SetToolTip(this.displayData, "Data will be displayed here ");
            this.displayData.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txtboxInput
            // 
            this.txtboxInput.Location = new System.Drawing.Point(256, 65);
            this.txtboxInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtboxInput.Name = "txtboxInput";
            this.txtboxInput.ReadOnly = true;
            this.txtboxInput.Size = new System.Drawing.Size(159, 22);
            this.txtboxInput.TabIndex = 2;
            this.toolTip2.SetToolTip(this.txtboxInput, "Enter the index of the entry you wish to edit");
            this.txtboxInput.Visible = false;
            this.txtboxInput.TextChanged += new System.EventHandler(this.txtboxInput_TextChanged);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(257, 30);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(100, 28);
            this.btn_search.TabIndex = 6;
            this.btn_search.Text = "Search";
            this.toolTip1.SetToolTip(this.btn_search, "Use this button to activate Search, Edit, Sort or Sequential Search mode");
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // displaydata1
            // 
            this.displaydata1.Location = new System.Drawing.Point(29, 30);
            this.displaydata1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.displaydata1.Name = "displaydata1";
            this.displaydata1.Size = new System.Drawing.Size(100, 28);
            this.displaydata1.TabIndex = 7;
            this.displaydata1.Text = "Display Data";
            this.toolTip1.SetToolTip(this.displaydata1, "Display the data in the Array using this button");
            this.displaydata1.UseVisualStyleBackColor = true;
            // 
            // mode_groupbox
            // 
            this.mode_groupbox.BackColor = System.Drawing.SystemColors.Control;
            this.mode_groupbox.Controls.Add(this.sequentialSearch_button);
            this.mode_groupbox.Controls.Add(this.sortmode_btn);
            this.mode_groupbox.Controls.Add(this.editmode_btn);
            this.mode_groupbox.Controls.Add(this.searchmode_btn);
            this.mode_groupbox.Location = new System.Drawing.Point(257, 156);
            this.mode_groupbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mode_groupbox.Name = "mode_groupbox";
            this.mode_groupbox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mode_groupbox.Size = new System.Drawing.Size(160, 135);
            this.mode_groupbox.TabIndex = 8;
            this.mode_groupbox.TabStop = false;
            this.mode_groupbox.Text = "Select mode";
            this.toolTip1.SetToolTip(this.mode_groupbox, "Use these buttons to choose between Search, Edit, Sort or sequential Search mode");
            this.mode_groupbox.Enter += new System.EventHandler(this.mode_groupbox_Enter);
            // 
            // sequentialSearch_button
            // 
            this.sequentialSearch_button.AutoSize = true;
            this.sequentialSearch_button.Location = new System.Drawing.Point(8, 103);
            this.sequentialSearch_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sequentialSearch_button.Name = "sequentialSearch_button";
            this.sequentialSearch_button.Size = new System.Drawing.Size(138, 20);
            this.sequentialSearch_button.TabIndex = 3;
            this.sequentialSearch_button.TabStop = true;
            this.sequentialSearch_button.Text = "Sequential Search";
            this.toolTip1.SetToolTip(this.sequentialSearch_button, "Sequential sort is an alternative to search mode, it functions the same but does " +
        "not need the data to be sorted first");
            this.sequentialSearch_button.UseVisualStyleBackColor = true;
            // 
            // sortmode_btn
            // 
            this.sortmode_btn.AutoSize = true;
            this.sortmode_btn.Location = new System.Drawing.Point(8, 79);
            this.sortmode_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sortmode_btn.Name = "sortmode_btn";
            this.sortmode_btn.Size = new System.Drawing.Size(90, 20);
            this.sortmode_btn.TabIndex = 2;
            this.sortmode_btn.TabStop = true;
            this.sortmode_btn.Text = "Sort mode";
            this.toolTip1.SetToolTip(this.sortmode_btn, "Sort mode will sort the data from lowest to highest using a bubble sort algorithm" +
        "");
            this.sortmode_btn.UseVisualStyleBackColor = true;
            // 
            // editmode_btn
            // 
            this.editmode_btn.AutoSize = true;
            this.editmode_btn.Location = new System.Drawing.Point(8, 52);
            this.editmode_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editmode_btn.Name = "editmode_btn";
            this.editmode_btn.Size = new System.Drawing.Size(89, 20);
            this.editmode_btn.TabIndex = 1;
            this.editmode_btn.TabStop = true;
            this.editmode_btn.Text = "Edit mode";
            this.toolTip1.SetToolTip(this.editmode_btn, "Edit mode allows you to edit an entry of your choosing");
            this.editmode_btn.UseVisualStyleBackColor = true;
            this.editmode_btn.CheckedChanged += new System.EventHandler(this.editmode_btn_CheckedChanged);
            // 
            // searchmode_btn
            // 
            this.searchmode_btn.AutoSize = true;
            this.searchmode_btn.Location = new System.Drawing.Point(8, 23);
            this.searchmode_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchmode_btn.Name = "searchmode_btn";
            this.searchmode_btn.Size = new System.Drawing.Size(109, 20);
            this.searchmode_btn.TabIndex = 0;
            this.searchmode_btn.TabStop = true;
            this.searchmode_btn.Text = "Search mode";
            this.toolTip1.SetToolTip(this.searchmode_btn, "Search mode allows you to search for a specific entry to see if it is in the data" +
        "set or not. ");
            this.searchmode_btn.UseVisualStyleBackColor = true;
            // 
            // edit_input
            // 
            this.edit_input.Location = new System.Drawing.Point(257, 126);
            this.edit_input.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.edit_input.Name = "edit_input";
            this.edit_input.Size = new System.Drawing.Size(159, 22);
            this.edit_input.TabIndex = 9;
            this.toolTip2.SetToolTip(this.edit_input, "Enter the value you wish to add to the dataset");
            this.edit_input.Visible = false;
            this.edit_input.TextChanged += new System.EventHandler(this.edit_input_TextChanged);
            // 
            // display_searchbox
            // 
            this.display_searchbox.Location = new System.Drawing.Point(29, 241);
            this.display_searchbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.display_searchbox.Name = "display_searchbox";
            this.display_searchbox.ReadOnly = true;
            this.display_searchbox.Size = new System.Drawing.Size(159, 22);
            this.display_searchbox.TabIndex = 10;
            this.toolTip1.SetToolTip(this.display_searchbox, "Results from searches will be displayed here");
            this.display_searchbox.TextChanged += new System.EventHandler(this.display_searchbox_TextChanged);
            // 
            // value_label
            // 
            this.value_label.AutoSize = true;
            this.value_label.Location = new System.Drawing.Point(253, 108);
            this.value_label.Name = "value_label";
            this.value_label.Size = new System.Drawing.Size(77, 16);
            this.value_label.TabIndex = 11;
            this.value_label.Text = "Enter value:";
            this.value_label.Visible = false;
            this.value_label.Click += new System.EventHandler(this.value_label_Click);
            // 
            // index_label
            // 
            this.index_label.AutoSize = true;
            this.index_label.Location = new System.Drawing.Point(253, 65);
            this.index_label.Name = "index_label";
            this.index_label.Size = new System.Drawing.Size(76, 16);
            this.index_label.TabIndex = 12;
            this.index_label.Text = "Enter index:";
            this.index_label.Visible = false;
            // 
            // txtbox_search
            // 
            this.txtbox_search.Location = new System.Drawing.Point(255, 66);
            this.txtbox_search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbox_search.Name = "txtbox_search";
            this.txtbox_search.Size = new System.Drawing.Size(160, 22);
            this.txtbox_search.TabIndex = 13;
            this.toolTip1.SetToolTip(this.txtbox_search, "Enter the value you wish to search for here");
            this.txtbox_search.TextChanged += new System.EventHandler(this.txtbox_search_TextChanged);
            // 
            // randomise_data
            // 
            this.randomise_data.Location = new System.Drawing.Point(29, 190);
            this.randomise_data.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.randomise_data.Name = "randomise_data";
            this.randomise_data.Size = new System.Drawing.Size(132, 23);
            this.randomise_data.TabIndex = 14;
            this.randomise_data.Text = "Randomise data";
            this.toolTip1.SetToolTip(this.randomise_data, "This button will randomise all data, randomised data will need to be sorted again" +
        "");
            this.randomise_data.UseVisualStyleBackColor = true;
            // 
            // result_label
            // 
            this.result_label.AutoSize = true;
            this.result_label.Location = new System.Drawing.Point(25, 222);
            this.result_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.result_label.Name = "result_label";
            this.result_label.Size = new System.Drawing.Size(55, 16);
            this.result_label.TabIndex = 15;
            this.result_label.Text = "Results:";
            // 
            // Options_groupbox
            // 
            this.Options_groupbox.Controls.Add(this.range_button);
            this.Options_groupbox.Controls.Add(this.average_button);
            this.Options_groupbox.Controls.Add(this.mode_button);
            this.Options_groupbox.Controls.Add(this.mid_button);
            this.Options_groupbox.Location = new System.Drawing.Point(447, 126);
            this.Options_groupbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Options_groupbox.Name = "Options_groupbox";
            this.Options_groupbox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Options_groupbox.Size = new System.Drawing.Size(135, 137);
            this.Options_groupbox.TabIndex = 16;
            this.Options_groupbox.TabStop = false;
            this.Options_groupbox.Text = "Calculate";
            this.toolTip1.SetToolTip(this.Options_groupbox, "Use these buttons to select what to calculate");
            this.Options_groupbox.Enter += new System.EventHandler(this.Options_groupbox_Enter);
            // 
            // range_button
            // 
            this.range_button.AutoSize = true;
            this.range_button.Location = new System.Drawing.Point(8, 111);
            this.range_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.range_button.Name = "range_button";
            this.range_button.Size = new System.Drawing.Size(69, 20);
            this.range_button.TabIndex = 3;
            this.range_button.TabStop = true;
            this.range_button.Text = "Range";
            this.range_button.UseVisualStyleBackColor = true;
            // 
            // average_button
            // 
            this.average_button.AutoSize = true;
            this.average_button.Location = new System.Drawing.Point(8, 82);
            this.average_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.average_button.Name = "average_button";
            this.average_button.Size = new System.Drawing.Size(80, 20);
            this.average_button.TabIndex = 2;
            this.average_button.TabStop = true;
            this.average_button.Text = "Average";
            this.average_button.UseVisualStyleBackColor = true;
            // 
            // mode_button
            // 
            this.mode_button.AutoSize = true;
            this.mode_button.Location = new System.Drawing.Point(8, 54);
            this.mode_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mode_button.Name = "mode_button";
            this.mode_button.Size = new System.Drawing.Size(63, 20);
            this.mode_button.TabIndex = 1;
            this.mode_button.TabStop = true;
            this.mode_button.Text = "Mode";
            this.mode_button.UseVisualStyleBackColor = true;
            // 
            // mid_button
            // 
            this.mid_button.AutoSize = true;
            this.mid_button.Location = new System.Drawing.Point(8, 23);
            this.mid_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mid_button.Name = "mid_button";
            this.mid_button.Size = new System.Drawing.Size(102, 20);
            this.mid_button.TabIndex = 0;
            this.mid_button.TabStop = true;
            this.mid_button.Text = "Mid-extreme";
            this.mid_button.UseVisualStyleBackColor = true;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(447, 30);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(100, 28);
            this.calculateButton.TabIndex = 17;
            this.calculateButton.Text = "Calculate";
            this.toolTip1.SetToolTip(this.calculateButton, "Use this button to activate one of the calculations chosen below");
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // calculate_resultbox
            // 
            this.calculate_resultbox.FormattingEnabled = true;
            this.calculate_resultbox.ItemHeight = 16;
            this.calculate_resultbox.Location = new System.Drawing.Point(451, 69);
            this.calculate_resultbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.calculate_resultbox.Name = "calculate_resultbox";
            this.calculate_resultbox.Size = new System.Drawing.Size(128, 52);
            this.calculate_resultbox.TabIndex = 18;
            this.toolTip1.SetToolTip(this.calculate_resultbox, "Results from calculations will be displayed here");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 295);
            this.Controls.Add(this.calculate_resultbox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.Options_groupbox);
            this.Controls.Add(this.result_label);
            this.Controls.Add(this.randomise_data);
            this.Controls.Add(this.txtbox_search);
            this.Controls.Add(this.index_label);
            this.Controls.Add(this.value_label);
            this.Controls.Add(this.display_searchbox);
            this.Controls.Add(this.edit_input);
            this.Controls.Add(this.mode_groupbox);
            this.Controls.Add(this.displaydata1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txtboxInput);
            this.Controls.Add(this.displayData);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mode_groupbox.ResumeLayout(false);
            this.mode_groupbox.PerformLayout();
            this.Options_groupbox.ResumeLayout(false);
            this.Options_groupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox displayData;
        private System.Windows.Forms.TextBox txtboxInput;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button displaydata1;
        private System.Windows.Forms.GroupBox mode_groupbox;
        private System.Windows.Forms.RadioButton editmode_btn;
        private System.Windows.Forms.RadioButton searchmode_btn;
        private System.Windows.Forms.TextBox edit_input;
        private System.Windows.Forms.RadioButton sortmode_btn;
        private System.Windows.Forms.TextBox display_searchbox;
        private System.Windows.Forms.Label value_label;
        private System.Windows.Forms.Label index_label;
        private System.Windows.Forms.TextBox txtbox_search;
        private System.Windows.Forms.Button randomise_data;
        private System.Windows.Forms.Label result_label;
        private System.Windows.Forms.GroupBox Options_groupbox;
        private System.Windows.Forms.RadioButton range_button;
        private System.Windows.Forms.RadioButton average_button;
        private System.Windows.Forms.RadioButton mode_button;
        private System.Windows.Forms.RadioButton mid_button;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.RadioButton sequentialSearch_button;
        private System.Windows.Forms.ListBox calculate_resultbox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}

