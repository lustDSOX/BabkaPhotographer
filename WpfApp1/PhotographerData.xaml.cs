
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Media3D;
using WpfApp1.DataBaseClasses;
using WpfApp1.Pages;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для PhotographerData.xaml
    /// </summary>
    public partial class PhotographerData : Window
    {
        Monitor monitor;
        public PhotographerData(Monitor monitor)
        {
            InitializeComponent();
            this.monitor = monitor;
        }
        private void login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) NewPhotographer();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NewPhotographer();
        }

        void NewPhotographer()
        {
            ApplicationContext db = new ApplicationContext();
            Service service = db.Services.Where(x => x.Name == "Visit of the photographer").First();
            monitor.products.Add(new Product(service.Name, "1", service.Price.ToString()));
            monitor.basket.Items.Refresh();
            monitor.result.Content = (double.Parse(monitor.result.Content.ToString()) + service.Price).ToString();
            this.Close();
        }
    }
}
