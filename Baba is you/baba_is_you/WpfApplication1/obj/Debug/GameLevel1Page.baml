   M S B A M L   `   `   `  ����  Ballade$    WpfApplication1.GameLevel1Page   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   -   5        $��level1��5   �     N� 
Background  �	#FF2D2D2D$y�Visible=�64   $	��900��6I   $	��530��6X   $	��900��6h   $	��530��6w   .��5      � .+�5	   
   �� ���	#FF1E1E1E$
��Left=�6%   $��30��6@   $	��Top=�6L   $	��870��6d   $��2��6p   �� 5
   
   -   5        $�� ��5
      $��Right=�6   $	��Top=�68   $��30��5      $��30��6    $��0,0,-1,0q�6p   $��1��6�   ��6,   Z� ��6C   Z� ��5      �� 5       �� ImageSource$ MySource/exit.png��6   5      �� 5   
   $
��Left=�6   $��10,3,0,0q�6+   $	��Top=�6=   $��22��6U   $��MySource/icon.png��6a   $��19��6|   �� 5   
   $��Fake Baba is You��6   $
��Left=�6+   $��40,0,0,0q�6F   $	��Top=�6X   
������ 
�������$3��-/SokobanGame;component/Resources/fonts/#Peepo)�6�   $��24��6�   $��98��6�   �� 5   
   -   5        $�� ��5      $
��Left=�6   $��25��67   $��
825,35,0,0q�6C   $	��Top=�6W   $��75��6o   $��MySource/font/#Peepo)�6�   ��6�   Z� ��6�   Z� ��5      �� 5      $ MySource/goback.png��6    j� Stretch$ Uniform=�6?   5      �� 5   
   -   5        $�� ��5      $
��Left=�6   $��25��67   $��0,35,0,0q�6C   $	��Top=�6U   $��75��6m   $��MySource/font/#Peepo)�6�   ��6�   Z� ��6�   Z� ��5      �� 5      $ MySource/restart.png��6   $ Uniform=�6@   5      � 5   
   -   5         �Name$ MainMap��5      $��50,65q�6!    � RowDefinitions 5      �� 5      -   5         ��Name$
 Row0��5       $	��25* �6.   �� 5      -   5        $
 Row1��5       $	��25* �6.   �� 5       -   5        $
 Row2��5        $	��25* �6.   �� 5!      -	   5        $
 Row3��5!       $	��25* �6.   �� 5"      -
   5        $
 Row4��5"       $	��25* �6.   �� 5#      -   5        $
 Row5��5#       $	��25* �6.   �� 5$      -   5        $
 Row6��5$       $	��25* �6.   �� 5%      -   5        $
 Row7��5%       $	��25* �6.   �� 5&      -   5        $
 Row8��5&       $	��25* �6.   �� 5'      -   5        $
 Row9��5'       $	��25* �6.   �� 5(      -   5        $ Row10��5(       $	��25* �6/   �� 5)      -   5        $ Row11��5)       $	��25* �6/   �� 5*      -   5        $ Row12��5*       $	��25* �6/   �� 5+      -   5        $ Row13��5+       $	��25* �6/   �� 5,      -   5        $ Row14��5,       $	��25* �6/   �� 5-      -   5        $ Row15��5-       $	��25* �6/    � ColumnDefinitions 50      �� 51      -   5         ��Name$ Column0��51   #   $	��25* �64   �� 52      -   5        $ Column1��52   #   $	��25* �64   �� 53      -   5        $ Column2��53   #   $	��25* �64   �� 54      -   5        $ Column3��54   #   $	��25* �64   �� 55      -   5        $ Column4��55   #   $	��25* �64   �� 56      -   5        $ Column5��56   #   $	��25* �64   �� 57      -   5        $ Column6��57   #   $	��25* �64   �� 58      -   5        $ Column7��58   #   $	��25* �64   �� 59      -   5        $ Column8��59   #   $	��25* �64   �� 5:      -   5        $ Column9��5:   #   $	��25* �64   �� 5;      -    5        $ Column10��5;   #   $	��25* �65   �� 5<      -!   5        $ Column11��5<   #   $	��25* �65   �� 5=      -"   5        $ Column12��5=   #   $	��25* �65   �� 5>      -#   5        $ Column13��5>   #   $	��25* �65   �� 5?      -$   5        $ Column14��5?   #   $	��25* �65   �� 5@      -%   5        $ Column15��5@   #   $	��25* �65   �� 5A      -&   5        $ Column16��5A   #   $	��25* �65   �� 5B      -'   5        $ Column17��5B   #   $	��25* �65   �� 5C      -(   5        $ Column18��5C   #   $	��25* �65   �� 5D      -)   5        $ Column19��5D   #   $	��25* �65   �� 5E      -*   5        $ Column20��5E   #   $	��25* �65   �� 5F      -+   5        $ Column21��5F   #   $	��25* �65   �� 5G      -,   5        $ Column22��5G   #   $	��25* �65   �� 5H      --   5        $ Column23��5H   #   $	��25* �65   �� 5I      -.   5        $ Column24��5I   #   $	��25* �65   �� 5J      -/   5        $ Column25��5J   #   $	��25* �65   �� 5K      -0   5        $ Column26��5K   #   $	��25* �65   �� 5L      -1   5        $ Column27��5L   #   $	��25* �65   �� 5M      -2   5        $ Column28��5M   #   $	��25* �65   �� 5N      -3   5        $ Column29��5N   #   $	��25* �65   �� 5O      -4   5        $ Column30��5O   #   $	��25* �65   �� 5P      -5   5        $ Column31��5P   #   $	��25* �65   .+�5S      �� -6   5         ��Name$ Canvas1��5S      ���	#FF2D2D2D$��32��6=   $��16��6R   .+�5T      �� -7   5        	 ��Name$	 
background��5T      $)��#MySource/baba is you/background.jpg��6,   $��UniformToFill=�6Y   $	��400��6q   

 �� Top$
 0��6~   $	��800��6�    �� Left$ 0��6�   �� 5U      -8   5        $	 Genius��5U   <   $	 200��6   $	
 200��6*   $��25��6L   $��25��6X   $
��Auto=�6~   $��MySource/正向站立.png��6�   |�.  J� IsHitTestVisible .  � FocusVisualStyle 6!  Z� z�5V      T� 5W      -9   5        aa�� T� X$ 0Q�5W   9    T� Y$ 0Q�6?   5Y      �� 5Z      -:   5        $
	 undo��5Z      $#��MySource/baba is you/Undo.png��6&   $��Uniform=�6N   $��50��6`   $
 25��6l   $	��100��6|   $	 350��6�   �� 5[      -;   5        $
	 move��5[      $#��MySource/baba is you/move.png��6&   $��Uniform=�6N   $��50��6`   $	
 325��6l   $	��100��6}   $	 350��6�   �� 5\      -<   5        $		 is1��5\      $!��MySource/baba is you/is.jpg��6%   $��Uniform=�6K   $��25��6]   $
 50��6i   $��25��6y   $ 25��6�   �� 5]      -=   5        $
	 baba��5]      $#��MySource/baba is you/baba.jpg��6&   $��Uniform=�6N   $��25��6`   $
 50��6l   $��25��6|   $ 0��6�   �� 5^      ->   5        $		 you��5^      $"��MySource/baba is you/you.JPG��6%   $��Uniform=�6L   $��25��6^   $
 50��6j   $��25��6z   $ 50��6�   �� 5_      -?   5        $
	 flag��5_      $#��MySource/baba is you/flag.JPG��6&   $��Uniform=�6N   $��25��6`   $
 50��6l   $��25��6|   $	 725��6�   �� 5`      -@   5        $		 is2��5`      $!��MySource/baba is you/is.jpg��6%   $��Uniform=�6K   $��25��6]   $
 50��6i   $��25��6y   $	 750��6�   �� 5a      -A   5        $		 win��5a      $"��MySource/baba is you/win.JPG��6%   $��Uniform=�6L   $��25��6^   $
 50��6j   $��25��6z   $	 775��6�   �� 5b      -B   5        $	 flag_pic��5b      $'��!MySource/baba is you/flag_pic.JPG��6*   $��Uniform=�6V   $��25��6h   $	
 200��6t   $��25��6�   $	 700��6�   �� 5c      -C   5        $
	 wall��5c      $#��MySource/baba is you/wall.jpg��6&   $��Uniform=�6N   $��25��6`   $	
 325��6l   $��25��6}   $ 0��6�   �� 5d      -D   5        $		 is3��5d      $!��MySource/baba is you/is.jpg��6%   $��Uniform=�6K   $��25��6]   $	
 325��6i   $��25��6z   $ 25��6�   �� 5e      -E   5        $
	 stop��5e      $#��MySource/baba is you/stop.png��6&   $��Uniform=�6N   $��25��6`   $	
 325��6l   $��25��6}   $ 50��6�   �� 5f      -F   5        $
	 rock��5f      $#��MySource/baba is you/rock.JPG��6&   $��Uniform=�6N   $��25��6`   $	
 325��6l   $��25��6}   $	 725��6�   �� 5g      -G   5        $		 is4��5g      $!��MySource/baba is you/is.jpg��6%   $��Uniform=�6K   $��25��6]   $	
 325��6i   $��25��6z   $	 750��6�   �� 5h      -H   5        $
	 push��5h      $#��MySource/baba is you/push.JPG��6&   $��Uniform=�6N   $��25��6`   $	
 325��6l   $��25��6}   $	 775��6�   �� 5i      -I   5        $	 skull��5i      $$��MySource/baba is you/skull.png��6'   $��Uniform=�6P   $��25��6b   $	
 350��6n   $��25��6   $	 725��6�   �� 5j      -J   5        $		 is5��5j      $!��MySource/baba is you/is.jpg��6%   $��Uniform=�6K   $��25��6]   $	
 350��6i   $��25��6z   $	 750��6�   �� 5k      -K   5        $	 defeat��5k      $%��MySource/baba is you/defeat.png��6(   $��Uniform=�6R   $��25��6d   $	
 350��6p   $��25��6�   $	 775��6�   �� 5l      -L   5        $	 	skull_pic��5l      $(��"MySource/baba is you/skull_pic.png��6+   $��Uniform=�6X   $��25��6j   $	
 200��6v   $��25��6�   $ 75��6�   �� 5m      -M   5        $	 wall_1��5m      $*��$MySource/baba is you/wall_pic_up.jpg��6(   $��Uniform=�6W   $��25��6i   $	
 100��6u   $��25��6�   $ 0��6�   �� 5n      -N   5        $	 wall_2��5n      $*��$MySource/baba is you/wall_pic_up.jpg��6(   $��Uniform=�6W   $��25��6i   $	
 100��6u   $��25��6�   $ 25��6�   �� 5o      -O   5        $	 wall_3��5o      $*��$MySource/baba is you/wall_pic_up.jpg��6(   $��Uniform=�6W   $��25��6i   $	
 100��6u   $��25��6�   $ 50��6�   �� 5p      -P   5        $	 wall_4��5p      $*��$MySource/baba is you/wall_pic_up.jpg��6(   $��Uniform=�6W   $��25��6i   $	
 100��6u   $��25��6�   $ 75��6�   �� 5q      -Q   5        $	 wall_5��5q      $*��$MySource/baba is you/wall_pic_up.jpg��6(   $��Uniform=�6W   $��25��6i   $	
 100��6u   $��25��6�   $	 100��6�   �� 5r      -R   5        $	 wall_6��5r      $*��$MySource/baba is you/wall_pic_up.jpg��6(   $��Uniform=�6W   $��25��6i   $	
 100��6u   $��25��6�   $	 125��6�   �� 5s      -S   5        $	 wall_7��5s      $*��$MySource/baba is you/wall_pic_up.jpg��6(   $��Uniform=�6W   $��25��6i   $	
 100��6u   $��25��6�   $	 150��6�   �� 5t      -T   5        $	 wall_8��5t      $*��$MySource/baba is you/wall_pic_up.jpg��6(   $��Uniform=�6W   $��25��6i   $	
 100��6u   $��25��6�   $	 175��6�   �� 5u      -U   5        $	 wall_9��5u      $*��$MySource/baba is you/wall_pic_up.jpg��6(   $��Uniform=�6W   $��25��6i   $	
 100��6u   $��25��6�   $	 200��6�   �� 5v      -V   5        $	 wall_10��5v      $*��$MySource/baba is you/wall_pic_up.jpg��6)   $��Uniform=�6X   $��25��6j   $	
 100��6v   $��25��6�   $	 225��6�   �� 5w      -W   5        $	 wall_11��5w      $*��$MySource/baba is you/wall_pic_up.jpg��6)   $��Uniform=�6X   $��25��6j   $	
 100��6v   $��25��6�   $	 250��6�   �� 5x      -X   5        $	 wall_12��5x      $*��$MySource/baba is you/wall_pic_up.jpg��6)   $��Uniform=�6X   $��25��6j   $	
 100��6v   $��25��6�   $	 275��6�   �� 5y      -Y   5        $	 wall_13��5y      $*��$MySource/baba is you/wall_pic_up.jpg��6)   $��Uniform=�6X   $��25��6j   $	
 100��6v   $��25��6�   $	 300��6�   �� 5z      -Z   5        $	 wall_14��5z      $*��$MySource/baba is you/wall_pic_up.jpg��6)   $��Uniform=�6X   $��25��6j   $	
 100��6v   $��25��6�   $	 325��6�   �� 5{      -[   5        $	 wall_15��5{      $*��$MySource/baba is you/wall_pic_up.jpg��6)   $��Uniform=�6X   $��25��6j   $	
 100��6v   $��25��6�   $	 350��6�   �� 5|      -\   5        $	 wall_16��5|      $*��$MySource/baba is you/wall_pic_up.jpg��6)   $��Uniform=�6X   $��25��6j   $	
 100��6v   $��25��6�   $	 375��6�   �� 5}      -]   5        $	 wall_17��5}      $*��$MySource/baba is you/wall_pic_up.jpg��6)   $��Uniform=�6X   $��25��6j   $	
 100��6v   $��25��6�   $	 400��6�   �� 5~      -^   5        $	 wall_18��5~      $*��$MySource/baba is you/wall_pic_up.jpg��6)   $��Uniform=�6X   $��25��6j   $	
 100��6v   $��25��6�   $	 425��6�   �� 5      -_   5        $	 wall_19��5      $*��$MySource/baba is you/wall_pic_up.jpg��6)   $��Uniform=�6X   $��25��6j   $	
 100��6v   $��25��6�   $	 450��6�   �� 5�      -`   5        $	 wall_20��5�      $*��$MySource/baba is you/wall_pic_up.jpg��6)   $��Uniform=�6X   $��25��6j   $	
 100��6v   $��25��6�   $	 475��6�   �� 5�      -a   5        $	 wall_21��5�      $*��$MySource/baba is you/wall_pic_up.jpg��6)   $��Uniform=�6X   $��25��6j   $	
 100��6v   $��25��6�   $	 500��6�   �� 5�      -b   5        $	 wall_22��5�      $*��$MySource/baba is you/wall_pic_up.jpg��6)   $��Uniform=�6X   $��25��6j   $	
 100��6v   $��25��6�   $	 525��6�   �� 5�      -c   5        $	 wall_23��5�      $*��$MySource/baba is you/wall_pic_up.jpg��6)   $��Uniform=�6X   $��25��6j   $	
 100��6v   $��25��6�   $	 550��6�   �� 5�      -d   5        $	 wall_24��5�      $*��$MySource/baba is you/wall_pic_up.jpg��6)   $��Uniform=�6X   $��25��6j   $	
 100��6v   $��25��6�   $	 575��6�   �� 5�      -e   5        $	 wall_25��5�      $*��$MySource/baba is you/wall_pic_up.jpg��6)   $��Uniform=�6X   $��25��6j   $	
 100��6v   $��25��6�   $	 600��6�   �� 5�      -f   5        $	 wall_26��5�      $*��$MySource/baba is you/wall_pic_up.jpg��6)   $��Uniform=�6X   $��25��6j   $	
 100��6v   $��25��6�   $	 625��6�   �� 5�      -g   5        $	 wall_27��5�      $*��$MySource/baba is you/wall_pic_up.jpg��6)   $��Uniform=�6X   $��25��6j   $	
 100��6v   $��25��6�   $	 650��6�   �� 5�      -h   5        $	 wall_28��5�      $*��$MySource/baba is you/wall_pic_up.jpg��6)   $��Uniform=�6X   $��25��6j   $	
 100��6v   $��25��6�   $	 675��6�   �� 5�      -i   5        $	 wall_29��5�      $*��$MySource/baba is you/wall_pic_up.jpg��6)   $��Uniform=�6X   $��25��6j   $	
 100��6v   $��25��6�   $	 700��6�   �� 5�      -j   5        $	 wall_30��5�      $*��$MySource/baba is you/wall_pic_up.jpg��6)   $��Uniform=�6X   $��25��6j   $	
 100��6v   $��25��6�   $	 725��6�   �� 5�      -k   5        $	 wall_31��5�      $*��$MySource/baba is you/wall_pic_up.jpg��6)   $��Uniform=�6X   $��25��6j   $	
 100��6v   $��25��6�   $	 750��6�   �� 5�      -l   5        $	 wall_32��5�      $*��$MySource/baba is you/wall_pic_up.jpg��6)   $��Uniform=�6X   $��25��6j   $	
 100��6v   $��25��6�   $	 775��6�   �� 5�      -m   5        $	 wall_33��5�      $,��&MySource/baba is you/wall_pic_down.jpg��6)   $��Uniform=�6Z   $��25��6l   $	
 275��6x   $��25��6�   $ 0��6�   �� 5�      -n   5        $	 wall_34��5�      $,��&MySource/baba is you/wall_pic_down.jpg��6)   $��Uniform=�6Z   $��25��6l   $	
 275��6x   $��25��6�   $ 25��6�   �� 5�      -o   5        $	 wall_35��5�      $,��&MySource/baba is you/wall_pic_down.jpg��6)   $��Uniform=�6Z   $��25��6l   $	
 275��6x   $��25��6�   $ 50��6�   �� 5�      -p   5        $	 wall_36��5�      $,��&MySource/baba is you/wall_pic_down.jpg��6)   $��Uniform=�6Z   $��25��6l   $	
 275��6x   $��25��6�   $ 75��6�   �� 5�      -q   5        $	 wall_37��5�      $,��&MySource/baba is you/wall_pic_down.jpg��6)   $��Uniform=�6Z   $��25��6l   $	
 275��6x   $��25��6�   $	 100��6�   �� 5�      -r   5        $	 wall_38��5�      $,��&MySource/baba is you/wall_pic_down.jpg��6)   $��Uniform=�6Z   $��25��6l   $	
 275��6x   $��25��6�   $	 125��6�   �� 5�      -s   5        $	 wall_39��5�      $,��&MySource/baba is you/wall_pic_down.jpg��6)   $��Uniform=�6Z   $��25��6l   $	
 275��6x   $��25��6�   $	 150��6�   �� 5�      -t   5        $	 wall_40��5�      $,��&MySource/baba is you/wall_pic_down.jpg��6)   $��Uniform=�6Z   $��25��6l   $	
 275��6x   $��25��6�   $	 175��6�   �� 5�      -u   5        $	 wall_41��5�      $,��&MySource/baba is you/wall_pic_down.jpg��6)   $��Uniform=�6Z   $��25��6l   $	
 275��6x   $��25��6�   $	 200��6�   �� 5�      -v   5        $	 wall_42��5�      $,��&MySource/baba is you/wall_pic_down.jpg��6)   $��Uniform=�6Z   $��25��6l   $	
 275��6x   $��25��6�   $	 225��6�   �� 5�      -w   5        $	 wall_43��5�      $,��&MySource/baba is you/wall_pic_down.jpg��6)   $��Uniform=�6Z   $��25��6l   $	
 275��6x   $��25��6�   $	 250��6�   �� 5�      -x   5        $	 wall_44��5�      $,��&MySource/baba is you/wall_pic_down.jpg��6)   $��Uniform=�6Z   $��25��6l   $	
 275��6x   $��25��6�   $	 275��6�   �� 5�      -y   5        $	 wall_45��5�      $,��&MySource/baba is you/wall_pic_down.jpg��6)   $��Uniform=�6Z   $��25��6l   $	
 275��6x   $��25��6�   $	 300��6�   �� 5�      -z   5        $	 wall_46��5�      $,��&MySource/baba is you/wall_pic_down.jpg��6)   $��Uniform=�6Z   $��25��6l   $	
 275��6x   $��25��6�   $	 325��6�   �� 5�      -{   5        $	 wall_47��5�      $,��&MySource/baba is you/wall_pic_down.jpg��6)   $��Uniform=�6Z   $��25��6l   $	
 275��6x   $��25��6�   $	 350��6�   �� 5�      -|   5        $	 wall_48��5�      $,��&MySource/baba is you/wall_pic_down.jpg��6)   $��Uniform=�6Z   $��25��6l   $	
 275��6x   $��25��6�   $	 375��6�   �� 5�      -}   5        $	 wall_49��5�      $,��&MySource/baba is you/wall_pic_down.jpg��6)   $��Uniform=�6Z   $��25��6l   $	
 275��6x   $��25��6�   $	 400��6�   �� 5�      -~   5        $	 wall_50��5�      $,��&MySource/baba is you/wall_pic_down.jpg��6)   $��Uniform=�6Z   $��25��6l   $	
 275��6x   $��25��6�   $	 425��6�   �� 5�      -   5        $	 wall_51��5�      $,��&MySource/baba is you/wall_pic_down.jpg��6)   $��Uniform=�6Z   $��25��6l   $	
 275��6x   $��25��6�   $	 450��6�   �� 5�      -�   5        $	 wall_52��5�      $,��&MySource/baba is you/wall_pic_down.jpg��6)   $��Uniform=�6Z   $��25��6l   $	
 275��6x   $��25��6�   $	 475��6�   �� 5�      -�   5        $	 wall_53��5�      $,��&MySource/baba is you/wall_pic_down.jpg��6)   $��Uniform=�6Z   $��25��6l   $	
 275��6x   $��25��6�   $	 500��6�   �� 5�      -�   5        $	 wall_54��5�      $,��&MySource/baba is you/wall_pic_down.jpg��6)   $��Uniform=�6Z   $��25��6l   $	
 275��6x   $��25��6�   $	 525��6�   �� 5�      -�   5        $	 wall_55��5�      $,��&MySource/baba is you/wall_pic_down.jpg��6)   $��Uniform=�6Z   $��25��6l   $	
 275��6x   $��25��6�   $	 550��6�   �� 5�      -�   5        $	 wall_56��5�      $,��&MySource/baba is you/wall_pic_down.jpg��6)   $��Uniform=�6Z   $��25��6l   $	
 275��6x   $��25��6�   $	 575��6�   �� 5�      -�   5        $	 wall_57��5�      $,��&MySource/baba is you/wall_pic_down.jpg��6)   $��Uniform=�6Z   $��25��6l   $	
 275��6x   $��25��6�   $	 600��6�   �� 5�      -�   5        $	 wall_58��5�      $,��&MySource/baba is you/wall_pic_down.jpg��6)   $��Uniform=�6Z   $��25��6l   $	
 275��6x   $��25��6�   $	 625��6�   �� 5�      -�   5        $	 wall_59��5�      $,��&MySource/baba is you/wall_pic_down.jpg��6)   $��Uniform=�6Z   $��25��6l   $	
 275��6x   $��25��6�   $	 650��6�   �� 5�      -�   5        $	 wall_60��5�      $,��&MySource/baba is you/wall_pic_down.jpg��6)   $��Uniform=�6Z   $��25��6l   $	
 275��6x   $��25��6�   $	 675��6�   �� 5�      -�   5        $	 wall_61��5�      $,��&MySource/baba is you/wall_pic_down.jpg��6)   $��Uniform=�6Z   $��25��6l   $	
 275��6x   $��25��6�   $	 700��6�   �� 5�      -�   5        $	 wall_62��5�      $,��&MySource/baba is you/wall_pic_down.jpg��6)   $��Uniform=�6Z   $��25��6l   $	
 275��6x   $��25��6�   $	 725��6�   �� 5�      -�   5        $	 wall_63��5�      $,��&MySource/baba is you/wall_pic_down.jpg��6)   $��Uniform=�6Z   $��25��6l   $	
 275��6x   $��25��6�   $	 750��6�   �� 5�      -�   5        $	 wall_64��5�      $,��&MySource/baba is you/wall_pic_down.jpg��6)   $��Uniform=�6Z   $��25��6l   $	
 275��6x   $��25��6�   $	 775��6�   �� 5�      -�   5        $	 rock_1��5�      $'��!MySource/baba is you/rock_pic.JPG��6(   $��Uniform=�6T   $��25��6f   $	
 200��6r   $��25��6�   $	 500��6�   z�5�      T� 5�      -�   5        b1��$ 0Q�5�   9   $ 0Q�6?   5�      �� 5�      -�   5        $	 rock_2��5�      $'��!MySource/baba is you/rock_pic.JPG��6(   $��Uniform=�6T   $��25��6f   $	
 175��6r   $��25��6�   $	 500��6�   z�5�      T� 5�      -�   5        b2��$ 0Q�5�   9   $ 0Q�6?   5�      �� 5�      -�   5        $	 rock_3��5�      $'��!MySource/baba is you/rock_pic.JPG��6(   $��Uniform=�6T   $��25��6f   $	
 225��6r   $��25��6�   $	 500��6�   z�5�      T� 5�      -�   5        b3��$ 0Q�5�   9   $ 0Q�6?   5�      5�      5�      5�       � Triggers 5�      :� 5�   
    :� RoutedEvent$ Loaded��6   [�5�      �� 5�      .��5�      �� .��5�      W�  �� TargetProperty$ Opacity�6*   	 W� To$ 1X�6N    g� Duration$ 0:0:0.5D�6U    �� 
TargetName$ level1��6h    W� From$ 0X�6�   5�      5�      5�      5�      5�      