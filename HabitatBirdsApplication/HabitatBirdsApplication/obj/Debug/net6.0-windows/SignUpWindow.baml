   M S B A M L   `   `   `  ����R  NHabitatBirdsApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:HabitatBirdsApplicationHabitatBirdsApplication  5   	   *    $HabitatBirdsApplication.SignUpWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:HabitatBirdsApplication     5   	     � Title$  SignUpWindow��5   	    � SizeToContent$ WidthAndHeight=�6   .��5	      � ��5
   
   �� 5       �� ImageSource$ /log in image.jpeg.jfif��6    �� Opacity$	 0.7Q�6?   .+�5   
   � $	��450��6   $��	20,0,11,0q�6    � RowDefinitions 5      �� 5       � ColumnDefinitions 5      �� 5      $	��21* �6#   �� 5      $	��29* �6#   .+�5      �� $��
First name��6   $��Center=�6)   $��0,37,0,0q�6F   $	��Top=�6X    J� RenderTransformOrigin$ -6.685,-2.348&�6p   $	��146��6�   $��16(�6�   $��Segoe UI Black)�6�   
�������$��Center=�6�   $��32��6  ��5      �� 5       �� Color$ 	#FFA8A6A1��6&   $	 0.6Q�68   5      �� 5      $��Family name��6   $��Center=�6*   $��0,88,0,0q�6G   $	��Top=�6Y   $ -5.554,-0.653&�6q   $��16(�6�   $��Segoe UI Black)�6�   
�������$��Center=�6�   $��32��6�   $	��144��6  ��5      �� 5      $ 	#FFA8A6A1��6&   $	 0.6Q�68   5      �� 5       $��ID��6   $��Center=�6!   $��	0,141,0,0q�6>   $	��Top=�6Q   $ -10.691,-2.002&�6i   $��16(�6�   
�������$��Segoe UI Black)�6�   $	��146��6�   $��Center=�6�   $��29��6�   ��5!      �� 5"      $ 	#FFA8A6A1��6&   $	 0.6Q�68   5$      �� 5%      -   5         ��Name$ firstNameText��5%      $
��Left=�6-   $��32��6H   $��	18,37,0,0q�6T   	 �� TextWrapping$
	 Wrap=�6g   $	��Top=�6{   $	��189��6�   $�� 1��6�   .��6�   ��5&      �� 5'      $ White��6&   $ 1Q�64   .��5(   &   5)      �� 5*      -   5        $ lastNameText��5*      $
��Left=�6,   $��32��6G   $��	18,88,0,0q�6S   $
	 Wrap=�6f   $	��Top=�6z   $	��189��6�   $�� 1��6�   �� 5+      -   5        $ IDtext��5+      $
��Left=�6&   $��29��6A   $��
18,141,0,0q�6M   $
	 Wrap=�6a   $	��Top=�6u   $	��189��6�   $��1��6�   �� 5,      -   5        $ userNameTextBox��5,      $
��Left=�6/   $��
18,186,0,0q�6J   $
	 Wrap=�6^   $	��Top=�6r   $	��189��6�   $��29��6�   $��1��6�   �� 5-      -   5        $ passwordTextBox��5-      $
��Left=�6/   $��32��6J   $��
18,230,0,0q�6V   $
	 Wrap=�6j   $	��Top=�6~   $	��189��6�   $��1��6�   �� 5.      -   5        $
��Save��5.      $��105,290,0,100q�6$   $��Segoe UI Black)�6N   ���	#FFFDFAFA$��18(�6�   $��Left =�6�   $	��212��6�   $��2��6�   $ 0.5,0.5&�6�   ��6�   Z� z�5/      V� 50      .~�51      �� �� 52      
 �� AngleX$
 1.472Q�6(   �� 53      T� 54       T� X$ 0.359Q�6-   55      ��57      �� 58      $ 	#FFA8A6A1��6&   $	 0.7Q�68   5:      �� 5;      $��	User name��6   $��Center=�6(   $��29��6E   $��	0,188,0,0q�6Q   $	��Top=�6d   $	��144��6|   $��Segoe UI Black)�6�   $��16(�6�   $
��Bold"�6�   ���	#FFFCFFFF$��Center=�6�   ��5<      �� 5=      $ 	#FFA8A6A1��6&   $	 0.6Q�68   5?      �� 5@      $��Password��6   $��Center=�6'   $��35��6D   $��	0,233,0,0q�6P   $	��Top=�6c   $	��144��6{   $��16(�6�   $
��Bold"�6�   $��Segoe UI Black)�6�   ���	#FFFBFFFF$��Center=�6�   ��5A      �� 5B      $ 	#FFA8A6A1��6&   $	 0.6Q�68   5D      5E      5F      5G      