﻿namespace VanriseWinforms
{
    partial class AddStudentForm
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
            label1 = new Label();
            label2 = new Label();
            nameTextBox = new TextBox();
            genderDropDown = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(335, 91);
            label1.Name = "label1";
            label1.Size = new Size(69, 25);
            label1.TabIndex = 0;
            label1.Text = "Gender";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 91);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(25, 141);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(166, 31);
            nameTextBox.TabIndex = 2;
            // 
            // genderDropDown
            // 
            genderDropDown.FormattingEnabled = true;
            genderDropDown.Location = new Point(281, 139);
            genderDropDown.Name = "genderDropDown";
            genderDropDown.Size = new Size(176, 33);
            genderDropDown.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(345, 262);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 4;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AddStudentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 340);
            Controls.Add(button1);
            Controls.Add(genderDropDown);
            Controls.Add(nameTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddStudentForm";
            Text = "AddStudentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox nameTextBox;
        private ComboBox genderDropDown;
        private Button button1;
    }
}