﻿namespace PRACTICA_10
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
            label1 = new Label();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            listBox4 = new ListBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(325, 72);
            label1.Name = "label1";
            label1.Size = new Size(166, 31);
            label1.TabIndex = 0;
            label1.Text = "Z= X^2 + X^3";
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.LightYellow;
            listBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 31;
            listBox1.Location = new Point(31, 166);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(144, 221);
            listBox1.TabIndex = 1;
            // 
            // listBox2
            // 
            listBox2.BackColor = Color.LightYellow;
            listBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 31;
            listBox2.Location = new Point(233, 166);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(142, 221);
            listBox2.TabIndex = 2;
            // 
            // listBox3
            // 
            listBox3.BackColor = Color.LightYellow;
            listBox3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 31;
            listBox3.Location = new Point(432, 166);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(136, 221);
            listBox3.TabIndex = 3;
            // 
            // listBox4
            // 
            listBox4.BackColor = Color.LightYellow;
            listBox4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 31;
            listBox4.Location = new Point(616, 166);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(141, 221);
            listBox4.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(90, 126);
            label2.Name = "label2";
            label2.Size = new Size(29, 31);
            label2.TabIndex = 5;
            label2.Text = "X";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(275, 126);
            label3.Name = "label3";
            label3.Size = new Size(58, 31);
            label3.TabIndex = 6;
            label3.Text = "X^2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(468, 126);
            label4.Name = "label4";
            label4.Size = new Size(58, 31);
            label4.TabIndex = 7;
            label4.Text = "X^3";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(672, 126);
            label5.Name = "label5";
            label5.Size = new Size(28, 31);
            label5.TabIndex = 8;
            label5.Text = "Z";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 0);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(325, 398);
            button1.Name = "button1";
            button1.Size = new Size(196, 40);
            button1.TabIndex = 9;
            button1.Text = "Calcular Valores";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listBox4);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
        private ListBox listBox4;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
    }
}
