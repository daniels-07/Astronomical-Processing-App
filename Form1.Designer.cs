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
            this.txtbox_search = new System.Windows.Forms.TextBox();
            this.mode_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // displayData
            // 
            this.displayData.FormattingEnabled = true;
            this.displayData.Location = new System.Drawing.Point(22, 53);
            this.displayData.Name = "displayData";
            this.displayData.Size = new System.Drawing.Size(120, 95);
            this.displayData.TabIndex = 0;
            this.displayData.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txtboxInput
            // 
            this.txtboxInput.Location = new System.Drawing.Point(192, 53);
            this.txtboxInput.Name = "txtboxInput";
            this.txtboxInput.ReadOnly = true;
            this.txtboxInput.Size = new System.Drawing.Size(120, 20);
            this.txtboxInput.TabIndex = 2;
            this.txtboxInput.Visible = false;
            this.txtboxInput.TextChanged += new System.EventHandler(this.txtboxInput_TextChanged);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(193, 24);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 6;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // displaydata1
            // 
            this.displaydata1.Location = new System.Drawing.Point(22, 24);
            this.displaydata1.Name = "displaydata1";
            this.displaydata1.Size = new System.Drawing.Size(75, 23);
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
            this.mode_groupbox.Location = new System.Drawing.Point(193, 127);
            this.mode_groupbox.Name = "mode_groupbox";
            this.mode_groupbox.Size = new System.Drawing.Size(98, 87);
            this.mode_groupbox.TabIndex = 8;
            this.mode_groupbox.TabStop = false;
            this.mode_groupbox.Text = "Select mode";
            this.mode_groupbox.Enter += new System.EventHandler(this.mode_groupbox_Enter);
            // 
            // sortmode_btn
            // 
            this.sortmode_btn.AutoSize = true;
            this.sortmode_btn.Location = new System.Drawing.Point(6, 64);
            this.sortmode_btn.Name = "sortmode_btn";
            this.sortmode_btn.Size = new System.Drawing.Size(73, 17);
            this.sortmode_btn.TabIndex = 2;
            this.sortmode_btn.TabStop = true;
            this.sortmode_btn.Text = "Sort mode";
            this.sortmode_btn.UseVisualStyleBackColor = true;
            // 
            // editmode_btn
            // 
            this.editmode_btn.AutoSize = true;
            this.editmode_btn.Location = new System.Drawing.Point(6, 42);
            this.editmode_btn.Name = "editmode_btn";
            this.editmode_btn.Size = new System.Drawing.Size(72, 17);
            this.editmode_btn.TabIndex = 1;
            this.editmode_btn.TabStop = true;
            this.editmode_btn.Text = "Edit mode";
            this.editmode_btn.UseVisualStyleBackColor = true;
            this.editmode_btn.CheckedChanged += new System.EventHandler(this.editmode_btn_CheckedChanged);
            // 
            // searchmode_btn
            // 
            this.searchmode_btn.AutoSize = true;
            this.searchmode_btn.Location = new System.Drawing.Point(6, 19);
            this.searchmode_btn.Name = "searchmode_btn";
            this.searchmode_btn.Size = new System.Drawing.Size(88, 17);
            this.searchmode_btn.TabIndex = 0;
            this.searchmode_btn.TabStop = true;
            this.searchmode_btn.Text = "Search mode";
            this.searchmode_btn.UseVisualStyleBackColor = true;
            // 
            // edit_input
            // 
            this.edit_input.Location = new System.Drawing.Point(193, 102);
            this.edit_input.Name = "edit_input";
            this.edit_input.Size = new System.Drawing.Size(120, 20);
            this.edit_input.TabIndex = 9;
            this.edit_input.Visible = false;
            this.edit_input.TextChanged += new System.EventHandler(this.edit_input_TextChanged);
            // 
            // display_searchbox
            // 
            this.display_searchbox.Location = new System.Drawing.Point(22, 196);
            this.display_searchbox.Name = "display_searchbox";
            this.display_searchbox.ReadOnly = true;
            this.display_searchbox.Size = new System.Drawing.Size(120, 20);
            this.display_searchbox.TabIndex = 10;
            this.display_searchbox.TextChanged += new System.EventHandler(this.display_searchbox_TextChanged);
            // 
            // value_label
            // 
            this.value_label.AutoSize = true;
            this.value_label.Location = new System.Drawing.Point(190, 88);
            this.value_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.value_label.Name = "value_label";
            this.value_label.Size = new System.Drawing.Size(64, 13);
            this.value_label.TabIndex = 11;
            this.value_label.Text = "Enter value:";
            this.value_label.Visible = false;
            this.value_label.Click += new System.EventHandler(this.value_label_Click);
            // 
            // index_label
            // 
            this.index_label.AutoSize = true;
            this.index_label.Location = new System.Drawing.Point(190, 53);
            this.index_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.index_label.Name = "index_label";
            this.index_label.Size = new System.Drawing.Size(63, 13);
            this.index_label.TabIndex = 12;
            this.index_label.Text = "Enter index:";
            this.index_label.Visible = false;
            // 
            // txtbox_search
            // 
            this.txtbox_search.Location = new System.Drawing.Point(192, 53);
            this.txtbox_search.Name = "txtbox_search";
            this.txtbox_search.Size = new System.Drawing.Size(121, 20);
            this.txtbox_search.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 240);
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
        private System.Windows.Forms.TextBox txtbox_search;
    }
}

