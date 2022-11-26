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
    /// Логика взаимодействия для AddService.xaml
    /// </summary>
    public partial class AddService : Page
    {
        ApplicationContext db;
        public AddService(ApplicationContext context)
        {
            InitializeComponent();
            db = context;
        }

        private void button_forDoc_Click(object sender, RoutedEventArgs e)
        {
            doc_image.Visibility = Visibility.Collapsed;
            doc_text.Visibility = Visibility.Collapsed;
            doc_count.Visibility = Visibility.Visible;
            doc_but.Visibility = Visibility.Visible;
        }

        private void doc_count_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                int t = int.Parse(doc_count.Text[doc_count.Text.Length - 1].ToString());
            }
            catch
            {
                if(doc_count.Text.Length > 0)
                {
                    doc_count.Text = doc_count.Text.Remove(doc_count.Text.Length - 1);
                    doc_count.SelectionStart = doc_count.Text.Length;  
                }
                
            }
        }
    }
}
