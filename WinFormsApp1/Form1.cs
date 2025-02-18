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
            setting_value["example_quantity"] = int.Parse(filter_task_quantity.Text);
            setting_value["min_answer_value"] = int.Parse(filter_min_answer_value.Text);
            setting_value["max_answer_value"] = int.Parse(filter_max_answer_value.Text);
            setting_value["plus"] = filter_check_plus.Checked ? 1 : 0;
            setting_value["minus"] = filter_check_minus.Checked ? 1 : 0;
            setting_value["multiply"] = filter_check_multiply.Checked ? 1 : 0;

            Form2 form2 = new Form2(setting_value);
            this.Hide();
            form2.FormClosed += (s, args) => this.Show();
            form2.Show();
        }
    }
}
