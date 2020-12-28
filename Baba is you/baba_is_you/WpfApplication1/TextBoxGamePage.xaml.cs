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
    public partial class TextBoxGamePage : Page
    {
        bool ISWIN = new bool();
        bool[] Z = new bool[1];
        List<positiondata> Saving = new List<positiondata>();

        my_positon hero;
        my_positon aim;
        my_positon kill;
        my_positon[] rock = new my_positon[3];        

        public struct my_positon
        {
            public int initial;
            public int x;
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
                MessageBox.Show("You win");
                NavigationService.Navigate(new Uri("HomePage.xaml", UriKind.Relative));
            }
            return true;
        }
        public TextBoxGamePage()
        {
            InitializeComponent();
            MainMap.Text = "################################\n################################\nBSU##########################FSN\n################################\nKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKK\n################################\n################################\n####################Y###########\n###E####X###########Y#######H###\n####################Y###########\n################################\nKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKK\n################################\nAST##########################RSU\n#############################VSD\n################################";
            hero.x = 0;
            hero.initial = 272; //(8, 8)
            aim.x = 0;
            aim.initial = 292; //(8, 28)
            kill.x = 0;
            kill.initial = 267; //(8, 3)
            rock[0].x = 0;
            rock[0].initial = 251; //(7, 20)
            rock[1].x = 0;
            rock[1].initial = 284; //(8, 20)
            rock[2].x = 0;
            rock[2].initial = 317; //(9, 20)
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("HomePage.xaml", UriKind.Relative));
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainMap.Text = "################################\n################################\nBSU##########################FSN\n################################\nKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKK\n################################\n################################\n####################Y###########\n###E####X###########Y#######H###\n####################Y###########\n################################\nKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKK\n################################\nAST##########################RSU\n#############################VSD\n################################";
            hero.x = 0;
            hero.initial = 272; //(8, 8)
            aim.x = 0;
            aim.initial = 292; //(8, 28)
            kill.x = 0;
            kill.initial = 267; //(8, 3)
            rock[0].x = 0;
            rock[0].initial = 251; //(7, 20)
            rock[1].x = 0;
            rock[1].initial = 284; //(8, 20)
            rock[2].x = 0;
            rock[2].initial = 317; //(9, 20)
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

        private void Button_Click_Up(object sender, RoutedEventArgs e)
        {
            save();
            if (!CheckStone(hero, 0, -33) && CheckBound(hero, 0, -33) && !CheckBox(hero, 0, -33))
            {
                NPCMove(hero, 0, -33);
            }
            CheckKill();
            CheckAim();
            CheckWin();
        }

        private void Button_Click_Down(object sender, RoutedEventArgs e)
        {
            save();
            if (!CheckStone(hero, 0, 33) && CheckBound(hero, 0, 33) && !CheckBox(hero, 0, 33))
            {
                NPCMove(hero, 0, 33);
            }
            CheckKill();
            CheckAim();
            CheckWin();
        }

        private void Button_Click_Left(object sender, RoutedEventArgs e)
        {
            save();
            if (!CheckStone(hero, -1, 0) && CheckBound(hero, -1, 0) && !CheckBox(hero, -1, 0))
            {
                NPCMove(hero, -1, 0);
            }
            CheckKill();
            CheckAim();
            CheckWin();
        }

        private void Button_Click_Right(object sender, RoutedEventArgs e)
        {
            save();
            if (!CheckStone(hero, 1, 0) && CheckBound(hero, 1, 0) && !CheckBox(hero, 1, 0))
            {
                NPCMove(hero, 1, 0);
            }
            CheckKill();
            CheckAim();
            CheckWin();
        }

        private void Button_Click_Undo(object sender, RoutedEventArgs e)
        {
            Z[0] = true;
            back();
            if (Saving.Count != 0)
                Saving.Remove(Saving.Last());
            Z[0] = false;
        }

        bool CheckBox(my_positon target, int step_x, int step_y)
        {
            int i;
            for (i = 0; i < 3; i++)
            {
                my_positon d = rock[i];
                if (BoxCollision(target, step_x, step_y, d))
                {
                    if (CheckStone(d, step_x, step_y)) return true;
                    if (!CheckBound(d, step_x, step_y)) return true;
                    if (BoxCheckBox(d, step_x, step_y)) return true;
                    if (!BoxCheckBox(d, step_x, step_y)) NPCMove(rock[i], step_x, step_y);
                }
            }
            return false;
        }

        void CheckAim()
        {
            my_positon c = aim;
            ISWIN = false;

            my_positon d = hero;

            if (AimCollision(c, d)) ISWIN = true;
        }

        void CheckKill()
        {
            my_positon d = kill;
            my_positon e = hero;

            if (AimCollision(d, e))
            {
                MessageBox.Show("You lose");
                NavigationService.Navigate(new Uri("HomePage.xaml", UriKind.Relative));
            }
        }

        bool AimCollision(my_positon target, my_positon target2)
        {
            var x1 = target2.initial + target2.x;
            var x2 = target.initial + target.x;

            if (x1 == x2) return true;
            else return false;
        }

        bool BoxCheckBox(my_positon target, int step_x, int step_y)
        {
            int i;
            for (i = 0; i < 3; i++)
            {
                my_positon b = rock[i];
                int c = rock[i].initial + rock[i].x;
                int d = target.initial + target.x;
                 
                if (c != d)
                {
                    if (BoxCollision(target, step_x, step_y, b))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        bool CheckStone(my_positon target, int step_x, int step_y)
        {
            if (StoneCollision(target, step_x, step_y))
            {
                return true;
            }
            return false;
        }

        bool StoneCollision(my_positon target, int step_x, int step_y)
        {
            var x = target.initial + target.x + step_x + step_y;
            //132 --- 163 and 363 --- 394
            for (int i = 132; i < 164; i++)
            {
                if (x == i) return true;
            }
            for (int i = 363; i < 395; i++)
            {
                if (x == i) return true;
            }
            return false;
        }

        bool BoxCollision(my_positon target, int step_x, int step_y, my_positon target2)
        {
            var x1 = target.initial + target.x + step_x + step_y;
            var x2 = target2.initial + target2.x;
            if (x1 == x2) return true;
            else return false;
        }

        bool CheckBound(my_positon target, int step_x, int step_y)
        {
            var x = target.initial + target.x + step_x + step_y;
            var y = 1;
            if (x < 32) y = 1;
            else y = (x+1) % 33;
            if (x <= 527 && x >= 0 && y != 0) return true;
            else return false;
        }

        void NPCMove(my_positon target, int step_x, int step_y)
        {
            if (step_x + step_y != 0)
            {
                var x = target.initial + target.x + step_x + step_y;

                if (MainMap.Text[x] == '#')
                {
                    MainMap.Text = MainMap.Text.Remove(x, 1);
                    if (target.initial == hero.initial) MainMap.Text = MainMap.Text.Insert(x, "X");
                    else MainMap.Text = MainMap.Text.Insert(x, "Y");
                }
                if (target.initial == hero.initial) hero.x += step_x + step_y;
                else
                {
                    for (int i = 0; i < 3; i++)
                    {
                        if (target.initial == rock[i].initial)
                            rock[i].x += step_x + step_y;
                    }
                }

                if (MainMap.Text[target.x + target.initial] != 'H' && MainMap.Text[target.x + target.initial] != 'E')
                {
                    MainMap.Text = MainMap.Text.Remove(target.x + target.initial, 1);
                    MainMap.Text = MainMap.Text.Insert(target.x + target.initial, "#");
                }
            }
        }

        void save()
        {
            positiondata data = new positiondata();
            data.person.initial = hero.initial;
            data.person.x = hero.x;
            int i;
            for (i = 0; i < 3; i++)
            {
                my_positon boxposition = new my_positon();
                boxposition.x = rock[i].x;
                boxposition.initial = rock[i].initial;
                data.save_box.Add(boxposition);
            }
            Saving.Add(data);
        }

        void back()
        {
            if (Saving.Count != 0)
            {
                int x;
                x = Saving.Last().person.x - hero.x;
                NPCMove(hero, x, 0);
                for (int i = 0; i < 3; i++)
                {
                    x = Saving.Last().save_box[i].x - rock[i].x;
                    NPCMove(rock[i], x, 0);
                }
            }
        }

    }

}
