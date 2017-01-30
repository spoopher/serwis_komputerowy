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
            CenterWindowOnScreen();
    
        }

       public void button_enable()
        {
            button3.IsEnabled = true;
        }

        private void CenterWindowOnScreen()
        {
            double screenWidth = System.Windows.SystemParameters.PrimaryScreenWidth;
            double screenHeight = System.Windows.SystemParameters.PrimaryScreenHeight;
            double windowWidth = this.Width;
            double windowHeight = this.Height;
            this.Left = (screenWidth / 2) - (windowWidth / 2);
            this.Top = (screenHeight / 2) - (windowHeight / 2);
        }


        private void button1_Click(object sender, RoutedEventArgs e)
        {
            main.Content = new new_user();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {

            if (MessageBox.Show("Przelogować użytkownika?", "Działanie", MessageBoxButton.YesNo, MessageBoxImage.Question)== MessageBoxResult.Yes)
            {
                this.Hide();
                login_start nowe_logowanie = new login_start();
                nowe_logowanie.Show();
                
            }
            else
            {
                Application.Current.Shutdown();
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            main.Content = new zarzadzaj_kontami();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            serwis nowys = new serwis();
            main.Content = nowys;
           
        }
    }
}
