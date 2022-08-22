namespace Ucus_Rezervasyon_Sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rota: " + comboBox1.Text + " - " 
                + comboBox2.Text + " Tarih: " + dateTimePicker1.Text 
                + " Saat: " + maskedTextBox1.Text + " Yolcu Bilgileri ~~ Ad ve Soyad: " 
                + textBox1 + "TC: " + maskedTextBox2.Text + "Telefon: " + maskedTextBox3.Text);
            MessageBox.Show("Yolcu Kaydý Yapýldý");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a;
            a=comboBox1.Text;
            comboBox1.Text = comboBox2.Text;
            comboBox2.Text = a;
            MessageBox.Show("Yön Deðiþtirildi");
        }
    }
}