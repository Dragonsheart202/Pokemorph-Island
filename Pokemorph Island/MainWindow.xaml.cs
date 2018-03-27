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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pokemorph_Island
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int cover = 0;

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new NavigationViewModel();
            //FullScreen.Content = new MainInterface();
        }

        private void Image_Source(object sender, RoutedEventArgs e)
        {
            if (cover == 1)
                System.Diagnostics.Process.Start("https://e621.net/post/show/1448494/2018-3-3_eyes-abdominal_bulge-anthro-black_fur-bla");
            if (cover == 2)
                System.Diagnostics.Process.Start("https://e621.net/post/show/611206/2015-anthro-anthrofied-areola-blush-breasts-elpatr");
        }
        private void Change_Image_UP(object sender, RoutedEventArgs e)
        {
            cover = cover + 1;
            if (cover > 2)
                cover = 0;
            if (cover == 0)
            {
                this.Background = new ImageBrush(new BitmapImage(new Uri(@"pack://application:,,,/Pokemorph Island;component/images/cover0.jpg", UriKind.Absolute)));
            }
            else if (cover == 1)
            {
                this.Background = new ImageBrush(new BitmapImage(new Uri(@"pack://application:,,,/Pokemorph Island;component/images/cover1.jpg", UriKind.Absolute)));
            }
            else if (cover == 2)
            {
                this.Background = new ImageBrush(new BitmapImage(new Uri(@"pack://application:,,,/Pokemorph Island;component/images/cover2.png", UriKind.Absolute)));
            }
        }
        private void Change_Image_Down(object sender, RoutedEventArgs e)
        {
            cover = cover - 1;
            if (cover < 0)
                cover = 2;
            if (cover == 0)
            {
                this.Background = new ImageBrush(new BitmapImage(new Uri(@"pack://application:,,,/Pokemorph Island;component/images/cover0.jpg", UriKind.Absolute)));
            }
            else if (cover == 1)
            {
                this.Background = new ImageBrush(new BitmapImage(new Uri(@"pack://application:,,,/Pokemorph Island;component/images/cover1.jpg", UriKind.Absolute)));
            }
            else if (cover == 2)
            {
                this.Background = new ImageBrush(new BitmapImage(new Uri(@"pack://application:,,,/Pokemorph Island;component/images/cover2.png", UriKind.Absolute)));
            }
        }
        private void Patreon_Link(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.patreon.com/user?u=3253293");
        }
    }
}
