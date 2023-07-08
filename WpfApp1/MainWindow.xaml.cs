using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        internal ObservableCollection<Photo> pictureList = new ObservableCollection<Photo>() 
        {
            new Photo("C:\\Users\\Elgun\\Source\\Repos\\PhotoShop\\WpfApp1\\Pictures\\child-2715429_640.webp"),
            new Photo("C:\\Users\\Elgun\\Source\\Repos\\PhotoShop\\WpfApp1\\Pictures\\elephant-1598359_640.webp" ),
            new Photo("C:\\Users\\Elgun\\source\\Repos\\PhotoShop\\WpfApp1\\Pictures\\rat-152162_640.webp"),
            new Photo("C:\\Users\\Elgun\\source\\Repos\\PhotoShop\\WpfApp1\\Pictures\\th.jpg")
        };
        public MainWindow()
        {
            InitializeComponent();
            Pictures.ItemsSource= pictureList;
        }

        private void Image_Click(object sender, RoutedEventArgs e)
        {
            Button Image = sender as Button;
            Image image = Image.Content as Image;
            BitmapImage bitmapImage = new BitmapImage(new Uri(image.Source.ToString(), UriKind.RelativeOrAbsolute));
            
            Gallery gallery = new Gallery();
            Image gImage = (Image)gallery.FindName("Current");
            gImage.Source= bitmapImage;
            gallery.ShowDialog();
        }
    }
}
