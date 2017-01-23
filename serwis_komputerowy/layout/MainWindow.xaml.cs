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
using serwis_komputerowy.layout;

namespace serwis_komputerowy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {



        public MainWindow()
        {
            InitializeComponent();
    
        }

       public void button_enable()
        {
            button3.IsEnabled = true;
        }
   


        private void button1_Click(object sender, RoutedEventArgs e)
        {
            main.Content = new new_user();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            main.Content = new zarzadzaj_kontami();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            serwis nowys = new serwis();
            main.Content = nowys;
            nowys.frame.Content = new nowe_zgloszenie();
        }
    }
}
