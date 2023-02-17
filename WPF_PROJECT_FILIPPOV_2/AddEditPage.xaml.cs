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
    /// Логика взаимодействия для AddEditPage.xaml
    /// </summary>
    public partial class AddEditPage : Page
    {
        private Tovar _currentTovar = new Tovar();

        public AddEditPage(Tovar selectedTovar)
        {
            InitializeComponent();
            if (selectedTovar != null)
                _currentTovar = selectedTovar;
            DataContext = _currentTovar;

        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_currentTovar.NameTovar))
                errors.AppendLine("Укажите название товара");
                errors.AppendLine("Укажите количество товара");
            if (_currentTovar.KolichestvoTovara == null)
                errors.AppendLine("Выбирите ID поставщика");
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            try
            {
                ProjectFilippov_2Entities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена!");
                Manager.MainFrame.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
