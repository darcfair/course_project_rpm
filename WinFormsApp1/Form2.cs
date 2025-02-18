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

        private int max_answer_value;
        private int min_answer_value;
        private int example_quantity;
        private List<string> example_types = []; // Типы примеров
        private int current_example = 0; // Текущий пример
        private int correct_answers = 0; // Кол-во правильных примеров
        private int current_сorrect_answer; // Текущий правильный ответ
        private Random random = new Random();

        public Form2(Dictionary<string, int> filter_data)
        {
            InitializeComponent();

            // Передача данных
            max_answer_value = filter_data["max_answer_value"];
            min_answer_value = filter_data["min_answer_value"];
            example_quantity = filter_data["example_quantity"];
            if (filter_data["plus"] == 1) example_types.Add("plus");
            if (filter_data["minus"] == 1) example_types.Add("minus");
            if (filter_data["multiply"] == 1) example_types.Add("multiply");

            generate_new_example();
        }

        private void generate_new_example()
        {
           
            if (current_example >= example_quantity)
            {
                end_play();
                return;
            } // Проверка на конец примеров

            current_example++;
            // Функция по обнавлению статы
            update_example_counter();


            // Выбор типа примера
            string example_type = example_types[random.Next(example_types.Count())];

            int a;
            int b;

            switch (example_type)
            {
                case "plus":
                    current_сorrect_answer = random.Next(min_answer_value, max_answer_value + 1);
                    a = random.Next(min_answer_value, current_сorrect_answer);
                    b = current_сorrect_answer - a;
                    label_example.Text = $"{a} + {b} = ";
                    label_example.Left= answer_textBox.Location.X - label_example.Width;
                    break;


                case "minus":
                    current_сorrect_answer = random.Next(min_answer_value, max_answer_value + 1);
                    b = random.Next(0, max_answer_value - current_сorrect_answer + 1);
                    a = current_сorrect_answer + b;
                    current_сorrect_answer = a - b;
                    label_example.Text = $"{a} - {b} = ";
                    break;


                case "multiply":
                    a = random.Next(1, (int)Math.Sqrt(max_answer_value));
                    b = random.Next(1, (int)Math.Sqrt(max_answer_value));
                    current_сorrect_answer = a * b;
                    label_example.Text = $"{a} * {b} = ";
                    break;
            }
            answer_textBox.Clear();


        }

        private void button_for_answer_Click(object sender, EventArgs e)
        {
            if (int.TryParse(answer_textBox.Text, out int user_answer))
            {
                if (user_answer == current_сorrect_answer)
                {
                    correct_answers++;
                    result_label.Text = "Правильно";
                    result_label.ForeColor = Color.Green;
                }
                else
                {
                    result_label.Text = $"Неверно! ❌ Правильный ответ: {current_сorrect_answer}";
                    result_label.ForeColor = Color.Red;
                }
                generate_new_example();
            }

            else
            {
                MessageBox.Show("Введите целое число!", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                answer_textBox.Focus();
            }

        }


        private void update_example_counter()
        {
            example_counters.Text = $"{current_example}/{example_quantity}";
        }


        private void end_play()
        {
            MessageBox.Show($"Тест завершён!\nПравильных ответов: {correct_answers} из {example_quantity}",
                            "Результат",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            this.Close();
        }

        private void answer_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                button_for_answer_Click(sender, e);
            }
        }
    }
}

