   M S B A M L   `   `   `  ����  InstrClient+    %InstrClient.ManageDiplomaEventsWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$)  #Редагування етапів��5   	   $	��350��6$   $	��500��61   $	��500��6=   $	��350��6L   $	��500��6\   $	��350��6k   .��5      � ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    � MappingMode$ RelativeToBoundingBox=�63    �� 
StartPoint$ 0.5,0&�6W   .��5      �  � Color$ 	#FFBFD7EC��6    � Offset$ 0Q�61   � 5	      $ White��6   $ 1Q�6-   5
      .+�5   
   �� -   5         ��Name$
 Back��5      $��
Назад��6   $	��110��6/   $��25��6;   $��1��6G   $��Bottom=�6T   $
��Left=�6o   $��	15,0,0,10q�6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 
EventsGrid��5         CanUserAddRows .  	   CanUserDeleteRows	 .  
   
IsReadOnly
 . $��Stretch=�6j   $��Bottom=�6�   $��
15,0,15,50q�6�   $	��220��6�   �� 5   
   -   5        $ AddEvent��5      $��Додати етап��6#   $	��110��69   $��25��6E   $��1��6Q   $��Bottom=�6^   $
��Left=�6y   $��
15,0,0,283q�6�   6�   �� 5   
   -   5        $ 	EditEvent��5      $#��Редагувати етап��6$   $	��110��6>   $��25��6J   $��1��6V   $��Bottom=�6c   $��Center=�6~   $��	0,0,0,283q�6�   6�   �� 5   
   -   5        $ DeleteEvent��5      $��Видалити етап��6&   $	��110��6>   $��25��6J   $��1��6V   $��Bottom=�6c   $��Right=�6~   $��15,0,15,283q�6�   6�   5      5      