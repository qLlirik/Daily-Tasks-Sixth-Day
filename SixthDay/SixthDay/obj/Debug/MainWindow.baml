   M S B A M L   `   `   `  ����C  ?SixthDay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:SixthDaySixthDay  5   	       SixthDay.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:SixthDay     5   	     � Title$B  <Бюро технической инвентаризации��5   	   
�������$��16(�6H   $	��750��6V   $
��1450��6f   $	��768��6v   $
��1500��6�    � WindowStartupLocation$ CenterScreen=�6�   .��5	      � .+�5
   
   �� $'��!Учёт домовладений��6   $��Center=�6-   $��20(�6J   $��	0 10 0 0 q�6X   �� 5   
   $��Center=�6   $��Center=�62   .+�5      �� -   5         ��Name$ lv��5      $
��1450��6#   $	��600��60   $��14(�6=    �� View 5      �� 5      .P�5      �� $	��№��6)    �� Width$ 40��64    �� CellTemplate 5      �� 5   "   .R�5   &   �� $
��Wrap=�6I   ��60   ��  �� Path$ ID�6I   5   #   5      �� 5      $��№ квартала��6)   $ 80��6=    5      �� 5   "   .R�5   &   �� $
��Wrap=�6L   ��60   �� $ Block�6L   5   #   5      �� 5      $��Адресс��6)   $	 150��69    5       �� 5!   "   .R�5"   &   �� $
��Wrap=�6N   ��60   �� $ Address�6N   5#   #   5%      �� 5'      $��Район города��6)   $	 100��6?    5(      �� 5)   "   .R�5*   &   �� $
��Wrap=�6O   ��60   �� $ District�6O   5+   #   5-      �� 5/      $ ��Дата инвент-ии��6)   $	 110��6A    50      �� 51   "   .R�52   &   �� $
��Wrap=�6o   ��60   �� $ 	Inventory� �� StringFormat$ {0:dd/MM/yyyy}��6o   53   #   55      �� 57      $��S зем. участка��6)   $	 100��6A    58      �� 59   "   .R�5:   &   �� $
��Wrap=�6f   ��60   �� $
 Land�$ {0:} кв.м.��6f   5;   #   5=      �� 5?      $"��Факт-я S участка��6)   $	 110��6C    5@      �� 5A   "   .R�5B   &   �� $
��Wrap=�6h   ��60   �� $ Actual�$ {0:} кв.м.��6h   5C   #   5E      �� 5G      $��S застройки��6)   $ 80��6>    5H      �� 5I   "   .R�5J   &   �� $
��Wrap=�6i   ��60   �� $ BuildUp�$ {0:} кв.м.��6i   5K   #   5M      �� 5O      $��S двора��6)   $ 60��6:    5P      �� 5Q   "   .R�5R   &   �� $
��Wrap=�6f   ��60   �� $
 Yard�$ {0:} кв.м.��6f   5S   #   5U      �� 5W      $��S озелен-я��6)   $ 75��6=    5X      �� 5Y   "   .R�5Z   &   �� $
��Wrap=�6g   ��60   �� $ Green�$ {0:} кв.м.��6g   5[   #   5]      �� 5_      $��S огорода��6)   $ 70��6<    5`      �� 5a   "   .R�5b   &   �� $
��Wrap=�6h   ��60   �� $ Garden�$ {0:} кв.м.��6h   5c   #   5e      �� 5g      $��Неудобья��6)   $ 70��6;    5h      �� 5i   "   .R�5j   &   �� $
��Wrap=�6e   ��60   �� $	 Bad�$ {0:} кв.м.��6e   5k   #   5m      �� 5o      $��Изобр-е��6)   $ 90��6:    5p      �� 5q   "   .R�5r   &   �� $��75��6L   ��6,   �� $ Picture�6L   5s   #   5u      �� 5w      $��Освещ-е��6)   $ 60��6:    5x      �� 5y   "   .R�5z   &   �� $
��Wrap=�6O   ��60   �� $ LightStr�6O   5{   #   5}      �� 5      $��Водопр.��6)   $ 70��6:    5�      �� 5�   "   .R�5�   &   �� $
��Wrap=�6S   ��60   �� $ WaterPipeStr�6S   5�   #   5�      �� 5�      $��Отопл-е��6)   $ 60��6:    5�      �� 5�   "   .R�5�   &   �� $
��Wrap=�6Q   ��60   �� $ 
HeatingStr�6Q   5�   #   5�      �� 5�      $	 100��6)    5�      �� 5�   "   .R�5�   &   �� -   5        $��Здания��5�   J   $��85��6[   $��30��6f   5�   #   5�      5�      5�      �� 5�      -   5        $:��4Добавить новое домовладение��5�   4   $��10q�6Z   $	��400��6f   5�      5�      5�      