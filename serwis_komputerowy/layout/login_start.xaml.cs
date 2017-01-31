using serwis_komputerowy.entity;
using serwis_komputerowy.layout;
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
            CenterWindowOnScreen();
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


        private void button_Click(object sender, RoutedEventArgs e)
        {
            String user = textBox.Text;
            String password = md5.CreateMD5(passwordBox.Password);

            try {


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
            catch
            {
                MessageBox.Show("Błąd logowania!", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void yy(object sender, MouseButtonEventArgs e)
        {
            przypomnienie_hasla nowe = new przypomnienie_hasla();
            nowe.Show();
        }
    }
}
