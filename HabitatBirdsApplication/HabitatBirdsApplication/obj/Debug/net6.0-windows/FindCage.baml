   M S B A M L   `   `   `  ����R  NHabitatBirdsApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:HabitatBirdsApplicationHabitatBirdsApplication  5   	   &     HabitatBirdsApplication.FindCage   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Amdi1http://materialdesigninxaml.net/winfx/xaml/themes     5   	   7local%clr-namespace:HabitatBirdsApplication     5   	     � Title$  FindCage��5   	   $	��450��6   $	��800��6'   .��5      � .+�5   
   � ��5      �� 5       �� ImageSource$ /News From The South.png��6   .+�5      �� $��	Find Cage��6   $
��Left=�6(   $��10,8,0,0q�6C   $	��Top=�6U   $��Segoe UI Black)�6m   $��22(�6�   ���	#FFF3EFEF6�   �� 5      -   5         ��Name$ OptionTypeToFind��5      $
��Left=�61   $��	48,90,0,0q�6L   $	��Top=�6_   $	��150��6x   $��Segoe UI Black)�6�   $��14(�6�   ��6�   �� *option+��5      �� 5       �� EndPoint$	 0,1&�6*    �� Opacity$
 0.65Q�69   .��5      �  � Color$ 	#FFF0F0F0��6'   � 5      $ 	#FFA8A6A1��6'    � Offset$ 1Q�69   5      5      �� 5      -   5         ��Name$ insertValueLable��5      $��Insert Value:��6.   $
��Left=�6G   $��
65,137,0,0q�6b   $	��Top=�6v   $��Segoe UI Black)�6�   $��16(�6�   ���	#FFF3EFEF$	��131��6�   �� 5      -   5         ��Name$ FindCageText��5      $
��Left=�6,   $��
48,172,0,0q�6H   	 �� TextWrapping$
	 Wrap=�6\   $�� ��6p   $	��Top=�6x   $	��154��6�   $��Segoe UI Black)�6�   $��24��6�   .��6�   ��5      �� 5       
 �� Color$
 	#FFE9E9E9��6&   $ 1Q�68   .��5!   &   5"      �� 5#      -   5        $��btnSearchCage��5#      $��Search��6*   $
��Left=�6;   $��
69,216,0,0q�6V   $	��Top=�6j   $��18(�6�   $��Segoe UI Black)�6�   ���	#FFF5F1F1$��0,0,0,0q�6�   $	��111��6�   $��35��6�   ���	#FF707070��5$      �� 5%      $
 	#FFA8A6A1��6&   $
 0.65Q�68   5'      �� 5(      -   5         ��Name$ ListViewCage��5(      $��206,280,20,10q�6.   $��Segoe UI Black)�6E   $��0��6a   ��5)      �� 5*      $
 	#FFB3C890��6&   $
 0.85Q�68    �� View 5,      �� 5-      .P�5.      �� -   5        serialNumberText�� �� Width$	 100��5.   C    �� DisplayMemberBinding 6O   �� *serialNumber+.��5/      �� .��63   Serial number6B   50      �� 51      -   5        MaterialText��$	 100��51   ?    6K   �� *
material+.��52      �� .��63   
Material6=   53      �� 54      -   5        	WidthText��$	 100��54   <    6H   �� *width+.��55      �� .��63   Width6:   56      �� 57      -	   5        
HeightText��$	 100��57   =    6I   �� *Heigth+.��58      �� .��63   Height6;   59      �� 5:      -
   5        
LengthText��$	 100��5:   =    6I   �� *lenght+.��5;      �� .��63   Length6;   5<      �� 5=      -   5        InfoCage��$ 50��5=   ;   .��5>      �� .��63   Info69    �� CellTemplate 5?      �� 5@   "   .R�5A   &   ��  ��Name$ btnInfoCage��6-   -   5        ��5N   *   F� 5O   .   $��16��63   $��16��6>   
������� �� Stretch$ Uniform=�6W   s����        р��     р�� �� р� �� р�  $� �     $� � 	=  	= р��  	= р�� ��[ р�[ ��[ р�[ ��� � 	= ��� 	6i   5Q   '   5R   #   5T      5U      5W      �� 5X      -   5        $ backHomePage��5X      $
��Back��6+   $
��Left=�6:   $��
690,25,0,0q�6U   $	��Top=�6i   $��60��6�   $��31��6�   $��Segoe UI Black)�6�   
�������$��14(�6�   ��5Y      �� 5Z      $
 	#FFA8A6A1��6&   $	 0.7Q�68   5\      �� 5]      -   5        $ insertValueLable_Copy��5]      $��Choose option:��63   $
��Left=�6M   $��	51,55,0,0q�6h   $	��Top=�6{   $��Segoe UI Black)�6�   $��16(�6�   ���	#FFF3EFEF6�   �� 5^      -   5        $ matirel_Options��5^      $ ��Options: Wood/Plastic/Iron��6-   $
��Left=�6R   $��218,168,0,0q�6m   $	��Top=�6�   $��Segoe UI Black)�6�   $��16(�6�   ���	#FFF3EFEF$y�Hidden=�6�   5`      5a      5b      