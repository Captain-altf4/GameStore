   M S B A M L   `   `   `  ����D  @GameStore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:GameStore	GameStore  5   	       GameStore.Views.RegWindow   5   	   _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:GameStore     5   	   -   5          �Name$  RWindow��5	   	    � Title$ 	RegWindow��5
   	   $	��350��5   	   $	��600��5   	    � WindowStartupLocation$ CenterScreen=�5   	    � AllowsTransparency$
 True��5   	    � WindowStyle$
 None=�5   	   .��5      � -   5         �Name$ MainGrid��5       � RowDefinitions 5   
   �� 5      $��35 �6   �� 5      $
��300* �6   .+�5   
   � -   5        $ ContentGrid��5      $��1��5      ��5      �� 5         RegBack �� ImageSource# [  6    5      �� 5      $	��40* �6    �� 5      $	��30* �6    �� 5      $	��20* �6    �� 5      $	��30* �6    �� 5      $	��20* �6    �� 5       $	��30* �6    �� 5!      $	��20* �6    �� 5"      $	��30* �6    �� 5#      $	��30* �6    �� 5$      $	��30* �6    �� 5%      $	��40* �6     � ColumnDefinitions 5'      �� 5(      $	��50* �6#   �� 5)      $
��100* �6#   �� 5*      $	��70* �6#   �� 5+      $
��100* �6#   �� 5,      $
��220* �6#   .+�5.      �� -   5        	 ��Name$	 tb_Login��5.      $��1��5/      $��3��50      $��1��51      )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 Введите логин��52      
�������$��16(�54      .  (MaterialDesignThemes.Wpf.TextFieldAssist   UnderlineBrush �	#FF212121��56      �� *CurrentUserLogin+57      �� 58      -   5        $	 tb_Mail��58      $��1��59      $��3��5:      $��3��5;      $
 Введите почту��5<      
�������$��16(�5>       �	#FF212121��5@      �� *CurrentUserMail+5A      G� 5B      -   5         G�Name$ pb_Password��5B      $��1��5C      $��3��5D      $��5��5E      $!
 Введите пароль��5F      
�������$��16(�5H       �	#FF2121215J      �� 5K      -   5         ��Name$ b_Auth��5K      $��1��5L      $��9��5M      $��
ВОЙТИ��5N      $��11(�5O      ���	#FF212121���	#FF212121 � Cursor$
 Hand��5R      ��5S      �� *ChangeToAuthWindow+�� 5T      -   5        $ b_Reg��5T      $��3��5U      $��9��5V      $��РЕГИСТРАЦИЯ��5W      $��11(�5X      ���	#FF212121���	#FF212121��5[      �� *	RegUser+��5\      ��  �� ElementName$ pb_Password��5]      5^      5_      