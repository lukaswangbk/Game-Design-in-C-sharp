using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Timers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfApplication1
{
    /// <summary>
    /// GamePage.xaml 的交互逻辑
    /// </summary>
    public partial class GamePage : Page
    {
        // Timer
        DispatcherTimer disTimer;
        private int countSecond = 600;

        // Loading Words
        private List<string> words = new List<string>();
        private string input = string.Empty;
        Random r;
        private int score = 0;
        private int currentHealth = 10;
        
        private StreamReader freader = new StreamReader(@"..\..\MySource\text.txt");
        private string line = string.Empty;

        MediaPlayer mediaPlayer = new MediaPlayer();

        public GamePage()
        {
            InitializeComponent();

            r = new Random();

            //words.Add("hello");
            //words.Add("world");
            //words.Add("nice");

            while ((line = freader.ReadLine()) != null && line != "")
            {
                words.Add(line);
            }

            Timer.Content = "Duration: ";
            Health.Content = "Health: " + currentHealth.ToString();
            Score.Content = "Score: 0";

            if (disTimer == null)
            {
                disTimer = new DispatcherTimer();
                disTimer.Interval = TimeSpan.FromSeconds(0.1);
                disTimer.Tick += disTimer_Tick;
                disTimer.Start();
            }
        }

        void disTimer_Tick(object sender, EventArgs e)
        {
            // Timer
            if (Timer.Dispatcher.CheckAccess())
            {
                Timer.Content = "Duration: " + (countSecond / 10).ToString();
            }
            else
            {
                Timer.Dispatcher.BeginInvoke(DispatcherPriority.Normal, (Action)(() => {
                    Timer.Content = "Duration: "+ (countSecond / 10).ToString();
                }));
            }
            countSecond--;
            
            // Falling Words 
            if (r.Next(10)>8 && words.Count>0 && currentHealth != 0 && GameGrid.Children.Count < 10)
            {
                Label show = new Label();
                show.FontSize = 14;

                int p = r.Next(words.Count);
                show.Content = words[p].ToString();
                words.RemoveAt(p);
                GameGrid.Children.Add(show);
                show.Margin = new Thickness(r.Next(0,(int)GameGrid.Width - 100), 0, r.Next(0, (int)GameGrid.Width - 100), 0);
                show.Tag = r.Next(3) + 3;
                show.Foreground = Brushes.White;
            }

            List<int> parm = new List<int>();
            parm.Add(score);
            parm.Add(currentHealth);

            if (currentHealth == 0)
            {
                if (NavigationService != null)
                {
                    MessageBox.Show("Score: " + score + "\n Health: " + currentHealth);
                    NavigationService.Navigate(new Uri("FailPage.xaml", UriKind.Relative), parm);
                }
            }

            else if (words.Count != 0 && countSecond / 10 == 0)
            {
                if (NavigationService != null)
                {
                    MessageBox.Show("Score: " + score + "\n Health: " + currentHealth);
                    NavigationService.Navigate(new Uri("FailPage.xaml", UriKind.Relative), parm);
                }
            }

            else if (words.Count == 0 && (GameGrid.Children.Count == 0))
            {
                if (NavigationService != null)
                {
                    MessageBox.Show("Score: " + score + "\n Health: " + currentHealth);
                    NavigationService.Navigate(new Uri("CongratulationPage.xaml", UriKind.Relative), parm);
                }
            }

            foreach (Label show in GameGrid.Children)
            {
                Label s = show;
                int speed = (int)s.Tag;
                double top = s.Margin.Top;
                double left = s.Margin.Left;
                top += speed;

                if (top > GameGrid.Height)
                {
                    score -= speed;
                    Score.Content = "Score: " + score.ToString();

                    currentHealth -= 1;
                    Health.Content = "Health: " + currentHealth.ToString();

                    GameGrid.Children.Remove(s);
                    break;
                }
                else
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (input[i] == s.Content.ToString()[i])
                        {
                            
                            show.Foreground = new SolidColorBrush(Colors.Red);
                        }
                        else
                        {
                            show.Foreground = new SolidColorBrush(Colors.White);
                            break;
                        }
                    }

                    if (input == s.Content.ToString())
                    {
                        score += speed;
                        Score.Content = "Score: " + score.ToString();
                        TextBox.Text = "";

                        GameGrid.Children.Remove(s);
                        break;
                    }

                    s.Margin = new Thickness(left, top, 0, 0);
                }
            }
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("WelcomePage.xaml", UriKind.Relative));
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            input = TextBox.Text;
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text == "Type Here!!! Only accept English charactors!!!")
                TextBox.Text = "";
        }
    }
}
