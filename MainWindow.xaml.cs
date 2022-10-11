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

namespace ISRPO_Cherednichenko_PR7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        int a = 0;
        int d;

        private void PB1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("состав", "Борщ");
        }

        private void PB2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("состав", "Куриный суп");
        }

        private void PB3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("состав", "Том Ям");
        }

        private void VB1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("состав", "Стейк-террияки");
        }

        private void VB2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("состав", "Шашлычок");
        }

        private void VB3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("состав", "Пельмени домашние");
        }

        private void N1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("состав", "Чай");
        }

        private void N2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("состав", "Кофе Латте");
        }

        private void N3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("состав", "Колд-брю");
        }

        private void D1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("состав", "Тирамису");
        }

        private void D2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("состав", "Чизкейк Нью-Йорк");
        }

        private void D3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("состав", "Мороженое с сиропом");
        }

        private void Z1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("состав", "Кальмары в кляре");
        }

        private void Z2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("состав", "Жульен охотничий");
        }

        private void Z3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("состав", "Карпаччо из говядины");
        }

        private void butt1_Click(object sender, RoutedEventArgs e)
        {
            a = a + 1;
            zakaz.Text = zakaz.Text += a + " " + PB1.Text + " " + PB1c.Text + Environment.NewLine;
            d = d + 180;
            itog.Text = d.ToString();

        }

        private void butt2_Click(object sender, RoutedEventArgs e)
        {
            a = a + 1;
            zakaz.Text = zakaz.Text += a +" "+ PB2.Text +" "+ PB2c.Text + Environment.NewLine;
            d = d + 180;
            itog.Text = d.ToString();
        }

        private void butt3_Click(object sender, RoutedEventArgs e)
        {
            a = a + 1;
            zakaz.Text = zakaz.Text += a + " " + PB3.Text + " " + PB3c.Text + Environment.NewLine;
            d = d + 340;
            itog.Text = d.ToString();
        }

        private void butt4_Click(object sender, RoutedEventArgs e)
        {
            a = a + 1;
            zakaz.Text = zakaz.Text += a + " " + VB1.Text + " " + VB1c.Text + Environment.NewLine;
            d = d + 410;
            itog.Text = d.ToString();
        }

        private void butt5_Click(object sender, RoutedEventArgs e)
        {
            a = a + 1;
            zakaz.Text = zakaz.Text += a + " " + VB2.Text + " " + VB2c.Text + Environment.NewLine;
            d = d + 290;
            itog.Text = d.ToString();
        }

        private void butt6_Click(object sender, RoutedEventArgs e)
        {
            a = a + 1;
            zakaz.Text = zakaz.Text += a + " " + VB3.Text + " " + VB3c.Text + Environment.NewLine;
            d = d + 115;
            itog.Text = d.ToString();
        }

        private void butt7_Click(object sender, RoutedEventArgs e)
        {
            a = a + 1;
            zakaz.Text = zakaz.Text += a + " " + N1.Text + " " + N1c.Text + Environment.NewLine;
            d = d + 40;
            itog.Text = d.ToString();
        }

        private void butt8_Click(object sender, RoutedEventArgs e)
        {
            a = a + 1;
            zakaz.Text = zakaz.Text += a + " " + N2.Text + " " + N2c.Text + Environment.NewLine;
            d = d + 120;
            itog.Text = d.ToString();
        }

        private void butt9_Click(object sender, RoutedEventArgs e)
        {
            a = a + 1;
            zakaz.Text = zakaz.Text += a + " " + N3.Text + " " + N3c.Text + Environment.NewLine;
            d = d + 200;
            itog.Text = d.ToString();
        }

        private void butt10_Click(object sender, RoutedEventArgs e)
        {
            a = a + 1;
            zakaz.Text = zakaz.Text += a + " " + D1.Text + " " + D1c.Text + Environment.NewLine;
            d = d + 280;
            itog.Text = d.ToString();
        }

        private void butt11_Click(object sender, RoutedEventArgs e)
        {
            a = a + 1;
            zakaz.Text = zakaz.Text += a + " " + D2.Text + " " + D2c.Text + Environment.NewLine;
            d = d + 200;
            itog.Text = d.ToString();
        }

        private void butt12_Click(object sender, RoutedEventArgs e)
        {
            a = a + 1;
            zakaz.Text = zakaz.Text += a + " " + D3.Text + " " + D3c.Text + Environment.NewLine;
            d = d + 100;
            itog.Text = d.ToString();
        }

        private void butt13_Click(object sender, RoutedEventArgs e)
        {
            a = a + 1;
            zakaz.Text = zakaz.Text += a + " " + Z1.Text + " " + Z1c.Text + Environment.NewLine;
            d = d + 215;
            itog.Text = d.ToString();
        }

        private void butt14_Click(object sender, RoutedEventArgs e)
        {
            a = a + 1;
            zakaz.Text = zakaz.Text += a + " " + Z2.Text + " " + Z2c.Text + Environment.NewLine;
            d = d + 150;
            itog.Text = d.ToString();
        }

        private void butt15_Click(object sender, RoutedEventArgs e)
        {
            a = a + 1;
            zakaz.Text = zakaz.Text += a + " " + Z3.Text + " " + Z3c.Text + Environment.NewLine;
            d = d + 550;
            itog.Text = d.ToString();
        }
    }
}
