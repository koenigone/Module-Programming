﻿namespace Exercise_2
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
            label = new Label();
            textbox = new TextBox();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(307, 134);
            label.Name = "label";
            label.Size = new Size(50, 20);
            label.TabIndex = 0;
            label.Text = "label1";
            label.Click += label_Click;
            // 
            // textbox
            // 
            textbox.Location = new Point(307, 157);
            textbox.Name = "textbox";
            textbox.Size = new Size(125, 27);
            textbox.TabIndex = 1;
            textbox.TextChanged += textbox_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textbox);
            Controls.Add(label);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label;
        private TextBox textbox;
    }
}
