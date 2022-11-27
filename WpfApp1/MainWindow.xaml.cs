using System.Linq;
using System.Windows;
using System.Windows.Input;
using WpfApp1.DataBaseClasses;

namespace WpfApp1
{

    public partial class MainWindow : Window
    {
        ApplicationContext db;
        public MainWindow()
        {
            InitializeComponent();
            db = new DataBaseClasses.ApplicationContext();
        }

        private void Button_Enter(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Check();
            }

        }

        void Check()
        {
            User user = db.Users.FirstOrDefault(x => x.Login == login.Text && x.Password == password.Password.ToString());
            if (user != null)
            {
                bool admin = false;
                if(user.RoleId == 1)
                {
                    admin = true;
                }
                VoidWindow monitor = new VoidWindow(admin);
                this.Close();
                monitor.Show();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Check();
        }
    }
}
