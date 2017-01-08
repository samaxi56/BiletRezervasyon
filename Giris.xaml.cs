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

namespace BiletRezervasyonu
{
    /// <summary>
    /// Interaction logic for Giris.xaml
    /// </summary>
    public partial class Giris : Page
    {
        public MainWindow babaEkran;
        public Giris()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if ((txt5.Text == "osman") && (psw5.Password == "1995"))
            {
                babaEkran.ekran.Navigate(new Salon());
                babaEkran.Title = "Hoş Geldiniz..";
            }
            else
            {
                babaEkran.Title = "Kullanıcı adı veya şifre yanlış";
            }
        }
    }
}
