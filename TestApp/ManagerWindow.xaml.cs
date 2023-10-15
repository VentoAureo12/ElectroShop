using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    /// Логика взаимодействия для ManagerWindow.xaml
    /// </summary>
    public partial class ManagerWindow : Window
    {
        private bool isDirty = true;
        public ManagerWindow()
        {
            InitializeComponent();
            OrdersData.ItemsSource = ElectroShopBDEntities.GetContext().Заказ.ToList();
            OrdersGoodData.ItemsSource = ElectroShopBDEntities.GetContext().Заказ_Товар.ToList();
            OrderStatusСomboBox.ItemsSource = ElectroShopBDEntities.GetContext().Статус_заказа.ToList();
            DeliverySpotSearchComboBox.ItemsSource = ElectroShopBDEntities.GetContext().Пункт_Выдачи.ToList();

            var allSpots = ElectroShopBDEntities.GetContext().Пункт_Выдачи.ToList();
            allSpots.Insert(0, new Пункт_Выдачи
            {
                Адрес_пункта_выдачи = "Все пункты"
            });

            DeliverySpotSearchComboBox.ItemsSource = allSpots;

            DeliverySpotSearchComboBox.SelectedIndex = 0;

            var allOrderStatus = ElectroShopBDEntities.GetContext().Статус_заказа.ToList();
            allOrderStatus.Insert(0, new Статус_заказа
            {
                Описание_статуса = "Все статусы"
            });

            OrderStatusСomboBox.ItemsSource = allOrderStatus;

            DeliverySpotSearchComboBox.SelectedIndex = 0;
        }

        private void DeliverySpotSearchComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (DeliverySpotSearchComboBox.SelectedIndex)
            {
                case 0:
                    OrdersData.ItemsSource = ElectroShopBDEntities.GetContext().Заказ.ToList();
                    break;

                case 1:
                    OrdersData.ItemsSource = ElectroShopBDEntities.GetContext().Заказ.Where(u => u.ID_пункта_выдачи == 1).ToList();
                    break;
                case 2:
                    OrdersData.ItemsSource = ElectroShopBDEntities.GetContext().Заказ.Where(u => u.ID_пункта_выдачи == 2).ToList();
                    break;
                case 3:
                    OrdersData.ItemsSource = ElectroShopBDEntities.GetContext().Заказ.Where(u => u.ID_пункта_выдачи == 3).ToList();
                    break;
            }
        }

        private void OrderIDSearchField_TextChanged(object sender, TextChangedEventArgs e)
        {
            int orderID;
            if (OrderIDSearchField.Text != null)
            {
                try
                {
                    orderID = int.Parse(OrderIDSearchField.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    MessageBox.Show("Необходимо вводить именно номер заказа");
                    return;
                }
                OrdersData.ItemsSource = ElectroShopBDEntities.GetContext().Заказ.Where(x => x.ID == orderID).ToList();
            }
            else
            {
                OrdersData.ItemsSource = ElectroShopBDEntities.GetContext().Заказ.ToList();
            }
           
        }

        private void Edit_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            OrdersData.BeginEdit();
            OrdersGoodData.BeginEdit();
            isDirty = false;
        }

        private void Edit_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = isDirty;
        }

        private void Save_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = !isDirty;
        }

        private void Save_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            try
            {
                ElectroShopBDEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            OrdersData.IsReadOnly = true;
            OrdersGoodData.IsReadOnly = true;
            isDirty = true;
        }

        private void Undo_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = !isDirty;
        }

        private void Undo_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            var context = ElectroShopBDEntities.GetContext();
            var changedEntries = context.ChangeTracker.Entries()
                .Where(x => x.State != EntityState.Unchanged).ToList();

            foreach (var entry in changedEntries)
            {
                switch (entry.State)
                {
                    case EntityState.Modified:
                        entry.CurrentValues.SetValues(entry.OriginalValues);
                        entry.State = EntityState.Unchanged;
                        break;
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                    case EntityState.Deleted:
                        entry.State = EntityState.Unchanged;
                        break;
                }
            }
            OrdersData.ItemsSource = null;
            OrdersData.ItemsSource = ElectroShopBDEntities.GetContext().Заказ.ToList();
            OrdersGoodData.ItemsSource = null;
            OrdersData.ItemsSource = ElectroShopBDEntities.GetContext().Заказ_Товар.ToList();
            MessageBox.Show("Отмена действия");
            isDirty = true;
            OrdersData.IsReadOnly = true;
            OrdersGoodData.IsReadOnly = true;
        }

        private void Find_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = isDirty;
        }

        private void Find_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if(OrdersData.Visibility == Visibility.Visible)
            {
                BorderFind.Visibility = Visibility.Visible;
                BorderGoodFind.Visibility = Visibility.Hidden;
            }
            if (OrdersGoodData.Visibility == Visibility.Visible)
            {
                BorderFind.Visibility = Visibility.Hidden;
                BorderGoodFind.Visibility = Visibility.Visible;
            }
            isDirty = false;
        }

        private void Refresh_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = isDirty;
        }

        private void Refresh_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            isDirty = false;

            OrderGoodIDSearchField.Text = null;
            OrderIDSearchField.Text = null;
            DeliverySpotSearchComboBox.SelectedIndex = 0;
            OrderStatusСomboBox.SelectedIndex = 0;

            OrdersData = null;
            OrdersGoodData = null;

            OrdersData.ItemsSource = ElectroShopBDEntities.GetContext().Заказ.ToList();
            OrdersGoodData.ItemsSource = ElectroShopBDEntities.GetContext().Заказ_Товар.ToList();

        }

        private void OrderStatusСomboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (OrderStatusСomboBox.SelectedIndex)
            {
                case 0:
                    OrdersData.ItemsSource = ElectroShopBDEntities.GetContext().Заказ.ToList();
                    break;

                case 1:
                    OrdersData.ItemsSource = ElectroShopBDEntities.GetContext().Заказ.Where(u => u.Статус_заказа == 1).ToList();
                    break;
                case 2:
                    OrdersData.ItemsSource = ElectroShopBDEntities.GetContext().Заказ.Where(u => u.Статус_заказа == 2).ToList();
                    break;
                case 3:
                    OrdersData.ItemsSource = ElectroShopBDEntities.GetContext().Заказ.Where(u => u.Статус_заказа == 3).ToList();
                    break;
                case 4:
                    OrdersData.ItemsSource = ElectroShopBDEntities.GetContext().Заказ.Where(u => u.Статус_заказа == 4).ToList();
                    break;
                case 5:
                    OrdersData.ItemsSource = ElectroShopBDEntities.GetContext().Заказ.Where(u => u.Статус_заказа == 5).ToList();
                    break;
            }
        }

        private void OrderGoodIDSearchField_TextChanged(object sender, TextChangedEventArgs e)
        {
            int orderID;
            try
            {
                orderID = int.Parse(OrderGoodIDSearchField.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
           
            OrdersData.ItemsSource = ElectroShopBDEntities.GetContext().Заказ_Товар.Where(u => u.ID_заказа == orderID).ToList();
        }

        private void SwitchToOrderDataGridButton_Click(object sender, RoutedEventArgs e)
        {
            OrdersData.Visibility = Visibility.Visible;
            OrdersGoodData.Visibility = Visibility.Hidden;

            BorderFind.Visibility = Visibility.Visible;
            BorderGoodFind.Visibility = Visibility.Hidden;
        }

        private void SwitchToOrderGoodDataGridButton_Click(object sender, RoutedEventArgs e)
        {
            OrdersData.Visibility = Visibility.Hidden;
            OrdersGoodData.Visibility = Visibility.Visible;

            BorderFind.Visibility = Visibility.Hidden;
            BorderGoodFind.Visibility = Visibility.Visible;
        }
    }
}
