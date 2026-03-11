namespace modul3_103022400047
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbSatuanAwal.Items.Add("Celcius");
            cbSatuanAwal.Items.Add("Fahrenheit");
            cbSatuanAwal.Items.Add("Kelvin");
            cbSatuanAwal.Items.Add("Reamur");

            cbSatuanAkhir.Items.Add("Celcius");
            cbSatuanAkhir.Items.Add("Fahrenheit");
            cbSatuanAkhir.Items.Add("Kelvin");
            cbSatuanAkhir.Items.Add("Reamur");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbSatuanAwal.SelectedItem == null || cbSatuanAkhir.SelectedItem == null)
            {
                MessageBox.Show("Pilih satuan terlebih dahulu!");
                return;
            }

            if (txtNilaiAwal.Text == "")
            {
                MessageBox.Show("Masukkan angka yang valid!");
                return;
            }

            double nilaiAwal = Convert.ToDouble(txtNilaiAwal.Text);

            string satuanAwal = cbSatuanAwal.SelectedItem.ToString();
            string satuanAkhir = cbSatuanAkhir.SelectedItem.ToString();

            double celcius = nilaiAwal;

            if (satuanAwal == "Fahrenheit")
                celcius = (nilaiAwal - 32) * 5 / 9;
            else if (satuanAwal == "Kelvin")
                celcius = nilaiAwal - 273.15;
            else if (satuanAwal == "Reamur")
                celcius = nilaiAwal * 5 / 4;

            double hasil = celcius;

            if (satuanAkhir == "Fahrenheit")
                hasil = (celcius * 9 / 5) + 32;
            else if (satuanAkhir == "Kelvin")
                hasil = celcius + 273.15;
            else if (satuanAkhir == "Reamur")
                hasil = celcius * 4 / 5;

            txtNilaiAkhir.Text = hasil.ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
