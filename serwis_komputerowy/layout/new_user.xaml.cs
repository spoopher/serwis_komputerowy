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



namespace serwis_komputerowy
{

    public partial class new_user : Page
    {
        Baza baza = new Baza();




        public new_user()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {


          

            if (comboBox.SelectedIndex == 0)
            {
                try
                {

                    Pracownik nowy_pracownik = new Pracownik();
                    nowy_pracownik.Imie = textBox1.Text;
                    nowy_pracownik.Nazwisko = textBox2.Text;
                    nowy_pracownik.Login = textBox.Text;
                    nowy_pracownik.Haslo = md5.CreateMD5(passwordBox.Password);
                    if (radioButton.IsChecked == true)
                    {
                        nowy_pracownik.Uprawnienia = "pracownik";
                    }
                    else if (radioButton1.IsChecked == true)
                    {
                        nowy_pracownik.Uprawnienia = "admin";
                    }
                    else
                    {
                        nowy_pracownik.Uprawnienia = "pracownik";
                    }

                    baza.Pracownik.Add(nowy_pracownik);
                    baza.SaveChanges();
                    MessageBox.Show("Nowy pracownik dodany!", "Dodano Uzytkownika", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch
                {
                    MessageBox.Show("Wystapil blad!", "Blad", MessageBoxButton.OK, MessageBoxImage.Error);
                }

            }

            /////////////////////////////////////////////////////////////////////////////////////////////////

            if (comboBox.SelectedIndex == 1)
            {
                try
                {
                    String login = textBox.Text;
                    Pracownik pracownik = (Pracownik)baza.Pracownik.Where(b => b.Login == login).First();
                    baza.Pracownik.Remove(pracownik);
                    baza.SaveChanges();
                    MessageBox.Show("Usuniêto pracownika", "Usunieto pracownika", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch
                {
                    MessageBox.Show("Wystapil blad!", "Blad", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }


        }

        private void radioButton_Checked(object sender, RoutedEventArgs e)
        {
            uprawnienia.Content = null;

        }

        private void radioButton1_Checked(object sender, RoutedEventArgs e)
        {
            uprawnienia.Content = new Page3();
        }


        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBox.SelectedIndex == 0)
            {
                label.Visibility = Visibility.Visible;
                label1.Visibility = Visibility.Visible;
                label2.Visibility = Visibility.Visible;
                label3.Visibility = Visibility.Visible;
                textBox.Visibility = Visibility.Visible;
                textBox1.Visibility = Visibility.Visible;
                textBox2.Visibility = Visibility.Visible;
                passwordBox.Visibility = Visibility.Visible;
                label5.Visibility = Visibility.Visible;
                radioButton.Visibility = Visibility.Visible;
                radioButton1.Visibility = Visibility.Visible;
                button.Content = "DODAJ";

            }
            if (comboBox.SelectedIndex == 1)
            {
                label.Visibility = Visibility.Hidden;
                label1.Visibility = Visibility.Hidden;
                label3.Visibility = Visibility.Hidden;
                textBox1.Visibility = Visibility.Hidden;
                textBox2.Visibility = Visibility.Hidden;
                passwordBox.Visibility = Visibility.Hidden;
                label5.Visibility = Visibility.Hidden;
                radioButton.Visibility = Visibility.Hidden;
                radioButton1.Visibility = Visibility.Hidden;
                button.Content = "USUÑ";

            }
        }
    }
}
