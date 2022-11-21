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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для UsersSettings.xaml
    /// </summary>
    public partial class UsersSettings : Page
    {
        ApplicationContext db;
        public UsersSettings(ApplicationContext context)
        {
            InitializeComponent();
            db = context;
            UpdateList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.GoBack();
        }

        private void StackPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var user = profiles.SelectedItem as User;
            EditUser editUser = new EditUser(user.Login, user.Password, user.RoleId, user.Id, this);
            editUser.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            EditUser editUser = new EditUser("", "", 1, -1, this);
            editUser.Show();
        }
        public void UpdateList()
        {
            List<User> users = db.Users.ToList();
            foreach (var item in users)
            {
                item.Role = db.Roles.Find(item.RoleId);
            }
            profiles.ItemsSource = users;
        }
    }
}
