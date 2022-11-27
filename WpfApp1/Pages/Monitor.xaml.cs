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
using WpfApp1.DataBaseClasses;

namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для Monitor.xaml
    /// </summary>Product
    public partial class Monitor : Page
    {
        ApplicationContext db;
        public List<Product> products = new List<Product>();
        public Monitor()
        {
            InitializeComponent();
            db = new ApplicationContext();
            basket.ItemsSource = products;
        }
        private void OpenSettings(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new UsersSettings(db));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddService(db, this));
        }
        private void Del_product(object sender, RoutedEventArgs e)
        {
            var product =  basket.SelectedItem as Product;
            MessageBoxResult result = MessageBox.Show("Действительно удалить данный товар?", null, MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);
            if (result == MessageBoxResult.Yes)
            {
                products.Remove(product);
                basket.Items.Refresh();
                this.result.Content = (double.Parse(this.result.Content.ToString()) - double.Parse(product.Price)).ToString();
            }
        }
    }
}
