namespace WinFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label_example = new Label();
            answer_textBox = new TextBox();
            button_for_answer = new Button();
            example_counters = new Label();
            result_label = new Label();
            SuspendLayout();
            // 
            // label_example
            // 
            label_example.AutoSize = true;
            label_example.Location = new Point(325, 154);
            label_example.Name = "label_example";
            label_example.Size = new Size(38, 15);
            label_example.TabIndex = 0;
            label_example.Text = "label1";
            // 
            // answer_textBox
            // 
            answer_textBox.Location = new Point(387, 151);
            answer_textBox.Name = "answer_textBox";
            answer_textBox.Size = new Size(58, 23);
            answer_textBox.TabIndex = 1;
            // 
            // button_for_answer
            // 
            button_for_answer.Location = new Point(350, 213);
            button_for_answer.Name = "button_for_answer";
            button_for_answer.Size = new Size(75, 23);
            button_for_answer.TabIndex = 2;
            button_for_answer.Text = "Ответить";
            button_for_answer.UseVisualStyleBackColor = true;
            button_for_answer.Click += button_for_answer_Click;
            // 
            // example_counters
            // 
            example_counters.AutoSize = true;
            example_counters.Location = new Point(663, 47);
            example_counters.Name = "example_counters";
            example_counters.Size = new Size(38, 15);
            example_counters.TabIndex = 3;
            example_counters.Text = "label2";
            // 
            // result_label
            // 
            result_label.AutoSize = true;
            result_label.Location = new Point(369, 280);
            result_label.Name = "result_label";
            result_label.Size = new Size(38, 15);
            result_label.TabIndex = 4;
            result_label.Text = "label1";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(result_label);
            Controls.Add(example_counters);
            Controls.Add(button_for_answer);
            Controls.Add(answer_textBox);
            Controls.Add(label_example);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_example;
        private TextBox answer_textBox;
        private Button button_for_answer;
        private Label example_counters;
        private Label result_label;
    }
}