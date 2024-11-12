namespace Exercise_3
{
    partial class x
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
            person1 = new Button();
            person2 = new Button();
            nameLabel = new Label();
            ageLabel = new Label();
            birthCountryLabel = new Label();
            SuspendLayout();
            // 
            // person1
            // 
            person1.Location = new Point(25, 27);
            person1.Name = "person1";
            person1.Size = new Size(192, 29);
            person1.TabIndex = 0;
            person1.Text = "Display Person 1 Details";
            person1.UseVisualStyleBackColor = true;
            person1.Click += person1_Click;
            // 
            // person2
            // 
            person2.Location = new Point(25, 80);
            person2.Name = "person2";
            person2.Size = new Size(192, 29);
            person2.TabIndex = 1;
            person2.Text = "Display Person 2 Details";
            person2.UseVisualStyleBackColor = true;
            person2.Click += person2_Click;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(521, 171);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(50, 20);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "label1";
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new Point(521, 223);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(50, 20);
            ageLabel.TabIndex = 3;
            ageLabel.Text = "label2";
            // 
            // birthCountryLabel
            // 
            birthCountryLabel.AutoSize = true;
            birthCountryLabel.Location = new Point(521, 275);
            birthCountryLabel.Name = "birthCountryLabel";
            birthCountryLabel.Size = new Size(50, 20);
            birthCountryLabel.TabIndex = 4;
            birthCountryLabel.Text = "label3";
            // 
            // x
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(birthCountryLabel);
            Controls.Add(ageLabel);
            Controls.Add(nameLabel);
            Controls.Add(person2);
            Controls.Add(person1);
            Name = "x";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button person1;
        private Button person2;
        private Label nameLabel;
        private Label ageLabel;
        private Label birthCountryLabel;
    }
}
