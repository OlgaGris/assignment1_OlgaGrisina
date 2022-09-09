namespace assignment1_OlgaGrisina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label2.Text = "Three of Hearts";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label2.Text = "Seven of Diamonds";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label2.Text = "Ace of Spades";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            label2.Text = "Jack of Clubs";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            label2.Text = "King of Hearts";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}