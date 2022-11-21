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
            if (db.Users.FirstOrDefault(x => x.Login == login.Text && x.Password == password.Password.ToString()) != null)
            {
                VoidWindow monitor = new VoidWindow();
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
