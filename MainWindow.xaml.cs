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
    }
}
