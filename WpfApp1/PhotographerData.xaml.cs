
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
            monitor.products.Add(new Product("Visit of the photographer", "1", "3000"));
            monitor.basket.Items.Refresh();
            monitor.result.Content = (double.Parse(monitor.result.Content.ToString()) + 3000).ToString();
            this.Close();
        }
    }
}
