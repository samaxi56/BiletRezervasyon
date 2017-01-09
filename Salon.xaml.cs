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
    /// Interaction logic for Salon.xaml
    /// </summary>
    public partial class Salon : Page
    {

        int i, x = 25;
        public Salon()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (tcno.Text != "" && isim.Text != "")
            {
                
                btn1.Name = tcno.Text;
                btn1.IsEnabled = false;
                tcno.Text = "";
                isim.Text = "";
                i++;
                x--;

              

            }
            else
            {
                MessageBox.Show("TcNo ve isim giriniz");
            }
        }
    }
}