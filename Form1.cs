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
                label1.Text = "HATALI GIRIS!!! Tekrardan 1-100 arasýnda bir sayi tahmini yapýnýz : ";
                return;
            }

            kalanTahminHakki--;

            if (kullaniciTahmin == randomSayi)
            {
                MessageBox.Show("Tebrikler!!! Doðru Tahmin.");
                oyunuCalistir();
            }
            else if (kalanTahminHakki == 0)
            {
                MessageBox.Show("Tahmin Hakkiniz Bitmistir!!! Oyunu Yeniden Baþlatýn. Doðru Sayi : " + randomSayi);
                oyunuCalistir();
            }
            else
            {
                label1.Text = "Yanlis Tahmin! Kalan Hakkýnýz : " + kalanTahminHakki;
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
