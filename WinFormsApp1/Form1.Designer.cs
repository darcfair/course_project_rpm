namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            start_game_button = new Button();
            filter_min_answer_value = new TextBox();
            filter_check_multiply = new CheckBox();
            filter_check_minus = new CheckBox();
            filter_check_plus = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            filter_max_answer_value = new TextBox();
            filter_task_quantity = new TextBox();
            label5 = new Label();
            filterBox = new GroupBox();
            filterBox.SuspendLayout();
            SuspendLayout();
            // 
            // start_game_button
            // 
            start_game_button.Location = new Point(133, 201);
            start_game_button.Name = "start_game_button";
            start_game_button.Size = new Size(75, 23);
            start_game_button.TabIndex = 0;
            start_game_button.Text = "ИГРАТЬ";
            start_game_button.UseVisualStyleBackColor = true;
            start_game_button.Click += button1_Click;
            // 
            // filter_min_answer_value
            // 
            filter_min_answer_value.Location = new Point(47, 122);
            filter_min_answer_value.Name = "filter_min_answer_value";
            filter_min_answer_value.Size = new Size(100, 23);
            filter_min_answer_value.TabIndex = 1;
            // 
            // filter_check_multiply
            // 
            filter_check_multiply.AutoSize = true;
            filter_check_multiply.Location = new Point(155, 250);
            filter_check_multiply.Name = "filter_check_multiply";
            filter_check_multiply.Size = new Size(91, 19);
            filter_check_multiply.TabIndex = 2;
            filter_check_multiply.Text = "Умножение";
            filter_check_multiply.UseVisualStyleBackColor = true;
            // 
            // filter_check_minus
            // 
            filter_check_minus.AutoSize = true;
            filter_check_minus.Location = new Point(251, 193);
            filter_check_minus.Name = "filter_check_minus";
            filter_check_minus.Size = new Size(87, 19);
            filter_check_minus.TabIndex = 3;
            filter_check_minus.Text = "Вычитание";
            filter_check_minus.UseVisualStyleBackColor = true;
            // 
            // filter_check_plus
            // 
            filter_check_plus.AutoSize = true;
            filter_check_plus.Location = new Point(64, 193);
            filter_check_plus.Name = "filter_check_plus";
            filter_check_plus.Size = new Size(83, 19);
            filter_check_plus.TabIndex = 4;
            filter_check_plus.Text = "Сложение";
            filter_check_plus.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Location = new Point(163, 34);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 5;
            label1.Text = "Выбор фильтров";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Enabled = false;
            label2.Location = new Point(47, 68);
            label2.Name = "label2";
            label2.Size = new Size(133, 15);
            label2.TabIndex = 6;
            label2.Text = "Диапозон вычислений";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Enabled = false;
            label3.Location = new Point(47, 104);
            label3.Name = "label3";
            label3.Size = new Size(21, 15);
            label3.TabIndex = 7;
            label3.Text = "От";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Enabled = false;
            label4.Location = new Point(278, 104);
            label4.Name = "label4";
            label4.Size = new Size(22, 15);
            label4.TabIndex = 9;
            label4.Text = "До";
            // 
            // filter_max_answer_value
            // 
            filter_max_answer_value.Location = new Point(278, 122);
            filter_max_answer_value.Name = "filter_max_answer_value";
            filter_max_answer_value.Size = new Size(100, 23);
            filter_max_answer_value.TabIndex = 8;
            // 
            // filter_task_quantity
            // 
            filter_task_quantity.Location = new Point(163, 358);
            filter_task_quantity.Name = "filter_task_quantity";
            filter_task_quantity.Size = new Size(100, 23);
            filter_task_quantity.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Enabled = false;
            label5.Location = new Point(155, 314);
            label5.Name = "label5";
            label5.Size = new Size(108, 15);
            label5.TabIndex = 11;
            label5.Text = "Количество задач:";
            // 
            // filterBox
            // 
            filterBox.Controls.Add(label2);
            filterBox.Controls.Add(label1);
            filterBox.Controls.Add(label5);
            filterBox.Controls.Add(filter_min_answer_value);
            filterBox.Controls.Add(filter_task_quantity);
            filterBox.Controls.Add(filter_check_multiply);
            filterBox.Controls.Add(label4);
            filterBox.Controls.Add(filter_check_minus);
            filterBox.Controls.Add(filter_max_answer_value);
            filterBox.Controls.Add(filter_check_plus);
            filterBox.Controls.Add(label3);
            filterBox.Location = new Point(373, 12);
            filterBox.Name = "filterBox";
            filterBox.Size = new Size(415, 416);
            filterBox.TabIndex = 12;
            filterBox.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(filterBox);
            Controls.Add(start_game_button);
            Name = "Form1";
            Text = "Form1";
            filterBox.ResumeLayout(false);
            filterBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button start_game_button;
        private TextBox filter_min_answer_value;
        private CheckBox filter_check_multiply;
        private CheckBox filter_check_minus;
        private CheckBox filter_check_plus;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox filter_max_answer_value;
        private TextBox filter_task_quantity;
        private Label label5;
        private GroupBox filterBox;
    }
}
