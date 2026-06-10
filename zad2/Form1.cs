namespace zad2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(tb1.Text, out int ile) || ile <= 0)
                {
                    MessageBox.Show("Pierwsza liczba musi byæ dodatni¹ liczb¹ ca³kowit¹!");
                    return;
                }

                if (!double.TryParse(tb2.Text, out double liczba))
                {
                    MessageBox.Show("Druga liczba ma niepoprawny format!");
                    return;
                }

                double[] tablica = new double[ile];
                for (int i = 0; i < ile; i++)
                {
                    tablica[i] = liczba * (i + 1);
                }

                rtb1.Clear();
                rtb1.Text = string.Join(", ", tablica);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wyst¹pi³ b³¹d: " + ex.Message);
            }
        }
    }
}
