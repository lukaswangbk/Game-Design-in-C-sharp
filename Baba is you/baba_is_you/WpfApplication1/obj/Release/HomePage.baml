   M S B A M L   `   `   `  ����   Ballade    WpfApplication1.HomePage   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     -   $��	主页面��  N� 
Background  �	#FF359BB9 N� Title$ HomePage�� J� Opacity$ 1Q� N� 
Foreground Z�  � 	Resources    FocusVisual �� Property �� Value J� SnapsToDevicePixels �� StrokeDashArray  Button.Static.Background	 �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 
 ToggleButtonStyle
 �� 
TargetType �� 
TargetType ��Name ��Name �� Triggers P� Property P� Value �� 
TargetName��%�  &	        &	 N     &	 c     &	 x     &	 �     &	 �     &	 �     &	 �     &	 �     &		 �     &	
     7   7  7  7  7  7 	 �� .���  � �� �� .R��� $��2q� . #��� ��$��1��$	 1 2R��� $	 	#FFDDDDDD���� $	 	#FF707070���� $	 	#FFBEE6FD���� $	 	#FF3C7FB1���� $	 	#FFC4E5F6���� $	 	#FF2C628B���� $	 	#FFF4F4F4���� $	 	#FFADB2B5���� $	 	#FF838383���� "
 d�.���  �@�FocusVisualStyle8   ��  � ��8  ��  � ��8  ��  � ��# � ����  � ��$ 1q���  � ��$ Center=���  � ��$ Center=���  � ��$ 1q���  � �� �� " d�.R��� $ border��#��z��#��z��#��z�� . ._��� $ contentPresenter��|�.  #��z��#��z����. # z #��z�� P�  �@��IsDefaulted . . ��� $ border��# � �� � ��P�  �@J�IsMouseOver . . ��� $ border�� Z�  � ���� $ border�� �@J�OpacityMask �	#CC000000P�  � �� . . ��� $ border�� Z�  � ���� $ border�� �@J�OpacityMask �	#CC000000P�  � {� .  . ��� $ border��8   � ���� $ border��8   � ���� $ contentPresenter��8   � ��.��� -    �Name$ WelcomePageBackground�����	#FF2D2D2D$��0q�.+��� ���	#FF1E1E1E$
��Left=�$��30��$	��Top=�$	��870���� -   $�� ��$��Right=�$	��Top=�$��30��$��30��$��0,0,0,0q���Z� ��Z� ����  �� ImageSource$ MySource/exit.png���� $
��Left=�$��10,3,0,0q�$	��Top=�$��22��$��MySource/icon.png���� $��Fake Baba is You��$
��Left=�$��40,0,0,0q�$	��Top=�
������ 
�������$3��-/SokobanGame;component/Resources/fonts/#Peepo)��� $��Fake Baba is You��$��Center=�
��� ���$��0,75,0,0q�$	��Top=�$	��575��$	��120��$��75(�$��MySource/font/#Peepo)��� $��Center=�$��80��$��71,103,729,0q�$	��Top=�$	��100��$��MySource/左边.png��$��Uniform=��� $��Center=�$��80��$��731,103,69,0q�$	��Top=�$	��100��$��MySource/右边.png��$��Uniform=�d� -    d�Name$ ModeToggleBtn��$��Center=�$��Center=�$��23��$��23��$��731,389,146,118q�#��� 
 ��Z� ���� $ MySource/lightmode.png���� -   $�� ��$��Center=�$��	0,374,0,0q�$	��Top=�$	��165��$��Peepo)�$��16(�
�������$��51����Z� ���� $ MySource/play.png���� -    ��Name$ PlayerIcon1��$
��Left=�$��42��$��	70,0,0,45q�$��Bottom=�$��31��$��MySource/player1.png��$
��Fill=��� -   $ PlayerIcon2��$
��Left=�$��42��$��
140,0,0,45q�$��Bottom=�$��31��$��MySource/player2.png��$
��Fill=��� -   $ PlayerIcon3��$
��Left=�$��42��$��
210,0,0,45q�$��Bottom=�$��31��$��MySource/player3.png��$
��Fill=��� $��©Wang Bokai and Yang Xu��$��Right=�$��	0,0,40,30q�$��Bottom=�
�������$3��-/SokobanGame;component/Resources/fonts/#Peepo)�$��14(��� -	    ��Name$ 	ModeLabel��$��NORMAL MODE��$
��Left=�$��762,385,0,0q�$	��Top=�$3��-/SokobanGame;component/Resources/fonts/#Peepo)�
�������$��14(�