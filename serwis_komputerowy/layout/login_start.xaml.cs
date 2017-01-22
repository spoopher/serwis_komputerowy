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

namespace serwis_komputerowy
{
    /// <summary>
    /// Interaction logic for login_start.xaml
    /// </summary>
    public partial class login_start : Window
    {
        MainWindow main = new MainWindow();
        Baza baza = new Baza();
        public login_start()
        {
            InitializeComponent();
          
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            String user = textBox.Text;
            String password = md5.CreateMD5(passwordBox.Password);
           

           


            foreach (var userr in baza.Pracownik)
            {
                if (userr.Login == user && userr.Haslo == password)
                {               
                    main.Show();
                    this.Hide();
                    MessageBox.Show("Poprawnie zalogowano!", "Logowanie", MessageBoxButton.OK, MessageBoxImage.Information);
                   
                    foreach (Window window in Application.Current.Windows)
                    {
                        if (window.GetType() == typeof(MainWindow))
                        {
                            (window as MainWindow).button3.IsEnabled = true;
                            
                        }
                        if (window.GetType() == typeof(MainWindow) && userr.Login == "admin")
                        {
                            (window as MainWindow).button3.IsEnabled = true;
                            (window as MainWindow).button1.IsEnabled = true;
                            (window as MainWindow).button.IsEnabled = true;

                        }
                    }

                    
                }
                else
                {
                    ;
                }

            }

        }
    }
}
