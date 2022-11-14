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
using WpfApp1.DataBaseClasses;
using WpfApp1.Frames;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для VoidWindow.xaml
    /// </summary>
    public partial class VoidWindow : Window
    {
        public VoidWindow()
        {
            InitializeComponent();
            frame.Navigate(new Monitor());
        }
    }
}
