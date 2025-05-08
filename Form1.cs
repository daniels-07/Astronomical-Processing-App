using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

// Daniel Shadbolt, Sprint 1
// Date: 1/05/2025
// Version: 1.0
// Astronomical Processing Data
// This program randomly generates data to simulate data gathered by an observatory which can be sorted, edited and searched, the data is stored in an array with 24 elements.


namespace Astronomical_Processing_App
{
    public partial class Form1 : Form
    {
        int[] randomData = new int[24];
        static int max = 24;
        bool is_sorted = false;
        public Form1()
        {
            InitializeComponent();
            searchmode_btn.Checked = true;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            for (int i = 0; i < randomData.Length; i++)
            {
                randomData[i] = rand.Next(10, 90);
            }
            displaydata1.Click += (s, args) =>
            {
                displayData.Items.Clear();
                for (int i = 0; i < randomData.Length; i++)
                {
                    displayData.Items.Add(randomData[i]);
                }
            };
            btn_search.Click += (s, args) =>
            {
                if (searchmode_btn.Checked)
                {
                    binary_Search(txtboxInput.Text, EventArgs.Empty);
                }
                else if (editmode_btn.Checked)
                {
                    editArray(null, EventArgs.Empty);
                }
                else if (sortmode_btn.Checked)
                {
                    bubble_sort(null, EventArgs.Empty);
                }
            };
            editmode_btn.Click += (s, args) =>
            {
                if (editmode_btn.Checked)
                {
                    btn_search.Text = "Edit";
                    txtboxInput.Text = "";
                    edit_input.Text = "";
                    edit_input.Visible = true;
                    display_searchbox.Visible = true;
                    txtboxInput.ReadOnly = false;
                    txtboxInput.Visible = true;
                    edit_input.ReadOnly = false;
                    index_label.Visible = true;
                    txtbox_search.ReadOnly = true;
                    txtbox_search.Visible = false;
                    value_label.Visible = true;
                    txtboxInput.Location = new Point(193, 65);
                    edit_input.Location = new Point(193, 100);
                }
                ;
            };
            searchmode_btn.Click += (s, args) =>
            {
                if (searchmode_btn.Checked)
                {
                    btn_search.Text = "Search";
                    txtboxInput.Text = "";
                    edit_input.Visible = false;
                    display_searchbox.Visible = true;
                    txtboxInput.ReadOnly = true;
                    txtboxInput.Visible = false;
                    txtbox_search.ReadOnly = false;
                    txtbox_search.Visible = true;
                    index_label.Visible = false;
                    value_label.Visible= false;
                    txtboxInput.Location = new Point(193, 53);
                }
                ;
            };
            sortmode_btn.Click += (s, args) =>
            {
                if (sortmode_btn.Checked)
                {
                    btn_search.Text = "Sort";
                    txtboxInput.Text = "";
                    edit_input.Text = "";
                    edit_input.Visible = true; ;
                    display_searchbox.Visible = false;
                    edit_input.ReadOnly = true;
                    txtboxInput.ReadOnly = true;
                    txtboxInput.Visible = true;
                    index_label.Visible = false;
                    txtbox_search.ReadOnly = true;
                    txtbox_search.Visible = false;
                    value_label.Visible = false;
                    txtboxInput.Location = new Point(193, 53);
                    edit_input.Location = new Point(193, 83);
                }
            };
        }
        private void binary_Search(object sender, EventArgs e) 
        {
            int mid;
            int lowBound = 0;
            int highBound = max;
            int target;
            if (is_sorted == false)
            {
                bubble_sort(null, EventArgs.Empty);
            }
            if (!(Int32.TryParse(txtbox_search.Text, out target)))
            {
                display_searchbox.Text = "You must enter an integer";
                return;
            }
            while (lowBound <= highBound) // Check “<” or “<=”
            {
                // Display list
                ShowArrayRange(lowBound, highBound);
                // Find the mid-point
                mid = (lowBound + highBound) / 2;
                if (randomData[mid] == target)
                {
                    // Target has been found
                    display_searchbox.Text = "Found at index " + mid;
                    return;
                }
                else if (randomData[mid] >= target)
                {
                    highBound = mid - 1;
                }
                else if (randomData[mid] <= target)
                {
                    lowBound = mid + 1;
                }
            }
            display_searchbox.Text = "Not Found, try again.";
        }
        // Method to display Array
        private void ShowArrayRange(int low, int high)
        {
            displayData.Items.Clear();
            for (int i = low; i < high; i++)
            {
                displayData.Items.Add(randomData[i]);
            }
        }
        private void bubble_sort(object sender, EventArgs e) 
        {
            int temp = 0;
            for (int outer = 0; outer < max; outer++)
            {
                for (int inner = 0; inner < max - 1; inner++)
                {
                    if (randomData[inner] > randomData[inner + 1])
                    {
                        // Swap routine
                        temp = randomData[inner + 1];
                        randomData[inner + 1] = randomData[inner];
                        randomData[inner] = temp;
                    }
                    // Code to demonstrate the bubble sort
                    ShowArray();
                    Application.DoEvents();
                    txtboxInput.Text = inner.ToString();
                    edit_input.Text = outer.ToString();
                    is_sorted = true;
                }
            }
        }
        // Method to display array
        private void ShowArray()
        {
            displayData.Items.Clear();
            for (int i = 0; i < max; i++)
            {
                displayData.Items.Add(randomData[i]);
            }
        }
        private void editArray(object sender, EventArgs e)
        {
            //Parse the input from txtboxinput
            if (!(Int32.TryParse(txtboxInput.Text, out int index)))
            {
                display_searchbox.Text = "You must enter an integer";
                return;
            }
            //Parse the input from edit_input
            if (!(Int32.TryParse(edit_input.Text, out int value)))
            {
                display_searchbox.Text = "You must enter an integer";
                return;
            }
            //Validate the index
            if (index < 0 || index >= max)
            {
                display_searchbox.Text = "Index out of range";
                return;
            }
            //Update the array
            randomData[index] = value;

            //Display the updated array
            ShowArray();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void mode_groupbox_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void editmode_btn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {

        }

        private void display_searchbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void edit_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void value_label_Click(object sender, EventArgs e)
        {

        }

        private void txtbox_search_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
