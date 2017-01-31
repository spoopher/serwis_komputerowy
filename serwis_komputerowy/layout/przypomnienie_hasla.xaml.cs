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
using System.Net.Mail;
using System.Net;
using serwis_komputerowy.entity;

namespace serwis_komputerowy.layout
{
    /// <summary>
    /// Interaction logic for przypomnienie_hasla.xaml
    /// </summary>
    public partial class przypomnienie_hasla : Window
    {
        Baza baza = new Baza();
        public przypomnienie_hasla()
        {
           
            InitializeComponent();
        }

        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string haslo = RandomString(10);
            String password = md5.CreateMD5(haslo);
            baza.Pracownik.Where(b => b.Login == textBox.Text).First().Haslo = password;
            baza.SaveChanges();

            var fromAddress = new MailAddress("maciejm1995@gmail.com", "From Name");
            var toAddress = new MailAddress(textBox1.Text, "To Name");
            const string fromPassword = "spoopher3.0ic199525";
            const string subject = "Subject";
             string body = haslo;

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }
    }
}
