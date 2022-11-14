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

namespace WpfApp1.Frames
{
    /// <summary>
    /// Логика взаимодействия для Monitor.xaml
    /// </summary>
    public partial class Monitor : Page
    {
        public Monitor()
        {
            InitializeComponent();
        }
        private void OpenSettings(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new Monitor());
        }
    }
}
