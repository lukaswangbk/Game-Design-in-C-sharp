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
using System.Windows.Media.Animation;
using System.Diagnostics;
using System.Windows.Navigation;


namespace WpfApplication1
{
    /// <summary>
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class GameLevel1Page : Page
    {
        public GameLevel1Page()
        {
            InitializeComponent();
            FocusManager.SetFocusedElement(this,Genius);
        }
        string[] stone = { "wall_1", "wall_2", "wall_3", "wall_4", "wall_5", "wall_6", "wall_7", "wall_8", "wall_9", "wall_10",
                            "wall_11", "wall_12", "wall_13", "wall_14", "wall_15", "wall_16", "wall_17", "wall_18", "wall_19", "wall_20",
                            "wall_21", "wall_22", "wall_23", "wall_24", "wall_25", "wall_26", "wall_27", "wall_28", "wall_29", "wall_30",
                            "wall_31", "wall_32", "wall_33", "wall_34", "wall_35", "wall_36", "wall_37", "wall_38", "wall_39", "wall_40",
                            "wall_41", "wall_42", "wall_43", "wall_44", "wall_45", "wall_46", "wall_47", "wall_48", "wall_49", "wall_50",
                            "wall_51", "wall_52", "wall_53", "wall_54", "wall_55", "wall_56", "wall_57", "wall_58", "wall_59", "wall_60",
                            "wall_61", "wall_62", "wall_63", "wall_64" };
        string[] box = { "rock_1", "rock_2", "rock_3" };
        string[] box_position = { "b1","b2","b3" };
        string[] aim = { "flag_pic" };
        string hero = "Genius";
        string hero_position = "aa";
        string skull_ = "skull_pic";

        bool ISWIN =new bool();
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
                NavigationService.Navigate(new Uri("CongratulationLevel1Page.xaml", UriKind.Relative));
            }
            return true;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("LevelChoosePage1.xaml", UriKind.Relative));
        }

        private void Genius_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up))
            {
                save();
                BitmapImage imagetemp = new BitmapImage(new Uri(@"MySource/正向移动.png", UriKind.Relative));
                this.Genius.Source = imagetemp;
                if (!CheckStone(this.Genius, this.aa, 0, 25) && CheckBound(this.Genius, this.aa, 0, 25) && !CheckBox(this.Genius, this.aa, 0, 25))
                {
                    NPCMove(this.aa,0, 25);
                }
            }
            if (Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Down))
            {
                save();
                BitmapImage imagetemp = new BitmapImage(new Uri(@"MySource/背向移动.png", UriKind.Relative));
                this.Genius.Source = imagetemp;
                if (!CheckStone(this.Genius, this.aa, 0, -25) && CheckBound(this.Genius, this.aa, 0, -25) && !CheckBox(this.Genius, this.aa, 0, -25))
                {
                    NPCMove(this.aa,0, -25);
                }
            }
            if (Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Right))
            {
                save();
                BitmapImage imagetemp = new BitmapImage(new Uri(@"MySource/左向移动.png", UriKind.Relative));
                this.Genius.Source = imagetemp;
                if (!CheckStone(this.Genius, this.aa, -25, 0) && CheckBound(this.Genius, this.aa, -25, 0) && !CheckBox(this.Genius, this.aa, -25, 0))
                {
                    NPCMove(this.aa, -25, 0);
                }
            }
            if (Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Left))
            {
                save();
                BitmapImage imagetemp = new BitmapImage(new Uri(@"MySource/右向移动.png", UriKind.Relative));
                this.Genius.Source = imagetemp;
                if (!CheckStone(this.Genius, this.aa, 25, 0) && CheckBound(this.Genius, this.aa, 25, 0) && !CheckBox(this.Genius, this.aa, 25, 0))
                {    
                    NPCMove(this.aa,25,0);                        
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
            for (i = 0; i < 3; i++)
            {
                TranslateTransform d = FindName(box_position[i]) as TranslateTransform;
                Image c = FindName(box[i]) as Image;
                if (BoxCollision(target, target_position, step_x, step_y, c,d))
                {
                    if (CheckStone(c, d, step_x, step_y)) return true;
                    if (!CheckBound(c, d, step_x, step_y)) return true;
                    if (BoxCheckBox(c, d, step_x, step_y)) return true;
                    if (!BoxCheckBox(c, d, step_x, step_y)) NPCMove(d, step_x, step_y);
                }
            }
            return false;
        }
        void CheckAim()
        {
            Image c = FindName(aim[0]) as Image;
            ISWIN = false;

            Image d = FindName(hero) as Image;
            TranslateTransform e = FindName(hero_position) as TranslateTransform;
            if (AimCollision(d, e, c)) ISWIN = true;
        }
        void CheckKill()
        {
            Image c = FindName(skull_) as Image;

            Image d = FindName(hero) as Image;
            TranslateTransform e = FindName(hero_position) as TranslateTransform;
            if (AimCollision(d, e, c)) NavigationService.Navigate(new Uri("FailPage2.xaml", UriKind.Relative));
        }
        bool AimCollision(Image target, TranslateTransform target_position, Image target2)
        {
            var x1 = Canvas.GetLeft(target) + target_position.X;
            var y1 = Canvas.GetTop(target) + target_position.Y;
            Rect r1 = new Rect(x1, y1, target.Width - 1, target.Height - 1);
            var x2 = Canvas.GetLeft(target2);
            var y2 = Canvas.GetTop(target2);
            Rect r2 = new Rect(x2, y2, target2.Width - 1, target2.Height - 1);
            if (r1.IntersectsWith(r2)) return true;
            else return false;
        }
        bool BoxCheckBox(Image target, TranslateTransform target_position, double step_x, double step_y)
        {
            int i;
            for (i = 0; i < 3; i++)
            {
                Image c = FindName(box[i]) as Image;
                TranslateTransform d = FindName(box_position[i]) as TranslateTransform;
                if (c != target)
                {
                    if (BoxCollision(target, target_position, step_x, step_y, c, d))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        bool CheckStone(Image target, TranslateTransform target_position, double step_x, double step_y)
        {
            int i;
            for (i = 0; i < 64; i++)
            {
                Image b = FindName(stone[i]) as Image;
                if (StoneCollision(target, target_position, step_x, step_y, b))
                {
                    return true;
                }
            }
            return false;
        }
       

         bool StoneCollision(Image target, TranslateTransform target_position, double step_x, double step_y, Image target2)
         {
             var x1 = Canvas.GetLeft(target) + target_position.X + step_x;
             var y1 = Canvas.GetTop(target) + target_position.Y + step_y;
             Rect r1 = new Rect(x1, y1, target.Width - 1, target.Height - 1);
             var x2 = Canvas.GetLeft(target2);
             var y2 = Canvas.GetTop(target2);
             Rect r2 = new Rect(x2, y2, target2.Width - 1, target2.Height - 1);
             if(r1.IntersectsWith(r2)) return true;
             else return false;
         }
         bool BoxCollision(Image target, TranslateTransform target_position, double step_x, double step_y, Image target2, TranslateTransform target2_position)
         {
             var x1 = Canvas.GetLeft(target) + target_position.X + step_x;
             var y1 = Canvas.GetTop(target) + target_position.Y + step_y;
             Rect r1 = new Rect(x1, y1, target.Width - 1, target.Height - 1);
             var x2 = Canvas.GetLeft(target2)+ target2_position.X;
             var y2 = Canvas.GetTop(target2)+ target2_position.Y;
             Rect r2 = new Rect(x2, y2, target2.Width - 1, target2.Height - 1);
             if (r1.IntersectsWith(r2)) return true;
             else return false;
         }
        
         bool CheckBound(Image target, TranslateTransform target_position, double step_x, double step_y)
         {

             var x = Canvas.GetLeft(target) + target_position.X + step_x;
             var y = Canvas.GetTop(target) + target_position.Y + step_y;
             if(x<=775&&x>=0&&y<=375&&y>=0) return true;
             else return false;
         }
      
        void NPCMove(TranslateTransform target_position,Double X,Double Y)
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

        private void Genius_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            this.Genius.Focus();
        }

        private void Genius_KeyUp(object sender, KeyEventArgs e)
        {
            CheckKill();
            CheckAim();
            CheckWin();
            if (Z[0] == true && Saving.Count != 0)
                Saving.Remove(Saving.Last());
            Z[0] = false; 
        }

        void save()
        {
            positiondata data = new positiondata();
            data.person.x = this.aa.X;
            data.person.y = this.aa.Y;
            int i;
            for (i = 0; i < 3; i++)
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
            if (Saving.Count != 0)
            {
                double x, y;
                x = Saving.Last().person.x - this.aa.X;
                y = Saving.Last().person.y - this.aa.Y;
                NPCMove(this.aa, x, y);
                int i;
                for (i = 0; i < 3; i++)
                {
                    TranslateTransform d = FindName(box_position[i]) as TranslateTransform;
                    x = Saving.Last().save_box[i].x - d.X;
                    y = Saving.Last().save_box[i].y - d.Y;
                    NPCMove(d, x, y);
                }
                BitmapImage imagetemp = new BitmapImage(new Uri(@"MySource/正向站立.png", UriKind.Relative));
                this.Genius.Source = imagetemp;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double x, y;
            x = 0 - this.aa.X;
            y = 0 - this.aa.Y;
            NPCMove(this.aa, x, y);
            int i;
            for (i = 0; i < 3; i++)
            {
                TranslateTransform d = FindName(box_position[i]) as TranslateTransform;
                x = 0 - d.X;
                y = 0 - d.Y;
                NPCMove(d, x, y);
            }
            BitmapImage imagetemp = new BitmapImage(new Uri(@"MySource/正向站立.png", UriKind.Relative));
            this.Genius.Source = imagetemp;
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
    }
}
