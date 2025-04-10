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

            foreach (int data in randomData)
            {
                listBox1.Items.Add(data);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
