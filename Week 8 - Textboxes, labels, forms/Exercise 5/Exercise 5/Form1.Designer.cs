namespace Exercise_5
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
            components = new System.ComponentModel.Container();
            player1 = new Label();
            player2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            startBtn = new Button();
            stopBtn = new Button();
            SuspendLayout();
            // 
            // player1
            // 
            player1.AutoSize = true;
            player1.Location = new Point(222, 187);
            player1.Name = "player1";
            player1.Size = new Size(17, 20);
            player1.TabIndex = 0;
            player1.Text = "0";
            // 
            // player2
            // 
            player2.AutoSize = true;
            player2.Location = new Point(517, 187);
            player2.Name = "player2";
            player2.Size = new Size(17, 20);
            player2.TabIndex = 1;
            player2.Text = "0";
            // 
            // timer1
            // 
            timer1.Interval = 5000;
            timer1.Tick += timer1_Tick;
            // 
            // startBtn
            // 
            startBtn.Location = new Point(188, 60);
            startBtn.Name = "startBtn";
            startBtn.Size = new Size(94, 29);
            startBtn.TabIndex = 2;
            startBtn.Text = "Start";
            startBtn.UseVisualStyleBackColor = true;
            startBtn.Click += startBtn_Click;
            // 
            // stopBtn
            // 
            stopBtn.Location = new Point(479, 60);
            stopBtn.Name = "stopBtn";
            stopBtn.Size = new Size(94, 29);
            stopBtn.TabIndex = 3;
            stopBtn.Text = "Stop";
            stopBtn.UseVisualStyleBackColor = true;
            stopBtn.Click += stopBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(stopBtn);
            Controls.Add(startBtn);
            Controls.Add(player2);
            Controls.Add(player1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label player1;
        private Label player2;
        private System.Windows.Forms.Timer timer1;
        private Button startBtn;
        private Button stopBtn;
    }
}
