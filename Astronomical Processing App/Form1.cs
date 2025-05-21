using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

// Daniel Shadbolt, Sprint 2
// Date: 15/05/2025
// Version: 2.0
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
            // This generates random data and fills the array
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
                    displayData.Items.Add($"{i}: {randomData[i]}");
                }
            };
            // This code calls the search, edit and sort methods based on what mode is toggled.
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
                else if (sequentialSearch_button.Checked)
                {
                    sequential_search(txtboxInput.Text, EventArgs.Empty);
                }
            };
            randomise_data.Click += (s, args) =>
            {
                randomise_Data(null, EventArgs.Empty);
            };
            // The code below changes the GUI structure when each individual button is toggled in order to switch between Search, Sort and Edit mode
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
                    result_label.Visible = true;
                    toolTip2.SetToolTip(edit_input, "Enter the value you wish to add to the dataset");
                    toolTip2.SetToolTip(txtboxInput, "Enter the index of the entry you wish to edit");
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
                    result_label.Visible = true;
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
                    result_label.Visible = false;
                    toolTip2.SetToolTip(edit_input, "Displays each row of data");
                    toolTip2.SetToolTip(txtboxInput, "Displays each item within the current row");
                }
            };
            sequentialSearch_button.Click += (s, args) =>
            {
                if (sequentialSearch_button.Checked)
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
                    value_label.Visible = false;
                    txtboxInput.Location = new Point(193, 53);
                    result_label.Visible = true;
                }
            };
            // This code allows the user to select if they wish to calculate the mid extreme, mode, average or range
            calculateButton.Click += (s, args) =>
            {
                if (mid_button.Checked)
                {
                    calculate_mid_extreme(null, EventArgs.Empty);
                }
                if (mode_button.Checked)
                {
                    calculate_mode(null, EventArgs.Empty);
                }
                if (average_button.Checked)
                {
                    calculate_average(null, EventArgs.Empty);
                }
                if (range_button.Checked)
                {
                    calculate_range(null, EventArgs.Empty);
                }
                if (!mid_button.Checked && !mode_button.Checked && !average_button.Checked && !range_button.Checked)
                {
                    calculate_resultbox.Text = "Please select an option";
                }
            };
        }
        // Method to randomise data
        private void randomise_Data(object sender, EventArgs e)
        {
            Random rand = new Random();
            for (int i = 0; i < randomData.Length; i++)
            {
                randomData[i] = rand.Next(10, 90);
            }
            ShowArray();
        }
        // Binary search method
        private void binary_Search(object sender, EventArgs e) 
        {
            int mid;
            int lowBound = 0;
            int highBound = max - 1;
            int target;
            // This if statement automatically sorts the data if it has not already been sorted
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
                // Find the mid-point
                mid = (lowBound + highBound) / 2;
                if (randomData[mid] == target)
                {
                    // Target has been found
                    display_searchbox.Text = "Found at index " + mid;
                    displayData.Items.Clear();
                    displayData.Items.Add($"{mid}: {randomData[mid]}");
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
        // Bubble sort method
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
                displayData.Items.Add($"{i}: {randomData[i]}");
            }
        }
        // Edit array method
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
        private void sequential_search(object sender, EventArgs e)
        {
            string input = txtbox_search.Text.Trim();
            int sequentialTarget;
            if (int.TryParse(txtbox_search.Text, out sequentialTarget))
            {
                bool isFound = false;

                for (int i = 0; i < randomData.Length; i++)
                {
                    if (randomData[i] == sequentialTarget)
                    {
                        display_searchbox.Text = $"Found at index {i}";
                         isFound = true;
                    }

                }
                if (!isFound)
                {
                    display_searchbox.Text = "Not found";
                }
            }
            if (!(int.TryParse(txtbox_search.Text, out sequentialTarget)))
            {
                display_searchbox.Text = "Please enter an integer";
            }
        }
        private void calculate_mid_extreme(object sender, EventArgs e)
        {
            int min = randomData.Min();
            int max = randomData.Max();
            double midextreme = (min + max) / 2.0;
            calculate_resultbox.Items.Clear();
            calculate_resultbox.Items.Add($"midextreme: {midextreme}");
        }
        private void calculate_mode(object sender, EventArgs e)
        {
            var grouped = randomData.GroupBy(n => n).ToList();
            int maxcount = grouped.Max(g => g.Count());

            List<int> modes = grouped
                .Where(g => g.Count() == maxcount)
                .Select(g => g.Key)
                .ToList();

            calculate_resultbox.Items.Clear();
            if (modes.Count == 1)
            {
                calculate_resultbox.Items.Add($"Mode: {modes}");
            }
            else 
            {
                calculate_resultbox.Items.Add($"Modes:");
                foreach (var mode in modes)
                {
                    calculate_resultbox.Items.Add(mode.ToString());
                }
            }

        }
        private void calculate_average(object sender, EventArgs e)
        {
            double average = randomData.Average();
            calculate_resultbox.Items.Clear();
            calculate_resultbox.Items.Add($"Average: {average}");
        }
        private void calculate_range(object sender, EventArgs e)
        {
            int range = randomData.Max() - randomData.Min();
            calculate_resultbox.Items.Clear();
            calculate_resultbox.Items.Add($"Range: {range}");
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

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Options_groupbox_Enter(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
