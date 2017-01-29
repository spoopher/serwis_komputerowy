using serwis_komputerowy.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace serwis_komputerowy.layout
{
    /// <summary>
    /// Interaction logic for nowe_zgloszenie.xaml
    /// </summary>
    public partial class nowe_zgloszenie : Page
    {
        Baza baza = new Baza();
        kategorie kat = new kategorie();
        public nowe_zgloszenie()
        {
            
            InitializeComponent();
            foreach (var a in baza.KatSprzetu)
                comboBox1.Items.Add(a.NazwaKatSprzetu);

          
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            kat.Show();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (comboBox2.SelectedIndex == 0)
                {
                    Klient klient = new Klient();
                    Sprzet sprzet = new Sprzet();
                    Zlecenie zlecenie = new Zlecenie();

                    klient.Imie = textBox.Text;
                    klient.Nazwisko = textBox1.Text;
                    klient.Mail = textBox2.Text;
                    klient.Telefon = Convert.ToInt32(textBox3.Text);
                    klient.Adres = textBox9.Text;
                    klient.Kod = 000;

                    baza.Klient.Add(klient);
                    baza.SaveChanges();

                    sprzet.Producent = textBox4.Text;
                    sprzet.Model = textBox5.Text;
                    sprzet.NrSeryjny = Convert.ToInt32(textBox6.Text);
                    sprzet.CzySprawny = comboBox.Text;
                    sprzet.Uwagi = textBox7.Text;
                    sprzet.IDKlienta = klient.IDKlienta;
                    sprzet.IDKatSprzetu = (baza.KatSprzetu.Where(b => b.NazwaKatSprzetu == comboBox1.Text).First()).idKatSprzetu;
                    sprzet.KatSprzetu = baza.KatSprzetu.Where(b => b.NazwaKatSprzetu == comboBox1.Text).First();
                    sprzet.Klient = klient;

                    baza.Sprzet.Add(sprzet);
                    baza.SaveChanges();

                    zlecenie.UwagiKlienta = textBox7.Text;
                    zlecenie.UwagiSerwisu = textBox8.Text;
                    zlecenie.Kod = 000;
                    zlecenie.IDKlienta = klient.IDKlienta;
                    zlecenie.IDSprzetu = sprzet.IDSprzetu;
                    zlecenie.Klient = klient;
                    zlecenie.Sprzet = sprzet;
                    zlecenie.Status = "przyjete";



                    baza.Zlecenie.Add(zlecenie);
                    baza.SaveChanges();


                    MessageBox.Show("Nowe zlecenie dodano do bazy danych", "Sukces!", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                if (comboBox2.SelectedIndex == 1)
                {
                    Klient klient_z_bazy = (Klient)baza.Klient.Where(b => b.Nazwisko == listBox.SelectedValue).First();
                    Sprzet sprzet = new Sprzet();
                    Zlecenie zlecenie = new Zlecenie();

                    sprzet.Producent = textBox4.Text;
                    sprzet.Model = textBox5.Text;
                    sprzet.NrSeryjny = Convert.ToInt32(textBox6.Text);
                    sprzet.CzySprawny = comboBox.Text;
                    sprzet.Uwagi = textBox7.Text;
                    sprzet.IDKlienta = klient_z_bazy.IDKlienta;
                    sprzet.IDKatSprzetu = (baza.KatSprzetu.Where(b => b.NazwaKatSprzetu == comboBox1.Text).First()).idKatSprzetu;
                    sprzet.KatSprzetu = baza.KatSprzetu.Where(b => b.NazwaKatSprzetu == comboBox1.Text).First();
                    sprzet.Klient = klient_z_bazy;

                    baza.Sprzet.Add(sprzet);
                    baza.SaveChanges();

                    zlecenie.UwagiKlienta = textBox7.Text;
                    zlecenie.UwagiSerwisu = textBox8.Text;
                    zlecenie.Kod = 000;
                    zlecenie.IDKlienta = klient_z_bazy.IDKlienta;
                    zlecenie.IDSprzetu = sprzet.IDSprzetu;
                    zlecenie.Klient = klient_z_bazy;
                    zlecenie.Sprzet = sprzet;
                    zlecenie.Status = "przyjete";



                    baza.Zlecenie.Add(zlecenie);
                    baza.SaveChanges();


                    MessageBox.Show("Nowe zlecenie dodano do bazy danych", "Sukces!", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch
            {
                MessageBox.Show("Nastąpił problem przy dodawaniu nowego zgłoszenia", "Błąd",  MessageBoxButton.OK, MessageBoxImage.Error);
            }
           
        }

      

      

        private void comboBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


            if (comboBox2.SelectedIndex == 0)
            {
                textBox.Visibility = Visibility.Visible;
                textBox1.Visibility = Visibility.Visible;
                textBox2.Visibility = Visibility.Visible;
                textBox3.Visibility = Visibility.Visible;
                textBox9.Visibility = Visibility.Visible;
                label.Visibility = Visibility.Visible;
                label1.Visibility = Visibility.Visible;
                label2.Visibility = Visibility.Visible;
                label3.Visibility = Visibility.Visible;
                label11.Visibility = Visibility.Visible;
                listBox.Visibility = Visibility.Hidden;
            }


            if (comboBox2.SelectedIndex == 1)
            {
                label.Visibility = Visibility.Hidden;
                label1.Visibility = Visibility.Hidden;
                label2.Visibility = Visibility.Hidden;
                label3.Visibility = Visibility.Hidden;
                label11.Visibility = Visibility.Hidden;
                textBox.Visibility = Visibility.Hidden;
                textBox1.Visibility = Visibility.Hidden;
                textBox2.Visibility = Visibility.Hidden;
                textBox3.Visibility = Visibility.Hidden;
                textBox9.Visibility = Visibility.Hidden;
                listBox.Visibility = Visibility.Visible;

                foreach (var a in baza.Klient)
                {
                    listBox.Items.Add(a.Nazwisko);
                }


            }



        }

      
    }
}
