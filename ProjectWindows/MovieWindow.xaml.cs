using CinemaProject.BuisnessLogic;
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
    /// Interaction logic for MovieWindow.xaml
    /// </summary>
    public partial class MovieWindow : Window
    {
        public MovieWindow()
        {
            InitializeComponent();
        }

        private void Order_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void ChoseSit_Click(object sender, RoutedEventArgs e)
        {
            ChoseSitWindow window = new ChoseSitWindow();
            this.Close();
            window.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MovieName.Content = UserControler.Film.Name;
            MoviePic.Source = (ImageSource)new ImageSourceConverter().ConvertFrom(UserControler.Film.ImageURL);
            RatingLb.Content = UserControler.Film.Rating;
        }
    }
}
