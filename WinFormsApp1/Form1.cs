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
    public partial class Form1 : Form
    {
        Dictionary<string, int> setting_value = new Dictionary<string, int>();


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setting_value["maxValue"] = int.Parse(textBox1.Text);
            setting_value["plus"] = checkBox1.Checked ? 1 : 0;
            setting_value["minus"] = checkBox2.Checked ? 1 : 0;
            setting_value["multiply"] = checkBox3.Checked ? 1 : 0;

            Form2 form2 = new Form2(setting_value);
            this.Hide();
            form2.FormClosed += (s, args) => this.Show();
            form2.Show();
        }
    }
}
