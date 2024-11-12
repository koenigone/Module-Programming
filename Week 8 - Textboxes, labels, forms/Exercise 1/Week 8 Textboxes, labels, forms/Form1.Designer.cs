namespace Week_8_Textboxes__labels__forms
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
            moveBtn = new Button();
            actorBtn = new Button();
            SuspendLayout();
            // 
            // moveBtn
            // 
            moveBtn.Location = new Point(359, 188);
            moveBtn.Name = "moveBtn";
            moveBtn.Size = new Size(94, 29);
            moveBtn.TabIndex = 1;
            moveBtn.Text = "move";
            moveBtn.UseVisualStyleBackColor = true;
            moveBtn.Click += moveBtn_Click;
            // 
            // actorBtn
            // 
            actorBtn.Location = new Point(434, 113);
            actorBtn.Name = "actorBtn";
            actorBtn.Size = new Size(94, 29);
            actorBtn.TabIndex = 2;
            actorBtn.Text = "move me";
            actorBtn.UseVisualStyleBackColor = true;
            actorBtn.Click += actorBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(actorBtn);
            Controls.Add(moveBtn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private Button moveBtn;
        private Button actorBtn;
    }
}
