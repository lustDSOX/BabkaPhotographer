﻿using System;
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
using WpfApp1.Pages;

namespace WpfApp1.Frames
{
    /// <summary>
    /// Логика взаимодействия для Monitor.xaml
    /// </summary>
    public partial class Monitor : Page
    {
        ApplicationContext db;
        public Monitor()
        {
            InitializeComponent();
            db = new ApplicationContext();
        }
        private void OpenSettings(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new UsersSettings(db));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddService(db));
        }
    }
}
