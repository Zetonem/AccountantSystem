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

namespace AccountantSystem.View
{
    public partial class ProxyView : UserControl
    {
        private bool isButton0 = false, isButton1 = false, isButton2 = false, isButton3 = false;
        public ProxyView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            statuslabel.Visibility = Visibility.Visible;
            statuslabel.Content = "Поручение получено";
            statuslabel.Background = new SolidColorBrush(Color.FromRgb(0, 255, 0));
            isButton0 = true;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (!isButton0)
            {
                statuslabel.Visibility = Visibility.Visible;
                statuslabel.Content = "Поручение не получено";
                statuslabel.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                return;
            }
            statuslabel.Content = "Оплата проверена";
            statuslabel.Background = new SolidColorBrush(Color.FromRgb(0, 255, 0));
            isButton1 = true;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (!isButton1)
            {
                statuslabel.Visibility = Visibility.Visible;
                statuslabel.Content = "Оплата не проверена";
                statuslabel.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                return;
            }
            if (sumTextBox.Text == String.Empty || numberTextBox.Text == String.Empty || nameTextBox.Text == String.Empty ||
                sumTextBox.Text == null || numberTextBox.Text == null || nameTextBox.Text == null)
            {
                statuslabel.Content = "Невозможно сформировать доверенность. Заполните все поля";
                statuslabel.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                return;
            }

            statuslabel.Content = $"Сформирована доверенность #{numberTextBox.Text} на сумму {sumTextBox.Text} на сотрудника {nameTextBox.Text}";
            statuslabel.Background = new SolidColorBrush(Color.FromRgb(0, 255, 0));
            isButton2 = true;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (!isButton2)
            {
                statuslabel.Visibility = Visibility.Visible;
                statuslabel.Content = "Доверенность не сформирована";
                statuslabel.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                return;
            }
            statuslabel.Content = $"Доверенность #{numberTextBox.Text} заверена";
            statuslabel.Background = new SolidColorBrush(Color.FromRgb(0, 255, 0));
            isButton3 = true;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (!isButton3)
            {
                statuslabel.Visibility = Visibility.Visible;
                statuslabel.Content = "Доверенность не заверена";
                statuslabel.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                return;
            }
            statuslabel.Content = $"Поручение #{numberTextBox.Text} выдано";
            statuslabel.Background = new SolidColorBrush(Color.FromRgb(0, 255, 0));
            sumTextBox.Text = String.Empty;
            numberTextBox.Text = String.Empty;
            nameTextBox.Text = String.Empty;
            isButton0 = false;
            isButton1 = false;
            isButton2 = false;
            isButton3 = false;
        }
    }
}
