   M S B A M L   `   `   `  ����   Ballade$    WpfApplication1.GameLevel2Page   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     -   $��level2��  N� 
Background  �	#FF2D2D2D$y�Visible=�$	��900��$	��530��$	��900��$	��530��.��� .+��� ���	#FF1E1E1E$
��Left=�$��30��$	��Top=�$	��870���� -   $�� ��$��Right=�$	��Top=�$��30��$��30��$��0,0,0,0q���Z� ��Z� ����  �� ImageSource$ MySource/exit.png���� $
��Left=�$��10,3,0,0q�$	��Top=�$��22��$��MySource/icon.png���� $��Fake Baba is You��$
��Left=�$��40,0,0,0q�$	��Top=�
������ 
�������$3��-/SokobanGame;component/Resources/fonts/#Peepo)��� -   $�� ��$
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
 Row9��$	��25* ��� -   $ Row10��$	��25* ��� -   $ Row11��$	��25* ��� -   $ Row12��$	��25* ��� -   $ Row13��$	��25* ��� -   $ Row14��$	��25* ��� -   $ Row15��$	��25* � � ColumnDefinitions �� -    ��Name$ Column0��$	��25* ��� -   $ Column1��$	��25* ��� -   $ Column2��$	��25* ��� -   $ Column3��$	��25* ��� -   $ Column4��$	��25* ��� -   $ Column5��$	��25* ��� -   $ Column6��$	��25* ��� -   $ Column7��$	��25* ��� -   $ Column8��$	��25* ��� -   $ Column9��$	��25* ��� -    $ Column10��$	��25* ��� -!   $ Column11��$	��25* ��� -"   $ Column12��$	��25* ��� -#   $ Column13��$	��25* ��� -$   $ Column14��$	��25* ��� -%   $ Column15��$	��25* ��� -&   $ Column16��$	��25* ��� -'   $ Column17��$	��25* ��� -(   $ Column18��$	��25* ��� -)   $ Column19��$	��25* ��� -*   $ Column20��$	��25* ��� -+   $ Column21��$	��25* ��� -,   $ Column22��$	��25* ��� --   $ Column23��$	��25* ��� -.   $ Column24��$	��25* ��� -/   $ Column25��$	��25* ��� -0   $ Column26��$	��25* ��� -1   $ Column27��$	��25* ��� -2   $ Column28��$	��25* ��� -3   $ Column29��$	��25* ��� -4   $ Column30��$	��25* ��� -5   $ Column31��$	��25* �.+��� -6    ��Name$ Canvas1��$��0,0,0,0q�$��32��$��16��.+��� -7   	 ��Name$	 
background��$)��#MySource/baba is you/background.jpg��$��UniformToFill=�$	��400��

 �� Top$
 0��$	��800�� �� Left$ 0���� -8   $	 wall_1��$*��$MySource/baba is you/wall_pic_up.jpg��$��Uniform=�$��25��$
 25��$��25��$	 400��$
��Auto=�|�.  J� IsHitTestVisible .  � FocusVisualStyle Z� z�T� -9   w1�� T� X$ 0Q� T� Y$ 0Q��� -:   $
	 wall��$#��MySource/baba is you/wall.jpg��$��Uniform=�$��25��$	
 275��$��25��$	 450��z�T� -;   wa��$ 0Q�$ 0Q��� -<   $		 is3��$!��MySource/baba is you/is.jpg��$��Uniform=�$��25��$	
 300��$��25��$	 450��z�T� -=   i3��$ 0Q�$ 0Q��� ->   $
	 stop��$#��MySource/baba is you/stop.png��$��Uniform=�$��25��$	
 325��$��25��$	 450��z�T� -?   s��$ 0Q�$ 0Q��� -@   $
	 flag��$#��MySource/baba is you/flag.JPG��$��Uniform=�$��25��$	
 175��$��25��$	 350��z�T� -A   fl��$ 0Q�$ 0Q��� -B   $		 is2��$!��MySource/baba is you/is.jpg��$��Uniform=�$��25��$
 50��$��25��$	 450��z�T� -C   i2��$ 0Q�$ 0Q��� -D   $		 win��$"��MySource/baba is you/win.JPG��$��Uniform=�$��25��$
 75��$��25��$	 525��z�T� -E   wi��$ 0Q�$ 0Q��� -F   $	 flag_pic��$'��!MySource/baba is you/flag_pic.JPG��$��Uniform=�$��25��$	
 150��$��25��$	 525��$
��Auto=�|�.  .  Z� z�T� -G   f��$ 0Q�$ 0Q��� -H   $
	 baba��$#��MySource/baba is you/baba.jpg��$��Uniform=�$��25��$	
 275��$��25��$	 300��z�T� -I   b��$ 0Q�$ 0Q��� -J   $		 is1��$!��MySource/baba is you/is.jpg��$��Uniform=�$��25��$	
 300��$��25��$	 300��z�T� -K   i1��$ 0Q�$ 0Q��� -L   $		 you��$"��MySource/baba is you/you.JPG��$��Uniform=�$��25��$	
 325��$��25��$	 300��z�T� -M   y1��$ 0Q�$ 0Q��� -N   $	 grass_1��$$��MySource/baba is you/grass.jpg��$��Uniform=�$��25��$	
 300��$��25��$	 100���� -O   $	 grass_2��$$��MySource/baba is you/grass.jpg��$��Uniform=�$��25��$	
 200��$��25��$	 150���� -P   $	 grass_3��$$��MySource/baba is you/grass.jpg��$��Uniform=�$��25��$	
 200��$��25��$	 175���� -Q   $	 grass_4��$$��MySource/baba is you/grass.jpg��$��Uniform=�$��25��$
 50��$��25��$	 300���� -R   $	 grass_5��$$��MySource/baba is you/grass.jpg��$��Uniform=�$��25��$	
 300��$��25��$	 700���� -S   $	 grass_6��$$��MySource/baba is you/grass.jpg��$��Uniform=�$��25��$	
 275��$��25��$	 700���� -T   $	 grass_7��$$��MySource/baba is you/grass.jpg��$��Uniform=�$��25��$	
 200��$��25��$	 650���� -U   $	 grass_8��$$��MySource/baba is you/grass.jpg��$��Uniform=�$��25��$
 50��$��25��$	 775���� -V   $	 Genius��$	 500��$	
 300��$��25��$��25��$
��Auto=�$��MySource/正向站立.png��|�.  .  Z� z�T� -W   aa��$ 0Q�$ 0Q� � Triggers :�  :� RoutedEvent$ Loaded��[��� .���� .��W�  �� TargetProperty$ Opacity�	 W� To$ 1X� g� Duration$ 0:0:0.5D� �� 
TargetName$ level2�� W� From$ 0X�