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
    /// Interaction logic for zarzadzaj_zleceniami.xaml
    /// </summary>
    public partial class zarzadzaj_zleceniami : Page
    {
        Baza baza = new Baza();
        public zarzadzaj_zleceniami()
        {
                  
            InitializeComponent();

            List<Zlecenie> lista_zlecen = new List<Zlecenie>();
            List<Klient> lista_klientow = new List<Klient>();

            lista_klientow = baza.Klient.ToList();
            lista_zlecen = baza.Zlecenie.ToList();



            foreach (var a in lista_zlecen)
            {
                string nazwisko = (lista_klientow.Where(b => b.IDKlienta == a.IDKlienta).First()).Nazwisko;
                string imie = (lista_klientow.Where(b => b.IDKlienta == a.IDKlienta).First()).Imie;
                string status = a.Status;
                listBox.Items.Add(nazwisko);
                ((ComboBoxItem)comboBox.SelectedItem).Content = status;
            }


        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                string aktualne_info = (baza.Zlecenie.Where(b => b.Klient.Nazwisko == listBox.SelectedItem.ToString()).First()).UwagiSerwisu;
                textBox.Text = aktualne_info;
            }
            catch
            {
                textBox.Text = "zadne zlecenie nie zostało zaznaczone";
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string nazwisko_zlecenie = listBox.SelectedItem.ToString();
                Zlecenie zlecenie = (Zlecenie)baza.Zlecenie.Where(b => b.Klient.Nazwisko == nazwisko_zlecenie).First();
                Sprzet sprzet = (Sprzet)baza.Sprzet.Where(b => b.Klient.Nazwisko == nazwisko_zlecenie).First();
                baza.Zlecenie.Remove(zlecenie);
                baza.SaveChanges();
                baza.Sprzet.Remove(sprzet);
                baza.SaveChanges();
                listBox.Items.RemoveAt(listBox.SelectedIndex);
                MessageBox.Show("Usunięto", "sukces", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("wystąpił problem", "bląd", MessageBoxButton.OK, MessageBoxImage.Error);
            }
     
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Zlecenie nowe_info = baza.Zlecenie.Where(b => b.Klient.Nazwisko == listBox.SelectedItem.ToString()).First();
                nowe_info.UwagiSerwisu = textBox.Text;
                nowe_info.Status = ((ComboBoxItem)comboBox.SelectedItem).Content.ToString();
                baza.SaveChanges();
                MessageBox.Show("zmodyfikowano!", "sukces", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("wystąpił problem", "bląd", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

      
    }
}
