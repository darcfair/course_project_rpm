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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            label6 = new Label();
            filterBox.SuspendLayout();
            SuspendLayout();
            // 
            // start_game_button
            // 
            start_game_button.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold | FontStyle.Italic);
            start_game_button.Location = new Point(141, 197);
            start_game_button.Name = "start_game_button";
            start_game_button.Size = new Size(103, 44);
            start_game_button.TabIndex = 0;
            start_game_button.Text = "ИГРАТЬ";
            start_game_button.UseVisualStyleBackColor = true;
            start_game_button.Click += button1_Click;
            // 
            // filter_min_answer_value
            // 
            filter_min_answer_value.Location = new Point(47, 135);
            filter_min_answer_value.Name = "filter_min_answer_value";
            filter_min_answer_value.Size = new Size(100, 29);
            filter_min_answer_value.TabIndex = 1;
            filter_min_answer_value.Text = "0";
            filter_min_answer_value.KeyPress += filterBoxs_KeyPress;
            // 
            // filter_check_multiply
            // 
            filter_check_multiply.AutoSize = true;
            filter_check_multiply.Location = new Point(156, 278);
            filter_check_multiply.Name = "filter_check_multiply";
            filter_check_multiply.Size = new Size(113, 25);
            filter_check_multiply.TabIndex = 2;
            filter_check_multiply.Text = "Умножение";
            filter_check_multiply.UseVisualStyleBackColor = true;
            // 
            // filter_check_minus
            // 
            filter_check_minus.AutoSize = true;
            filter_check_minus.Location = new Point(241, 247);
            filter_check_minus.Name = "filter_check_minus";
            filter_check_minus.Size = new Size(108, 25);
            filter_check_minus.TabIndex = 3;
            filter_check_minus.Text = "Вычитание";
            filter_check_minus.UseVisualStyleBackColor = true;
            // 
            // filter_check_plus
            // 
            filter_check_plus.AutoSize = true;
            filter_check_plus.Checked = true;
            filter_check_plus.CheckState = CheckState.Checked;
            filter_check_plus.Location = new Point(60, 247);
            filter_check_plus.Name = "filter_check_plus";
            filter_check_plus.Size = new Size(102, 25);
            filter_check_plus.TabIndex = 4;
            filter_check_plus.Text = "Сложение";
            filter_check_plus.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            label1.Location = new Point(144, 25);
            label1.Name = "label1";
            label1.Size = new Size(152, 21);
            label1.TabIndex = 5;
            label1.Text = "Выбор фильтров";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 78);
            label2.Name = "label2";
            label2.Size = new Size(172, 21);
            label2.TabIndex = 6;
            label2.Text = "Диапозон вычислений";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 111);
            label3.Name = "label3";
            label3.Size = new Size(29, 21);
            label3.TabIndex = 7;
            label3.Text = "От";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(249, 111);
            label4.Name = "label4";
            label4.Size = new Size(30, 21);
            label4.TabIndex = 9;
            label4.Text = "До";
            // 
            // filter_max_answer_value
            // 
            filter_max_answer_value.Location = new Point(249, 135);
            filter_max_answer_value.Name = "filter_max_answer_value";
            filter_max_answer_value.Size = new Size(100, 29);
            filter_max_answer_value.TabIndex = 8;
            filter_max_answer_value.Text = "100";
            filter_max_answer_value.KeyPress += filterBoxs_KeyPress;
            // 
            // filter_task_quantity
            // 
            filter_task_quantity.Location = new Point(241, 344);
            filter_task_quantity.Name = "filter_task_quantity";
            filter_task_quantity.Size = new Size(100, 29);
            filter_task_quantity.TabIndex = 10;
            filter_task_quantity.Text = "5";
            filter_task_quantity.KeyPress += filterBoxs_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 347);
            label5.Name = "label5";
            label5.Size = new Size(141, 21);
            label5.TabIndex = 11;
            label5.Text = "Количество задач:";
            // 
            // filterBox
            // 
            filterBox.Controls.Add(label6);
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
            filterBox.Font = new Font("Segoe UI", 12F);
            filterBox.Location = new Point(373, 12);
            filterBox.Name = "filterBox";
            filterBox.Size = new Size(415, 416);
            filterBox.TabIndex = 12;
            filterBox.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(47, 208);
            label6.Name = "label6";
            label6.Size = new Size(127, 21);
            label6.TabIndex = 12;
            label6.Text = "Виды примеров:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(filterBox);
            Controls.Add(start_game_button);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(500, 500);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ReshuPlay";
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
        private Label label6;
    }
}
