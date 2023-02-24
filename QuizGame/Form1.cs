namespace QuizGame
{
    public partial class Form1 : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentAge;
        int totalQuestions;






        public Form1()
        {
            InitializeComponent();
            asqQuestion(questionNumber);

            totalQuestions = 5;


        }

        private void lblQuestion_Click(object sender, EventArgs e)
        {

        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
            {
                score++;
            }

            if (questionNumber == totalQuestions)
            {
                percentAge = (int)Math.Round((double)(score * 100) / totalQuestions);

                MessageBox.Show(
                    "Quiz Endl." + Environment.NewLine +
                    "You have answered" + score + "Questions correct." + Environment.NewLine +
                    "Your total percent:" + percentAge + "%" + Environment.NewLine +
                    "Click ok to play again"
                    );

                score = 0;
                questionNumber = 0;
                asqQuestion(questionNumber);

            }


            questionNumber++;
            asqQuestion(questionNumber);




        }

        private void asqQuestion(int qnum)
        {
            switch (qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.questions_png;

                    lblQuestion.Text = "C# kompiliyatoru nece adnlanir ?";

                    button1.Text = "JIT";
                    button2.Text = "Pro Prossesor";
                    button3.Text = "Rosny";
                    button4.Text = "Interpritator";

                    correctAnswer = 3;


                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources.python_png;

                    lblQuestion.Text = "Python kim terefinden yaradilib ?";

                    button1.Text = "Qvido van Rossum";
                    button2.Text = "Mark Twen";
                    button3.Text = "Lionel Cemi";
                    button4.Text = "Fistig Rafiq";

                    correctAnswer = 1;


                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources.amerka_png;

                    lblQuestion.Text = "Amerikanin nece stati var ?";

                    button1.Text = "54";
                    button2.Text = "50";
                    button3.Text = "33";
                    button4.Text = "70";

                    correctAnswer = 2;
                    break;

                case 4:
                    pictureBox1.Image = Properties.Resources.caySual;

                    lblQuestion.Text = "Dunyanin en uzun cayi hansidir ?";

                    button1.Text = "Yantsizi";
                    button2.Text = "Xuanxe";
                    button3.Text = "Amazon cayi";
                    button4.Text = "Nil cayi";

                    correctAnswer = 4;


                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.hacSeheri;

                    lblQuestion.Text = "Kebe seheri harada yerlesir ?";

                    button1.Text = "Seudiyye Erebistan";
                    button2.Text = "Iran";
                    button3.Text = "Dubai";
                    button4.Text = "Birlesmir ereb emirlikleri";

                    correctAnswer = 1;


                    break;
            }
        }
    }
}