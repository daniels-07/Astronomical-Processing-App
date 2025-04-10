using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Astronomical_Processing_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[] randomData = new int[24];
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
                int index;
                if (int.TryParse(txtboxInput.Text, out index) && index >= 0 && index < randomData.Length)
                {
                    displayData.Items.Clear();
                    displayData.Items.Add(randomData[index]);
                }
                else
                {
                    displayData.Items.Add("Invalid input, please");
                    //TEMPORARY SOLUTION
                    displayData.Items.Add("enter an input between");
                    displayData.Items.Add("0 and 23");
                }
            };
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
    }
}
