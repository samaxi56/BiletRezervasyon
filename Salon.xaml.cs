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
using System.Drawing.Configuration;
using System.Drawing;



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
            lb3.Content = "Boş:" + x.ToString();
            lb4.Content = "Dolu:" + i.ToString();

            Random rnd = new Random();
            double sayi = rnd.Next(1 * 1000);
            rezerveno.Text = Convert.ToString(sayi);

            btn1.Background = new SolidColorBrush(Colors.Green);
            btn2.Background = new SolidColorBrush(Colors.Green);
            btn3.Background = new SolidColorBrush(Colors.Green);
            btn4.Background = new SolidColorBrush(Colors.Green);
            btn5.Background = new SolidColorBrush(Colors.Green);
            btn6.Background = new SolidColorBrush(Colors.Green);
            btn7.Background = new SolidColorBrush(Colors.Green);
            btn8.Background = new SolidColorBrush(Colors.Green);
            btn9.Background = new SolidColorBrush(Colors.Green);
            btn10.Background = new SolidColorBrush(Colors.Green);
            btn11.Background = new SolidColorBrush(Colors.Green);
            btn12.Background = new SolidColorBrush(Colors.Green);
            btn13.Background = new SolidColorBrush(Colors.Green);
            btn14.Background = new SolidColorBrush(Colors.Green);
            btn15.Background = new SolidColorBrush(Colors.Green);
            btn16.Background = new SolidColorBrush(Colors.Green);
            btn17.Background = new SolidColorBrush(Colors.Green);
            btn18.Background = new SolidColorBrush(Colors.Green);
            btn19.Background = new SolidColorBrush(Colors.Green);
            btn20.Background = new SolidColorBrush(Colors.Green);
            btn21.Background = new SolidColorBrush(Colors.Green);
            btn22.Background = new SolidColorBrush(Colors.Green);
            btn23.Background = new SolidColorBrush(Colors.Green);
            btn24.Background = new SolidColorBrush(Colors.Green);
            btn25.Background = new SolidColorBrush(Colors.Green);

        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {

            if (rezerveno.Text != "" && isim.Text != "")
            {
                btn1.Background = new SolidColorBrush(Colors.Red);
                btn1.Content = rezerveno.Text + " " + isim.Text;
                btn1.IsEnabled = false;
                rezerveno.Text = "";
                isim.Text = "";
                i++;
                x--;
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();
            }
            else
            {
                MessageBox.Show("rezerveno ve isim giriniz");
            }

            Random rnd = new Random();
            double sayi = rnd.Next(1 * 1000);
            rezerveno.Text = Convert.ToString(sayi);
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (rezerveno.Text != "" && isim.Text != "")
            {
                btn2.Content = rezerveno.Text + " " + isim.Text;
                btn2.IsEnabled = false;
                rezerveno.Text = "";
                isim.Text = "";
                i++;
                x--;
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();
            }
            else
            {
                MessageBox.Show("rezerveno ve isim giriniz");
            }
            Random rnd = new Random();
            double sayi = rnd.Next(1 * 1000);
            rezerveno.Text = Convert.ToString(sayi);
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (rezerveno.Text != "" && isim.Text != "")
            {
                btn3.Content = rezerveno.Text + " " + isim.Text;
                btn3.IsEnabled = false;
                rezerveno.Text = "";
                isim.Text = "";
                i++;
                x--;
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();

            }
            else
            {
                MessageBox.Show("rezerveno ve isim giriniz");
            }
            Random rnd = new Random();
            double sayi = rnd.Next(1 * 1000);
            rezerveno.Text = Convert.ToString(sayi);

        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (rezerveno.Text != "" && isim.Text != "")
            {
                btn4.Content = rezerveno.Text + " " + isim.Text;
                btn4.IsEnabled = false;
                rezerveno.Text = "";
                isim.Text = "";
                i++;
                x--;
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();

            }
            else
            {
                MessageBox.Show("rezerveno ve isim giriniz");
            }
            Random rnd = new Random();
            double sayi = rnd.Next(1 * 1000);
            rezerveno.Text = Convert.ToString(sayi);

        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (rezerveno.Text != "" && isim.Text != "")
            {
                btn5.Content = rezerveno.Text + " " + isim.Text;
                btn5.IsEnabled = false;
                rezerveno.Text = "";
                isim.Text = "";
                i++;
                x--;
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();

            }
            else
            {
                MessageBox.Show("rezerveno ve isim giriniz");
            }
            Random rnd = new Random();
            double sayi = rnd.Next(1 * 1000);
            rezerveno.Text = Convert.ToString(sayi);
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (rezerveno.Text != "" && isim.Text != "")
            {
                btn6.Content = rezerveno.Text + " " + isim.Text;
                btn6.IsEnabled = false;
                rezerveno.Text = "";
                isim.Text = "";
                i++;
                x--;
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();

            }
            else
            {
                MessageBox.Show("rezerveno ve isim giriniz");
            }
            Random rnd = new Random();
            double sayi = rnd.Next(1 * 1000);
            rezerveno.Text = Convert.ToString(sayi);
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (rezerveno.Text != "" && isim.Text != "")
            {
                btn7.Content = rezerveno.Text + " " + isim.Text;
                btn7.IsEnabled = false;
                rezerveno.Text = "";
                isim.Text = "";
                i++;
                x--;
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();
            }
            else
            {
                MessageBox.Show("rezerveno ve isim giriniz");
            }
            Random rnd = new Random();
            double sayi = rnd.Next(1 * 1000);
            rezerveno.Text = Convert.ToString(sayi);
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (rezerveno.Text != "" && isim.Text != "")
            {
                btn8.Content = rezerveno.Text + " " + isim.Text;
                btn8.IsEnabled = false;
                rezerveno.Text = "";
                isim.Text = "";
                i++;
                x--;
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();

            }
            else
            {
                MessageBox.Show("rezerveno ve isim giriniz");
            }
            Random rnd = new Random();
            double sayi = rnd.Next(1 * 1000);
            rezerveno.Text = Convert.ToString(sayi);
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (rezerveno.Text != "" && isim.Text != "")
            {
                btn9.Content = rezerveno.Text + " " + isim.Text;
                btn9.IsEnabled = false;
                rezerveno.Text = "";
                isim.Text = "";
                i++;
                x--;
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();

            }
            else
            {
                MessageBox.Show("rezerveno ve isim giriniz");
            }
            Random rnd = new Random();
            double sayi = rnd.Next(1 * 1000);
            rezerveno.Text = Convert.ToString(sayi);
        }

        private void btn10_Click(object sender, RoutedEventArgs e)
        {
            if (rezerveno.Text != "" && isim.Text != "")
            {
                btn10.Content = rezerveno.Text + " " + isim.Text;
                btn10.IsEnabled = false;
                rezerveno.Text = "";
                isim.Text = "";
                i++;
                x--;
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();

            }
            else
            {
                MessageBox.Show("rezerveno ve isim giriniz");
            }
            Random rnd = new Random();
            double sayi = rnd.Next(1 * 1000);
            rezerveno.Text = Convert.ToString(sayi);
        }

        private void btn11_Click(object sender, RoutedEventArgs e)
        {
            if (rezerveno.Text != "" && isim.Text != "")
            {
                btn11.Content = rezerveno.Text + " " + isim.Text;
                btn11.IsEnabled = false;
                rezerveno.Text = "";
                isim.Text = "";
                i++;
                x--;
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();

            }
            else
            {
                MessageBox.Show("rezerveno ve isim giriniz");
            }
            Random rnd = new Random();
            double sayi = rnd.Next(1 * 1000);
            rezerveno.Text = Convert.ToString(sayi);
        }

        private void btn12_Click(object sender, RoutedEventArgs e)
        {
            if (rezerveno.Text != "" && isim.Text != "")
            {
                btn12.Content = rezerveno.Text + " " + isim.Text;
                btn12.IsEnabled = false;
                rezerveno.Text = "";
                isim.Text = "";
                i++;
                x--;
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();

            }
            else
            {
                MessageBox.Show("rezerveno ve isim giriniz");
            }
            Random rnd = new Random();
            double sayi = rnd.Next(1 * 1000);
            rezerveno.Text = Convert.ToString(sayi);
        }

        private void btn13_Click(object sender, RoutedEventArgs e)
        {
            if (rezerveno.Text != "" && isim.Text != "")
            {
                btn13.Content = rezerveno.Text + " " + isim.Text;
                btn13.IsEnabled = false;
                rezerveno.Text = "";
                isim.Text = "";
                i++;
                x--;
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();

            }
            else
            {
                MessageBox.Show("rezerveno ve isim giriniz");
            }
            Random rnd = new Random();
            double sayi = rnd.Next(1 * 1000);
            rezerveno.Text = Convert.ToString(sayi);
        }

        private void btn14_Click(object sender, RoutedEventArgs e)
        {
            if (rezerveno.Text != "" && isim.Text != "")
            {
                btn14.Content = rezerveno.Text + " " + isim.Text;
                btn14.IsEnabled = false;
                rezerveno.Text = "";
                isim.Text = "";
                i++;
                x--;
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();

            }
            else
            {
                MessageBox.Show("rezerveno ve isim giriniz");
            }
            Random rnd = new Random();
            double sayi = rnd.Next(1 * 1000);
            rezerveno.Text = Convert.ToString(sayi);
        }

        private void btn15_Click(object sender, RoutedEventArgs e)
        {
            if (rezerveno.Text != "" && isim.Text != "")
            {
                btn15.Content = rezerveno.Text + " " + isim.Text;
                btn15.IsEnabled = false;
                rezerveno.Text = "";
                isim.Text = "";
                i++;
                x--;
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();

            }
            else
            {
                MessageBox.Show("rezerveno ve isim giriniz");
            }
            Random rnd = new Random();
            double sayi = rnd.Next(1 * 1000);
            rezerveno.Text = Convert.ToString(sayi);
        }

        private void btn16_Click(object sender, RoutedEventArgs e)
        {
            if (rezerveno.Text != "" && isim.Text != "")
            {
                btn16.Content = rezerveno.Text + " " + isim.Text;
                btn16.IsEnabled = false;
                rezerveno.Text = "";
                isim.Text = "";
                i++;
                x--;
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();

            }
            else
            {
                MessageBox.Show("rezerveno ve isim giriniz");
            }
            Random rnd = new Random();
            double sayi = rnd.Next(1 * 1000);
            rezerveno.Text = Convert.ToString(sayi);
        }

        private void btn17_Click(object sender, RoutedEventArgs e)
        {
            if (rezerveno.Text != "" && isim.Text != "")
            {
                btn17.Content = rezerveno.Text + " " + isim.Text;
                btn17.IsEnabled = false;
                rezerveno.Text = "";
                isim.Text = "";
                i++;
                x--;
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();

            }
            else
            {
                MessageBox.Show("rezerveno ve isim giriniz");
            }
            Random rnd = new Random();
            double sayi = rnd.Next(1 * 1000);
            rezerveno.Text = Convert.ToString(sayi);

        }

        private void btn18_Click(object sender, RoutedEventArgs e)
        {
            if (rezerveno.Text != "" && isim.Text != "")
            {
                btn18.Content = rezerveno.Text + " " + isim.Text;
                btn18.IsEnabled = false;
                rezerveno.Text = "";
                isim.Text = "";
                i++;
                x--;
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();

            }
            else
            {
                MessageBox.Show("rezerveno ve isim giriniz");
            }
            Random rnd = new Random();
            double sayi = rnd.Next(1 * 1000);
            rezerveno.Text = Convert.ToString(sayi);
        }

        private void btn19_Click(object sender, RoutedEventArgs e)
        {
            if (rezerveno.Text != "" && isim.Text != "")
            {
                btn19.Content = rezerveno.Text + " " + isim.Text;
                btn19.IsEnabled = false;
                rezerveno.Text = "";
                isim.Text = "";
                i++;
                x--;
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();

            }
            else
            {
                MessageBox.Show("rezerveno ve isim giriniz");
            }
            Random rnd = new Random();
            double sayi = rnd.Next(1 * 1000);
            rezerveno.Text = Convert.ToString(sayi);
        }

        private void btn20_Click(object sender, RoutedEventArgs e)
        {
            if (rezerveno.Text != "" && isim.Text != "")
            {
                btn20.Content = rezerveno.Text + " " + isim.Text;
                btn20.IsEnabled = false;
                rezerveno.Text = "";
                isim.Text = "";
                i++;
                x--;
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();
            }
            else
            {
                MessageBox.Show("rezerveno ve isim giriniz");
            }
            Random rnd = new Random();
            double sayi = rnd.Next(1 * 1000);
            rezerveno.Text = Convert.ToString(sayi);
        }

        private void btn21_Click(object sender, RoutedEventArgs e)
        {
            if (rezerveno.Text != "" && isim.Text != "")
            {
                btn21.Content = rezerveno.Text + " " + isim.Text;
                btn21.IsEnabled = false;
                rezerveno.Text = "";
                isim.Text = "";
                i++;
                x--;
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();

            }
            else
            {
                MessageBox.Show("rezerveno ve isim giriniz");
            }
            Random rnd = new Random();
            double sayi = rnd.Next(1 * 1000);
            rezerveno.Text = Convert.ToString(sayi);
        }

        private void btn22_Click(object sender, RoutedEventArgs e)
        {
            if (rezerveno.Text != "" && isim.Text != "")
            {
                btn22.Content = rezerveno.Text + " " + isim.Text;
                btn22.IsEnabled = false;
                rezerveno.Text = "";
                isim.Text = "";
                i++;
                x--;
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();

            }
            else
            {
                MessageBox.Show("rezerveno ve isim giriniz");
            }
            Random rnd = new Random();
            double sayi = rnd.Next(1 * 1000);
            rezerveno.Text = Convert.ToString(sayi);
        }

        private void btn23_Click(object sender, RoutedEventArgs e)
        {
            if (rezerveno.Text != "" && isim.Text != "")
            {
                btn23.Content = rezerveno.Text + " " + isim.Text;
                btn23.IsEnabled = false;
                rezerveno.Text = "";
                isim.Text = "";
                i++;
                x--;
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();

            }
            else
            {
                MessageBox.Show("rezerveno ve isim giriniz");
            }
            Random rnd = new Random();
            double sayi = rnd.Next(1 * 1000);
            rezerveno.Text = Convert.ToString(sayi);
        }

        private void btn24_Click(object sender, RoutedEventArgs e)
        {
            if (rezerveno.Text != "" && isim.Text != "")
            {
                btn24.Content = rezerveno.Text + " " + isim.Text;
                btn24.IsEnabled = false;
                rezerveno.Text = "";
                isim.Text = "";
                i++;
                x--;
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();

            }
            else
            {
                MessageBox.Show("rezerveno ve isim giriniz");
            }
            Random rnd = new Random();
            double sayi = rnd.Next(1 * 1000);
            rezerveno.Text = Convert.ToString(sayi);
        }

        private void btn25_Click(object sender, RoutedEventArgs e)
        {
            if (rezerveno.Text != "" && isim.Text != "")
            {
                btn25.Content = rezerveno.Text + " " + isim.Text;
                btn25.IsEnabled = false;
                rezerveno.Text = "";
                isim.Text = "";
                i++;
                x--;
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();

            }
            else
            {
                MessageBox.Show("rezerveno ve isim giriniz");
            }
            Random rnd = new Random();
            double sayi = rnd.Next(1 * 1000);
            rezerveno.Text = Convert.ToString(sayi);
        }
        private void sil_Click(object sender, RoutedEventArgs e)
        {
            if (iptal.Text!="")
            {
                if (iptal.Text == Convert.ToString(btn1.Content))
                {
                    btn1.Content = "";
                    btn1.IsEnabled = true;
                    iptal.Text = "";
                    i--;
                    x++;
                    lb3.Content = "Boş:" + x.ToString();
                    lb4.Content = "Dolu:" + i.ToString();
                }
                else if (iptal.Text == Convert.ToString(btn2.Content))
                {
                    btn2.Content = "";
                    btn2.IsEnabled = true;
                    iptal.Text = "";
                    i--;
                    x++;
                    lb3.Content = "Boş:" + x.ToString();
                    lb4.Content = "Dolu:" + i.ToString();
                }
                else if (iptal.Text == Convert.ToString(btn3.Content))
                {
                    btn3.Content = "";
                    btn3.IsEnabled = true;
                    iptal.Text = "";
                    i--;
                    x++;
                    lb3.Content = "Boş:" + x.ToString();
                    lb4.Content = "Dolu:" + i.ToString();
                }
                else if (iptal.Text == Convert.ToString(btn4.Content))
                {
                    btn4.Content = "";
                    btn4.IsEnabled = true;
                    iptal.Text = "";
                    i--;
                    x++;
                    lb3.Content = "Boş:" + x.ToString();
                    lb4.Content = "Dolu:" + i.ToString();
                }
                else if (iptal.Text == Convert.ToString(btn5.Content))
                {
                    btn5.Content = "";
                    btn5.IsEnabled = true;
                    iptal.Text = "";
                    i--;
                    x++;
                    lb3.Content = "Boş:" + x.ToString();
                    lb4.Content = "Dolu:" + i.ToString();
                }
                else if (iptal.Text == Convert.ToString(btn6.Content))
                {
                    btn6.Content = "";
                    btn6.IsEnabled = true;
                    iptal.Text = "";
                    i--;
                    x++;
                    lb3.Content = "Boş:" + x.ToString();
                    lb4.Content = "Dolu:" + i.ToString();
                }
                else if (iptal.Text == Convert.ToString(btn7.Content))
                {
                    btn7.Content = "";
                    btn7.IsEnabled = true;
                    iptal.Text = "";
                    i--;
                    x++;
                    lb3.Content = "Boş:" + x.ToString();
                    lb4.Content = "Dolu:" + i.ToString();
                }
                else if (iptal.Text == Convert.ToString(btn8.Content))
                {
                    btn8.Content = "";
                    btn8.IsEnabled = true;
                    iptal.Text = "";
                    i--;
                    x++;
                    lb3.Content = "Boş:" + x.ToString();
                    lb4.Content = "Dolu:" + i.ToString();
                }
                else if (iptal.Text == Convert.ToString(btn9.Content))
                {
                    btn9.Content = "";
                    btn9.IsEnabled = true;
                    iptal.Text = "";
                    i--;
                    x++;
                    lb3.Content = "Boş:" + x.ToString();
                    lb4.Content = "Dolu:" + i.ToString();
                }
                else if (iptal.Text == Convert.ToString(btn10.Content))
                {
                    btn10.Content = "";
                    btn10.IsEnabled = true;
                    iptal.Text = "";
                    i--;
                    x++;
                    lb3.Content = "Boş:" + x.ToString();
                    lb4.Content = "Dolu:" + i.ToString();
                }
                else if (iptal.Text == Convert.ToString(btn11.Content))
                {
                    btn11.Content = "";
                    btn11.IsEnabled = true;
                    iptal.Text = "";
                    i--;
                    x++;
                    lb3.Content = "Boş:" + x.ToString();
                    lb4.Content = "Dolu:" + i.ToString();
                }
                else if (iptal.Text == Convert.ToString(btn12.Content))
                {
                    btn12.Content = "";
                    btn12.IsEnabled = true;
                    iptal.Text = "";
                    i--;
                    x++;
                    lb3.Content = "Boş:" + x.ToString();
                    lb4.Content = "Dolu:" + i.ToString();
                }
                else if (iptal.Text == Convert.ToString(btn13.Content))
                {
                    btn13.Content = "";
                    btn13.IsEnabled = true;
                    iptal.Text = "";
                    i--;
                    x++;
                    lb3.Content = "Boş:" + x.ToString();
                    lb4.Content = "Dolu:" + i.ToString();
                }
                else if (iptal.Text == Convert.ToString(btn14.Content))
                {
                    btn14.Content = "";
                    btn14.IsEnabled = true;
                    iptal.Text = "";
                    i--;
                    x++;
                    lb3.Content = "Boş:" + x.ToString();
                    lb4.Content = "Dolu:" + i.ToString();
                }
                else if (iptal.Text == Convert.ToString(btn15.Content))
                {
                    btn15.Content = "";
                    btn15.IsEnabled = true;
                    iptal.Text = "";
                    i--;
                    x++;
                    lb3.Content = "Boş:" + x.ToString();
                    lb4.Content = "Dolu:" + i.ToString();
                }
                else if (iptal.Text == Convert.ToString(btn16.Content))
                {
                    btn16.Content = "";
                    btn16.IsEnabled = true;
                    iptal.Text = "";
                    i--;
                    x++;
                    lb3.Content = "Boş:" + x.ToString();
                    lb4.Content = "Dolu:" + i.ToString();
                }
                else if (iptal.Text == Convert.ToString(btn17.Content))
                {
                    btn17.Content = "";
                    btn17.IsEnabled = true;
                    iptal.Text = "";
                    i--;
                    x++;
                    lb3.Content = "Boş:" + x.ToString();
                    lb4.Content = "Dolu:" + i.ToString();
                }
                else if (iptal.Text == Convert.ToString(btn18.Content))
                {
                    btn18.Content = "";
                    btn18.IsEnabled = true;
                    iptal.Text = "";
                    i--;
                    x++;
                    lb3.Content = "Boş:" + x.ToString();
                    lb4.Content = "Dolu:" + i.ToString();
                }
                else if (iptal.Text == Convert.ToString(btn19.Content))
                {
                    btn19.Content = "";
                    btn19.IsEnabled = true;
                    iptal.Text = "";
                    i--;
                    x++;
                    lb3.Content = "Boş:" + x.ToString();
                    lb4.Content = "Dolu:" + i.ToString();
                }
                else if (iptal.Text == Convert.ToString(btn20.Content))
                {
                    btn20.Content = "";
                    btn20.IsEnabled = true;
                    iptal.Text = "";
                    i--;
                    x++;
                    lb3.Content = "Boş:" + x.ToString();
                    lb4.Content = "Dolu:" + i.ToString();
                }
                else if (iptal.Text == Convert.ToString(btn21.Content))
                {
                    btn21.Content = "";
                    btn21.IsEnabled = true;
                    iptal.Text = "";
                    i--;
                    x++;
                    lb3.Content = "Boş:" + x.ToString();
                    lb4.Content = "Dolu:" + i.ToString();
                }
                else if (iptal.Text == Convert.ToString(btn22.Content))
                {
                    btn22.Content = "";
                    btn22.IsEnabled = true;
                    iptal.Text = "";
                    i--;
                    x++;
                    lb3.Content = "Boş:" + x.ToString();
                    lb4.Content = "Dolu:" + i.ToString();
                }
                else if (iptal.Text == Convert.ToString(btn23.Content))
                {
                    btn23.Content = "";
                    btn23.IsEnabled = true;
                    iptal.Text = "";
                    i--;
                    x++;
                    lb3.Content = "Boş:" + x.ToString();
                    lb4.Content = "Dolu:" + i.ToString();
                }
                else if (iptal.Text == Convert.ToString(btn24.Content))
                {
                    btn24.Content = "";
                    btn24.IsEnabled = true;
                    iptal.Text = "";
                    i--;
                    x++;
                    lb3.Content = "Boş:" + x.ToString();
                    lb4.Content = "Dolu:" + i.ToString();
                }
                else if (iptal.Text == Convert.ToString(btn25.Content))
                {
                    btn25.Content = "";
                    btn25.IsEnabled = true;
                    iptal.Text = "";
                    i--;
                    x++;
                    lb3.Content = "Boş:" + x.ToString();
                    lb4.Content = "Dolu:" + i.ToString();
                }
            }
        }
    }
}