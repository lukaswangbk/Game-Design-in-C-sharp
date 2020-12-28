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
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Threading;
using System.Windows.Media.Animation;
namespace WpfApplication1
{
    /// <summary>
    /// Page1.xaml 的交互逻辑
    /// </summary>
    public partial class HomePage : Page
    {
        private bool textBoxModeEnabled = false;

        public HomePage()
        {
            InitializeComponent();

            jumpAnimation(PlayerIcon1, 15, 2.0);
            jumpAnimation(PlayerIcon2, 15, 1.5);
            jumpAnimation(PlayerIcon3, 15, 1.8);
        }
        //EnableTextBoxMode
        private void jumpAnimation(Image target, double newY, double duration)
        {
            Vector offset = VisualTreeHelper.GetOffset(target);
            var top = offset.X;

            TranslateTransform translateTransform = new TranslateTransform();
            target.RenderTransform = translateTransform;

            DoubleAnimation animate = new DoubleAnimation(0, newY - top, TimeSpan.FromSeconds(duration));

            BounceEase bounce = new BounceEase();
            bounce.EasingMode = EasingMode.EaseOut;

            animate.EasingFunction = bounce;
            animate.AutoReverse = true;
            animate.RepeatBehavior = RepeatBehavior.Forever;

            translateTransform.BeginAnimation(TranslateTransform.YProperty, animate);
        }

        private void EnableTextBoxMode(object sender, RoutedEventArgs e)
        {
            ModeLabel.Content = "TEXTBOX MODE";

            Uri resourceUri = new Uri(@"../../MySource/darkmode.png", UriKind.Relative);
            StreamResourceInfo streamResourceInfo = Application.GetResourceStream(resourceUri);
            BitmapFrame bitmapFrame = BitmapFrame.Create(streamResourceInfo.Stream);
            ImageBrush imageBrush = new ImageBrush();
            imageBrush.ImageSource = bitmapFrame;
            ModeToggleBtn.Background = imageBrush;

            textBoxModeEnabled = true;
        }

        private void DisableTextBoxMode(object sender, RoutedEventArgs e)
        {
            ModeLabel.Content = "NORMAL MODE";

            Uri resourceUri = new Uri(@"../../MySource/lightmode.png", UriKind.Relative);
            StreamResourceInfo streamResourceInfo = Application.GetResourceStream(resourceUri);
            BitmapFrame bitmapFrame = BitmapFrame.Create(streamResourceInfo.Stream);
            ImageBrush imageBrush = new ImageBrush();
            imageBrush.ImageSource = bitmapFrame;
            ModeToggleBtn.Background = imageBrush;

            textBoxModeEnabled = false;
        }

        private void StartGame(object sender, RoutedEventArgs e)
        {
            if (!textBoxModeEnabled)
                NavigationService.Navigate(new Uri("LevelChoosePage1.xaml", UriKind.Relative));
            else
                NavigationService.Navigate(new Uri("TextBoxGamePage.xaml", UriKind.Relative));
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
