using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Astronomical_Processing_App
{
    public partial class Form1 : Form
    {
        int[] randomData = new int[24];
        static int max = 24;
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
                    
                }
                else if (sortmode_btn.Checked)
                {

                }
            };
            editmode_btn.Click += (s, args) =>
            {
                if (editmode_btn.Checked)
                {
                    btn_search.Text = "Edit";
                    txtboxInput.Text = "Enter element:";
                    edit_input.Visible = true;
                    display_searchbox.Visible = false;
                };
            };
            searchmode_btn.Click += (s, args) =>
            {
                if (searchmode_btn.Checked)
                {
                    btn_search.Text = "Search";
                    txtboxInput.Text = "";
                    edit_input.Visible = false;
                    display_searchbox.Visible = true;
                };
            };
            sortmode_btn.Click += (s, args) =>
            {
                if (sortmode_btn.Checked)
                {
                    btn_search.Text = "Sort";
                    txtboxInput.Text = "";
                    edit_input.Visible = false; ;
                    display_searchbox.Visible = false;
                }
            };
        }

        private void binary_Search(object sender, EventArgs e)
        {
            int mid;
            int lowBound = 0;
            int highBound = max;
            int target;
            if (!(Int32.TryParse(txtboxInput.Text, out target)))
            {
                display_searchbox.Text = "You must enter an integer";
                return;
            }
            while (lowBound <= highBound) // Check “<” or “<=”
            {
                // Display list
                ShowArray(lowBound, highBound);
                // Find the mid-point
                mid = (lowBound + highBound) / 2;
                // Pause with a messagebox
                MessageBox.Show("Low:" + lowBound + " Mid:" + mid +
               " High:" + highBound);
                if (randomData[mid] == target)
                {
                    // Target has been found
                    displayData.Items.Add("Found at index " + mid);
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
        private void ShowArray(int low, int high)
        {
            displayData.Items.Clear();
            for (int i = low; i < high; i++)
            {
                displayData.Items.Add(randomData[i]);
            }
        }
        // Method to fill Array with random numbers
        private void FillArray()
        {
            // Create a random number
            Random rand = new Random();
            for (int i = 0; i < max; i++)
            {
                // Random number 0..100
                randomData[i] = rand.Next(100);
            }
            // Use the build in sort method
            Array.Sort(randomData);
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
    }
}
