   M S B A M L   `   `   `  ����   Ballade%    WpfApplication1.TextBoxGamePage   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     -   $��level1��  N� 
Background  �	#FF2D2D2D$y�Visible=�$	��900��$	��530��$	��900��$	��530��.��� .+��� ���	#FF1E1E1E$
��Left=�$��30��$	��Top=�$	��870���� -   $�� ��$��Right=�$	��Top=�$��30��$��30��$��0,0,0,0q���Z� ��Z� ����  �� ImageSource$ MySource/exit.png���� $
��Left=�$��10,3,0,0q�$	��Top=�$��22��$��MySource/icon.png���� $��Fake Baba is You��$
��Left=�$��40,0,0,0q�$	��Top=�
������ 
�������$3��-/SokobanGame;component/Resources/fonts/#Peepo)��� -   $�� ��$
��Left=�$��25��$��
825,35,0,0q�$	��Top=�$��75��$��MySource/font/#Peepo)���Z� ��Z� ���� $ MySource/goback.png�� j� Stretch$ Uniform=��� -   $�� ��$
��Left=�$��25��$��0,35,0,0q�$	��Top=�$��75��$��MySource/font/#Peepo)���Z� ��Z� ���� $ MySource/restart.png��$ Uniform=��� -    ��Name$ MainMap�� �� 
IsReadOnly .  $��262,70,261,92q� �� TextWrapping$
 Wrap=�$��18(�$�� ���� -   $��UP��$
��Left=�$	��Top=�$��80��$��30��$��
80,485,0,0q��� -   $
��DOWN��$
��Left=�$	��Top=�$��80��$��30��$��245,485,0,0q��� -   $
��LEFT��$��Right=�$	��Top=�$��80��$��30��$��0,485,410,0q��� -	   $��RIGHT��$��Right=�$	��Top=�$��80��$��30��$��0,485,245,0q��� -
   $
��UNDO��$��Right=�$	��Top=�$��80��$��30��$��
0,485,80,0q� � Triggers :�  :� RoutedEvent$ Loaded��[��� .���� .��W�  �� TargetProperty$ Opacity�		 W� To$	 1X�
 g� Duration$
 0:0:0.5D� �� 
TargetName$ level1�� W� From$ 0X�