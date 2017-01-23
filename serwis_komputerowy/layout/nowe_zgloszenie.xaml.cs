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
    }
}
