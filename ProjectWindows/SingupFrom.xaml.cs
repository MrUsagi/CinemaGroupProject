using CinemaProject.BuisnessLogic;
using Microsoft.Extensions.DependencyInjection;
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

namespace CinemaProject.ProjectWindows
{
    /// <summary>
    /// Interaction logic for SingupFrom.xaml
    /// </summary>
    public partial class SingupFrom : Window
    {
        private readonly RegisterService _service;
        public SingupFrom(RegisterService service)
        {
            InitializeComponent();
            _service = service;
        }

        private async void SingUp_Click(object sender, RoutedEventArgs e)
        {
            if (await _service.RegisterUser(LoginTb.Text, PasswordTb.Text, EmailTb.Text))
            {
                MessageBox.Show("Registration complete!");
                this.Close();
            }
            else
                MessageBox.Show("You have some troubles. Try Again");
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var window = App.ServiceProvider.GetRequiredService<LoginWindow>();
            window.Show();
        }
    }
}
