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
using System.Windows.Shapes;

namespace serwis_komputerowy.layout
{
    /// <summary>
    /// Interaction logic for kategorie.xaml
    /// </summary>
    public partial class kategorie : Window
    {
        Baza baza = new Baza();
        public kategorie()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            KatSprzetu nowa_kategoria = new KatSprzetu();
            nowa_kategoria.NazwaKatSprzetu = textBox.Text;
            nowa_kategoria.Uwagi = textBox1.Text;

            baza.KatSprzetu.Add(nowa_kategoria);
            baza.SaveChanges();

        }
    }
}
