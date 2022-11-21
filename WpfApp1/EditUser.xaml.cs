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
using System.Windows.Shapes;
using WpfApp1.DataBaseClasses;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для EditUser.xaml
    /// </summary>
    public partial class EditUser : Window
    {
        ApplicationContext db;
        int id;
        UsersSettings Settings;
        public EditUser(string login, string password,int role, int id,UsersSettings settings)
        {
            InitializeComponent();
            db = new ApplicationContext();
            Settings = settings;
            this.login.Text = login;
            this.password.Text = password;
            List<Role> roles = db.Roles.ToList();
            this.role.ItemsSource = roles;
            this.role.SelectedItem = roles.Find(x=>x.Id == role);
            this.id = id;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Update();
        }

        private void login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) Update();
        }

        void Update()
        {
            if(id != -1)
            {
                User user = db.Users.Find(id);
                if (user != null)
                {
                    user.Login = login.Text;
                    user.Password = password.Text;
                    user.Role = db.Roles.Find(((Role)role.SelectedItem).Id);
                    db.SaveChanges();
                    Settings.UpdateList();
                }
            }
            else
            {
                User user = new User(login.Text, password.Text, db.Roles.Find(((Role)role.SelectedItem).Id));
                db.Users.Add(user);
                db.SaveChanges();
                Settings.UpdateList();
            }
            
        }
    }
}