using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;


namespace WpfApplication1
{
    /// <summary>
    /// Page4.xaml 的交互逻辑
    /// </summary>
    public partial class GameLevel2Page : Page
    {
        public GameLevel2Page()
        {
            InitializeComponent();
            FocusManager.SetFocusedElement(this, Genius);
        }
        string person = "Genius";
        string person_position = "aa";
        string[] is_ = { "is1", "is2", "is3" };
        string[] is_position = { "i1", "i2", "i3" };
        string flag_ = "flag";
        string flag_position = "fl";
        string baba_ = "baba";
        string baba_position = "b";
        string you_ = "you";
        string you_position = "y1";
        string wall_ = "wall";
        string wall_position = "wa";
        string stop_ = "stop";
        string stop_position = "s";
        string win_ = "win";
        string win_position = "wi";
        string[] box = new string[] { "is1", "is2", "is3", "baba", "you", "flag", "win", "wall", "stop" };
        string[] box_position = new string[] { "i1", "i2", "i3", "b", "y1", "fl", "wi", "wa", "s" };
        string aim;
        string aim_position;
        string stone;
        string stone_position;
        bool ISWIN = new bool();
        bool[] Z = new bool[1];
        List<positiondata> Saving = new List<positiondata>();

        public struct my_positon
        {
            public double x;
            public double y;
        }

        public class positiondata
        {
            public my_positon person;
            public List<my_positon> save_box = new List<my_positon>();
        }

        bool CheckWin()
        {
            if (ISWIN == false)
                return false;
            if (NavigationService != null)
            {
                NavigationService.Navigate(new Uri("CongratulationLevel2Page.xaml", UriKind.Relative));
            }
            return true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("LevelChoosePage2.xaml", UriKind.Relative));
        }

        private void Genius_KeyDown(object sender, KeyEventArgs e)
        {
            if (CheckHero() == "wall")
            {
                person = "wall_1";
                person_position = "w1";
                FocusManager.SetFocusedElement(this, wall_1);
            }
            else if (CheckHero() == "flag")
            {
                person = "flag_pic";
                person_position = "f";
                FocusManager.SetFocusedElement(this, flag_pic);
            }
            else if (CheckHero() == "baba")
            {
                person = "Genius";
                person_position = "aa";
                FocusManager.SetFocusedElement(this, Genius);
            }
            else
            {
                if (CheckHero() == "nothing" && CheckHero() != "wall")
                {
                    NavigationService.Navigate(new Uri("FailPage.xaml", UriKind.Relative));
                }
                person = "";
                person_position = "";
                FocusManager.SetFocusedElement(this, null);
            }

            if (CheckStop() == "wall")
            {
                if (CheckFlag() == "wall")
                {
                    aim = "wall_1";
                    aim_position = "w1";


                    if (Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up))
                    {
                        save();
                        BitmapImage imagetemp = new BitmapImage(new Uri(@"MySource/正向移动.png", UriKind.Relative));
                        this.Genius.Source = imagetemp;
                        if (!CheckStone(this.Genius, this.aa, 0, 25) && CheckBound(this.Genius, this.aa, 0, 25) && !CheckBox(this.Genius, this.aa, 0, 25))
                        {
                            NPCMove(this.aa, 0, 25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Down))
                    {
                        save();
                        BitmapImage imagetemp = new BitmapImage(new Uri(@"MySource/背向移动.png", UriKind.Relative));
                        this.Genius.Source = imagetemp;
                        if (!CheckStone(this.Genius, this.aa, 0, -25) && CheckBound(this.Genius, this.aa, 0, -25) && !CheckBox(this.Genius, this.aa, 0, -25))
                        {
                            NPCMove(this.aa, 0, -25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Right))
                    {
                        save();
                        BitmapImage imagetemp = new BitmapImage(new Uri(@"MySource/左向移动.png", UriKind.Relative));
                        this.Genius.Source = imagetemp;
                        if (!CheckStone(this.Genius, this.aa, -25, 0) && CheckBound(this.Genius, this.aa, -25, 0) && !CheckBox(this.Genius, this.aa, -25, 0))
                        {
                            NPCMove(this.aa, -25, 0);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left))
                    {
                        save();
                        BitmapImage imagetemp = new BitmapImage(new Uri(@"MySource/右向移动.png", UriKind.Relative));
                        this.Genius.Source = imagetemp;
                        if (!CheckStone(this.Genius, this.aa, 25, 0) && CheckBound(this.Genius, this.aa, 25, 0) && !CheckBox(this.Genius, this.aa, 25, 0))
                        {
                            NPCMove(this.aa, 25, 0);
                        }
                    }
                }
                else if (CheckFlag() == "baba")
                {
                    NavigationService.Navigate(new Uri("CongratulationLevel2Page.xaml", UriKind.Relative));
                }
                else if (CheckFlag() == "flag")
                {
                    aim = "flag_pic";
                    aim_position = "f";

                    if (Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up))
                    {
                        save();
                        BitmapImage imagetemp = new BitmapImage(new Uri(@"MySource/正向移动.png", UriKind.Relative));
                        this.Genius.Source = imagetemp;
                        if (!CheckStone(this.Genius, this.aa, 0, 25) && CheckBound(this.Genius, this.aa, 0, 25) && !CheckBox(this.Genius, this.aa, 0, 25))
                        {
                            NPCMove(this.aa, 0, 25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Down))
                    {
                        save();
                        BitmapImage imagetemp = new BitmapImage(new Uri(@"MySource/背向移动.png", UriKind.Relative));
                        this.Genius.Source = imagetemp;
                        if (!CheckStone(this.Genius, this.aa, 0, -25) && CheckBound(this.Genius, this.aa, 0, -25) && !CheckBox(this.Genius, this.aa, 0, -25))
                        {
                            NPCMove(this.aa, 0, -25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Right))
                    {
                        save();
                        BitmapImage imagetemp = new BitmapImage(new Uri(@"MySource/左向移动.png", UriKind.Relative));
                        this.Genius.Source = imagetemp;
                        if (!CheckStone(this.Genius, this.aa, -25, 0) && CheckBound(this.Genius, this.aa, -25, 0) && !CheckBox(this.Genius, this.aa, -25, 0))
                        {
                            NPCMove(this.aa, -25, 0);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left))
                    {
                        save();
                        BitmapImage imagetemp = new BitmapImage(new Uri(@"MySource/右向移动.png", UriKind.Relative));
                        this.Genius.Source = imagetemp;
                        if (!CheckStone(this.Genius, this.aa, 25, 0) && CheckBound(this.Genius, this.aa, 25, 0) && !CheckBox(this.Genius, this.aa, 25, 0))
                        {
                            NPCMove(this.aa, 25, 0);
                        }
                    }
                }
                else
                {
                    aim = "";
                    aim_position = "";

                    if (Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up))
                    {
                        save();
                        BitmapImage imagetemp = new BitmapImage(new Uri(@"MySource/正向移动.png", UriKind.Relative));
                        this.Genius.Source = imagetemp;
                        if (!CheckStone(this.Genius, this.aa, 0, 25) && CheckBound(this.Genius, this.aa, 0, 25) && !CheckBox(this.Genius, this.aa, 0, 25))
                        {
                            NPCMove(this.aa, 0, 25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Down))
                    {
                        save();
                        BitmapImage imagetemp = new BitmapImage(new Uri(@"MySource/背向移动.png", UriKind.Relative));
                        this.Genius.Source = imagetemp;
                        if (!CheckStone(this.Genius, this.aa, 0, -25) && CheckBound(this.Genius, this.aa, 0, -25) && !CheckBox(this.Genius, this.aa, 0, -25))
                        {
                            NPCMove(this.aa, 0, -25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Right))
                    {
                        save();
                        BitmapImage imagetemp = new BitmapImage(new Uri(@"MySource/左向移动.png", UriKind.Relative));
                        this.Genius.Source = imagetemp;
                        if (!CheckStone(this.Genius, this.aa, -25, 0) && CheckBound(this.Genius, this.aa, -25, 0) && !CheckBox(this.Genius, this.aa, -25, 0))
                        {
                            NPCMove(this.aa, -25, 0);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left))
                    {
                        save();
                        BitmapImage imagetemp = new BitmapImage(new Uri(@"MySource/右向移动.png", UriKind.Relative));
                        this.Genius.Source = imagetemp;
                        if (!CheckStone(this.Genius, this.aa, 25, 0) && CheckBound(this.Genius, this.aa, 25, 0) && !CheckBox(this.Genius, this.aa, 25, 0))
                        {
                            NPCMove(this.aa, 25, 0);
                        }
                    }
                }
            }
            else if (CheckStop() == "baba")
            {
                if (CheckFlag() == "wall")
                {
                    aim = "wall_1";
                    aim_position = "w1";

                    if (Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up))
                    {
                        save();
                        BitmapImage imagetemp = new BitmapImage(new Uri(@"MySource/正向移动.png", UriKind.Relative));
                        this.Genius.Source = imagetemp;
                        if (!CheckStone(this.Genius, this.aa, 0, 25) && CheckBound(this.Genius, this.aa, 0, 25) && !CheckBox(this.Genius, this.aa, 0, 25))
                        {
                            NPCMove(this.aa, 0, 25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Down))
                    {
                        save();
                        BitmapImage imagetemp = new BitmapImage(new Uri(@"MySource/背向移动.png", UriKind.Relative));
                        this.Genius.Source = imagetemp;
                        if (!CheckStone(this.Genius, this.aa, 0, -25) && CheckBound(this.Genius, this.aa, 0, -25) && !CheckBox(this.Genius, this.aa, 0, -25))
                        {
                            NPCMove(this.aa, 0, -25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Right))
                    {
                        save();
                        BitmapImage imagetemp = new BitmapImage(new Uri(@"MySource/左向移动.png", UriKind.Relative));
                        this.Genius.Source = imagetemp;
                        if (!CheckStone(this.Genius, this.aa, -25, 0) && CheckBound(this.Genius, this.aa, -25, 0) && !CheckBox(this.Genius, this.aa, -25, 0))
                        {
                            NPCMove(this.aa, -25, 0);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left))
                    {
                        save();
                        BitmapImage imagetemp = new BitmapImage(new Uri(@"MySource/右向移动.png", UriKind.Relative));
                        this.Genius.Source = imagetemp;
                        if (!CheckStone(this.Genius, this.aa, 25, 0) && CheckBound(this.Genius, this.aa, 25, 0) && !CheckBox(this.Genius, this.aa, 25, 0))
                        {
                            NPCMove(this.aa, 25, 0);
                        }
                    }
                }
                else if (CheckFlag() == "baba")
                {
                    NavigationService.Navigate(new Uri("CongratulationLevel2Page.xaml", UriKind.Relative));
                }
                else if (CheckFlag() == "flag")
                {
                    aim = "flag_pic";
                    aim_position = "f";

                    if (Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up))
                    {
                        save();
                        BitmapImage imagetemp = new BitmapImage(new Uri(@"MySource/正向移动.png", UriKind.Relative));
                        this.Genius.Source = imagetemp;
                        if (!CheckStone(this.Genius, this.aa, 0, 25) && CheckBound(this.Genius, this.aa, 0, 25) && !CheckBox(this.Genius, this.aa, 0, 25))
                        {
                            NPCMove(this.aa, 0, 25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Down))
                    {
                        save();
                        BitmapImage imagetemp = new BitmapImage(new Uri(@"MySource/背向移动.png", UriKind.Relative));
                        this.Genius.Source = imagetemp;
                        if (!CheckStone(this.Genius, this.aa, 0, -25) && CheckBound(this.Genius, this.aa, 0, -25) && !CheckBox(this.Genius, this.aa, 0, -25))
                        {
                            NPCMove(this.aa, 0, -25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Right))
                    {
                        save();
                        BitmapImage imagetemp = new BitmapImage(new Uri(@"MySource/左向移动.png", UriKind.Relative));
                        this.Genius.Source = imagetemp;
                        if (!CheckStone(this.Genius, this.aa, -25, 0) && CheckBound(this.Genius, this.aa, -25, 0) && !CheckBox(this.Genius, this.aa, -25, 0))
                        {
                            NPCMove(this.aa, -25, 0);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left))
                    {
                        save();
                        BitmapImage imagetemp = new BitmapImage(new Uri(@"MySource/右向移动.png", UriKind.Relative));
                        this.Genius.Source = imagetemp;
                        if (!CheckStone(this.Genius, this.aa, 25, 0) && CheckBound(this.Genius, this.aa, 25, 0) && !CheckBox(this.Genius, this.aa, 25, 0))
                        {
                            NPCMove(this.aa, 25, 0);
                        }
                    }
                }
                else
                {
                    aim = "";
                    aim_position = "";

                    if (Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up))
                    {
                        save();
                        BitmapImage imagetemp = new BitmapImage(new Uri(@"MySource/正向移动.png", UriKind.Relative));
                        this.Genius.Source = imagetemp;
                        if (!CheckStone(this.Genius, this.aa, 0, 25) && CheckBound(this.Genius, this.aa, 0, 25) && !CheckBox(this.Genius, this.aa, 0, 25))
                        {
                            NPCMove(this.aa, 0, 25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Down))
                    {
                        save();
                        BitmapImage imagetemp = new BitmapImage(new Uri(@"MySource/背向移动.png", UriKind.Relative));
                        this.Genius.Source = imagetemp;
                        if (!CheckStone(this.Genius, this.aa, 0, -25) && CheckBound(this.Genius, this.aa, 0, -25) && !CheckBox(this.Genius, this.aa, 0, -25))
                        {
                            NPCMove(this.aa, 0, -25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Right))
                    {
                        save();
                        BitmapImage imagetemp = new BitmapImage(new Uri(@"MySource/左向移动.png", UriKind.Relative));
                        this.Genius.Source = imagetemp;
                        if (!CheckStone(this.Genius, this.aa, -25, 0) && CheckBound(this.Genius, this.aa, -25, 0) && !CheckBox(this.Genius, this.aa, -25, 0))
                        {
                            NPCMove(this.aa, -25, 0);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left))
                    {
                        save();
                        BitmapImage imagetemp = new BitmapImage(new Uri(@"MySource/右向移动.png", UriKind.Relative));
                        this.Genius.Source = imagetemp;
                        if (!CheckStone(this.Genius, this.aa, 25, 0) && CheckBound(this.Genius, this.aa, 25, 0) && !CheckBox(this.Genius, this.aa, 25, 0))
                        {
                            NPCMove(this.aa, 25, 0);
                        }
                    }
                }
            }
            else if (CheckStop() == "flag")
            {
                if (CheckFlag() == "wall")
                {
                    aim = "wall_1";
                    aim_position = "w1";

                    if (Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up))
                    {
                        save();
                        BitmapImage imagetemp = new BitmapImage(new Uri(@"MySource/正向移动.png", UriKind.Relative));
                        this.Genius.Source = imagetemp;
                        if (!CheckStone(this.Genius, this.aa, 0, 25) && CheckBound(this.Genius, this.aa, 0, 25) && !CheckBox(this.Genius, this.aa, 0, 25))
                        {
                            NPCMove(this.aa, 0, 25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Down))
                    {
                        save();
                        BitmapImage imagetemp = new BitmapImage(new Uri(@"MySource/背向移动.png", UriKind.Relative));
                        this.Genius.Source = imagetemp;
                        if (!CheckStone(this.Genius, this.aa, 0, -25) && CheckBound(this.Genius, this.aa, 0, -25) && !CheckBox(this.Genius, this.aa, 0, -25))
                        {
                            NPCMove(this.aa, 0, -25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Right))
                    {
                        save();
                        BitmapImage imagetemp = new BitmapImage(new Uri(@"MySource/左向移动.png", UriKind.Relative));
                        this.Genius.Source = imagetemp;
                        if (!CheckStone(this.Genius, this.aa, -25, 0) && CheckBound(this.Genius, this.aa, -25, 0) && !CheckBox(this.Genius, this.aa, -25, 0))
                        {
                            NPCMove(this.aa, -25, 0);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left))
                    {
                        save();
                        BitmapImage imagetemp = new BitmapImage(new Uri(@"MySource/右向移动.png", UriKind.Relative));
                        this.Genius.Source = imagetemp;
                        if (!CheckStone(this.Genius, this.aa, 25, 0) && CheckBound(this.Genius, this.aa, 25, 0) && !CheckBox(this.Genius, this.aa, 25, 0))
                        {
                            NPCMove(this.aa, 25, 0);
                        }
                    }
                }
                else if (CheckFlag() == "baba")
                {
                    NavigationService.Navigate(new Uri("CongratulationLevel2Page.xaml", UriKind.Relative));
                }
                else if (CheckFlag() == "flag")
                {
                    aim = "flag_pic";
                    aim_position = "f";

                    if (Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up))
                    {
                        save();
                        BitmapImage imagetemp = new BitmapImage(new Uri(@"MySource/正向移动.png", UriKind.Relative));
                        this.Genius.Source = imagetemp;
                        if (!CheckStone(this.Genius, this.aa, 0, 25) && CheckBound(this.Genius, this.aa, 0, 25) && !CheckBox(this.Genius, this.aa, 0, 25))
                        {
                            NPCMove(this.aa, 0, 25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Down))
                    {
                        save();
                        BitmapImage imagetemp = new BitmapImage(new Uri(@"MySource/背向移动.png", UriKind.Relative));
                        this.Genius.Source = imagetemp;
                        if (!CheckStone(this.Genius, this.aa, 0, -25) && CheckBound(this.Genius, this.aa, 0, -25) && !CheckBox(this.Genius, this.aa, 0, -25))
                        {
                            NPCMove(this.aa, 0, -25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Right))
                    {
                        save();
                        BitmapImage imagetemp = new BitmapImage(new Uri(@"MySource/左向移动.png", UriKind.Relative));
                        this.Genius.Source = imagetemp;
                        if (!CheckStone(this.Genius, this.aa, -25, 0) && CheckBound(this.Genius, this.aa, -25, 0) && !CheckBox(this.Genius, this.aa, -25, 0))
                        {
                            NPCMove(this.aa, -25, 0);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left))
                    {
                        save();
                        BitmapImage imagetemp = new BitmapImage(new Uri(@"MySource/右向移动.png", UriKind.Relative));
                        this.Genius.Source = imagetemp;
                        if (!CheckStone(this.Genius, this.aa, 25, 0) && CheckBound(this.Genius, this.aa, 25, 0) && !CheckBox(this.Genius, this.aa, 25, 0))
                        {
                            NPCMove(this.aa, 25, 0);
                        }
                    }
                }
                else
                {
                    aim = "";
                    aim_position = "";

                    if (Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up))
                    {
                        save();
                        BitmapImage imagetemp = new BitmapImage(new Uri(@"MySource/正向移动.png", UriKind.Relative));
                        this.Genius.Source = imagetemp;
                        if (!CheckStone(this.Genius, this.aa, 0, 25) && CheckBound(this.Genius, this.aa, 0, 25) && !CheckBox(this.Genius, this.aa, 0, 25))
                        {
                            NPCMove(this.aa, 0, 25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Down))
                    {
                        save();
                        BitmapImage imagetemp = new BitmapImage(new Uri(@"MySource/背向移动.png", UriKind.Relative));
                        this.Genius.Source = imagetemp;
                        if (!CheckStone(this.Genius, this.aa, 0, -25) && CheckBound(this.Genius, this.aa, 0, -25) && !CheckBox(this.Genius, this.aa, 0, -25))
                        {
                            NPCMove(this.aa, 0, -25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Right))
                    {
                        save();
                        BitmapImage imagetemp = new BitmapImage(new Uri(@"MySource/左向移动.png", UriKind.Relative));
                        this.Genius.Source = imagetemp;
                        if (!CheckStone(this.Genius, this.aa, -25, 0) && CheckBound(this.Genius, this.aa, -25, 0) && !CheckBox(this.Genius, this.aa, -25, 0))
                        {
                            NPCMove(this.aa, -25, 0);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left))
                    {
                        save();
                        BitmapImage imagetemp = new BitmapImage(new Uri(@"MySource/右向移动.png", UriKind.Relative));
                        this.Genius.Source = imagetemp;
                        if (!CheckStone(this.Genius, this.aa, 25, 0) && CheckBound(this.Genius, this.aa, 25, 0) && !CheckBox(this.Genius, this.aa, 25, 0))
                        {
                            NPCMove(this.aa, 25, 0);
                        }
                    }
                }
            }
            else
            {
                if (CheckFlag() == "wall")
                {
                    aim = "wall_1";
                    aim_position = "w1";

                    if (Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up))
                    {
                        save();
                        BitmapImage imagetemp = new BitmapImage(new Uri(@"MySource/正向移动.png", UriKind.Relative));
                        this.Genius.Source = imagetemp;
                        if (!CheckStone(this.Genius, this.aa, 0, 25) && CheckBound(this.Genius, this.aa, 0, 25) && !CheckBox(this.Genius, this.aa, 0, 25))
                        {
                            NPCMove(this.aa, 0, 25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Down))
                    {
                        save();
                        BitmapImage imagetemp = new BitmapImage(new Uri(@"MySource/背向移动.png", UriKind.Relative));
                        this.Genius.Source = imagetemp;
                        if (!CheckStone(this.Genius, this.aa, 0, -25) && CheckBound(this.Genius, this.aa, 0, -25) && !CheckBox(this.Genius, this.aa, 0, -25))
                        {
                            NPCMove(this.aa, 0, -25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Right))
                    {
                        save();
                        BitmapImage imagetemp = new BitmapImage(new Uri(@"MySource/左向移动.png", UriKind.Relative));
                        this.Genius.Source = imagetemp;
                        if (!CheckStone(this.Genius, this.aa, -25, 0) && CheckBound(this.Genius, this.aa, -25, 0) && !CheckBox(this.Genius, this.aa, -25, 0))
                        {
                            NPCMove(this.aa, -25, 0);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left))
                    {
                        save();
                        BitmapImage imagetemp = new BitmapImage(new Uri(@"MySource/右向移动.png", UriKind.Relative));
                        this.Genius.Source = imagetemp;
                        if (!CheckStone(this.Genius, this.aa, 25, 0) && CheckBound(this.Genius, this.aa, 25, 0) && !CheckBox(this.Genius, this.aa, 25, 0))
                        {
                            NPCMove(this.aa, 25, 0);
                        }
                    }
                }
                else if (CheckFlag() == "baba")
                {
                    NavigationService.Navigate(new Uri("CongratulationLevel2Page.xaml", UriKind.Relative));
                }
                else if (CheckFlag() == "flag")
                {
                    aim = "flag_pic";
                    aim_position = "f";

                    if (Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up))
                    {
                        save();
                        BitmapImage imagetemp = new BitmapImage(new Uri(@"MySource/正向移动.png", UriKind.Relative));
                        this.Genius.Source = imagetemp;
                        if (!CheckStone(this.Genius, this.aa, 0, 25) && CheckBound(this.Genius, this.aa, 0, 25) && !CheckBox(this.Genius, this.aa, 0, 25))
                        {
                            NPCMove(this.aa, 0, 25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Down))
                    {
                        save();
                        BitmapImage imagetemp = new BitmapImage(new Uri(@"MySource/背向移动.png", UriKind.Relative));
                        this.Genius.Source = imagetemp;
                        if (!CheckStone(this.Genius, this.aa, 0, -25) && CheckBound(this.Genius, this.aa, 0, -25) && !CheckBox(this.Genius, this.aa, 0, -25))
                        {
                            NPCMove(this.aa, 0, -25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Right))
                    {
                        save();
                        BitmapImage imagetemp = new BitmapImage(new Uri(@"MySource/左向移动.png", UriKind.Relative));
                        this.Genius.Source = imagetemp;
                        if (!CheckStone(this.Genius, this.aa, -25, 0) && CheckBound(this.Genius, this.aa, -25, 0) && !CheckBox(this.Genius, this.aa, -25, 0))
                        {
                            NPCMove(this.aa, -25, 0);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left))
                    {
                        save();
                        BitmapImage imagetemp = new BitmapImage(new Uri(@"MySource/右向移动.png", UriKind.Relative));
                        this.Genius.Source = imagetemp;
                        if (!CheckStone(this.Genius, this.aa, 25, 0) && CheckBound(this.Genius, this.aa, 25, 0) && !CheckBox(this.Genius, this.aa, 25, 0))
                        {
                            NPCMove(this.aa, 25, 0);
                        }
                    }
                }
                else
                {
                    aim = "";
                    aim_position = "";

                    if (Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up))
                    {
                        save();
                        BitmapImage imagetemp = new BitmapImage(new Uri(@"MySource/正向移动.png", UriKind.Relative));
                        this.Genius.Source = imagetemp;
                        if (!CheckStone(this.Genius, this.aa, 0, 25) && CheckBound(this.Genius, this.aa, 0, 25) && !CheckBox(this.Genius, this.aa, 0, 25))
                        {
                            NPCMove(this.aa, 0, 25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Down))
                    { 
                        save();
                        BitmapImage imagetemp = new BitmapImage(new Uri(@"MySource/背向移动.png", UriKind.Relative));
                        this.Genius.Source = imagetemp;
                        if (!CheckStone(this.Genius, this.aa, 0, -25) && CheckBound(this.Genius, this.aa, 0, -25) && !CheckBox(this.Genius, this.aa, 0, -25))
                        {
                            NPCMove(this.aa, 0, -25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Right))
                    {
                        save();
                        BitmapImage imagetemp = new BitmapImage(new Uri(@"MySource/左向移动.png", UriKind.Relative));
                        this.Genius.Source = imagetemp;
                        if (!CheckStone(this.Genius, this.aa, -25, 0) && CheckBound(this.Genius, this.aa, -25, 0) && !CheckBox(this.Genius, this.aa, -25, 0))
                        {
                            NPCMove(this.aa, -25, 0);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left))
                    {
                        save();
                        BitmapImage imagetemp = new BitmapImage(new Uri(@"MySource/右向移动.png", UriKind.Relative));
                        this.Genius.Source = imagetemp;
                        if (!CheckStone(this.Genius, this.aa, 25, 0) && CheckBound(this.Genius, this.aa, 25, 0) && !CheckBox(this.Genius, this.aa, 25, 0))
                        {
                            NPCMove(this.aa, 25, 0);
                        }
                    }
                }
            }
            if (Keyboard.IsKeyDown(Key.Z))
            {
                Z[0] = true;
                back();
            }
        }

        private void Game_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (CheckHero() == "wall")
            {
                person = "wall_1";
                person_position = "w1";
                this.wall_1.Focus();
            }
            else if (CheckHero() == "flag")
            {
                person = "flag_pic";
                person_position = "f";
                this.flag_pic.Focus();
            }
            else if (CheckHero() == "baba")
            {
                person = "Genius";
                person_position = "aa";
                this.Genius.Focus();
            }
            else
            {
                person = "";
                person_position = "";
                FocusManager.SetFocusedElement(this, null);
            }
        }

        private void Flag_KeyDown(object sender, KeyEventArgs e)
        {

            if (CheckHero() == "wall")
            {
                person = "wall_1";
                person_position = "w1";
                FocusManager.SetFocusedElement(this, wall_1);
            }
            else if (CheckHero() == "flag")
            {
                person = "flag_pic";
                person_position = "f";
                FocusManager.SetFocusedElement(this, flag_pic);
            }
            else if (CheckHero() == "baba")
            {
                person = "Genius";
                person_position = "aa";
                FocusManager.SetFocusedElement(this, Genius);
            }
            else
            {
                if (CheckHero() == "nothing" && CheckHero() != "wall")
                {
                    NavigationService.Navigate(new Uri("FailPage.xaml", UriKind.Relative));
                }
                person = "";
                person_position = "";
                FocusManager.SetFocusedElement(this, null);
            }
            
            if (CheckStop() == "wall")
            {
                if (CheckFlag() == "wall")
                {
                    aim = "wall_1";
                    aim_position = "w1";

                    if (Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up))
                    {
                        save();
                        if (!CheckStone(this.flag_pic, this.f, 0, 25) && CheckBound(this.flag_pic, this.f, 0, 25) && !CheckBox(this.flag_pic, this.f, 0, 25))
                        {
                            NPCMove(this.f, 0, 25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Down))
                    {
                        save();
                        if (!CheckStone(this.flag_pic, this.f, 0, -25) && CheckBound(this.flag_pic, this.f, 0, -25) && !CheckBox(this.flag_pic, this.f, 0, -25))
                        {
                            NPCMove(this.f, 0, -25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Right))
                    {
                        save();
                        if (!CheckStone(this.flag_pic, this.f, -25, 0) && CheckBound(this.flag_pic, this.f, -25, 0) && !CheckBox(this.flag_pic, this.f, -25, 0))
                        {
                            NPCMove(this.f, -25, 0);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left))
                    {
                        save();
                        if (!CheckStone(this.flag_pic, this.f, 25, 0) && CheckBound(this.flag_pic, this.f, 25, 0) && !CheckBox(this.flag_pic, this.f, 25, 0))
                        {
                            NPCMove(this.f, 25, 0);
                        }
                    }
                }
                else if (CheckFlag() == "baba")
                {
                    aim = "Genius";
                    aim_position = "aa";

                    if (Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up))
                    {
                        save();
                        if (!CheckStone(this.flag_pic, this.f, 0, 25) && CheckBound(this.flag_pic, this.f, 0, 25) && !CheckBox(this.flag_pic, this.f, 0, 25))
                        {
                            NPCMove(this.f, 0, 25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Down))
                    {
                        save();
                        if (!CheckStone(this.flag_pic, this.f, 0, -25) && CheckBound(this.flag_pic, this.f, 0, -25) && !CheckBox(this.flag_pic, this.f, 0, -25))
                        {
                            NPCMove(this.f, 0, -25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Right))
                    {
                        save();
                        if (!CheckStone(this.flag_pic, this.f, -25, 0) && CheckBound(this.flag_pic, this.f, -25, 0) && !CheckBox(this.flag_pic, this.f, -25, 0))
                        {
                            NPCMove(this.f, -25, 0);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left))
                    {
                        save();
                        if (!CheckStone(this.flag_pic, this.f, 25, 0) && CheckBound(this.flag_pic, this.f, 25, 0) && !CheckBox(this.flag_pic, this.f, 25, 0))
                        {
                            NPCMove(this.f, 25, 0);
                        }
                    }
                }
                else if (CheckFlag() == "flag")
                {
                    NavigationService.Navigate(new Uri("CongratulationLevel2Page.xaml", UriKind.Relative));
                }
                else
                {
                    aim = "";
                    aim_position = "";

                    if (Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up))
                    {
                        save();
                        if (!CheckStone(this.flag_pic, this.f, 0, 25) && CheckBound(this.flag_pic, this.f, 0, 25) && !CheckBox(this.flag_pic, this.f, 0, 25))
                        {
                            NPCMove(this.f, 0, 25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Down))
                    {
                        save();
                        if (!CheckStone(this.flag_pic, this.f, 0, -25) && CheckBound(this.flag_pic, this.f, 0, -25) && !CheckBox(this.flag_pic, this.f, 0, -25))
                        {
                            NPCMove(this.f, 0, -25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Right))
                    {
                        save();
                        if (!CheckStone(this.flag_pic, this.f, -25, 0) && CheckBound(this.flag_pic, this.f, -25, 0) && !CheckBox(this.flag_pic, this.f, -25, 0))
                        {
                            NPCMove(this.f, -25, 0);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left))
                    {
                        save();
                        if (!CheckStone(this.flag_pic, this.f, 25, 0) && CheckBound(this.flag_pic, this.f, 25, 0) && !CheckBox(this.flag_pic, this.f, 25, 0))
                        {
                            NPCMove(this.f, 25, 0);
                        }
                    }
                }
            }
            else if (CheckStop() == "baba")
            {
                if (CheckFlag() == "wall")
                {
                    aim = "wall_1";
                    aim_position = "w1";

                    if (Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up))
                    {
                        save();
                        if (!CheckStone(this.flag_pic, this.f, 0, 25) && CheckBound(this.flag_pic, this.f, 0, 25) && !CheckBox(this.flag_pic, this.f, 0, 25))
                        {
                            NPCMove(this.f, 0, 25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Down))
                    {
                        save();
                        if (!CheckStone(this.flag_pic, this.f, 0, -25) && CheckBound(this.flag_pic, this.f, 0, -25) && !CheckBox(this.flag_pic, this.f, 0, -25))
                        {
                            NPCMove(this.f, 0, -25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Right))
                    {
                        save();
                        if (!CheckStone(this.flag_pic, this.f, -25, 0) && CheckBound(this.flag_pic, this.f, -25, 0) && !CheckBox(this.flag_pic, this.f, -25, 0))
                        {
                            NPCMove(this.f, -25, 0);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left))
                    {
                        save();
                        if (!CheckStone(this.flag_pic, this.f, 25, 0) && CheckBound(this.flag_pic, this.f, 25, 0) && !CheckBox(this.flag_pic, this.f, 25, 0))
                        {
                            NPCMove(this.f, 25, 0);
                        }
                    }
                }
                else if (CheckFlag() == "baba")
                {
                    aim = "Genius";
                    aim_position = "aa";

                    if (Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up))
                    {
                        save();
                        if (!CheckStone(this.flag_pic, this.f, 0, 25) && CheckBound(this.flag_pic, this.f, 0, 25) && !CheckBox(this.flag_pic, this.f, 0, 25))
                        {
                            NPCMove(this.f, 0, 25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Down))
                    {
                        save();
                        if (!CheckStone(this.flag_pic, this.f, 0, -25) && CheckBound(this.flag_pic, this.f, 0, -25) && !CheckBox(this.flag_pic, this.f, 0, -25))
                        {
                            NPCMove(this.f, 0, -25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Right))
                    {
                        save();
                        if (!CheckStone(this.flag_pic, this.f, -25, 0) && CheckBound(this.flag_pic, this.f, -25, 0) && !CheckBox(this.flag_pic, this.f, -25, 0))
                        {
                            NPCMove(this.f, -25, 0);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left))
                    {
                        save();
                        if (!CheckStone(this.flag_pic, this.f, 25, 0) && CheckBound(this.flag_pic, this.f, 25, 0) && !CheckBox(this.flag_pic, this.f, 25, 0))
                        {
                            NPCMove(this.f, 25, 0);
                        }
                    }
                }
                else if (CheckFlag() == "flag")
                {
                    NavigationService.Navigate(new Uri("CongratulationLevel2Page.xaml", UriKind.Relative));
                }
                else
                {
                    aim = "";
                    aim_position = "";

                    if (Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up))
                    {
                        save();
                        if (!CheckStone(this.flag_pic, this.f, 0, 25) && CheckBound(this.flag_pic, this.f, 0, 25) && !CheckBox(this.flag_pic, this.f, 0, 25))
                        {
                            NPCMove(this.f, 0, 25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Down))
                    {
                        save();
                        if (!CheckStone(this.flag_pic, this.f, 0, -25) && CheckBound(this.flag_pic, this.f, 0, -25) && !CheckBox(this.flag_pic, this.f, 0, -25))
                        {
                            NPCMove(this.f, 0, -25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Right))
                    {
                        save();
                        if (!CheckStone(this.flag_pic, this.f, -25, 0) && CheckBound(this.flag_pic, this.f, -25, 0) && !CheckBox(this.flag_pic, this.f, -25, 0))
                        {
                            NPCMove(this.f, -25, 0);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left))
                    {
                        save();
                        if (!CheckStone(this.flag_pic, this.f, 25, 0) && CheckBound(this.flag_pic, this.f, 25, 0) && !CheckBox(this.flag_pic, this.f, 25, 0))
                        {
                            NPCMove(this.f, 25, 0);
                        }
                    }
                }
            }
            else if (CheckStop() == "flag")
            {
                if (CheckFlag() == "wall")
                {
                    aim = "wall_1";
                    aim_position = "w1";

                    if (Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up))
                    {
                        save();
                        if (!CheckStone(this.flag_pic, this.f, 0, 25) && CheckBound(this.flag_pic, this.f, 0, 25) && !CheckBox(this.flag_pic, this.f, 0, 25))
                        {
                            NPCMove(this.f, 0, 25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Down))
                    {
                        save();
                        if (!CheckStone(this.flag_pic, this.f, 0, -25) && CheckBound(this.flag_pic, this.f, 0, -25) && !CheckBox(this.flag_pic, this.f, 0, -25))
                        {
                            NPCMove(this.f, 0, -25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Right))
                    {
                        save();
                        if (!CheckStone(this.flag_pic, this.f, -25, 0) && CheckBound(this.flag_pic, this.f, -25, 0) && !CheckBox(this.flag_pic, this.f, -25, 0))
                        {
                            NPCMove(this.f, -25, 0);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left))
                    {
                        save();
                        if (!CheckStone(this.flag_pic, this.f, 25, 0) && CheckBound(this.flag_pic, this.f, 25, 0) && !CheckBox(this.flag_pic, this.f, 25, 0))
                        {
                            NPCMove(this.f, 25, 0);
                        }
                    }
                }
                else if (CheckFlag() == "baba")
                {
                    aim = "Genius";
                    aim_position = "aa";

                    if (Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up))
                    {
                        save();
                        if (!CheckStone(this.flag_pic, this.f, 0, 25) && CheckBound(this.flag_pic, this.f, 0, 25) && !CheckBox(this.flag_pic, this.f, 0, 25))
                        {
                            NPCMove(this.f, 0, 25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Down))
                    {
                        save();
                        if (!CheckStone(this.flag_pic, this.f, 0, -25) && CheckBound(this.flag_pic, this.f, 0, -25) && !CheckBox(this.flag_pic, this.f, 0, -25))
                        {
                            NPCMove(this.f, 0, -25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Right))
                    {
                        save();
                        if (!CheckStone(this.flag_pic, this.f, -25, 0) && CheckBound(this.flag_pic, this.f, -25, 0) && !CheckBox(this.flag_pic, this.f, -25, 0))
                        {
                            NPCMove(this.f, -25, 0);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left))
                    {
                        save();
                        if (!CheckStone(this.flag_pic, this.f, 25, 0) && CheckBound(this.flag_pic, this.f, 25, 0) && !CheckBox(this.flag_pic, this.f, 25, 0))
                        {
                            NPCMove(this.f, 25, 0);
                        }
                    }
                }
                else if (CheckFlag() == "flag")
                {
                    NavigationService.Navigate(new Uri("CongratulationLevel2Page.xaml", UriKind.Relative));
                }
                else
                {
                    aim = "";
                    aim_position = "";

                    if (Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up))
                    {
                        save();
                        if (!CheckStone(this.flag_pic, this.f, 0, 25) && CheckBound(this.flag_pic, this.f, 0, 25) && !CheckBox(this.flag_pic, this.f, 0, 25))
                        {
                            NPCMove(this.f, 0, 25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Down))
                    {
                        save();
                        if (!CheckStone(this.flag_pic, this.f, 0, -25) && CheckBound(this.flag_pic, this.f, 0, -25) && !CheckBox(this.flag_pic, this.f, 0, -25))
                        {
                            NPCMove(this.f, 0, -25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Right))
                    {
                        save();
                        if (!CheckStone(this.flag_pic, this.f, -25, 0) && CheckBound(this.flag_pic, this.f, -25, 0) && !CheckBox(this.flag_pic, this.f, -25, 0))
                        {
                            NPCMove(this.f, -25, 0);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left))
                    {
                        save();
                        if (!CheckStone(this.flag_pic, this.f, 25, 0) && CheckBound(this.flag_pic, this.f, 25, 0) && !CheckBox(this.flag_pic, this.f, 25, 0))
                        {
                            NPCMove(this.f, 25, 0);
                        }
                    }
                }
            }
            else
            {
                if (CheckFlag() == "wall")
                {
                    aim = "wall_1";
                    aim_position = "w1";

                    if (Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up))
                    {
                        save();
                        if (!CheckStone(this.flag_pic, this.f, 0, 25) && CheckBound(this.flag_pic, this.f, 0, 25) && !CheckBox(this.flag_pic, this.f, 0, 25))
                        {
                            NPCMove(this.f, 0, 25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Down))
                    {
                        save();
                        if (!CheckStone(this.flag_pic, this.f, 0, -25) && CheckBound(this.flag_pic, this.f, 0, -25) && !CheckBox(this.flag_pic, this.f, 0, -25))
                        {
                            NPCMove(this.f, 0, -25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Right))
                    {
                        save();
                        if (!CheckStone(this.flag_pic, this.f, -25, 0) && CheckBound(this.flag_pic, this.f, -25, 0) && !CheckBox(this.flag_pic, this.f, -25, 0))
                        {
                            NPCMove(this.f, -25, 0);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left))
                    {
                        save();
                        if (!CheckStone(this.flag_pic, this.f, 25, 0) && CheckBound(this.flag_pic, this.f, 25, 0) && !CheckBox(this.flag_pic, this.f, 25, 0))
                        {
                            NPCMove(this.f, 25, 0);
                        }
                    }
                }
                else if (CheckFlag() == "baba")
                {
                    aim = "Genius";
                    aim_position = "aa";

                    if (Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up))
                    {
                        save();
                        if (!CheckStone(this.flag_pic, this.f, 0, 25) && CheckBound(this.flag_pic, this.f, 0, 25) && !CheckBox(this.flag_pic, this.f, 0, 25))
                        {
                            NPCMove(this.f, 0, 25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Down))
                    {
                        save();
                        if (!CheckStone(this.flag_pic, this.f, 0, -25) && CheckBound(this.flag_pic, this.f, 0, -25) && !CheckBox(this.flag_pic, this.f, 0, -25))
                        {
                            NPCMove(this.f, 0, -25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Right))
                    {
                        save();
                        if (!CheckStone(this.flag_pic, this.f, -25, 0) && CheckBound(this.flag_pic, this.f, -25, 0) && !CheckBox(this.flag_pic, this.f, -25, 0))
                        {
                            NPCMove(this.f, -25, 0);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left))
                    {
                        save();
                        if (!CheckStone(this.flag_pic, this.f, 25, 0) && CheckBound(this.flag_pic, this.f, 25, 0) && !CheckBox(this.flag_pic, this.f, 25, 0))
                        {
                            NPCMove(this.f, 25, 0);
                        }
                    }
                }
                else if (CheckFlag() == "flag")
                {
                    NavigationService.Navigate(new Uri("CongratulationLevel2Page.xaml", UriKind.Relative));
                }
                else
                {
                    aim = "";
                    aim_position = "";

                    if (Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up))
                    {
                        save();
                        if (!CheckStone(this.flag_pic, this.f, 0, 25) && CheckBound(this.flag_pic, this.f, 0, 25) && !CheckBox(this.flag_pic, this.f, 0, 25))
                        {
                            NPCMove(this.f, 0, 25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Down))
                    {
                        save();
                        if (!CheckStone(this.flag_pic, this.f, 0, -25) && CheckBound(this.flag_pic, this.f, 0, -25) && !CheckBox(this.flag_pic, this.f, 0, -25))
                        {
                            NPCMove(this.f, 0, -25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Right))
                    {
                        save();
                        if (!CheckStone(this.flag_pic, this.f, -25, 0) && CheckBound(this.flag_pic, this.f, -25, 0) && !CheckBox(this.flag_pic, this.f, -25, 0))
                        {
                            NPCMove(this.f, -25, 0);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left))
                    {
                        save();
                        if (!CheckStone(this.flag_pic, this.f, 25, 0) && CheckBound(this.flag_pic, this.f, 25, 0) && !CheckBox(this.flag_pic, this.f, 25, 0))
                        {
                            NPCMove(this.f, 25, 0);
                        }
                    }
                }
            }
            if (Keyboard.IsKeyDown(Key.Z))
            {
                Z[0] = true;
                back();
            }
        }

        private void Wall_KeyDown(object sender, KeyEventArgs e)
        {

            if (CheckHero() == "wall")
            {
                person = "wall_1";
                person_position = "w1";
                FocusManager.SetFocusedElement(this, wall_1);
            }
            else if (CheckHero() == "flag")
            {
                person = "flag_pic";
                person_position = "f";
                FocusManager.SetFocusedElement(this, flag_pic);
            }
            else if (CheckHero() == "baba")
            {
                person = "Genius";
                person_position = "aa";
                FocusManager.SetFocusedElement(this, Genius);
            }
            else
            {
                if (CheckHero() == "nothing" && CheckHero() != "wall")
                {
                    NavigationService.Navigate(new Uri("FailPage.xaml", UriKind.Relative));
                }
                person = "";
                person_position = "";
                FocusManager.SetFocusedElement(this, null);
            }
            if (CheckStop() == "wall")
            {
                if (CheckFlag() == "wall")
                {
                    NavigationService.Navigate(new Uri("CongratulationLevel2Page.xaml", UriKind.Relative));
                }
                else if (CheckFlag() == "baba")
                {
                    aim = "Genius";
                    aim_position = "aa";

                    if (Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up))
                    {
                        save();
                        if (!CheckStone(this.wall_1, this.w1, 0, 25) && CheckBound(this.wall_1, this.w1, 0, 25) && !CheckBox(this.wall_1, this.w1, 0, 25))
                        {
                            NPCMove(this.w1, 0, 25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Down))
                    {
                        save();
                        if (!CheckStone(this.wall_1, this.w1, 0, -25) && CheckBound(this.wall_1, this.w1, 0, -25) && !CheckBox(this.wall_1, this.w1, 0, -25))
                        {
                            NPCMove(this.w1, 0, -25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Right))
                    {
                        save();
                        if (!CheckStone(this.wall_1, this.w1, -25, 0) && CheckBound(this.wall_1, this.w1, -25, 0) && !CheckBox(this.wall_1, this.w1, -25, 0))
                        {
                            NPCMove(this.w1, -25, 0);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left))
                    {
                        save();
                        if (!CheckStone(this.wall_1, this.w1, 25, 0) && CheckBound(this.wall_1, this.w1, 25, 0) && !CheckBox(this.wall_1, this.w1, 25, 0))
                        {
                            NPCMove(this.w1, 25, 0);
                        }
                    }
                }
                else if (CheckFlag() == "flag")
                {
                    aim = "flag_pic";
                    aim_position = "f";

                    if (Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up))
                    {
                        save();
                        if (!CheckStone(this.wall_1, this.w1, 0, 25) && CheckBound(this.wall_1, this.w1, 0, 25) && !CheckBox(this.wall_1, this.w1, 0, 25))
                        {
                            NPCMove(this.w1, 0, 25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Down))
                    {
                        save();
                        if (!CheckStone(this.wall_1, this.w1, 0, -25) && CheckBound(this.wall_1, this.w1, 0, -25) && !CheckBox(this.wall_1, this.w1, 0, -25))
                        {
                            NPCMove(this.w1, 0, -25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Right))
                    {
                        save();
                        if (!CheckStone(this.wall_1, this.w1, -25, 0) && CheckBound(this.wall_1, this.w1, -25, 0) && !CheckBox(this.wall_1, this.w1, -25, 0))
                        {
                            NPCMove(this.w1, -25, 0);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left))
                    {
                        save();
                        if (!CheckStone(this.wall_1, this.w1, 25, 0) && CheckBound(this.wall_1, this.w1, 25, 0) && !CheckBox(this.wall_1, this.w1, 25, 0))
                        {
                            NPCMove(this.w1, 25, 0);
                        }
                    }
                }
                else
                {
                    aim = "";
                    aim_position = "";

                    if (Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up))
                    {
                        save();
                        if (!CheckStone(this.wall_1, this.w1, 0, 25) && CheckBound(this.wall_1, this.w1, 0, 25) && !CheckBox(this.wall_1, this.w1, 0, 25))
                        {
                            NPCMove(this.w1, 0, 25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Down))
                    {
                        save();
                        if (!CheckStone(this.wall_1, this.w1, 0, -25) && CheckBound(this.wall_1, this.w1, 0, -25) && !CheckBox(this.wall_1, this.w1, 0, -25))
                        {
                            NPCMove(this.w1, 0, -25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Right))
                    {
                        save();
                        if (!CheckStone(this.wall_1, this.w1, -25, 0) && CheckBound(this.wall_1, this.w1, -25, 0) && !CheckBox(this.wall_1, this.w1, -25, 0))
                        {
                            NPCMove(this.w1, -25, 0);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left))
                    {
                        save();
                        if (!CheckStone(this.wall_1, this.w1, 25, 0) && CheckBound(this.wall_1, this.w1, 25, 0) && !CheckBox(this.wall_1, this.w1, 25, 0))
                        {
                            NPCMove(this.w1, 25, 0);
                        }
                    }
                }
            }
            else if (CheckStop() == "baba")
            {
                if (CheckFlag() == "wall")
                {
                    NavigationService.Navigate(new Uri("CongratulationLevel2Page.xaml", UriKind.Relative));
                }
                else if (CheckFlag() == "baba")
                {
                    aim = "Genius";
                    aim_position = "aa";

                    if (Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up))
                    {
                        save();
                        if (!CheckStone(this.wall_1, this.w1, 0, 25) && CheckBound(this.wall_1, this.w1, 0, 25) && !CheckBox(this.wall_1, this.w1, 0, 25))
                        {
                            NPCMove(this.w1, 0, 25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Down))
                    {
                        save();
                        if (!CheckStone(this.wall_1, this.w1, 0, -25) && CheckBound(this.wall_1, this.w1, 0, -25) && !CheckBox(this.wall_1, this.w1, 0, -25))
                        {
                            NPCMove(this.w1, 0, -25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Right))
                    {
                        save();
                        if (!CheckStone(this.wall_1, this.w1, -25, 0) && CheckBound(this.wall_1, this.w1, -25, 0) && !CheckBox(this.wall_1, this.w1, -25, 0))
                        {
                            NPCMove(this.w1, -25, 0);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left))
                    {
                        save();
                        if (!CheckStone(this.wall_1, this.w1, 25, 0) && CheckBound(this.wall_1, this.w1, 25, 0) && !CheckBox(this.wall_1, this.w1, 25, 0))
                        {
                            NPCMove(this.w1, 25, 0);
                        }
                    }
                }
                else if (CheckFlag() == "flag")
                {
                    aim = "flag_pic";
                    aim_position = "f";

                    if (Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up))
                    {
                        save();
                        if (!CheckStone(this.wall_1, this.w1, 0, 25) && CheckBound(this.wall_1, this.w1, 0, 25) && !CheckBox(this.wall_1, this.w1, 0, 25))
                        {
                            NPCMove(this.w1, 0, 25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Down))
                    {
                        save();
                        if (!CheckStone(this.wall_1, this.w1, 0, -25) && CheckBound(this.wall_1, this.w1, 0, -25) && !CheckBox(this.wall_1, this.w1, 0, -25))
                        {
                            NPCMove(this.w1, 0, -25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Right))
                    {
                        save();
                        if (!CheckStone(this.wall_1, this.w1, -25, 0) && CheckBound(this.wall_1, this.w1, -25, 0) && !CheckBox(this.wall_1, this.w1, -25, 0))
                        {
                            NPCMove(this.w1, -25, 0);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left))
                    {
                        save();
                        if (!CheckStone(this.wall_1, this.w1, 25, 0) && CheckBound(this.wall_1, this.w1, 25, 0) && !CheckBox(this.wall_1, this.w1, 25, 0))
                        {
                            NPCMove(this.w1, 25, 0);
                        }
                    }
                }
                else
                {
                    aim = "";
                    aim_position = "";

                    if (Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up))
                    {
                        save();
                        if (!CheckStone(this.wall_1, this.w1, 0, 25) && CheckBound(this.wall_1, this.w1, 0, 25) && !CheckBox(this.wall_1, this.w1, 0, 25))
                        {
                            NPCMove(this.w1, 0, 25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Down))
                    {
                        save();
                        if (!CheckStone(this.wall_1, this.w1, 0, -25) && CheckBound(this.wall_1, this.w1, 0, -25) && !CheckBox(this.wall_1, this.w1, 0, -25))
                        {
                            NPCMove(this.w1, 0, -25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Right))
                    {
                        save();
                        if (!CheckStone(this.wall_1, this.w1, -25, 0) && CheckBound(this.wall_1, this.w1, -25, 0) && !CheckBox(this.wall_1, this.w1, -25, 0))
                        {
                            NPCMove(this.w1, -25, 0);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left))
                    {
                        save();
                        if (!CheckStone(this.wall_1, this.w1, 25, 0) && CheckBound(this.wall_1, this.w1, 25, 0) && !CheckBox(this.wall_1, this.w1, 25, 0))
                        {
                            NPCMove(this.w1, 25, 0);
                        }
                    }
                }
            }
            else if (CheckStop() == "flag")
            {
                if (CheckFlag() == "wall")
                {
                    NavigationService.Navigate(new Uri("CongratulationLevel2Page.xaml", UriKind.Relative));
                }
                else if (CheckFlag() == "baba")
                {
                    aim = "Genius";
                    aim_position = "aa";

                    if (Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up))
                    {
                        save();
                        if (!CheckStone(this.wall_1, this.w1, 0, 25) && CheckBound(this.wall_1, this.w1, 0, 25) && !CheckBox(this.wall_1, this.w1, 0, 25))
                        {
                            NPCMove(this.w1, 0, 25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Down))
                    {
                        save();
                        if (!CheckStone(this.wall_1, this.w1, 0, -25) && CheckBound(this.wall_1, this.w1, 0, -25) && !CheckBox(this.wall_1, this.w1, 0, -25))
                        {
                            NPCMove(this.w1, 0, -25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Right))
                    {
                        save();
                        if (!CheckStone(this.wall_1, this.w1, -25, 0) && CheckBound(this.wall_1, this.w1, -25, 0) && !CheckBox(this.wall_1, this.w1, -25, 0))
                        {
                            NPCMove(this.w1, -25, 0);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left))
                    {
                        save();
                        if (!CheckStone(this.wall_1, this.w1, 25, 0) && CheckBound(this.wall_1, this.w1, 25, 0) && !CheckBox(this.wall_1, this.w1, 25, 0))
                        {
                            NPCMove(this.w1, 25, 0);
                        }
                    }
                }
                else if (CheckFlag() == "flag")
                {
                    aim = "flag_pic";
                    aim_position = "f";

                    if (Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up))
                    {
                        save();
                        if (!CheckStone(this.wall_1, this.w1, 0, 25) && CheckBound(this.wall_1, this.w1, 0, 25) && !CheckBox(this.wall_1, this.w1, 0, 25))
                        {
                            NPCMove(this.w1, 0, 25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Down))
                    {
                        save();
                        if (!CheckStone(this.wall_1, this.w1, 0, -25) && CheckBound(this.wall_1, this.w1, 0, -25) && !CheckBox(this.wall_1, this.w1, 0, -25))
                        {
                            NPCMove(this.w1, 0, -25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Right))
                    {
                        save();
                        if (!CheckStone(this.wall_1, this.w1, -25, 0) && CheckBound(this.wall_1, this.w1, -25, 0) && !CheckBox(this.wall_1, this.w1, -25, 0))
                        {
                            NPCMove(this.w1, -25, 0);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left))
                    {
                        save();
                        if (!CheckStone(this.wall_1, this.w1, 25, 0) && CheckBound(this.wall_1, this.w1, 25, 0) && !CheckBox(this.wall_1, this.w1, 25, 0))
                        {
                            NPCMove(this.w1, 25, 0);
                        }
                    }
                }
                else
                {
                    aim = "";
                    aim_position = "";

                    if (Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up))
                    {
                        save();
                        if (!CheckStone(this.wall_1, this.w1, 0, 25) && CheckBound(this.wall_1, this.w1, 0, 25) && !CheckBox(this.wall_1, this.w1, 0, 25))
                        {
                            NPCMove(this.w1, 0, 25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Down))
                    {
                        save();
                        if (!CheckStone(this.wall_1, this.w1, 0, -25) && CheckBound(this.wall_1, this.w1, 0, -25) && !CheckBox(this.wall_1, this.w1, 0, -25))
                        {
                            NPCMove(this.w1, 0, -25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Right))
                    {
                        save();
                        if (!CheckStone(this.wall_1, this.w1, -25, 0) && CheckBound(this.wall_1, this.w1, -25, 0) && !CheckBox(this.wall_1, this.w1, -25, 0))
                        {
                            NPCMove(this.w1, -25, 0);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left))
                    {
                        save();
                        if (!CheckStone(this.wall_1, this.w1, 25, 0) && CheckBound(this.wall_1, this.w1, 25, 0) && !CheckBox(this.wall_1, this.w1, 25, 0))
                        {
                            NPCMove(this.w1, 25, 0);
                        }
                    }
                }
            }
            else
            {
                if (CheckFlag() == "wall")
                {
                    NavigationService.Navigate(new Uri("CongratulationLevel2Page.xaml", UriKind.Relative));
                }
                else if (CheckFlag() == "baba")
                {
                    aim = "Genius";
                    aim_position = "aa";

                    if (Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up))
                    {
                        save();
                        if (!CheckStone(this.wall_1, this.w1, 0, 25) && CheckBound(this.wall_1, this.w1, 0, 25) && !CheckBox(this.wall_1, this.w1, 0, 25))
                        {
                            NPCMove(this.w1, 0, 25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Down))
                    {
                        save();
                        if (!CheckStone(this.wall_1, this.w1, 0, -25) && CheckBound(this.wall_1, this.w1, 0, -25) && !CheckBox(this.wall_1, this.w1, 0, -25))
                        {
                            NPCMove(this.w1, 0, -25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Right))
                    {
                        save();
                        if (!CheckStone(this.wall_1, this.w1, -25, 0) && CheckBound(this.wall_1, this.w1, -25, 0) && !CheckBox(this.wall_1, this.w1, -25, 0))
                        {
                            NPCMove(this.w1, -25, 0);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left))
                    {
                        save();
                        if (!CheckStone(this.wall_1, this.w1, 25, 0) && CheckBound(this.wall_1, this.w1, 25, 0) && !CheckBox(this.wall_1, this.w1, 25, 0))
                        {
                            NPCMove(this.w1, 25, 0);
                        }
                    }
                }
                else if (CheckFlag() == "flag")
                {
                    aim = "flag_pic";
                    aim_position = "f";

                    if (Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up))
                    {
                        save();
                        if (!CheckStone(this.wall_1, this.w1, 0, 25) && CheckBound(this.wall_1, this.w1, 0, 25) && !CheckBox(this.wall_1, this.w1, 0, 25))
                        {
                            NPCMove(this.w1, 0, 25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Down))
                    {
                        save();
                        if (!CheckStone(this.wall_1, this.w1, 0, -25) && CheckBound(this.wall_1, this.w1, 0, -25) && !CheckBox(this.wall_1, this.w1, 0, -25))
                        {
                            NPCMove(this.w1, 0, -25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Right))
                    {
                        save();
                        if (!CheckStone(this.wall_1, this.w1, -25, 0) && CheckBound(this.wall_1, this.w1, -25, 0) && !CheckBox(this.wall_1, this.w1, -25, 0))
                        {
                            NPCMove(this.w1, -25, 0);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left))
                    {
                        save();
                        if (!CheckStone(this.wall_1, this.w1, 25, 0) && CheckBound(this.wall_1, this.w1, 25, 0) && !CheckBox(this.wall_1, this.w1, 25, 0))
                        {
                            NPCMove(this.w1, 25, 0);
                        }
                    }
                }
                else
                {
                    aim = "";
                    aim_position = "";

                    if (Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up))
                    {
                        save();
                        if (!CheckStone(this.wall_1, this.w1, 0, 25) && CheckBound(this.wall_1, this.w1, 0, 25) && !CheckBox(this.wall_1, this.w1, 0, 25))
                        {
                            NPCMove(this.w1, 0, 25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Down))
                    {
                        save();
                        if (!CheckStone(this.wall_1, this.w1, 0, -25) && CheckBound(this.wall_1, this.w1, 0, -25) && !CheckBox(this.wall_1, this.w1, 0, -25))
                        {
                            NPCMove(this.w1, 0, -25);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Right))
                    {
                        save();
                        if (!CheckStone(this.wall_1, this.w1, -25, 0) && CheckBound(this.wall_1, this.w1, -25, 0) && !CheckBox(this.wall_1, this.w1, -25, 0))
                        {
                            NPCMove(this.w1, -25, 0);
                        }
                    }
                    else if (Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left))
                    {
                        save();
                        if (!CheckStone(this.wall_1, this.w1, 25, 0) && CheckBound(this.wall_1, this.w1, 25, 0) && !CheckBox(this.wall_1, this.w1, 25, 0))
                        {
                            NPCMove(this.w1, 25, 0);
                        }
                    }
                }
            }
            if (Keyboard.IsKeyDown(Key.Z))
            {
                Z[0] = true;
                back();
            }
        }

        bool CheckBox(Image target, TranslateTransform target_position, double step_x, double step_y)
        {
            int i;
            for (i = 0; i < 9; i++)
            {
                TranslateTransform d = FindName(box_position[i]) as TranslateTransform;
                Image c = FindName(box[i]) as Image;
                if (BoxCollision(target, target_position, step_x, step_y, c, d))
                {
                    if (CheckStone(c, d, step_x, step_y)) return true;
                    if (!CheckBound(c, d, step_x, step_y)) return true;
                    if (BoxCheckBox(c, d, step_x, step_y)) return true;
                    if (!BoxCheckBox(c, d, step_x, step_y)) NPCMove(d, step_x, step_y);
                }
            }
            return false;
        }

        void CheckAim(string target, string target_positioin)
        {
            if (target == "" || target == null || aim == "" || aim == null)
                ISWIN = false;
            else
            {
                Image c = FindName(aim) as Image;
                TranslateTransform f = FindName(aim_position) as TranslateTransform;
                ISWIN = false;
                Image d = FindName(target) as Image;
                TranslateTransform e = FindName(target_positioin) as TranslateTransform;
                if (AimCollision(d, e, c, f)) ISWIN = true;
            }
        }

        bool AimCollision(Image target, TranslateTransform target_position, Image target2, TranslateTransform target2_position)
        {
            var x1 = Canvas.GetLeft(target) + target_position.X;
            var y1 = Canvas.GetTop(target) + target_position.Y;
            Rect r1 = new Rect(x1, y1, target.Width - 1, target.Height - 1);
            var x2 = Canvas.GetLeft(target2) + target2_position.X;
            var y2 = Canvas.GetTop(target2) + target2_position.Y;
            Rect r2 = new Rect(x2, y2, target2.Width - 1, target2.Height - 1);
            if (r1.IntersectsWith(r2)) return true;
            else return false;
        }

        bool BoxCheckBox(Image target, TranslateTransform target_position, double step_x, double step_y)
        {
            int i;
            for (i = 0; i < 9; i++)
            {
                Image c = FindName(box[i]) as Image;
                TranslateTransform d = FindName(box_position[i]) as TranslateTransform;
                if (c != target)
                {
                    if (BoxCollision(target, target_position, step_x, step_y, c, d))
                    {
                        BoxCheckBox(c, d, step_x, step_y);
                        if (CheckBound(c, d, step_x, step_y))
                            NPCMove(d, step_x, step_y);
                    }
                }
            }
            return false;
        }

        bool CheckStone(Image target, TranslateTransform target_position, double step_x, double step_y)
        {
            if (stone != "")
            {
                Image b = FindName(stone) as Image;
                TranslateTransform b_position = FindName(stone_position) as TranslateTransform;
                if (StoneCollision(target, target_position, step_x, step_y, b, b_position))
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        bool StoneCollision(Image target, TranslateTransform target_position, double step_x, double step_y, Image target2, TranslateTransform target2_position)
        {
            var x1 = Canvas.GetLeft(target) + target_position.X + step_x;
            var y1 = Canvas.GetTop(target) + target_position.Y + step_y;
            Rect r1 = new Rect(x1, y1, target.Width - 1, target.Height - 1);
            var x2 = Canvas.GetLeft(target2) + target2_position.X;
            var y2 = Canvas.GetTop(target2) + target2_position.Y;
            Rect r2 = new Rect(x2, y2, target2.Width - 1, target2.Height - 1);
            if (r1.IntersectsWith(r2)) return true;
            else return false;
        }

        bool BoxCollision(Image target, TranslateTransform target_position, double step_x, double step_y, Image target2, TranslateTransform target2_position)
        {
            var x1 = Canvas.GetLeft(target) + target_position.X + step_x;
            var y1 = Canvas.GetTop(target) + target_position.Y + step_y;
            Rect r1 = new Rect(x1, y1, target.Width - 1, target.Height - 1);
            var x2 = Canvas.GetLeft(target2) + target2_position.X;
            var y2 = Canvas.GetTop(target2) + target2_position.Y;
            Rect r2 = new Rect(x2, y2, target2.Width - 1, target2.Height - 1);
            if (r1.IntersectsWith(r2)) return true;
            else return false;
        }

        bool CheckBound(Image target, TranslateTransform target_position, double step_x, double step_y)
        {

            var x = Canvas.GetLeft(target) + target_position.X + step_x;
            var y = Canvas.GetTop(target) + target_position.Y + step_y;
            if (x <= 775 && x >= 0 && y <= 375 && y >= 0) return true;
            else return false;
        }

        void NPCMove(TranslateTransform target_position, Double X, Double Y)
        {
            var x = new DoubleAnimation();
            var y = new DoubleAnimation();
            x.From = target_position.X;
            y.From = target_position.Y;
            x.To = target_position.X + X;
            y.To = target_position.Y + Y;
            target_position.X += X;
            target_position.Y += Y;
            x.Duration = new Duration(TimeSpan.FromSeconds(0.005));
            y.Duration = new Duration(TimeSpan.FromSeconds(0.005));
            target_position.BeginAnimation(TranslateTransform.XProperty, x);
            target_position.BeginAnimation(TranslateTransform.YProperty, y);
        }

        private void Game_KeyUp(object sender, KeyEventArgs e)
        {
            CheckAim(person, person_position);
            CheckWin();
            if (Z[0] == true && Saving.Count != 0)
                Saving.Remove(Saving.Last());
            Z[0] = false;
        }

        void save()
        {
            positiondata data = new positiondata();
            if (person == "Genius")
            {
                data.person.x = this.aa.X;
                data.person.y = this.aa.Y;
            }
            else if (person == "wall_1")
            {
                data.person.x = this.w1.X;
                data.person.y = this.w1.Y;
            }
            else if (person == "flag_pic")
            {
                data.person.x = this.f.X;
                data.person.y = this.f.Y;
            }

            int i;
            for (i = 0; i < 9; i++)
            {
                TranslateTransform d = FindName(box_position[i]) as TranslateTransform;
                my_positon boxposition = new my_positon();
                boxposition.x = d.X;
                boxposition.y = d.Y;
                data.save_box.Add(boxposition);
            }
            Saving.Add(data);
        }

        void back()
        {
            double x, y;
            if (Saving.Count != 0)
            {
                if (person == "Genius")
                {
                    x = Saving.Last().person.x - this.aa.X;
                    y = Saving.Last().person.y - this.aa.Y;
                    NPCMove(this.aa, x, y);
                    int i;
                    for (i = 0; i < 9; i++)
                    {
                        TranslateTransform d = FindName(box_position[i]) as TranslateTransform;
                        x = Saving.Last().save_box[i].x - d.X;
                        y = Saving.Last().save_box[i].y - d.Y;
                        NPCMove(d, x, y);
                    }
                    BitmapImage imagetemp = new BitmapImage(new Uri(@"MySource/正向站立.png", UriKind.Relative));
                    this.Genius.Source = imagetemp;
                }
                else if (person == "wall_1")
                {
                    x = Saving.Last().person.x - this.w1.X;
                    y = Saving.Last().person.y - this.w1.Y;
                    NPCMove(this.w1, x, y);
                    int i;
                    for (i = 0; i < 9; i++)
                    {
                        TranslateTransform d = FindName(box_position[i]) as TranslateTransform;
                        x = Saving.Last().save_box[i].x - d.X;
                        y = Saving.Last().save_box[i].y - d.Y;
                        NPCMove(d, x, y);
                    }
                }
                else if (person == "flag_pic")
                {
                    x = Saving.Last().person.x - this.f.X;
                    y = Saving.Last().person.y - this.f.Y;
                    NPCMove(this.f, x, y);
                    int i;
                    for (i = 0; i < 9; i++)
                    {
                        TranslateTransform d = FindName(box_position[i]) as TranslateTransform;
                        x = Saving.Last().save_box[i].x - d.X;
                        y = Saving.Last().save_box[i].y - d.Y;
                        NPCMove(d, x, y);
                    }
                }
                
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double x, y;
            x = 0 - this.aa.X;
            y = 0 - this.aa.Y;
            NPCMove(this.aa, x, y);

            x = 0 - this.f.X;
            y = 0 - this.f.Y;
            NPCMove(this.f, x, y);

            x = 0 - this.w1.X;
            y = 0 - this.w1.Y;
            NPCMove(this.w1, x, y);

            int i;
            for (i = 0; i < 9; i++)
            {
                TranslateTransform d = FindName(box_position[i]) as TranslateTransform;
                x = 0 - d.X;
                y = 0 - d.Y;
                NPCMove(d, x, y);
            }
            BitmapImage imagetemp = new BitmapImage(new Uri(@"MySource/正向站立.png", UriKind.Relative));
            this.Genius.Source = imagetemp;
            FocusManager.SetFocusedElement(this, Genius);
            Saving.Clear();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Do you really want to quit?", "Quit Game",
            MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
            else
            {
                // Do nothing.
            }
        }

        private string CheckStop()
        {
            TranslateTransform STOP = FindName(stop_position) as TranslateTransform;
            Image P_STOP = FindName(stop_) as Image;

            TranslateTransform WALL = FindName(wall_position) as TranslateTransform;
            Image P_WALL = FindName(wall_) as Image;

            TranslateTransform FLAG = FindName(flag_position) as TranslateTransform;
            Image P_FLAG = FindName(flag_) as Image;

            TranslateTransform BABA = FindName(baba_position) as TranslateTransform;
            Image P_BABA = FindName(baba_) as Image;

            for (int i = 0; i < 3; i++)
            {
                TranslateTransform IS = FindName(is_position[i]) as TranslateTransform;
                Image P_IS = FindName(is_[i]) as Image;

                var x1 = Canvas.GetLeft(P_STOP) + STOP.X;
                var y1 = Canvas.GetTop(P_STOP) + STOP.Y;
                Rect r1 = new Rect(x1, y1, P_STOP.Width - 1, P_STOP.Height - 1);
                var x2 = Canvas.GetLeft(P_IS) + IS.X + 25;
                var y2 = Canvas.GetTop(P_IS) + IS.Y;
                Rect r2 = new Rect(x2, y2, P_IS.Width - 1, P_IS.Height - 1);
                var x3 = Canvas.GetLeft(P_WALL) + WALL.X + 50;
                var y3 = Canvas.GetTop(P_WALL) + WALL.Y;
                Rect r3 = new Rect(x3, y3, P_WALL.Width - 1, P_WALL.Height - 1);
                if (r1.IntersectsWith(r2) && r2.IntersectsWith(r3))
                {
                    stone = "wall_1";
                    stone_position = "w1";
                    return "wall";
                }
                else
                {
                    x1 = Canvas.GetLeft(P_STOP) + STOP.X;
                    y1 = Canvas.GetTop(P_STOP) + STOP.Y;
                    r1 = new Rect(x1, y1, P_STOP.Width - 1, P_STOP.Height - 1);
                    x2 = Canvas.GetLeft(P_IS) + IS.X;
                    y2 = Canvas.GetTop(P_IS) + IS.Y + 25;
                    r2 = new Rect(x2, y2, P_IS.Width - 1, P_IS.Height - 1);
                    x3 = Canvas.GetLeft(P_WALL) + WALL.X;
                    y3 = Canvas.GetTop(P_WALL) + WALL.Y + 50;
                    r3 = new Rect(x3, y3, P_WALL.Width - 1, P_WALL.Height - 1);
                    if (r1.IntersectsWith(r2) && r2.IntersectsWith(r3))
                    {
                        stone = "wall_1";
                        stone_position = "w1";
                        return "wall";
                    }
                    else
                    {
                        x1 = Canvas.GetLeft(P_STOP) + STOP.X;
                        y1 = Canvas.GetTop(P_STOP) + STOP.Y;
                        r1 = new Rect(x1, y1, P_STOP.Width - 1, P_STOP.Height - 1);
                        x2 = Canvas.GetLeft(P_IS) + IS.X;
                        y2 = Canvas.GetTop(P_IS) + IS.Y + 25;
                        r2 = new Rect(x2, y2, P_IS.Width - 1, P_IS.Height - 1);
                        x3 = Canvas.GetLeft(P_FLAG) + FLAG.X;
                        y3 = Canvas.GetTop(P_FLAG) + FLAG.Y + 50;
                        r3 = new Rect(x3, y3, P_FLAG.Width - 1, P_FLAG.Height - 1);
                        if (r1.IntersectsWith(r2) && r2.IntersectsWith(r3))
                        {
                            stone = "flag_pic";
                            stone_position = "f";
                            return "flag";
                        }
                        else
                        {
                            x1 = Canvas.GetLeft(P_STOP) + STOP.X;
                            y1 = Canvas.GetTop(P_STOP) + STOP.Y;
                            r1 = new Rect(x1, y1, P_STOP.Width - 1, P_STOP.Height - 1);
                            x2 = Canvas.GetLeft(P_IS) + IS.X + 25;
                            y2 = Canvas.GetTop(P_IS) + IS.Y;
                            r2 = new Rect(x2, y2, P_IS.Width - 1, P_IS.Height - 1);
                            x3 = Canvas.GetLeft(P_FLAG) + FLAG.X + 50;
                            y3 = Canvas.GetTop(P_FLAG) + FLAG.Y;
                            r3 = new Rect(x3, y3, P_FLAG.Width - 1, P_FLAG.Height - 1);
                            if (r1.IntersectsWith(r2) && r2.IntersectsWith(r3))
                            {
                                stone = "flag_pic";
                                stone_position = "f";
                                return "flag";
                            }
                            else
                            {
                                x1 = Canvas.GetLeft(P_STOP) + STOP.X;
                                y1 = Canvas.GetTop(P_STOP) + STOP.Y;
                                r1 = new Rect(x1, y1, P_STOP.Width - 1, P_STOP.Height - 1);
                                x2 = Canvas.GetLeft(P_IS) + IS.X;
                                y2 = Canvas.GetTop(P_IS) + IS.Y + 25;
                                r2 = new Rect(x2, y2, P_IS.Width - 1, P_IS.Height - 1);
                                x3 = Canvas.GetLeft(P_BABA) + BABA.X;
                                y3 = Canvas.GetTop(P_BABA) + BABA.Y + 50;
                                r3 = new Rect(x3, y3, P_BABA.Width - 1, P_BABA.Height - 1);
                                if (r1.IntersectsWith(r2) && r2.IntersectsWith(r3))
                                {
                                    stone = "Genius";
                                    stone_position = "aa";
                                    return "baba";
                                }
                                else
                                {
                                    x1 = Canvas.GetLeft(P_STOP) + STOP.X;
                                    y1 = Canvas.GetTop(P_STOP) + STOP.Y;
                                    r1 = new Rect(x1, y1, P_STOP.Width - 1, P_STOP.Height - 1);
                                    x2 = Canvas.GetLeft(P_IS) + IS.X + 25;
                                    y2 = Canvas.GetTop(P_IS) + IS.Y;
                                    r2 = new Rect(x2, y2, P_IS.Width - 1, P_IS.Height - 1);
                                    x3 = Canvas.GetLeft(P_BABA) + BABA.X + 50;
                                    y3 = Canvas.GetTop(P_BABA) + BABA.Y;
                                    r3 = new Rect(x3, y3, P_BABA.Width - 1, P_BABA.Height - 1);
                                    if (r1.IntersectsWith(r2) && r2.IntersectsWith(r3))
                                    {
                                        stone = "Genius";
                                        stone_position = "aa";
                                        return "baba";
                                    }
                                }
                            }
                        }
                    }
                }
                
            }
            stone = "";
            stone_position = "";
            return "nothing";
        }

        private string CheckHero()
        {
            TranslateTransform YOU = FindName(you_position) as TranslateTransform;
            Image P_YOU = FindName(you_) as Image;

            TranslateTransform WALL = FindName(wall_position) as TranslateTransform;
            Image P_WALL = FindName(wall_) as Image;

            TranslateTransform FLAG = FindName(flag_position) as TranslateTransform;
            Image P_FLAG = FindName(flag_) as Image;

            TranslateTransform BABA = FindName(baba_position) as TranslateTransform;
            Image P_BABA = FindName(baba_) as Image;

            int i;
            for (i = 0; i < 3; i++)
            {
                TranslateTransform IS = FindName(is_position[i]) as TranslateTransform;
                Image P_IS = FindName(is_[i]) as Image;

                var x1 = Canvas.GetLeft(P_YOU) + YOU.X;
                var y1 = Canvas.GetTop(P_YOU) + YOU.Y;
                Rect r1 = new Rect(x1, y1, P_YOU.Width - 1, P_YOU.Height - 1);
                var x2 = Canvas.GetLeft(P_IS) + IS.X + 25;
                var y2 = Canvas.GetTop(P_IS) + IS.Y;
                Rect r2 = new Rect(x2, y2, P_IS.Width - 1, P_IS.Height - 1);
                var x3 = Canvas.GetLeft(P_WALL) + WALL.X + 50;
                var y3 = Canvas.GetTop(P_WALL) + WALL.Y;
                Rect r3 = new Rect(x3, y3, P_WALL.Width - 1, P_WALL.Height - 1);
                if (r1.IntersectsWith(r2) && r2.IntersectsWith(r3))
                {
                    return "wall";
                }
                else
                {
                    x1 = Canvas.GetLeft(P_YOU) + YOU.X;
                    y1 = Canvas.GetTop(P_YOU) + YOU.Y;
                    r1 = new Rect(x1, y1, P_YOU.Width - 1, P_YOU.Height - 1);
                    x2 = Canvas.GetLeft(P_IS) + IS.X;
                    y2 = Canvas.GetTop(P_IS) + IS.Y + 25;
                    r2 = new Rect(x2, y2, P_IS.Width - 1, P_IS.Height - 1);
                    x3 = Canvas.GetLeft(P_WALL) + WALL.X;
                    y3 = Canvas.GetTop(P_WALL) + WALL.Y + 50;
                    r3 = new Rect(x3, y3, P_WALL.Width - 1, P_WALL.Height - 1);
                    if (r1.IntersectsWith(r2) && r2.IntersectsWith(r3))
                    {
                        return "wall";
                    }
                    else
                    {
                        x1 = Canvas.GetLeft(P_YOU) + YOU.X;
                        y1 = Canvas.GetTop(P_YOU) + YOU.Y;
                        r1 = new Rect(x1, y1, P_YOU.Width - 1, P_YOU.Height - 1);
                        x2 = Canvas.GetLeft(P_IS) + IS.X;
                        y2 = Canvas.GetTop(P_IS) + IS.Y + 25;
                        r2 = new Rect(x2, y2, P_IS.Width - 1, P_IS.Height - 1);
                        x3 = Canvas.GetLeft(P_FLAG) + FLAG.X;
                        y3 = Canvas.GetTop(P_FLAG) + FLAG.Y + 50;
                        r3 = new Rect(x3, y3, P_FLAG.Width - 1, P_FLAG.Height - 1);
                        if (r1.IntersectsWith(r2) && r2.IntersectsWith(r3))
                        {
                            return "flag";
                        }
                        else
                        {
                            x1 = Canvas.GetLeft(P_YOU) + YOU.X;
                            y1 = Canvas.GetTop(P_YOU) + YOU.Y;
                            r1 = new Rect(x1, y1, P_YOU.Width - 1, P_YOU.Height - 1);
                            x2 = Canvas.GetLeft(P_IS) + IS.X + 25;
                            y2 = Canvas.GetTop(P_IS) + IS.Y;
                            r2 = new Rect(x2, y2, P_IS.Width - 1, P_IS.Height - 1);
                            x3 = Canvas.GetLeft(P_FLAG) + FLAG.X + 50;
                            y3 = Canvas.GetTop(P_FLAG) + FLAG.Y;
                            r3 = new Rect(x3, y3, P_FLAG.Width - 1, P_FLAG.Height - 1);
                            if (r1.IntersectsWith(r2) && r2.IntersectsWith(r3))
                            {
                                return "flag";
                            }
                            else
                            {
                                x1 = Canvas.GetLeft(P_YOU) + YOU.X;
                                y1 = Canvas.GetTop(P_YOU) + YOU.Y;
                                r1 = new Rect(x1, y1, P_YOU.Width - 1, P_YOU.Height - 1);
                                x2 = Canvas.GetLeft(P_IS) + IS.X;
                                y2 = Canvas.GetTop(P_IS) + IS.Y + 25;
                                r2 = new Rect(x2, y2, P_IS.Width - 1, P_IS.Height - 1);
                                x3 = Canvas.GetLeft(P_BABA) + BABA.X;
                                y3 = Canvas.GetTop(P_BABA) + BABA.Y + 50;
                                r3 = new Rect(x3, y3, P_BABA.Width - 1, P_BABA.Height - 1);
                                if (r1.IntersectsWith(r2) && r2.IntersectsWith(r3))
                                {
                                    return "baba";
                                }
                                else
                                {
                                    x1 = Canvas.GetLeft(P_YOU) + YOU.X;
                                    y1 = Canvas.GetTop(P_YOU) + YOU.Y;
                                    r1 = new Rect(x1, y1, P_YOU.Width - 1, P_YOU.Height - 1);
                                    x2 = Canvas.GetLeft(P_IS) + IS.X + 25;
                                    y2 = Canvas.GetTop(P_IS) + IS.Y;
                                    r2 = new Rect(x2, y2, P_IS.Width - 1 + 25, P_IS.Height - 1);
                                    x3 = Canvas.GetLeft(P_BABA) + BABA.X + 50;
                                    y3 = Canvas.GetTop(P_BABA) + BABA.Y;
                                    r3 = new Rect(x3, y3, P_BABA.Width - 1, P_BABA.Height - 1);
                                    if (r1.IntersectsWith(r2) && r2.IntersectsWith(r3))
                                    {
                                        return "baba";
                                    }
                                }
                            }
                        }
                    }

                }

            }
            return "nothing";
        }

        private string CheckFlag()
        {
            TranslateTransform WIN = FindName(win_position) as TranslateTransform;
            Image P_WIN = FindName(win_) as Image;

            TranslateTransform WALL = FindName(wall_position) as TranslateTransform;
            Image P_WALL = FindName(wall_) as Image;

            TranslateTransform FLAG = FindName(flag_position) as TranslateTransform;
            Image P_FLAG = FindName(flag_) as Image;

            TranslateTransform BABA = FindName(baba_position) as TranslateTransform;
            Image P_BABA = FindName(baba_) as Image;

            int i;
            for (i = 0; i < 3; i++)
            {
                TranslateTransform IS = FindName(is_position[i]) as TranslateTransform;
                Image P_IS = FindName(is_[i]) as Image;

                var x1 = Canvas.GetLeft(P_WIN) + WIN.X;
                var y1 = Canvas.GetTop(P_WIN) + WIN.Y;
                Rect r1 = new Rect(x1, y1, P_WIN.Width - 1, P_WIN.Height - 1);
                var x2 = Canvas.GetLeft(P_IS) + IS.X + 25;
                var y2 = Canvas.GetTop(P_IS) + IS.Y;
                Rect r2 = new Rect(x2, y2, P_IS.Width - 1, P_IS.Height - 1);
                var x3 = Canvas.GetLeft(P_WALL) + WALL.X + 50;
                var y3 = Canvas.GetTop(P_WALL) + WALL.Y;
                Rect r3 = new Rect(x3, y3, P_WALL.Width - 1, P_WALL.Height - 1);
                if (r1.IntersectsWith(r2) && r2.IntersectsWith(r3))
                {
                    return "wall";
                }
                else
                {
                    x1 = Canvas.GetLeft(P_WIN) + WIN.X;
                    y1 = Canvas.GetTop(P_WIN) + WIN.Y;
                    r1 = new Rect(x1, y1, P_WIN.Width - 1, P_WIN.Height - 1);
                    x2 = Canvas.GetLeft(P_IS) + IS.X;
                    y2 = Canvas.GetTop(P_IS) + IS.Y + 25;
                    r2 = new Rect(x2, y2, P_IS.Width - 1, P_IS.Height - 1);
                    x3 = Canvas.GetLeft(P_WALL) + WALL.X;
                    y3 = Canvas.GetTop(P_WALL) + WALL.Y + 50;
                    r3 = new Rect(x3, y3, P_WALL.Width - 1, P_WALL.Height - 1);
                    if (r1.IntersectsWith(r2) && r2.IntersectsWith(r3))
                    {
                        return "wall";
                    }
                    else
                    {
                        x1 = Canvas.GetLeft(P_WIN) + WIN.X;
                        y1 = Canvas.GetTop(P_WIN) + WIN.Y;
                        r1 = new Rect(x1, y1, P_WIN.Width - 1, P_WIN.Height - 1);
                        x2 = Canvas.GetLeft(P_IS) + IS.X;
                        y2 = Canvas.GetTop(P_IS) + IS.Y + 25;
                        r2 = new Rect(x2, y2, P_IS.Width - 1, P_IS.Height - 1);
                        x3 = Canvas.GetLeft(P_FLAG) + FLAG.X;
                        y3 = Canvas.GetTop(P_FLAG) + FLAG.Y + 50;
                        r3 = new Rect(x3, y3, P_FLAG.Width - 1, P_FLAG.Height - 1);
                        if (r1.IntersectsWith(r2) && r2.IntersectsWith(r3))
                        {
                            return "flag";
                        }
                        else
                        {
                            x1 = Canvas.GetLeft(P_WIN) + WIN.X;
                            y1 = Canvas.GetTop(P_WIN) + WIN.Y;
                            r1 = new Rect(x1, y1, P_WIN.Width - 1, P_WIN.Height - 1);
                            x2 = Canvas.GetLeft(P_IS) + IS.X + 25;
                            y2 = Canvas.GetTop(P_IS) + IS.Y;
                            r2 = new Rect(x2, y2, P_IS.Width - 1, P_IS.Height - 1);
                            x3 = Canvas.GetLeft(P_FLAG) + FLAG.X + 50;
                            y3 = Canvas.GetTop(P_FLAG) + FLAG.Y;
                            r3 = new Rect(x3, y3, P_FLAG.Width - 1, P_FLAG.Height - 1);
                            if (r1.IntersectsWith(r2) && r2.IntersectsWith(r3))
                            {
                                return "flag";
                            }
                            else
                            {
                                x1 = Canvas.GetLeft(P_WIN) + WIN.X;
                                y1 = Canvas.GetTop(P_WIN) + WIN.Y;
                                r1 = new Rect(x1, y1, P_WIN.Width - 1, P_WIN.Height - 1);
                                x2 = Canvas.GetLeft(P_IS) + IS.X;
                                y2 = Canvas.GetTop(P_IS) + IS.Y + 25;
                                r2 = new Rect(x2, y2, P_IS.Width - 1, P_IS.Height - 1);
                                x3 = Canvas.GetLeft(P_BABA) + BABA.X;
                                y3 = Canvas.GetTop(P_BABA) + BABA.Y + 50;
                                r3 = new Rect(x3, y3, P_BABA.Width - 1, P_BABA.Height - 1);
                                if (r1.IntersectsWith(r2) && r2.IntersectsWith(r3))
                                {
                                    return "baba";
                                }
                                else
                                {
                                    x1 = Canvas.GetLeft(P_WIN) + WIN.X;
                                    y1 = Canvas.GetTop(P_WIN) + WIN.Y;
                                    r1 = new Rect(x1, y1, P_WIN.Width - 1, P_WIN.Height - 1);
                                    x2 = Canvas.GetLeft(P_IS) + IS.X + 25;
                                    y2 = Canvas.GetTop(P_IS) + IS.Y;
                                    r2 = new Rect(x2, y2, P_IS.Width - 1, P_IS.Height - 1);
                                    x3 = Canvas.GetLeft(P_BABA) + BABA.X + 50;
                                    y3 = Canvas.GetTop(P_BABA) + BABA.Y;
                                    r3 = new Rect(x3, y3, P_BABA.Width - 1, P_BABA.Height - 1);
                                    if (r1.IntersectsWith(r2) && r2.IntersectsWith(r3))
                                    {
                                        return "baba";
                                    }
                                }
                            }
                        }
                    }

                }

            }
            return "nothing";
        }
    }
}
