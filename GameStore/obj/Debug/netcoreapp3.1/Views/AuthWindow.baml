   M S B A M L   `   `   `  ����D  @GameStore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:GameStore	GameStore  5   	        GameStore.Views.AuthWindow   5   	   _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:GameStore     5   	   -   5          �Name$  AWindow��5	   	    � Title$ 
MainWindow��5
   	   $	��350��5   	   $	��600��5   	    � WindowStartupLocation$ CenterScreen=�5   	    � AllowsTransparency$
 True��5   	    � WindowStyle$
 None=�5   	   .��5      � -   5         �Name$ MainGrid��5       � RowDefinitions 5   
   �� 5      $��35 �6   �� 5      $
��300* �6   .+�5   
   � -   5        $ ContentGrid��5      $��1��5      ��5      �� 5         AuthBack �� ImageSource# [  6    5      �� 5      $	��40* �6    �� 5      $	��30* �6    �� 5      $	��20* �6    �� 5      $	��30* �6    �� 5      $
��130* �6    �� 5       $	��30* �6    �� 5!      $	��40* �6     � ColumnDefinitions 5#      �� 5$      $	��50* �6#   �� 5%      $
��100* �6#   �� 5&      $	��70* �6#   �� 5'      $
��100* �6#   �� 5(      $
��220* �6#   .+�5*      �� -   5        	 ��Name$	 tb_Login��5*      $��1��5+      $��3��5,      $��1��5-      )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 Введите логин��5.      
�������$��16(�50      .  (MaterialDesignThemes.Wpf.TextFieldAssist   UnderlineBrush �	#FF212121��52      �� *CurrentUserLogin+G� 53      -   5         G�Name$ pb_Password��53      $��1��54      $��3��55      $��3��56      $!
 Введите пароль��57      
�������$��16(�59       �	#FF2121215:      �� 5;      -   5         ��Name$ b_Reg��5;      $��1��5<      $��5��5=      $��РЕГИСТРАЦИЯ��5>      $��11(�5?      ���	#FF212121���	#FF212121 � Cursor$
 Hand��5B      ��5C      �� *ChangeToRegWindow+�� 5D      -   5        $ b_Join��5D      $��3��5E      $��5��5F      $��
ВОЙТИ��5G      $��11(�5H      ���	#FF212121���	#FF212121��5K      �� *	LoginUser+��5L      ��  �� ElementName$ pb_Password��5M      5N      5O      