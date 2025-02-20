using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
            var screen = Screen.FromControl(this);
            this.Top = screen.Bounds.Height / 2 - this.Height / 2;
            this.Left = screen.Bounds.Width / 2 - this.Width / 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (filter_check_minus.Checked == false && filter_check_plus.Checked == false && filter_check_multiply.Checked == false) { throw new Exception(); }

                setting_value["example_quantity"] = int.Parse(filter_task_quantity.Text);
                setting_value["min_answer_value"] = int.Parse(filter_min_answer_value.Text);
                setting_value["max_answer_value"] = int.Parse(filter_max_answer_value.Text);
                setting_value["plus"] = filter_check_plus.Checked ? 1 : 0;
                setting_value["minus"] = filter_check_minus.Checked ? 1 : 0;
                setting_value["multiply"] = filter_check_multiply.Checked ? 1 : 0;
                if (setting_value["example_quantity"] <= 0 || setting_value["example_quantity"] > 100) { throw new Exception(); }
                if (setting_value["min_answer_value"] >= setting_value["max_answer_value"]) { throw new Exception(); }
            }

            catch
            {
                MessageBox.Show("Неверное заполнение фильтров", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Form2 form2 = new Form2(setting_value);
            this.Hide();
            form2.FormClosed += (s, args) => this.Show();
            form2.Show();

        }

        private void filterBoxs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }
    }
}
