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
    /// <summary>
    /// Логика взаимодействия для AccountView.xaml
    /// </summary>
    public partial class AccountView : UserControl
    {
        public AccountView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string messageBoxText;
            MessageBoxImage icon;
            string caption = "Регистрация данных";
            MessageBoxButton button = MessageBoxButton.OK;
            if (Text1.Text == null || Text2.Text == null || Text3.Text == null || Text4.Text == null ||
                Text1.Text == String.Empty || Text2.Text == String.Empty || Text3.Text == String.Empty || Text4.Text == String.Empty)
            {
                messageBoxText = "Заполните все поля для регистрации.";
                icon = MessageBoxImage.Warning;
                MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);
                return;
            }
            messageBoxText = "Регистрация прошла успешно.";
            icon = MessageBoxImage.Information;

            MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string messageBoxText = "Оплачено.";
            string caption = "Оплата";
            MessageBoxButton button = MessageBoxButton.OK;
            MessageBoxImage icon = MessageBoxImage.Information;

            MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);
        }
    }
}
