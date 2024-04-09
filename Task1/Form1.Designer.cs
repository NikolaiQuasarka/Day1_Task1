namespace Task1
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
            button1 = new Button();
            x_textBox = new TextBox();
            y_textBox = new TextBox();
            z_textBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            f_textBox = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(344, 282);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Вычислить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // x_textBox
            // 
            x_textBox.Location = new Point(154, 156);
            x_textBox.Name = "x_textBox";
            x_textBox.Size = new Size(125, 27);
            x_textBox.TabIndex = 1;
            // 
            // y_textBox
            // 
            y_textBox.Location = new Point(334, 156);
            y_textBox.Name = "y_textBox";
            y_textBox.Size = new Size(125, 27);
            y_textBox.TabIndex = 2;
            // 
            // z_textBox
            // 
            z_textBox.Location = new Point(506, 156);
            z_textBox.Name = "z_textBox";
            z_textBox.Size = new Size(125, 27);
            z_textBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(300, 90);
            label1.Name = "label1";
            label1.Size = new Size(138, 20);
            label1.TabIndex = 4;
            label1.Text = "Введите значения:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(129, 159);
            label2.Name = "label2";
            label2.Size = new Size(19, 20);
            label2.TabIndex = 5;
            label2.Text = "x:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(309, 159);
            label3.Name = "label3";
            label3.Size = new Size(19, 20);
            label3.TabIndex = 6;
            label3.Text = "y:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(481, 159);
            label4.Name = "label4";
            label4.Size = new Size(19, 20);
            label4.TabIndex = 7;
            label4.Text = "z:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(219, 229);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 8;
            label5.Text = "Результат:";
            // 
            // f_textBox
            // 
            f_textBox.Location = new Point(300, 226);
            f_textBox.Name = "f_textBox";
            f_textBox.Size = new Size(266, 27);
            f_textBox.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(f_textBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(z_textBox);
            Controls.Add(y_textBox);
            Controls.Add(x_textBox);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox x_textBox;
        private TextBox y_textBox;
        private TextBox z_textBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox f_textBox;
    }
}
