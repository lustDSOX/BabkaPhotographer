using System.Linq;
using System.Windows;
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (db.Users.FirstOrDefault(x => x.Login == login.Text && x.Passowd == password.Password.ToString()) != null)
            {
                VoidWindow monitor = new VoidWindow();
                this.Close();
                monitor.Show();
            }
        }
    }
}
