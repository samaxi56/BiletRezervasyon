﻿using System;
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
                btn1.Content = tcno.Text + " " + isim.Text;
                btn1.IsEnabled = false;
                tcno.Text = "";
                isim.Text = "";
                i++;
                x--; 
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();

            }
            else
            {
                MessageBox.Show("TcNo ve isim giriniz");
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (tcno.Text != "" && isim.Text != "")
            {
                btn2.Content = tcno.Text + " " + isim.Text;
                btn2.IsEnabled = false;
                tcno.Text = "";
                isim.Text = "";
                i++;
                x--;
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();
            }
            else
            {
                MessageBox.Show("TcNo ve isim giriniz");
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (tcno.Text != "" && isim.Text != "")
            {
                btn3.Content = tcno.Text + " " + isim.Text;
                btn3.IsEnabled = false;
                tcno.Text = "";
                isim.Text = "";
                i++;
                x--;
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();

            }
            else
            {
                MessageBox.Show("TcNo ve isim giriniz");
            }

        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (tcno.Text != "" && isim.Text != "")
            {
                btn4.Content = tcno.Text + " " + isim.Text;
                btn4.IsEnabled = false;
                tcno.Text = "";
                isim.Text = "";
                i++;
                x--;
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();

            }
            else
            {
                MessageBox.Show("TcNo ve isim giriniz");
            }

        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (tcno.Text != "" && isim.Text != "")
            {
                btn5.Content = tcno.Text + " " + isim.Text;
                btn5.IsEnabled = false;
                tcno.Text = "";
                isim.Text = "";
                i++;
                x--;
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();

            }
            else
            {
                MessageBox.Show("TcNo ve isim giriniz");
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (tcno.Text != "" && isim.Text != "")
            {
                btn6.Content = tcno.Text + " " + isim.Text;
                btn6.IsEnabled = false;
                tcno.Text = "";
                isim.Text = "";
                i++;
                x--;
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();

            }
            else
            {
                MessageBox.Show("TcNo ve isim giriniz");
            }
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (tcno.Text != "" && isim.Text != "")
            {
                btn7.Content = tcno.Text + " " + isim.Text;
                btn7.IsEnabled = false;
                tcno.Text = "";
                isim.Text = "";
                i++;
                x--;
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();
            }
            else
            {
                MessageBox.Show("TcNo ve isim giriniz");
            }
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (tcno.Text != "" && isim.Text != "")
            {
                btn8.Content = tcno.Text + " " + isim.Text;
                btn8.IsEnabled = false;
                tcno.Text = "";
                isim.Text = "";
                i++;
                x--;
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();

            }
            else
            {
                MessageBox.Show("TcNo ve isim giriniz");
            }
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (tcno.Text != "" && isim.Text != "")
            {
                btn9.Content = tcno.Text + " " + isim.Text;
                btn9.IsEnabled = false;
                tcno.Text = "";
                isim.Text = "";
                i++;
                x--;
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();

            }
            else
            {
                MessageBox.Show("TcNo ve isim giriniz");
            }
        }

        private void btn10_Click(object sender, RoutedEventArgs e)
        {
            if (tcno.Text != "" && isim.Text != "")
            {
                btn10.Content = tcno.Text + " " + isim.Text;
                btn10.IsEnabled = false;
                tcno.Text = "";
                isim.Text = "";
                i++;
                x--;
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();

            }
            else
            {
                MessageBox.Show("TcNo ve isim giriniz");
            }
        }

        private void btn11_Click(object sender, RoutedEventArgs e)
        {
            if (tcno.Text != "" && isim.Text != "")
            {
                btn11.Content = tcno.Text + " " + isim.Text;
                btn11.IsEnabled = false;
                tcno.Text = "";
                isim.Text = "";
                i++;
                x--;
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();

            }
            else
            {
                MessageBox.Show("TcNo ve isim giriniz");
            }
        }

        private void btn12_Click(object sender, RoutedEventArgs e)
        {
            if (tcno.Text != "" && isim.Text != "")
            {
                btn12.Content = tcno.Text + " " + isim.Text;
                btn12.IsEnabled = false;
                tcno.Text = "";
                isim.Text = "";
                i++;
                x--;
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();

            }
            else
            {
                MessageBox.Show("TcNo ve isim giriniz");
            }
        }

        private void btn13_Click(object sender, RoutedEventArgs e)
        {
            if (tcno.Text != "" && isim.Text != "")
            {
                btn13.Content = tcno.Text + " " + isim.Text;
                btn13.IsEnabled = false;
                tcno.Text = "";
                isim.Text = "";
                i++;
                x--;
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();

            }
            else
            {
                MessageBox.Show("TcNo ve isim giriniz");
            }
        }

        private void btn14_Click(object sender, RoutedEventArgs e)
        {
            if (tcno.Text != "" && isim.Text != "")
            {
                btn14.Content = tcno.Text + " " + isim.Text;
                btn14.IsEnabled = false;
                tcno.Text = "";
                isim.Text = "";
                i++;
                x--;
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();

            }
            else
            {
                MessageBox.Show("TcNo ve isim giriniz");
            }
        }

        private void btn15_Click(object sender, RoutedEventArgs e)
        {
            if (tcno.Text != "" && isim.Text != "")
            {
                btn15.Content = tcno.Text + " " + isim.Text;
                btn15.IsEnabled = false;
                tcno.Text = "";
                isim.Text = "";
                i++;
                x--;
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();

            }
            else
            {
                MessageBox.Show("TcNo ve isim giriniz");
            }
        }

        private void btn16_Click(object sender, RoutedEventArgs e)
        {
            if (tcno.Text != "" && isim.Text != "")
            {
                btn16.Content = tcno.Text + " " + isim.Text;
                btn16.IsEnabled = false;
                tcno.Text = "";
                isim.Text = "";
                i++;
                x--;
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();

            }
            else
            {
                MessageBox.Show("TcNo ve isim giriniz");
            }
        }

        private void btn17_Click(object sender, RoutedEventArgs e)
        {
            if (tcno.Text != "" && isim.Text != "")
            {
                btn17.Content = tcno.Text + " " + isim.Text;
                btn17.IsEnabled = false;
                tcno.Text = "";
                isim.Text = "";
                i++;
                x--;
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();

            }
            else
            {
                MessageBox.Show("TcNo ve isim giriniz");
            }
        }

        private void btn18_Click(object sender, RoutedEventArgs e)
        {
            if (tcno.Text != "" && isim.Text != "")
            {
                btn18.Content = tcno.Text + " " + isim.Text;
                btn18.IsEnabled = false;
                tcno.Text = "";
                isim.Text = "";
                i++;
                x--;
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();

            }
            else
            {
                MessageBox.Show("TcNo ve isim giriniz");
            }
        }

        private void btn19_Click(object sender, RoutedEventArgs e)
        {
            if (tcno.Text != "" && isim.Text != "")
            {
                btn19.Content = tcno.Text + " " + isim.Text;
                btn19.IsEnabled = false;
                tcno.Text = "";
                isim.Text = "";
                i++;
                x--;
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();

            }
            else
            {
                MessageBox.Show("TcNo ve isim giriniz");
            }
        }

        private void btn20_Click(object sender, RoutedEventArgs e)
        {
            if (tcno.Text != "" && isim.Text != "")
            {
                btn20.Content = tcno.Text + " " + isim.Text;
                btn20.IsEnabled = false;
                tcno.Text = "";
                isim.Text = "";
                i++;
                x--;
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();
            }
            else
            {
                MessageBox.Show("TcNo ve isim giriniz");
            }
        }

        private void btn21_Click(object sender, RoutedEventArgs e)
        {
            if (tcno.Text != "" && isim.Text != "")
            {
                btn21.Content = tcno.Text + " " + isim.Text;
                btn21.IsEnabled = false;
                tcno.Text = "";
                isim.Text = "";
                i++;
                x--;
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();

            }
            else
            {
                MessageBox.Show("TcNo ve isim giriniz");
            }
        }

        private void btn22_Click(object sender, RoutedEventArgs e)
        {
            if (tcno.Text != "" && isim.Text != "")
            {
                btn22.Content = tcno.Text + " " + isim.Text;
                btn22.IsEnabled = false;
                tcno.Text = "";
                isim.Text = "";
                i++;
                x--;
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();

            }
            else
            {
                MessageBox.Show("TcNo ve isim giriniz");
            }
        }

        private void btn23_Click(object sender, RoutedEventArgs e)
        {
            if (tcno.Text != "" && isim.Text != "")
            {
                btn23.Content = tcno.Text + " " + isim.Text;
                btn23.IsEnabled = false;
                tcno.Text = "";
                isim.Text = "";
                i++;
                x--;
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();

            }
            else
            {
                MessageBox.Show("TcNo ve isim giriniz");
            }
        }

        private void btn24_Click(object sender, RoutedEventArgs e)
        {
            if (tcno.Text != "" && isim.Text != "")
            {
                btn24.Content = tcno.Text + " " + isim.Text;
                btn24.IsEnabled = false;
                tcno.Text = "";
                isim.Text = "";
                i++;
                x--;
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();

            }
            else
            {
                MessageBox.Show("TcNo ve isim giriniz");
            }
        }

        private void btn25_Click(object sender, RoutedEventArgs e)
        {
            if (tcno.Text != "" && isim.Text != "")
            {
                btn25.Content = tcno.Text + " " + isim.Text;
                btn25.IsEnabled = false;
                tcno.Text = "";
                isim.Text = "";
                i++;
                x--;
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();

            }
            else
            {
                MessageBox.Show("TcNo ve isim giriniz");
            }
        }
        private void sil_Click(object sender, RoutedEventArgs e)
        {
            if (iptal.Text==Convert.ToString(btn1.Content))
            {
                btn1.Content = "";
                btn1.IsEnabled = true;
                iptal.Text = "";
                i--;
                x++;
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();
            }
            else if (iptal.Text ==Convert.ToString(btn2.Content))
            {
                btn2.Content = "";
                btn2.IsEnabled = true;
                iptal.Text = "";
                i--;
                x++;
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();
            }
            else if (iptal.Text ==Convert.ToString(btn3.Content))
            {
                btn3.Content = "";
                btn3.IsEnabled = true;
                iptal.Text = "";
                i--;
                x++;
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();
            }
            else if (iptal.Text ==Convert.ToString(btn4.Content))
            {
                btn4.Content = "";
                btn4.IsEnabled = true;
                iptal.Text = "";
                i--;
                x++;
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();
            }
            else if (iptal.Text ==Convert.ToString(btn5.Content))
            {
                btn5.Content = "";
                btn5.IsEnabled = true;
                iptal.Text = "";
                i--;
                x++;
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();
            }
            else if (iptal.Text ==Convert.ToString(btn6.Content))
            {
                btn6.Content = "";
                btn6.IsEnabled = true;
                iptal.Text = "";
                i--;
                x++;
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();
            }
            else if (iptal.Text ==Convert.ToString(btn7.Content))
            {
                btn7.Content = "";
                btn7.IsEnabled = true;
                iptal.Text = "";
                i--;
                x++;
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();
            }
            else if (iptal.Text ==Convert.ToString(btn8.Content))
            {
                btn8.Content = "";
                btn8.IsEnabled = true;
                iptal.Text = "";
                i--;
                x++;
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();
            }
            else if (iptal.Text ==Convert.ToString(btn9.Content))
            {
                btn9.Content = "";
                btn9.IsEnabled = true;
                iptal.Text = "";
                i--;
                x++;
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();
            }
            else if (iptal.Text ==Convert.ToString(btn10.Content))
            {
                btn10.Content = "";
                btn10.IsEnabled = true;
                iptal.Text = "";
                i--;
                x++;
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();
            }
            else if (iptal.Text ==Convert.ToString(btn11.Content))
            {
                btn11.Content = "";
                btn11.IsEnabled = true;
                iptal.Text = "";
                i--;
                x++;
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();
            }
            else if (iptal.Text ==Convert.ToString(btn12.Content))
            {
                btn12.Content = "";
                btn12.IsEnabled = true;
                iptal.Text = "";
                i--;
                x++;
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();
            }
            else if (iptal.Text ==Convert.ToString(btn13.Content))
            {
                btn13.Content = "";
                btn13.IsEnabled = true;
                iptal.Text = "";
                i--;
                x++;
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();
            }
            else if (iptal.Text ==Convert.ToString(btn14.Content))
            {
                btn14.Content = "";
                btn14.IsEnabled = true;
                iptal.Text = "";
                i--;
                x++;
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();
            }
            else if (iptal.Text ==Convert.ToString(btn15.Content))
            {
                btn15.Content = "";
                btn15.IsEnabled = true;
                iptal.Text = "";
                i--;
                x++;
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();
            }
            else if (iptal.Text ==Convert.ToString(btn16.Content))
            {
                btn16.Content = "";
                btn16.IsEnabled = true;
                iptal.Text = "";
                i--;
                x++;
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();
            }
            else if (iptal.Text ==Convert.ToString(btn17.Content))
            {
                btn17.Content = "";
                btn17.IsEnabled = true;
                iptal.Text = "";
                i--;
                x++;
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();
            }
            else if (iptal.Text ==Convert.ToString(btn18.Content))
            {
                btn18.Content = "";
                btn18.IsEnabled = true;
                iptal.Text = "";
                i--;
                x++;
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();
            }
            else if (iptal.Text ==Convert.ToString(btn19.Content))
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
            else if (iptal.Text ==Convert.ToString(btn21.Content))
            {
                btn21.Content = "";
                btn21.IsEnabled = true;
                iptal.Text = "";
                i--;
                x++;
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();
            }
            else if (iptal.Text ==Convert.ToString(btn22.Content))
            {
                btn22.Content = "";
                btn22.IsEnabled = true;
                iptal.Text = "";
                i--;
                x++;
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();
            }
            else if (iptal.Text ==Convert.ToString(btn23.Content))
            {
                btn23.Content = "";
                btn23.IsEnabled = true;
                iptal.Text = "";
                i--;
                x++;
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();
            }
            else if (iptal.Text ==Convert.ToString(btn24.Content))
            {
                btn24.Content = "";
                btn24.IsEnabled = true;
                iptal.Text = "";
                i--;
                x++;
                lb3.Content = "Boş:" + x.ToString();
                lb4.Content = "Dolu:" + i.ToString();
            }
            else if (iptal.Text ==Convert.ToString(btn25.Content))
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