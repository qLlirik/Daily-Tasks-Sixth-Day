   M S B A M L   `   `   `  ����C  ?SixthDay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:SixthDay.WindowsSixthDay.Windows  5   	   "    SixthDay.Windows.RoomsWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:SixthDay.Windows     5   	     � Title$B  <Бюро технической инвентаризации��5   	   
�������$��16(�6H   $	��580��6V   $	��780��6f   $	��600��6u   $	��800��6�    � WindowStartupLocation$ CenterScreen=�6�    � WindowStyle$
 None=�6�   .��5	      � .+�5
   
   �� $7��1Комнаты в выбранном здании��6   $��20(�66   $��Center=�6D   $��0 10 0 0q�6a   �� 5   
   -   5        $��
Назад��5   $   $	��100��64   $��30��6@   $��Right=�6L   $	��Top=�6h   $��10q�6�   �� 5   
   $��Center=�6   $��Center=�62   .+�5      �� -   5         ��Name$ lv��5      $	��700��6#   $	��400��6/   $��12(�6<    �� View 5      �� 5      .P�5      �� $#��№ в эксплитации��6)    �� Width$	 100��6B    �� CellTemplate 5      �� 5   "   .R�5   &   �� $
��Wrap=�6Q   ��60   ��  �� Path$ 
NumberSign�6Q   5   #   5      �� 5      $��Назначение��6)   $	 250��6=    5      �� 5   "   .R�5   &   �� $
��Wrap=�6P   ��60   �� $ 	Prescribe�6P   5   #   5      �� 5!      $��Площадь��6)   $	 100��6:    5"      �� 5#   "   .R�5$   &   �� $
��Wrap=�6l   ��60   �� $ 
SquareRoom� �� StringFormat$ {0:} кв.м.��6l   5%   #   5'      �� 5)      $��Высота��6)   $	 100��69    5*      �� 5+   "   .R�5,   &   �� $
��Wrap=�6g   ��60   �� $ HighRoom�$ {0:} м.��6g   5-   #   5/      �� 51      $��Этаж��6)   $	 100��67    52      �� 53   "   .R�54   &   �� $
��Wrap=�6M   ��60   �� $ Storey�6M   55   #   57      58      5:      �� 5<      -   5        $��Добавление��5<   .   $��10q�6C   5=      5>      5?      