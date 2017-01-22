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
    /// Interaction logic for new_password.xaml
    /// </summary>
    public partial class new_password : Window
    {
        public new_password()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBox.Show("Czy napewno chcesz zmienić hasło dla tego użytkownika?");
            }
            catch
            {
                MessageBox.Show("Wsystąpił problem ze zmianą hasła!");
            }
        }
    }
}
