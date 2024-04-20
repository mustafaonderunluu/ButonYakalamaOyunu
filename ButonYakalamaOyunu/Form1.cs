
namespace ButonYakalamaOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Form y�klendi�inde butonu rastgele bir konuma yerle�tir
            RandomlyPlaceButton();
        }

        public int i = 1;
        private Random rnd = new Random();

        // Butonu rastgele bir konuma yerle�tiren metod
        private void RandomlyPlaceButton()
        {
            button1.Left = rnd.Next(0, this.ClientSize.Width - button1.Width);
            button1.Top = rnd.Next(label2.Height + label3.Height, this.ClientSize.Height - button1.Height);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = ("Tebrikler Toplam Puan�n�z = " + " " + Convert.ToString(i) + " " + ".");
            if (i <= 20)
            {
                i++;
            }
            else if (i > 20)
            {
                label1.Text = "Oyun Bitti";
            }
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            // Butonun farkl� bir noktaya ���nlanmas�n� sa�la
            RandomlyPlaceButton();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label3.Text = textBox1.Text;
        }
    }
}

