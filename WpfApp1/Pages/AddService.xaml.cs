using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        Monitor monitor;
        public AddService(ApplicationContext context, Monitor monitor)
        {
            InitializeComponent();
            db = context;
            this.monitor = monitor;
        }

        private void button_forDoc_Click(object sender, RoutedEventArgs e)
        {
            AllVisible();
            doc_image.Visibility = Visibility.Collapsed;
            doc_text.Visibility = Visibility.Collapsed;

            doc_count.Visibility = Visibility.Visible;
            doc_but.Visibility = Visibility.Visible;
        }
        private void button_Films_Click(object sender, RoutedEventArgs e)
        {
            AllVisible();
            films_image.Visibility = Visibility.Collapsed;
            films_text.Visibility = Visibility.Collapsed;

            films_count.Visibility = Visibility.Visible;
            films_but.Visibility = Visibility.Visible;
        }
        private void button_Art_Click(object sender, RoutedEventArgs e)
        {
            AllVisible();
            art_image.Visibility = Visibility.Collapsed;
            art_text.Visibility = Visibility.Collapsed;

            art_count.Visibility = Visibility.Visible;
            art_but.Visibility = Visibility.Visible;
        }
        private void button_Print_Click(object sender, RoutedEventArgs e)
        {
            AllVisible();
            print_image.Visibility = Visibility.Collapsed;
            print_text.Visibility = Visibility.Collapsed;

            print_count.Visibility = Visibility.Visible;
            print_but.Visibility = Visibility.Visible;
        }
        private void button_Rest_Click(object sender, RoutedEventArgs e)
        {
            AllVisible();
            rest_image.Visibility = Visibility.Collapsed;
            rest_text.Visibility = Visibility.Collapsed;

            rest_status.Visibility = Visibility.Visible;
            rest_but.Visibility = Visibility.Visible;
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

        void AllVisible()
        {
            doc_image.Visibility = Visibility.Visible;
            doc_text.Visibility = Visibility.Visible;
            doc_count.Visibility = Visibility.Collapsed;
            doc_but.Visibility = Visibility.Collapsed;


            art_image.Visibility = Visibility.Visible;
            art_text.Visibility = Visibility.Visible;
            art_count.Visibility = Visibility.Collapsed;
            art_but.Visibility = Visibility.Collapsed;

            films_image.Visibility = Visibility.Visible;
            films_text.Visibility = Visibility.Visible;
            films_count.Visibility = Visibility.Collapsed;
            films_but.Visibility = Visibility.Collapsed;

            print_image.Visibility = Visibility.Visible;
            print_text.Visibility = Visibility.Visible;
            print_count.Visibility = Visibility.Collapsed;
            print_but.Visibility = Visibility.Collapsed;

            rest_image.Visibility = Visibility.Visible;
            rest_text.Visibility = Visibility.Visible;
            rest_but.Visibility = Visibility.Collapsed;
            rest_status.Visibility = Visibility.Collapsed;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(SearchCam.Text == "")
            {
                Services.Visibility = Visibility.Visible;
                Cameras.Visibility = Visibility.Hidden;
            }
            else
            {
                Services.Visibility = Visibility.Hidden;
                Cameras.Visibility = Visibility.Visible;
                List<PhotoCamera> cameras = db.Cameras.Where(x => x.Name.Contains(SearchCam.Text)).ToList();
                Cameras.ItemsSource = cameras;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.GoBack();
        }

        private void doc_but_Click(object sender, RoutedEventArgs e)
        {
            Service service = db.Services.Where(x => x.Name == "Photo for documents").First();
            double price = int.Parse(doc_count.Text) * service.Price;
            monitor.products.Add(new Product(service.Name, doc_count.Text, price.ToString()));
            monitor.basket.Items.Refresh();
            monitor.result.Content = (double.Parse(monitor.result.Content.ToString()) + price).ToString();
        }
        private void art_but_Click(object sender, RoutedEventArgs e)
        {
            Service service = db.Services.Where(x => x.Name == "Artistic photo").First();
            double price = int.Parse(art_count.Text) * service.Price;
            monitor.products.Add(new Product(service.Name, art_count.Text, price.ToString()));
            monitor.basket.Items.Refresh();
            monitor.result.Content = (double.Parse(monitor.result.Content.ToString()) + price).ToString();
        }
        private void films_but_Click(object sender, RoutedEventArgs e)
        {
            Service service = db.Services.Where(x => x.Name == "Photographic films").First();
            double price = int.Parse(films_count.Text) * service.Price;
            monitor.products.Add(new Product(service.Name, films_count.Text, price.ToString()));
            monitor.basket.Items.Refresh();
            monitor.result.Content = (double.Parse(monitor.result.Content.ToString()) + price).ToString();
        }
        private void print_but_Click(object sender, RoutedEventArgs e)
        {
            Service service = db.Services.Where(x => x.Name == "Print photo").First();
            double price = int.Parse(print_count.Text) * service.Price;
            monitor.products.Add(new Product(service.Name, print_count.Text, price.ToString()));
            monitor.basket.Items.Refresh();
            monitor.result.Content = (double.Parse(monitor.result.Content.ToString()) + price).ToString();
        }
        private void rest_but_Click(object sender, RoutedEventArgs e)
        {
            Service service = db.Services.Where(x => x.Name == "Photo restoration").First();
            double price = 0;
            switch (rest_status.SelectedValuePath)
            {
                case "50 рублей":
                    price = 50;
                    break;
                case "жить можно":
                    price = 500;
                    break;
                case "undead":
                    price = 4004;
                    break;
                case "тазик твой друг":
                    price = 74314;
                    break;
                case "плачевное":
                    price = 14100;
                    break;
            }
            monitor.products.Add(new Product(service.Name, rest_status.SelectedValuePath, price.ToString()));
            monitor.basket.Items.Refresh();
            monitor.result.Content = (double.Parse(monitor.result.Content.ToString()) + price).ToString();
        }

        private void Cameras_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Добавить в корзину?",null,MessageBoxButton.YesNo,MessageBoxImage.Question);
            if(result == MessageBoxResult.Yes)
            {
                var camera = Cameras.SelectedItem as PhotoCamera;
                monitor.products.Add(new Product(camera.Name, "1", camera.Prise.ToString()));
                monitor.basket.Items.Refresh();
                monitor.result.Content = (double.Parse(monitor.result.Content.ToString()) + camera.Prise).ToString();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            PhotographerData editUser = new PhotographerData(monitor);
            editUser.Show();
        }
    }
}
