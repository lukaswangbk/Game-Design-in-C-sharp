   M S B A M L   `   `   `  ����  Ballade!    WpfApplication1.WelcomePage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -   5        $��	主界面��5	   :     N� 
Background
  �   � N� Title$ WelcomePage��6    J� Opacity$ 1Q�6.    N� 
Foreground 6   Z� .��5      � .+�5   
   �� $
��Left=�6   $	��540��6+   $��-22,-130,-9,-20q�68   $	��Top=�6Q   $	��674��6i    J� OpacityMask �	#FFBB2E2E$��MySource/Background.jpg��6�   $��UniformToFill=�6�   �� 5   
   ���	#FF1E1E1E$
��Left=�6%   $��30��6@   $	��Top=�6L   $	��650��6d   �� 5   
   $
��Left=�6   $��10,3,0,0q�6+   $	��Top=�6=   $��22��6U   $��MySource/icon72x72.png��6a   �� 5   
   $��Typing Game��6   $
��Left=�6&   $��40,0,0,0q�6A   $	��Top=�6S   
������ 
�������$��MySource/font/#Peepo)�6�   �� 5   
   $��Typing Game��6   $
��Left=�6&   $��
250,50,0,0q�6A   $	��Top=�6U   $	��290��6m   $��50��6y   $��24(�6�   $��MySource/font/#Peepo)�6�   
�������6�   �� 5   
   -   5        $��Start��5      $
��Left=�6!   $	��Top=�6<   $��80��6T   $��285,220,0,0q�6_   $��1��6�   $��25��6�   $��14(�6�   $��MySource/font/#Peepo)�6�   �� 5   
   -   5        $��Leave��5      $
��Left=�6!   $	��Top=�6<   $��80��6T   $��285,280,0,0q�6_   $��1��6�   $��25��6�   $��14(�6�   $��MySource/font/#Peepo)�6�   �� 5   
   -   5        $��Author��5      $
��Left=�6"   $	��Top=�6=   $��80��6U   $��285,340,0,0q�6`   $��1��6�   $��25��6�   $��14(�6�   $��MySource/font/#Peepo)�6�   �� 5   
   -   5        $
��Left=�5      $��27��6,   $��	600,0,0,0q�68   $	��Top=�6K   $��50��6c   ��5      �� 5       �� Orientation$ Vertical=�6   .+�5      �� $��UniformToFill=�6   $��-2q�64   $��Mysource/no.png��6@   $��27��6Y   $��27��6d   5      5      5       � Triggers 5      :� 5   
    :� RoutedEvent$ Loaded��6   [�5      �� 5      .��5       �� .��5!      W�  �� TargetProperty$ Opacity�6*   		 W� To$	 1X�6N   
 g� Duration$
 0:0:0.3D�6U    �� 
TargetName$ 	主界面��6h    W� From$ 0X�6�   5"      5#      5$      5&      5(      