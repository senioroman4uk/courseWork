   M S B A M L   `   `   `  ����F  BInstrClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:InstrClientInstrClient  5      !    InstrClient.WorkWithDiploma   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:InstrClient     5      -   5          N� Title$  Instructor Client��5       N� WindowHeight$	 650Q�6!    N� WindowWidth$
 1100Q�64    N� ShowsNavigationUI .  .��5
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
   -   5         ��Name$ LabTabs��5      $��1��6&   $��1��63   $��Stretch=�6C   $��Stretch=�6_   .@�5      �� -   5         ��Name$ StudentsTab��5      $��Студенти��6+   .��5      � .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ StudentsGrid��5      $   HorizontalScrollBarVisibility$
 Auto=�66   "   VerticalScrollBarVisibility$
 Auto=�6[   $��Stretch=�6~   $��Stretch=�6�   $��3,3,3,3q�6�      
IsReadOnly . 6�   5      5       �� 5!      -   5        $ 
DiplomaTab��5!      $#��Дипломна робота��6*   .��5"      � .+�5#        -   5        $ 
EventsGrid��5#      $
 Auto=�64   $
 Auto=�6Y   $��Stretch=�6|   $��Stretch=�6�   $��	3,130,3,3q�6�    . 6�   �� 5$      -	   5         ��Name$
 Name��5$       $
��Left=�6.   $	��200��6I   $��22��6U   $	��Top=�6a   $��	22,15,0,0q�6y   $��2��6�   �� 5%      -
   5        $ Subject��5%       $��Center=�61   $	��200��6N   $��22��6Z   $	��Top=�6f   $��0,15,0,0q�6~   �� 5&      -   5         ��Name$
 Info��5&      $	��240��6+   $C��=Детальна інформація про студента��67   $��25��6b   $��Right=�6n   $	��Top=�6�   $��	0,15,22,0q�6�   6�   �� 5'      -   5        $
 Pass��5'      $	��240��6+   $%��Зарахувати подію��67   $��25��6R   $��Right=�6^   $	��Top=�6z   $��	0,55,22,0q�6�   6�   �� 5(      -   5        $ FileControl��5(      $	��240��62   $7��1Керування файлами до події��6>   $��25��6c   $��Right=�6o   $	��Top=�6�   $��	0,95,22,0q�6�   6�   �� 5)      -   5        $ Description��5)   !   $
��Wrap=�66   $��Stretch=�6J   $��60��6h   $	��Top=�6t   $��22,50,242,0q�6�   $��2��6�   5*      5+      5,      5-      5.      