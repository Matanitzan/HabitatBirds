   M S B A M L   `   `   `  ����R  NHabitatBirdsApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:HabitatBirdsApplicationHabitatBirdsApplication  5   	   &     HabitatBirdsApplication.ShowBird   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:HabitatBirdsApplication     5   	     � Title$  Bird Profile��5   	   $	��700��6   $	��500��6+   .��5	      � ���#F2F2F2 � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6    �� Padding$ 20q�6   $��10q�6+   ��5      �� 5       �� ImageSource$ /log in image.jpeg.jfif��6   ._�5      � .+�5      A� $	��150��6   $	��150��6&   ���#EDEDEF63   �� 5      $��/bird_image.jpg��6   $	��130��61   $	��130��6=   $��10q�6J   $��Center=�6V   $��Center=�6s    J� Clip 5      @� 5       @� Center$ 65,65&�6*    @� RadiusX$ 65Q�69    @� RadiusY$ 65Q�6F   5      5      5      �� 5   
   $��1��6   $
��Auto=�6$   .��5      �� ���#FFFFFF$��10q�6.   .+�5       �� $��Serial Number:��6   $
��Bold"�62   $��14(�6D   $��0 0 0 5q�6R   �� 5!      -   5         ��Name$ SerialNumberTextBox��5!      $��14(�6U   $��0 0 0 10q�6c   $��5q�6u   $��1q�6�   ���#CCCCCC	 �� 
IsReadOnly$
	 True��6�   ��67   �� *SerialNumber+6�   �� 5%      $��Species:��6   $
��Bold"�6,   $��14(�6>   $��0 0 0 5q�6L   �� 5&      -   5        $ SpeciesTextBox��5&      $��14(�6K   $��0 0 0 10q�6Y   $��5q�6k   $��1q�6w   ���#CCCCCC$
	 True��6�   ��62   �� *	Species+6�   �� 5(      $��Subspecies:��6   $
��Bold"�6/   $��14(�6A   $��0 0 0 5q�6O   �� 5)      -   5        $ SubspeciesTextBox��5)      $��14(�6Q   $��0 0 0 10q�6_   $��5q�6q   $��1q�6}   ���#CCCCCC$
	 True��6�   ��65   �� *
Subspecies+6�   �� 5-      $��Hatch Date:��6   $
��Bold"�6/   $��14(�6A   $��0 0 0 5q�6O   �� 5.      -   5        $ HatchDateTextBox��5.      $��14(�6O   $��0 0 0 10q�6]   $��5q�6o   $��1q�6{   ���#CCCCCC$
	 True��6�   ��64   �� *	HatchDate+6�   �� 50      $��Gender:��6   $
��Bold"�6+   $��14(�6=   $��0 0 0 5q�6K   �� 51      -   5        $ GenderTextBox��51      $��14(�6I   $��0 0 0 10q�6W   $��5q�6i   $��1q�6u   ���#CCCCCC$
	 True��6�   ��61   �� *Gender+6�   �� 53      $��Cage Number:��6   $
��Bold"�60   $��14(�6B   $��0 0 0 5q�6P   �� 54      -   5        $ CageNumberTextBox��54      $��14(�6Q   $��0 0 0 10q�6_   $��5q�6q   $��1q�6}   ���#CCCCCC$
	 True��6�   ��65   �� *
CageNumber+6�   �� 56      $��Father Serial:��6   $
��Bold"�62   $��14(�6D   $��0 0 0 5q�6R   �� 57      -   5        $ FatherSerialTextBox��57      $��14(�6U   $��0 0 0 10q�6c   $��5q�6u   $��1q�6�   ���#CCCCCC$
	 True��6�   ��67   �� *FatherSerial+6�   �� 59      $��Mother Serial:��6   $
��Bold"�62   $��14(�6D   $��0 0 0 5q�6R   �� 5:      -   5        $ MotherSerialTextBox��5:      $��14(�6U   $��0 0 0 10q�6c   $��5q�6u   $��1q�6�   ���#CCCCCC$
	 True��6�   ��67   �� *MotherSerial+6�   5;      5<      �� 5>   
   $��2��6   $��Center=�6"   $	��Top=�6?   $��10q�6W   .+�5?      �� -	   5        $��+ Add Chicks��5?      ���	#FFA8A6A1
�������
������ $��14(�6�   $
��Bold"�6�   $
��10 5q�6�   $	��139��6�   $��Segoe UI Black)�6�   �� 5@      -
   5        
 ��Name$
 btnEditBird1��5@      $��	Edit bird��6,   ���	#FFA8A6A1
�������
������ $��14(�6�   $
��Bold"�6�   $
��10 5q�6�   $	��139��6�   $��Segoe UI Black)�6�   6�   5B      �� 5C   
   -   5        $
��Back��5C      $��18,23,409,171q�6    ���	#FFA8A6A1���	#FFF9F6F6$��Segoe UI Black)�6e   $��14(�6�   6�   5E      5F      