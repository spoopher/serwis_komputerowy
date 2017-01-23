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


    public partial class zarzadzaj_kontami : Page
    {
        Baza baza = new Baza();
        layout.new_password nowe_haslo = new serwis_komputerowy.layout.new_password();
        public zarzadzaj_kontami()
        {
            InitializeComponent();
           
           
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            listBox.Items.Clear();
            
                foreach (var user in baza.Pracownik)
                {
                    String log = user.Login;
                    listBox.Items.Add(log);
                  

                }
            
          
        }


        private void button2_Click(object sender, RoutedEventArgs e)
        {
            String selected_user = Convert.ToString(listBox.SelectedItem);
            Pracownik pracownik = (Pracownik)baza.Pracownik.Where(b => b.Login == selected_user).First();
            pracownik.Login = textBox.Text;
            pracownik.Imie = textBox1.Text;
            pracownik.Nazwisko = textBox2.Text;
            pracownik.Uprawnienia = textBox4.Text;
            baza.SaveChanges();
            listBox.Items.Clear();
            MessageBox.Show("Zamiany zostały zatwierdzon!", "Edycja", MessageBoxButton.OK, MessageBoxImage.Information);


        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                String selected_user = Convert.ToString(listBox.SelectedItem);
                Pracownik pracownik = (Pracownik)baza.Pracownik.Where(b => b.Login == selected_user).First();
                textBox.Text = pracownik.Login;
                textBox1.Text = pracownik.Imie;
                textBox2.Text = pracownik.Nazwisko;
                textBox4.Text = pracownik.Uprawnienia;
            }
            catch
            {
                ;
            }
            }

      
        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {
           
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            nowe_haslo.Show();
        }
    }
}
