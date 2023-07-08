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
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Application;
using System.Threading;
using System.Windows.Threading;
using System.Timers;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Gallery.xaml
    /// </summary>
    public partial class Gallery : Window
    {

        int current_index = 0;
        MainWindow mainWindow = Application.Current.MainWindow as MainWindow;

        public Gallery()
        {
            InitializeComponent();
        }

        private void Forwward_Click(object sender, RoutedEventArgs e)
        {

            if (current_index < mainWindow.pictureList.Count - 1)
            {
                current_index++;
                BitmapImage bitmapImage = new BitmapImage(new Uri(mainWindow.pictureList[current_index].Image, UriKind.RelativeOrAbsolute));
                Current.Source = bitmapImage;
            }
            else
            {
                current_index = 0;
                BitmapImage bitmapImage = new BitmapImage(new Uri(mainWindow.pictureList[current_index].Image, UriKind.RelativeOrAbsolute));
                Current.Source = bitmapImage;
            }

        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            if (current_index > 0)
            {
                current_index--;
                BitmapImage bitmapImage = new BitmapImage(new Uri(mainWindow.pictureList[current_index].Image, UriKind.RelativeOrAbsolute));
                Current.Source = bitmapImage;
            }
            else 
            {
                current_index = mainWindow.pictureList.Count - 1;
                BitmapImage bitmapImage = new BitmapImage(new Uri(mainWindow.pictureList[current_index].Image, UriKind.RelativeOrAbsolute));
                Current.Source = bitmapImage;
            }
        }
    }
}
