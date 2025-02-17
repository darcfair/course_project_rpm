using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Dictionary<string, int> receivedData;

        public Form2(Dictionary<string, int> data)
        {
            InitializeComponent();
            receivedData = data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = $"{receivedData["maxValue"]} + {((receivedData["plus"] == 1) ? 'g' : 0)}";
        }
    }
}
