   M S B A M L   `   `   `  ����F  BInstrClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:InstrClientInstrClient  5      "    InstrClient.GroupControlPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:InstrClient     5      -   5          N� Title$%  Клієнт викладача��5       N� WindowHeight$	 650Q�6     N� WindowWidth$
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
   -   5         ��Name$
 Test��5      $��1��6"   $��1��6/   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 	GroupGrid��5      $   HorizontalScrollBarVisibility$
 Auto=�6'   "   VerticalScrollBarVisibility$
 Auto=�6L   $��Stretch=�6o   $��Stretch=�6�   $��3,3,3,33q�6�      
IsReadOnly . $��1��6�   $��1��6�   �� 5   
   -   5         ��Name$ AddGroup��5      $	��200��6#   $��Додати групу��6/   $��25��6F   $
��Left=�6R   $��Bottom=�6m   $��20,0,0,5q�6�   $��1��6�   $��1��6�   6�   �� 5   
   -   5        $ 	EditGroup��5      $	��200��6$   $��Змінити групу��60   $��25��6H   $��Center=�6T   $��Bottom=�6q   $��0,0,0,5q�6�   $��1��6�   $��1��6�   6�   �� 5   
   -   5        $ DeleteGroup��5      $	��200��6&   $!��Видалити групу��62   $��25��6K   $��Right=�6W   $��Bottom=�6s   $��0,0,20,5q�6�   $��1��6�   $��1��6�   6�   5       5!      