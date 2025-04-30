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
            this.displayData = new System.Windows.Forms.ListBox();
            this.txtboxInput = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.displaydata1 = new System.Windows.Forms.Button();
            this.mode_groupbox = new System.Windows.Forms.GroupBox();
            this.sortmode_btn = new System.Windows.Forms.RadioButton();
            this.editmode_btn = new System.Windows.Forms.RadioButton();
            this.searchmode_btn = new System.Windows.Forms.RadioButton();
            this.edit_input = new System.Windows.Forms.TextBox();
            this.display_searchbox = new System.Windows.Forms.TextBox();
            this.value_label = new System.Windows.Forms.Label();
            this.index_label = new System.Windows.Forms.Label();
            this.warning_label = new System.Windows.Forms.Label();
            this.mode_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // displayData
            // 
            this.displayData.FormattingEnabled = true;
            this.displayData.ItemHeight = 16;
            this.displayData.Location = new System.Drawing.Point(29, 65);
            this.displayData.Margin = new System.Windows.Forms.Padding(4);
            this.displayData.Name = "displayData";
            this.displayData.Size = new System.Drawing.Size(159, 116);
            this.displayData.TabIndex = 0;
            this.displayData.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txtboxInput
            // 
            this.txtboxInput.Location = new System.Drawing.Point(256, 65);
            this.txtboxInput.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxInput.Name = "txtboxInput";
            this.txtboxInput.Size = new System.Drawing.Size(159, 22);
            this.txtboxInput.TabIndex = 2;
            this.txtboxInput.TextChanged += new System.EventHandler(this.txtboxInput_TextChanged);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(257, 30);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(100, 28);
            this.btn_search.TabIndex = 6;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // displaydata1
            // 
            this.displaydata1.Location = new System.Drawing.Point(29, 30);
            this.displaydata1.Margin = new System.Windows.Forms.Padding(4);
            this.displaydata1.Name = "displaydata1";
            this.displaydata1.Size = new System.Drawing.Size(100, 28);
            this.displaydata1.TabIndex = 7;
            this.displaydata1.Text = "Display Data";
            this.displaydata1.UseVisualStyleBackColor = true;
            // 
            // mode_groupbox
            // 
            this.mode_groupbox.BackColor = System.Drawing.SystemColors.Control;
            this.mode_groupbox.Controls.Add(this.sortmode_btn);
            this.mode_groupbox.Controls.Add(this.editmode_btn);
            this.mode_groupbox.Controls.Add(this.searchmode_btn);
            this.mode_groupbox.Location = new System.Drawing.Point(257, 156);
            this.mode_groupbox.Margin = new System.Windows.Forms.Padding(4);
            this.mode_groupbox.Name = "mode_groupbox";
            this.mode_groupbox.Padding = new System.Windows.Forms.Padding(4);
            this.mode_groupbox.Size = new System.Drawing.Size(131, 107);
            this.mode_groupbox.TabIndex = 8;
            this.mode_groupbox.TabStop = false;
            this.mode_groupbox.Text = "Select mode";
            this.mode_groupbox.Enter += new System.EventHandler(this.mode_groupbox_Enter);
            // 
            // sortmode_btn
            // 
            this.sortmode_btn.AutoSize = true;
            this.sortmode_btn.Location = new System.Drawing.Point(8, 79);
            this.sortmode_btn.Margin = new System.Windows.Forms.Padding(4);
            this.sortmode_btn.Name = "sortmode_btn";
            this.sortmode_btn.Size = new System.Drawing.Size(90, 20);
            this.sortmode_btn.TabIndex = 2;
            this.sortmode_btn.TabStop = true;
            this.sortmode_btn.Text = "Sort mode";
            this.sortmode_btn.UseVisualStyleBackColor = true;
            // 
            // editmode_btn
            // 
            this.editmode_btn.AutoSize = true;
            this.editmode_btn.Location = new System.Drawing.Point(8, 52);
            this.editmode_btn.Margin = new System.Windows.Forms.Padding(4);
            this.editmode_btn.Name = "editmode_btn";
            this.editmode_btn.Size = new System.Drawing.Size(89, 20);
            this.editmode_btn.TabIndex = 1;
            this.editmode_btn.TabStop = true;
            this.editmode_btn.Text = "Edit mode";
            this.editmode_btn.UseVisualStyleBackColor = true;
            this.editmode_btn.CheckedChanged += new System.EventHandler(this.editmode_btn_CheckedChanged);
            // 
            // searchmode_btn
            // 
            this.searchmode_btn.AutoSize = true;
            this.searchmode_btn.Location = new System.Drawing.Point(8, 23);
            this.searchmode_btn.Margin = new System.Windows.Forms.Padding(4);
            this.searchmode_btn.Name = "searchmode_btn";
            this.searchmode_btn.Size = new System.Drawing.Size(109, 20);
            this.searchmode_btn.TabIndex = 0;
            this.searchmode_btn.TabStop = true;
            this.searchmode_btn.Text = "Search mode";
            this.searchmode_btn.UseVisualStyleBackColor = true;
            // 
            // edit_input
            // 
            this.edit_input.Location = new System.Drawing.Point(257, 126);
            this.edit_input.Margin = new System.Windows.Forms.Padding(4);
            this.edit_input.Name = "edit_input";
            this.edit_input.Size = new System.Drawing.Size(159, 22);
            this.edit_input.TabIndex = 9;
            this.edit_input.Visible = false;
            this.edit_input.TextChanged += new System.EventHandler(this.edit_input_TextChanged);
            // 
            // display_searchbox
            // 
            this.display_searchbox.Location = new System.Drawing.Point(29, 241);
            this.display_searchbox.Margin = new System.Windows.Forms.Padding(4);
            this.display_searchbox.Name = "display_searchbox";
            this.display_searchbox.ReadOnly = true;
            this.display_searchbox.Size = new System.Drawing.Size(159, 22);
            this.display_searchbox.TabIndex = 10;
            this.display_searchbox.TextChanged += new System.EventHandler(this.display_searchbox_TextChanged);
            // 
            // value_label
            // 
            this.value_label.AutoSize = true;
            this.value_label.Location = new System.Drawing.Point(254, 108);
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
            // warning_label
            // 
            this.warning_label.Location = new System.Drawing.Point(26, 197);
            this.warning_label.Name = "warning_label";
            this.warning_label.Size = new System.Drawing.Size(206, 40);
            this.warning_label.TabIndex = 13;
            this.warning_label.Text = "Please ensure array is sorted before using search mode";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 295);
            this.Controls.Add(this.warning_label);
            this.Controls.Add(this.index_label);
            this.Controls.Add(this.value_label);
            this.Controls.Add(this.display_searchbox);
            this.Controls.Add(this.edit_input);
            this.Controls.Add(this.mode_groupbox);
            this.Controls.Add(this.displaydata1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txtboxInput);
            this.Controls.Add(this.displayData);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mode_groupbox.ResumeLayout(false);
            this.mode_groupbox.PerformLayout();
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
        private System.Windows.Forms.Label warning_label;
    }
}

