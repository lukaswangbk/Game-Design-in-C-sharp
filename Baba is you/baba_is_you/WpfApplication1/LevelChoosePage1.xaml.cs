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

namespace WpfApplication1
{
    /// <summary>
    /// Page2.xaml 的交互逻辑
    /// </summary>
    public partial class LevelChoosePage1 : Page
    {
        public LevelChoosePage1()
        {
            InitializeComponent();
        }

        private void BackHome(object sender, RoutedEventArgs e)
        {
            if (NavigationService != null)
            {
                NavigationService.Navigate(new Uri("HomePage.xaml", UriKind.Relative));
            }
        }

        private void CloseWindow(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Do you really want to quit?", "Quit Game",
            MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }

        private void ResetGame(object sender, RoutedEventArgs e)
        {
            // Do nothing.
        }

        private void PreviousLevel(object sender, RoutedEventArgs e)
        {
            // Do nothing.
        }

        private void NextLevel(object sender, RoutedEventArgs e)
        {
            if (NavigationService != null)
            {
                NavigationService.Navigate(new Uri("LevelChoosePage2.xaml", UriKind.Relative));
            }
        }

        private void PlayLevel(object sender, RoutedEventArgs e)
        {
            if (NavigationService != null)
            {
                NavigationService.Navigate(new Uri("GameLevel1Page.xaml", UriKind.Relative));
            }
        }
    }
}
