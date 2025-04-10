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
            this.displaydata1 = new System.Windows.Forms.RadioButton();
            this.editData = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // displayData
            // 
            this.displayData.FormattingEnabled = true;
            this.displayData.Location = new System.Drawing.Point(36, 118);
            this.displayData.Name = "displayData";
            this.displayData.Size = new System.Drawing.Size(120, 95);
            this.displayData.TabIndex = 0;
            this.displayData.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // displaydata1
            // 
            this.displaydata1.AutoSize = true;
            this.displaydata1.Location = new System.Drawing.Point(36, 95);
            this.displaydata1.Name = "displaydata1";
            this.displaydata1.Size = new System.Drawing.Size(85, 17);
            this.displaydata1.TabIndex = 1;
            this.displaydata1.TabStop = true;
            this.displaydata1.Text = "Display Data";
            this.displaydata1.UseVisualStyleBackColor = true;
            // 
            // editData
            // 
            this.editData.Location = new System.Drawing.Point(155, 21);
            this.editData.Name = "editData";
            this.editData.Size = new System.Drawing.Size(103, 20);
            this.editData.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 232);
            this.Controls.Add(this.editData);
            this.Controls.Add(this.displaydata1);
            this.Controls.Add(this.displayData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox displayData;
        private System.Windows.Forms.RadioButton displaydata1;
        private System.Windows.Forms.TextBox editData;
    }
}

