   M S B A M L   `   `   `  ����F  BInstrClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:InstrClientInstrClient  5      ,    &InstrClient.DeadlinePenaltyControlPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:InstrClient     5      -   5          N� Title$%  Клієнт викладача��5       N� WindowHeight$	 650Q�6     N� WindowWidth$
 1100Q�63    N� ShowsNavigationUI .  .��5      � -   5         �Name$ MainGrid��5      ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    � MappingMode$ RelativeToBoundingBox=�63    �� 
StartPoint$ 0.5,0&�6W   .��5      �  � Color$ 	#FFBFD7EC��6   	 � Offset$	 0Q�61   � 5      $ White��6   $	 1Q�6-   5      
 � RowDefinitions
 5   
   �� 5      $��24 �6   �� 5      $
��411* �6    � ColumnDefinitions 5   
   �� 5      $	��212 �6   �� 5      $
��835* �6   $	��500��6,   .+�5   
      InstrClient.MenuControl  $��0��6   $��0��6)   $��2��69      InstrClient.Tree  5   
   -   5          Name$ TreeName��5      $��1��6'   $��0��64   �� 5   
   -   5         ��Name$ GroupBox��5   E    �� 
IsEditable .  �� 
IsReadOnly . $��18(�67   $��1��6W   $��1��6d    �� Text$ 
Група��6t   $
��Left=�6�   $��	15,15,0,0q�6�   $	��Top=�6�   $	��200��6�   $��30��6�   6�   �� 5   
   -   5        $ 
SubjectBox��5   E    .  . $��18(�67   $��1��6Y   $��1��6f   $ Предмет��6v   $
��Left=�6�   $��
300,15,0,0q�6�   $	��Top=�6�   $	��200��6�   $��30��6�   6�   �� 5   
   $'��!Величина штрафу (%)��6   $��1��6.   $��1��6;   $��16(�6K   $	��Top=�6Y   $
��Left=�6q   $��	15,70,0,0q�6�   �� 5   
   $F��@За скільки днів накладається штраф��6   $��1��6=   $��1��6J   $��16(�6Z   $	��Top=�6h   $
��Left=�6�   $��
270,70,0,0q�6�   �� 5    
   -   5         ��Name$ PenaltyValue��5       $	��195��6(   $��25��64   $��16(�6@   $��1��6N   $��1��6[   $	��Top=�6k   $
��Left=�6�   $��
18,100,0,0q�6�   �� 5!   
   -   5        $ PenaltyDays��5!      $	��195��6'   $��25��63   $��16(�6?   $��1��6N   $��1��6[   $	��Top=�6k   $
��Left=�6�   $��303,100,0,0q�6�   �� 5"   
   -   5         ��Name$
 Save��5"      $	��150��6   $��25��6+   $��Зберегти��67   $��1��6J   $��1��6W   $
��Left=�6g   $	��Top=�6�   $��
18,170,0,0q�6�   6�   5#      5$      