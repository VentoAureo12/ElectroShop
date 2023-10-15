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

namespace TestApp
{
    /// <summary>
    /// Логика взаимодействия для UserOrdersWindow.xaml
    /// </summary>
    public partial class UserOrdersWindow : Window
    {
        public UserOrdersWindow()
        {
            InitializeComponent();
            userOrders.ItemsSource = ElectroShopBDEntities.GetContext().Заказ.Where(u => u.ID_пользователя == DataTransfer.userID).ToList();
        }

        private void SnapBackButton_Click(object sender, RoutedEventArgs e)
        {
            UserWindow window = new UserWindow();
            window.Show();
            this.Close();
        }
    }
}
