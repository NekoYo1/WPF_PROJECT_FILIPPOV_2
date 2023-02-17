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

namespace WPF_PROJECT_FILIPPOV_2
{
    /// <summary>
    /// Логика взаимодействия для UchetTovarPage.xaml
    /// </summary>
    public partial class UchetTovarPage : Page
    {
        public UchetTovarPage()
        {
            InitializeComponent();
            DGridHotels.ItemsSource = ProjectFilippov_2Entities.GetContext().Tovar.ToList();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditPage(null));
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            var TovarForRemoving = DGridHotels.SelectedItems.Cast<Tovar>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующие {TovarForRemoving.Count()} элементов?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    ProjectFilippov_2Entities.GetContext().Tovar.RemoveRange(TovarForRemoving);
                    ProjectFilippov_2Entities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");
                    DGridHotels.ItemsSource = ProjectFilippov_2Entities.GetContext().Tovar.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }

            }
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                // Ошибка - не сохранятся добавленные данные, строка 69.
                ProjectFilippov_2Entities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DGridHotels.ItemsSource = ProjectFilippov_2Entities.GetContext().Tovar.ToList();
            }
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditPage((sender as Button).DataContext as Tovar));
        }
    }
}
