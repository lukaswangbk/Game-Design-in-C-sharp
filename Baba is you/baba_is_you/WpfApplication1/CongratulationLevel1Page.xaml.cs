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
    /// Page1.xaml 的交互逻辑
    /// </summary>
    public partial class CongratulationLevel1Page : Page
    {
        public CongratulationLevel1Page()
        {
            InitializeComponent();
        }

        private void ContinueOrRestart(object sender, RoutedEventArgs e)
        {
            if (NavigationService != null)
            {
                NavigationService.Navigate(new Uri("GameLevel2Page.xaml", UriKind.Relative));
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
    }
}
