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
            cmbislemler.Items.Add("��karma");
            cmbislemler.Items.Add("�arpma");
            cmbislemler.Items.Add("B�lme");
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
                    case "��karma":
                        sonuc = sayi1 - sayi2;
                        break;
                    case "�arpma":
                        sonuc = sayi1 * sayi2;
                        break;
                    case "B�lme":
                        if (sayi2 != 0)
                            sonuc = (double)sayi1 / sayi2;
                        else
                            MessageBox.Show("B�lme i�lemi i�in ikinci say� s�f�r olamaz.");
                        break;
                }
                lblsonuc.Text = "Sonu�: " + sonuc.ToString();           
            }
            else
            {
                MessageBox.Show("L�tfen iki say� se�in.");
            }
        }

            
    }
}
