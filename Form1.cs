using System.Diagnostics.Eventing.Reader;

namespace son
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbislemler.Items.Add("Toplama");
            cmbislemler.Items.Add("Çýkarma");
            cmbislemler.Items.Add("Çarpma");
            cmbislemler.Items.Add("Bölme");
        }

        private void btnolustur_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            List<int> solListe = new List<int>();
            List<int> sagListe = new List<int>();   

            for (int i = 0; i < 20; i++)
            {
                solListe.Add(rnd.Next(1, 1000));
                sagListe.Add(rnd.Next(1, 1000));
            }

            solListe.Sort();
            sagListe.Sort();

            lstsol.Items.Clear();
            lstsag.Items.Clear();

            foreach (int sayi in solListe)
            {
                lstsol.Items.Add(sayi);
            }
            foreach (int sayi in sagListe)
            {
                lstsag.Items.Add(sayi);
            }



        }

        private void cmbislemler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstsol.SelectedItem != null && lstsag.SelectedItem != null)
            {
                int sayi1 = Convert.ToInt32(lstsol.SelectedItem);
                int sayi2 = Convert.ToInt32(lstsag.SelectedItem);
                string secilenislem = cmbislemler.SelectedItem.ToString();
                double sonuc = 0;

                switch (secilenislem)
                {
                    case "Toplama":
                        sonuc = sayi1 + sayi2;
                        break;
                    case "Çýkarma":
                        sonuc = sayi1 - sayi2;
                        break;
                    case "Çarpma":
                        sonuc = sayi1 * sayi2;
                        break;
                    case "Bölme":
                        if (sayi2 != 0)
                            sonuc = (double)sayi1 / sayi2;
                        else
                            MessageBox.Show("Bölme iþlemi için ikinci sayý sýfýr olamaz.");
                        break;
                }
                lblsonuc.Text = "Sonuç: " + sonuc.ToString();           
            }
            else
            {
                MessageBox.Show("Lütfen iki sayý seçin.");
            }
        }

            
    }
}
