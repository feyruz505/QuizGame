namespace QuizGame
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
            pictureBox1 = new PictureBox();
            lblQuestion = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.questions_png;
            pictureBox1.Location = new Point(28, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(743, 348);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblQuestion
            // 
            lblQuestion.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblQuestion.Location = new Point(28, 394);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(743, 36);
            lblQuestion.TabIndex = 1;
            lblQuestion.Text = "Question";
            lblQuestion.TextAlign = ContentAlignment.MiddleCenter;
            lblQuestion.Click += lblQuestion_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(28, 443);
            button1.Name = "button1";
            button1.Size = new Size(300, 56);
            button1.TabIndex = 2;
            button1.Tag = "1";
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += checkAnswerEvent;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(471, 443);
            button2.Name = "button2";
            button2.Size = new Size(300, 56);
            button2.TabIndex = 3;
            button2.Tag = "2";
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += checkAnswerEvent;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(28, 515);
            button3.Name = "button3";
            button3.Size = new Size(300, 56);
            button3.TabIndex = 4;
            button3.Tag = "3";
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += checkAnswerEvent;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(471, 515);
            button4.Name = "button4";
            button4.Size = new Size(300, 56);
            button4.TabIndex = 5;
            button4.Tag = "4";
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += checkAnswerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 593);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblQuestion);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Quiz Game";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblQuestion;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}