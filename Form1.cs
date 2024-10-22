namespace labOdevi5Hafta
{
    public partial class Form1 : Form
    {

        private int randomSayi;
        private int kalanTahminHakki;
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            oyunuCalistir();
        }

        private void oyunuCalistir()
        {
            randomSayi = random.Next(1, 101);
            kalanTahminHakki = 5;
            label1.Text = "1-100 arasinda bir sayi tahmini yapiniz : ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kullaniciTahmin;
            bool sayiKontrol = int.TryParse(textBox1.Text, out kullaniciTahmin);

            if (!sayiKontrol || kullaniciTahmin < 1 || kullaniciTahmin > 100)
            {
                label1.Text = "HATALI GIRIS!!! Tekrardan 1-100 aras�nda bir sayi tahmini yap�n�z : ";
                return;
            }

            kalanTahminHakki--;

            if (kullaniciTahmin == randomSayi)
            {
                MessageBox.Show("Tebrikler!!! Do�ru Tahmin.");
                oyunuCalistir();
            }
            else if (kalanTahminHakki == 0)
            {
                MessageBox.Show("Tahmin Hakkiniz Bitmistir!!! Oyunu Yeniden Ba�lat�n. Do�ru Sayi : " + randomSayi);
                oyunuCalistir();
            }
            else
            {
                label1.Text = "Yanlis Tahmin! Kalan Hakk�n�z : " + kalanTahminHakki;
            }

            textBox1.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
