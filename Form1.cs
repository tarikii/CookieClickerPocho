namespace CutiClicker
{
    public partial class Form1 : Form
    {
        private int cookiesClicked = 0;
        private int timeLeft;
        public Form1()
        {
            InitializeComponent();
            timeLeft = 20;
            label2.Text = "Suicide in: " + timeLeft;

            timer1.Interval = 1000;
            timer1.Start();
        }

        private void buttonCookie_Click(object sender, EventArgs e)
        {

            cookiesClicked++;

            labelCookies.Text = "Cookies: " + cookiesClicked;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            label2.Text = "Suicide in: " + timeLeft;

            if (timeLeft == 0)
            {
                timer1.Stop();
                label2.Text = "Te has suicidado!";
                MessageBox.Show("Tu partida ha acabado! :(");
            }
        }
    }
}