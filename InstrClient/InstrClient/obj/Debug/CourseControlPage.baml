   M S B A M L   `   `   `  ����F  BInstrClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:InstrClientInstrClient  5      #    InstrClient.CourseControlPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:InstrClient     5      -   5          N� Title$%  Клієнт викладача��5       N� WindowHeight$	 650Q�6     N� WindowWidth$
 1100Q�63    N� ShowsNavigationUI .  .��5
      � -   5         �Name$ MainGrid��5
      ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    � MappingMode$ RelativeToBoundingBox=�63    �� 
StartPoint$ 0.5,0&�6W   .��5      �  � Color$ 	#FFBFD7EC��6   	 � Offset$	 0Q�61   � 5      $ White��6   $	 1Q�6-   5      
 � RowDefinitions
 5   
   �� 5      $��24 �6   �� 5      $
��411* �6    � ColumnDefinitions 5   
   �� 5      $	��212 �6   �� 5      $
��835* �6   $	��500��6,   .+�5   
      InstrClient.MenuControl  $��0��6   $��0��6)   $��2��69      InstrClient.Tree  5   
   -   5          Name$ TreeName��5      $��1��6'   $��0��64   �� 5   
   -   5         ��Name$ LabTabs��5      $��1��6&   $��1��63   $��Stretch=�6C   $��Stretch=�6_   .@�5      �� -   5         ��Name$ Projects��5      $!��Курсові роботи��6(   .��5      � .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ ProjectsGrid��5      $   HorizontalScrollBarVisibility$
 Auto=�66   "   VerticalScrollBarVisibility$
 Auto=�6[   $��Stretch=�6~   $��Stretch=�6�   $��3,3,3,33q�6�      
IsReadOnly . 6�   �� 5      -   5         ��Name$ AddLab��5      $	��200��6-   $.��(Додати курсову роботу��69   $��25��6Y   $
��Left=�6e   $��Bottom=�6�   $��20,0,0,5q�6�   6�   5       5!      �� 5"      -   5        $ Events��5"      $!��Курсова робота��6&   .��5#      � .+�5$        -	   5        $ 
EventsGrid��5$      $
 Auto=�64   $
 Auto=�6Y   $��Stretch=�6|   $��Stretch=�6�   $��
3,120,3,33q�6�    . $��2��6   �� 5%      -
   5         ��Name$ Labname��5%       $
��Left=�61   $	��200��6L   $��22��6X   $	��Top=�6d   $��	22,15,0,0q�6|   $��2��6�   �� 5&      -   5        $ 
LabSubject��5&       $��Center=�64   $	��200��6Q   $��22��6]   $	��Top=�6i   $��0,15,0,0q�6�   �� 5'      -   5        $ EditLab��5'      $	��200��6.   $0��*Змінити курсову роботу��6:   $��25��6[   $��Right=�6g   $	��Top=�6�   $��	0,15,22,0q�6�   6�   �� 5(      -   5        $ LabDescription��5(   !   $
��Wrap=�69   $��Stretch=�6M   $��60��6k   $	��Top=�6w   $��
22,50,22,0q�6�   $��2��6�   �� 5)      -   5        $ AddEvent��5)      $	��200��6/   $��Додати етап��6;   $��25��6Q   $
��Left=�6]   $��Bottom=�6x   $��20,0,0,5q�6�   $��2��6�   �� 5*      -   5        $ 	EditEvent��5*      $	��200��60   $��Змінити етап��6<   $��25��6S   $��Center=�6_   $��Bottom=�6|   $��0,0,0,5q�6�   6�   �� 5+      -   5        $ DeleteEvent��5+      $	��200��62   $��Видалити етап��6>   $��25��6V   $��Right=�6b   $��Bottom=�6~   $��0,0,20,5q�6�   5,      5-      5.      5/      50      