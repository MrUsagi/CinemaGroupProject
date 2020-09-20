
using CinemaProject.BuisnessLogic;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CinemaProject.ProjectWindows
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private readonly LoginService _service;
        public LoginWindow(LoginService service)
        {
            InitializeComponent();
            _service = service;
        }

        private async void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            if(await _service.Login(Login.Text, Password.Password))
            {
                MainWindow window = App.ServiceProvider.GetRequiredService<MainWindow>();
                this.Close();
                window.Show();
            }
            else
            {
                MessageBox.Show("Invalid login or password!");
            }
        }

        private void SingUpBtn_Click(object sender, RoutedEventArgs e)
        {
            SingupFrom window = App.ServiceProvider.GetRequiredService<SingupFrom>();
            this.Close();
            window.Show();
        }
    }
}
