   M S B A M L   `   `   `  ����R  NHabitatBirdsApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:HabitatBirdsApplicationHabitatBirdsApplication  5   	   &     HabitatBirdsApplication.CageInfo   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:HabitatBirdsApplication     5   	     � Title$  CageInfo��5   	   $	��450��6   $	��700��6'   .��5
      � ��5   
   �� 5       �� ImageSource$ /News From The South.png��6   .+�5   
   �� -   5         ��Name$ SerialNumberName��5      $�� ��6*   $
��Left=�65   $��
132,45,0,0q�6P   $	��100��6d   $��Segoe UI Black)�6p   $��14(�6�   $	��Top=�6�   �� 5   
   -   5        $ 	WidthName��5      $�� ��6#   $
��Left=�6.   $��
132,79,0,0q�6I   $	��100��6]   $��Segoe UI Black)�6i   $��14(�6�   $	��Top=�6�   �� 5   
   -   5        $ 
LengthName��5      $�� ��6$   $
��Left=�6/   $��132,113,0,0q�6J   $	��100��6_   $��Segoe UI Black)�6k   $��14(�6�   $	��Top=�6�   �� 5   
   -   5        $ 
HeigthName��5      $�� ��6$   $
��Left=�6/   $��132,147,0,0q�6J   $	��100��6_   $��Segoe UI Black)�6k   $��14(�6�   $	��Top=�6�   �� 5   
   -   5        $ MetrialName��5      $�� ��6%   $
��Left=�60   $��132,188,0,0q�6K   $	��100��6`   $��Segoe UI Black)�6l   $��14(�6�   $	��Top=�6�   �� 5   
   $��	Cage Info��6   $
��Left=�6$   $��37,0,0,0q�6?   $��Segoe UI Black)�6Q   $��20(�6m   $	��Top=�6{   ���	#FFF5F1F16�   �� 5   
   $��SerialNumber��6   $
��Left=�6'   $��Segoe UI Black)�6B   $��	36,45,0,0q�6^   $	��Top=�6q   $��14(�6�   �� 5   
   $��Width��6   $
��Left=�6    $��Segoe UI Black)�6;   $��	36,81,0,0q�6W   $	��Top=�6j   $��14(�6�   �� 5   
   $��Length��6   $
��Left=�6!   $��Segoe UI Black)�6<   $��
36,114,0,0q�6X   $	��Top=�6l   $��14(�6�   �� 5   
   $��Heigth��6   $
��Left=�6!   $��Segoe UI Black)�6<   $��
36,150,0,0q�6X   $	��Top=�6l   $��14(�6�   �� 5   
   $��Metrial��6   $
��Left=�6"   $��Segoe UI Black)�6=   $��
37,189,0,0q�6Y   $	��Top=�6m   $��14(�6�   �� 5   
   $��List Of Birds��6   $
��Left=�6(   $��
37,238,0,0q�6C   $��Segoe UI Black)�6W   $��20(�6s   $	��Top=�6�   ���	#FFF9F6F66�   �� 5   
   -   5         ��Name$ 	BirdsList��5      $��0��6&   $��1q�66   $��41,275,76,9q�6J   
�������$��Segoe UI Black)�6�   $��14(�6�   ��6_   Z� ��6�   Z�  � 	Resources 5         MaterialDesignIcons��%�   &	        *�5      d`pack://application:,,,/MaterialDesignThemes.Wpf;component/Resources/Fonts/#Material Design Icons)�6�   5       �� View 5      �� 5      .P�5       �� $��Serial Number��6S    �� Width$	 120��6j    �� DisplayMemberBinding 6%   �� *SerialNumber+6j   �� 5!      $��Species��6N   $	 150��6_    6%   �� *	Species+6_   �� 5"      $��
Hatch Date��6P   $	 120��6d    6%   �� *	HatchDate+6d   �� 5#      $��Gender��6M   $	 100��6]    6%   �� *Gender+6]   �� 5$      $��Select��6%   $ 80��65    �� CellTemplate 5%      �� 5&      .R�5'   "   �� -   5        ��5(   &   F� 5)   *   $��16��6/   $��16��6:   
�������	 �� Stretch$	 Uniform=�6S   s����        р��     р�� �� р� �� р�  $� �     $� � 	=  	= р��  	= р�� ��[ р�[ ��[ р�[ ��� � 	= ��� 	6e   5+   #   5,      5.      5/      51      �� 52   
   -   5        $��	Edit cage��52      $
��Left=�6%   $��
555,61,0,0q�6@   $	��Top=�6T   $��36��6l   $	��113��6x   
�������$��Segoe UI Black)�6�   
 J� RenderTransformOrigin$
 0.318,0.518&�6�   $��16(�6  ��6�   Z� ��53      �� 54       �� Color$ 	#FFA8A6A1��6"    �� Opacity$	 0.7Q�64   56      �� 57   
   -	   5         ��Name$ backHomePage��57      $
��Back��6'   $
��Left=�66   $��624,350,0,0q�6Q   $	��Top=�6f   $��60��6�   $��31��6�   $��Segoe UI Black)�6�   
�������$��14(�6�   $
 0.639,0.048&�6�   ��58      �� 59      $ 	#FFA8A6A1��6"   $	 0.7Q�64   5;      5=      5>      