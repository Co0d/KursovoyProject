   M S B A M L   `   `   `  ����C  ?Programm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Programm.ViewAddProgramm.ViewAdd  5   	       Programm.ViewAdd.AddUser   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Programm.ViewAdd     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � 
ResizeMode$ NoResize=�5   	    � Title$ Добавление��5
   	   $	��500��6   $	��500��6)   .��5      �  � ColumnDefinitions 5   
   �� 5      $��50 �6   6,   �� 5      $	��400 �6   6-   �� 5      $��50 �6   6,    � RowDefinitions 5   
   �� 5      $��50 �6   6*   �� 5      $��50 �6   6*   �� 5      $��50 �6   6*   �� 5      $��50 �6   6*   �� 5      $��50 �6   6*   �� 5      $��50 �6   6*   �� 5      $��50 �6   6*   �� 5      $��50 �6   6*   �� 5      $��50 �6   6*   �� 5      $��34 �6   6*   .+�5   
   �� $	��200��6   $��30��6   $��Arial)�6(   $��20(�6;   $/��)Добавить Пользователя��6I   $��0��6i   $��1��6v   6�   �� 5   
   $
��Left=�6   $	��200��6+   $��30��67   $��Arial)�6C   $��14(�6V   $��
Логин��6d   $��1��6t   $��1��6�   6�   �� 5   
   $
��Left=�6   $	��200��6+   $��30��67   $��Arial)�6C   $��14(�6V   $��Пароль��6d   $��3��6u   $��1��6�   6�   �� 5    
   $
��Left=�6   $	��200��6+   $��30��67   $��Arial)�6C   $��14(�6V   $��Должность��6d   $��5��6x   $��1��6�   6�   �� 5!   
   -   5         ��Name$ 	txb_Login��5!      $	��400��6%   $��30��61   $��Arial)�6=   $��14(�6P   $��2��6^   $��1��6k   6}   �� 5"   
   -   5        $ txb_Password��5"      $	��400��6(   $��30��64   $��Arial)�6@   $��14(�6S   $��4��6a   $��1��6n   6�   �� 5#   
   -   5        $ txb_Post��5#      $	��400��6$   $��30��60   $��Arial)�6<   $��14(�6O   $��6��6]   $��1��6j   6|   �� 5$   
   -   5        $
��Left=�5$   "   $��8��6=   $��1��6J   $	��150��6Z   $��30��6f   $��Arial)�6r   $��14(�6�   $��Добавить��6�   
����������#4A67F76�   �� 5%   
   -   5        $��Right=�5%   !   $��8��6=   $��1��6J   $	��150��6Z   $��30��6f   $��Arial)�6r   $��14(�6�   $��Отмена��6�   
����������#4A67F76�   5&      5'      