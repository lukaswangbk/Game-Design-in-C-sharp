   M S B A M L   `   `   `  ����   Ballade$    WpfApplication1.GameLevel1Page   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     -   $��level1��  N� 
Background  �	#FF2D2D2D$y�Visible=�$	��900��$	��530��$	��900��$	��530��.��� .+��� ���	#FF1E1E1E$
��Left=�$��30��$	��Top=�$	��870��$��2���� -   $�� ��$��Right=�$	��Top=�$��30��$��30��$��0,0,-1,0q�$��1����Z� ��Z� ����  �� ImageSource$ MySource/exit.png���� $
��Left=�$��10,3,0,0q�$	��Top=�$��22��$��MySource/icon.png��$��19���� $��Fake Baba is You��$
��Left=�$��40,0,0,0q�$	��Top=�
������ 
�������$3��-/SokobanGame;component/Resources/fonts/#Peepo)�$��24��$��98���� -   $�� ��$
��Left=�$��25��$��
825,35,0,0q�$	��Top=�$��75��$��MySource/font/#Peepo)���Z� ��Z� ���� $ MySource/goback.png�� j� Stretch$ Uniform=��� -   $�� ��$
��Left=�$��25��$��0,35,0,0q�$	��Top=�$��75��$��MySource/font/#Peepo)���Z� ��Z� ���� $ MySource/restart.png��$ Uniform=�� -    �Name$ MainMap��$��50,65q� � RowDefinitions �� -    ��Name$
 Row0��$	��25* ��� -   $
 Row1��$	��25* ��� -   $
 Row2��$	��25* ��� -	   $
 Row3��$	��25* ��� -
   $
 Row4��$	��25* ��� -   $
 Row5��$	��25* ��� -   $
 Row6��$	��25* ��� -   $
 Row7��$	��25* ��� -   $
 Row8��$	��25* ��� -   $
 Row9��$	��25* ��� -   $ Row10��$	��25* ��� -   $ Row11��$	��25* ��� -   $ Row12��$	��25* ��� -   $ Row13��$	��25* ��� -   $ Row14��$	��25* ��� -   $ Row15��$	��25* � � ColumnDefinitions �� -    ��Name$ Column0��$	��25* ��� -   $ Column1��$	��25* ��� -   $ Column2��$	��25* ��� -   $ Column3��$	��25* ��� -   $ Column4��$	��25* ��� -   $ Column5��$	��25* ��� -   $ Column6��$	��25* ��� -   $ Column7��$	��25* ��� -   $ Column8��$	��25* ��� -   $ Column9��$	��25* ��� -    $ Column10��$	��25* ��� -!   $ Column11��$	��25* ��� -"   $ Column12��$	��25* ��� -#   $ Column13��$	��25* ��� -$   $ Column14��$	��25* ��� -%   $ Column15��$	��25* ��� -&   $ Column16��$	��25* ��� -'   $ Column17��$	��25* ��� -(   $ Column18��$	��25* ��� -)   $ Column19��$	��25* ��� -*   $ Column20��$	��25* ��� -+   $ Column21��$	��25* ��� -,   $ Column22��$	��25* ��� --   $ Column23��$	��25* ��� -.   $ Column24��$	��25* ��� -/   $ Column25��$	��25* ��� -0   $ Column26��$	��25* ��� -1   $ Column27��$	��25* ��� -2   $ Column28��$	��25* ��� -3   $ Column29��$	��25* ��� -4   $ Column30��$	��25* ��� -5   $ Column31��$	��25* �.+��� -6    ��Name$ Canvas1�����	#FF2D2D2D$��32��$��16��.+��� -7   	 ��Name$	 
background��$)��#MySource/baba is you/background.jpg��$��UniformToFill=�$	��400��

 �� Top$
 0��$	��800�� �� Left$ 0���� -8   $	 Genius��$	 200��$	
 200��$��25��$��25��$
��Auto=�$��MySource/正向站立.png��|�.  J� IsHitTestVisible .  � FocusVisualStyle Z� z�T� -9   aa�� T� X$ 0Q� T� Y$ 0Q��� -:   $
	 undo��$#��MySource/baba is you/Undo.png��$��Uniform=�$��50��$
 25��$	��100��$	 350���� -;   $
	 move��$#��MySource/baba is you/move.png��$��Uniform=�$��50��$	
 325��$	��100��$	 350���� -<   $		 is1��$!��MySource/baba is you/is.jpg��$��Uniform=�$��25��$
 50��$��25��$ 25���� -=   $
	 baba��$#��MySource/baba is you/baba.jpg��$��Uniform=�$��25��$
 50��$��25��$ 0���� ->   $		 you��$"��MySource/baba is you/you.JPG��$��Uniform=�$��25��$
 50��$��25��$ 50���� -?   $
	 flag��$#��MySource/baba is you/flag.JPG��$��Uniform=�$��25��$
 50��$��25��$	 725���� -@   $		 is2��$!��MySource/baba is you/is.jpg��$��Uniform=�$��25��$
 50��$��25��$	 750���� -A   $		 win��$"��MySource/baba is you/win.JPG��$��Uniform=�$��25��$
 50��$��25��$	 775���� -B   $	 flag_pic��$'��!MySource/baba is you/flag_pic.JPG��$��Uniform=�$��25��$	
 200��$��25��$	 700���� -C   $
	 wall��$#��MySource/baba is you/wall.jpg��$��Uniform=�$��25��$	
 325��$��25��$ 0���� -D   $		 is3��$!��MySource/baba is you/is.jpg��$��Uniform=�$��25��$	
 325��$��25��$ 25���� -E   $
	 stop��$#��MySource/baba is you/stop.png��$��Uniform=�$��25��$	
 325��$��25��$ 50���� -F   $
	 rock��$#��MySource/baba is you/rock.JPG��$��Uniform=�$��25��$	
 325��$��25��$	 725���� -G   $		 is4��$!��MySource/baba is you/is.jpg��$��Uniform=�$��25��$	
 325��$��25��$	 750���� -H   $
	 push��$#��MySource/baba is you/push.JPG��$��Uniform=�$��25��$	
 325��$��25��$	 775���� -I   $	 skull��$$��MySource/baba is you/skull.png��$��Uniform=�$��25��$	
 350��$��25��$	 725���� -J   $		 is5��$!��MySource/baba is you/is.jpg��$��Uniform=�$��25��$	
 350��$��25��$	 750���� -K   $	 defeat��$%��MySource/baba is you/defeat.png��$��Uniform=�$��25��$	
 350��$��25��$	 775���� -L   $	 	skull_pic��$(��"MySource/baba is you/skull_pic.png��$��Uniform=�$��25��$	
 200��$��25��$ 75���� -M   $	 wall_1��$*��$MySource/baba is you/wall_pic_up.jpg��$��Uniform=�$��25��$	
 100��$��25��$ 0���� -N   $	 wall_2��$*��$MySource/baba is you/wall_pic_up.jpg��$��Uniform=�$��25��$	
 100��$��25��$ 25���� -O   $	 wall_3��$*��$MySource/baba is you/wall_pic_up.jpg��$��Uniform=�$��25��$	
 100��$��25��$ 50���� -P   $	 wall_4��$*��$MySource/baba is you/wall_pic_up.jpg��$��Uniform=�$��25��$	
 100��$��25��$ 75���� -Q   $	 wall_5��$*��$MySource/baba is you/wall_pic_up.jpg��$��Uniform=�$��25��$	
 100��$��25��$	 100���� -R   $	 wall_6��$*��$MySource/baba is you/wall_pic_up.jpg��$��Uniform=�$��25��$	
 100��$��25��$	 125���� -S   $	 wall_7��$*��$MySource/baba is you/wall_pic_up.jpg��$��Uniform=�$��25��$	
 100��$��25��$	 150���� -T   $	 wall_8��$*��$MySource/baba is you/wall_pic_up.jpg��$��Uniform=�$��25��$	
 100��$��25��$	 175���� -U   $	 wall_9��$*��$MySource/baba is you/wall_pic_up.jpg��$��Uniform=�$��25��$	
 100��$��25��$	 200���� -V   $	 wall_10��$*��$MySource/baba is you/wall_pic_up.jpg��$��Uniform=�$��25��$	
 100��$��25��$	 225���� -W   $	 wall_11��$*��$MySource/baba is you/wall_pic_up.jpg��$��Uniform=�$��25��$	
 100��$��25��$	 250���� -X   $	 wall_12��$*��$MySource/baba is you/wall_pic_up.jpg��$��Uniform=�$��25��$	
 100��$��25��$	 275���� -Y   $	 wall_13��$*��$MySource/baba is you/wall_pic_up.jpg��$��Uniform=�$��25��$	
 100��$��25��$	 300���� -Z   $	 wall_14��$*��$MySource/baba is you/wall_pic_up.jpg��$��Uniform=�$��25��$	
 100��$��25��$	 325���� -[   $	 wall_15��$*��$MySource/baba is you/wall_pic_up.jpg��$��Uniform=�$��25��$	
 100��$��25��$	 350���� -\   $	 wall_16��$*��$MySource/baba is you/wall_pic_up.jpg��$��Uniform=�$��25��$	
 100��$��25��$	 375���� -]   $	 wall_17��$*��$MySource/baba is you/wall_pic_up.jpg��$��Uniform=�$��25��$	
 100��$��25��$	 400���� -^   $	 wall_18��$*��$MySource/baba is you/wall_pic_up.jpg��$��Uniform=�$��25��$	
 100��$��25��$	 425���� -_   $	 wall_19��$*��$MySource/baba is you/wall_pic_up.jpg��$��Uniform=�$��25��$	
 100��$��25��$	 450���� -`   $	 wall_20��$*��$MySource/baba is you/wall_pic_up.jpg��$��Uniform=�$��25��$	
 100��$��25��$	 475���� -a   $	 wall_21��$*��$MySource/baba is you/wall_pic_up.jpg��$��Uniform=�$��25��$	
 100��$��25��$	 500���� -b   $	 wall_22��$*��$MySource/baba is you/wall_pic_up.jpg��$��Uniform=�$��25��$	
 100��$��25��$	 525���� -c   $	 wall_23��$*��$MySource/baba is you/wall_pic_up.jpg��$��Uniform=�$��25��$	
 100��$��25��$	 550���� -d   $	 wall_24��$*��$MySource/baba is you/wall_pic_up.jpg��$��Uniform=�$��25��$	
 100��$��25��$	 575���� -e   $	 wall_25��$*��$MySource/baba is you/wall_pic_up.jpg��$��Uniform=�$��25��$	
 100��$��25��$	 600���� -f   $	 wall_26��$*��$MySource/baba is you/wall_pic_up.jpg��$��Uniform=�$��25��$	
 100��$��25��$	 625���� -g   $	 wall_27��$*��$MySource/baba is you/wall_pic_up.jpg��$��Uniform=�$��25��$	
 100��$��25��$	 650���� -h   $	 wall_28��$*��$MySource/baba is you/wall_pic_up.jpg��$��Uniform=�$��25��$	
 100��$��25��$	 675���� -i   $	 wall_29��$*��$MySource/baba is you/wall_pic_up.jpg��$��Uniform=�$��25��$	
 100��$��25��$	 700���� -j   $	 wall_30��$*��$MySource/baba is you/wall_pic_up.jpg��$��Uniform=�$��25��$	
 100��$��25��$	 725���� -k   $	 wall_31��$*��$MySource/baba is you/wall_pic_up.jpg��$��Uniform=�$��25��$	
 100��$��25��$	 750���� -l   $	 wall_32��$*��$MySource/baba is you/wall_pic_up.jpg��$��Uniform=�$��25��$	
 100��$��25��$	 775���� -m   $	 wall_33��$,��&MySource/baba is you/wall_pic_down.jpg��$��Uniform=�$��25��$	
 275��$��25��$ 0���� -n   $	 wall_34��$,��&MySource/baba is you/wall_pic_down.jpg��$��Uniform=�$��25��$	
 275��$��25��$ 25���� -o   $	 wall_35��$,��&MySource/baba is you/wall_pic_down.jpg��$��Uniform=�$��25��$	
 275��$��25��$ 50���� -p   $	 wall_36��$,��&MySource/baba is you/wall_pic_down.jpg��$��Uniform=�$��25��$	
 275��$��25��$ 75���� -q   $	 wall_37��$,��&MySource/baba is you/wall_pic_down.jpg��$��Uniform=�$��25��$	
 275��$��25��$	 100���� -r   $	 wall_38��$,��&MySource/baba is you/wall_pic_down.jpg��$��Uniform=�$��25��$	
 275��$��25��$	 125���� -s   $	 wall_39��$,��&MySource/baba is you/wall_pic_down.jpg��$��Uniform=�$��25��$	
 275��$��25��$	 150���� -t   $	 wall_40��$,��&MySource/baba is you/wall_pic_down.jpg��$��Uniform=�$��25��$	
 275��$��25��$	 175���� -u   $	 wall_41��$,��&MySource/baba is you/wall_pic_down.jpg��$��Uniform=�$��25��$	
 275��$��25��$	 200���� -v   $	 wall_42��$,��&MySource/baba is you/wall_pic_down.jpg��$��Uniform=�$��25��$	
 275��$��25��$	 225���� -w   $	 wall_43��$,��&MySource/baba is you/wall_pic_down.jpg��$��Uniform=�$��25��$	
 275��$��25��$	 250���� -x   $	 wall_44��$,��&MySource/baba is you/wall_pic_down.jpg��$��Uniform=�$��25��$	
 275��$��25��$	 275���� -y   $	 wall_45��$,��&MySource/baba is you/wall_pic_down.jpg��$��Uniform=�$��25��$	
 275��$��25��$	 300���� -z   $	 wall_46��$,��&MySource/baba is you/wall_pic_down.jpg��$��Uniform=�$��25��$	
 275��$��25��$	 325���� -{   $	 wall_47��$,��&MySource/baba is you/wall_pic_down.jpg��$��Uniform=�$��25��$	
 275��$��25��$	 350���� -|   $	 wall_48��$,��&MySource/baba is you/wall_pic_down.jpg��$��Uniform=�$��25��$	
 275��$��25��$	 375���� -}   $	 wall_49��$,��&MySource/baba is you/wall_pic_down.jpg��$��Uniform=�$��25��$	
 275��$��25��$	 400���� -~   $	 wall_50��$,��&MySource/baba is you/wall_pic_down.jpg��$��Uniform=�$��25��$	
 275��$��25��$	 425���� -   $	 wall_51��$,��&MySource/baba is you/wall_pic_down.jpg��$��Uniform=�$��25��$	
 275��$��25��$	 450���� -�   $	 wall_52��$,��&MySource/baba is you/wall_pic_down.jpg��$��Uniform=�$��25��$	
 275��$��25��$	 475���� -�   $	 wall_53��$,��&MySource/baba is you/wall_pic_down.jpg��$��Uniform=�$��25��$	
 275��$��25��$	 500���� -�   $	 wall_54��$,��&MySource/baba is you/wall_pic_down.jpg��$��Uniform=�$��25��$	
 275��$��25��$	 525���� -�   $	 wall_55��$,��&MySource/baba is you/wall_pic_down.jpg��$��Uniform=�$��25��$	
 275��$��25��$	 550���� -�   $	 wall_56��$,��&MySource/baba is you/wall_pic_down.jpg��$��Uniform=�$��25��$	
 275��$��25��$	 575���� -�   $	 wall_57��$,��&MySource/baba is you/wall_pic_down.jpg��$��Uniform=�$��25��$	
 275��$��25��$	 600���� -�   $	 wall_58��$,��&MySource/baba is you/wall_pic_down.jpg��$��Uniform=�$��25��$	
 275��$��25��$	 625���� -�   $	 wall_59��$,��&MySource/baba is you/wall_pic_down.jpg��$��Uniform=�$��25��$	
 275��$��25��$	 650���� -�   $	 wall_60��$,��&MySource/baba is you/wall_pic_down.jpg��$��Uniform=�$��25��$	
 275��$��25��$	 675���� -�   $	 wall_61��$,��&MySource/baba is you/wall_pic_down.jpg��$��Uniform=�$��25��$	
 275��$��25��$	 700���� -�   $	 wall_62��$,��&MySource/baba is you/wall_pic_down.jpg��$��Uniform=�$��25��$	
 275��$��25��$	 725���� -�   $	 wall_63��$,��&MySource/baba is you/wall_pic_down.jpg��$��Uniform=�$��25��$	
 275��$��25��$	 750���� -�   $	 wall_64��$,��&MySource/baba is you/wall_pic_down.jpg��$��Uniform=�$��25��$	
 275��$��25��$	 775���� -�   $	 rock_1��$'��!MySource/baba is you/rock_pic.JPG��$��Uniform=�$��25��$	
 200��$��25��$	 500��z�T� -�   b1��$ 0Q�$ 0Q��� -�   $	 rock_2��$'��!MySource/baba is you/rock_pic.JPG��$��Uniform=�$��25��$	
 175��$��25��$	 500��z�T� -�   b2��$ 0Q�$ 0Q��� -�   $	 rock_3��$'��!MySource/baba is you/rock_pic.JPG��$��Uniform=�$��25��$	
 225��$��25��$	 500��z�T� -�   b3��$ 0Q�$ 0Q� � Triggers :�  :� RoutedEvent$ Loaded��[��� .���� .��W�  �� TargetProperty$ Opacity�	 W� To$ 1X� g� Duration$ 0:0:0.5D� �� 
TargetName$ level1�� W� From$ 0X�