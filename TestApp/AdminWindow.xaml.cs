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
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        private bool isDirty = true;
        public AdminWindow()
        {
            InitializeComponent();
            GoodsData.ItemsSource = ElectroShopBDEntities.GetContext().Товар.ToList();
            TypesOfGoodsComboBox.ItemsSource = ElectroShopBDEntities.GetContext().Вид_товара.ToList();
            TypeSearchComboBox.ItemsSource = ElectroShopBDEntities.GetContext().Вид_товара.ToList();

            var allTypes = ElectroShopBDEntities.GetContext().Вид_товара.ToList();
            allTypes.Insert(0, new Вид_товара
            {
                Название = "Все типы"
            });

            TypeSearchComboBox.ItemsSource = allTypes;

            TypeSearchComboBox.SelectedIndex = 0;
        }

        private void Delete_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            var GoodForDeleting = GoodsData.SelectedItems.Cast<Товар>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие {GoodForDeleting.Count()} элементов?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    ElectroShopBDEntities.GetContext().Товар.RemoveRange(GoodForDeleting);
                    ElectroShopBDEntities.GetContext().SaveChanges();
                    MessageBox.Show("Удалено");
                    GoodsData.ItemsSource = ElectroShopBDEntities.GetContext().Товар.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            isDirty = false;
        }

        private void Delete_Canexecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = isDirty;
        }

        private void Edit_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            GoodsData.IsReadOnly = false;
            GoodsData.BeginEdit();
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
            isDirty = true;
            GoodsData.IsReadOnly = true;
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
            GoodsData.ItemsSource = null;
            GoodsData.ItemsSource = ElectroShopBDEntities.GetContext().Товар.ToList();
            MessageBox.Show("Отмена действия");
            isDirty = true;
            GoodsData.IsReadOnly = true;
        }

        private void New_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = isDirty;
        }

        private void New_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            GoodsData.IsReadOnly = false;
            Товар goods = new Товар()
            {
                Наименование = "Вставьте название",
                Вид_товара = 1,
                Количество_на_складе = 0,
                Цена = 0,
                Изображение = null
            };
            ElectroShopBDEntities.GetContext().Товар.Add(goods);
            try
            {
                ElectroShopBDEntities.GetContext().SaveChanges();
                GoodsData.ItemsSource = null;
                GoodsData.ItemsSource = ElectroShopBDEntities.GetContext().Товар.ToList();
                MessageBox.Show("Данные готовы к добавлению");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            isDirty = false;
        }

        private void Find_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = isDirty;
        }

        private void Find_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            BorderFind.Visibility = Visibility.Visible;
            isDirty = false;
        }

        private void Refresh_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = isDirty;
        }

        private void Refresh_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            TypeSearchComboBox.SelectedIndex = -1;
            NameSearchField.Text = "";
            GoodsData.ItemsSource = null;
            GoodsData.ItemsSource = ElectroShopBDEntities.GetContext().Товар.ToList();
            isDirty = false;
            BorderFind.Visibility = Visibility.Hidden;

        }

        private void NameSearchField_TextChanged(object sender, TextChangedEventArgs e)
        {
           GoodsData.ItemsSource = ElectroShopBDEntities.GetContext().Товар.Where(u => u.Наименование.Contains(NameSearchField.Text)).ToList();
           TypeSearchComboBox.SelectedIndex = -1;
        }

        private void TypeSearchComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (TypeSearchComboBox.SelectedIndex)
            {
                case 0:
                    GoodsData.ItemsSource = ElectroShopBDEntities.GetContext().Товар.ToList();
                    break;

                case 1:
                    GoodsData.ItemsSource = ElectroShopBDEntities.GetContext().Товар.Where(u => u.Вид_товара == 1).ToList();
                    break;
                case 2:
                    GoodsData.ItemsSource = ElectroShopBDEntities.GetContext().Товар.Where(u => u.Вид_товара == 2).ToList();
                    break;
                case 3:
                    GoodsData.ItemsSource = ElectroShopBDEntities.GetContext().Товар.Where(u => u.Вид_товара == 3).ToList();
                    break;
                case 4:
                    GoodsData.ItemsSource = ElectroShopBDEntities.GetContext().Товар.Where(u => u.Вид_товара == 4).ToList();
                    break;
                case 5:
                    GoodsData.ItemsSource = ElectroShopBDEntities.GetContext().Товар.Where(u => u.Вид_товара == 5).ToList();
                    break;
            }
        }
    }
}
