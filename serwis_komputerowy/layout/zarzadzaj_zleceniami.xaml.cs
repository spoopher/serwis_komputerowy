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
            foreach (var a in baza.Zlecenie)
            {
                int nazwisko = a.IDKlienta;
                listBox.Items.Add(nazwisko);
            }
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
          
        }
    }
}
