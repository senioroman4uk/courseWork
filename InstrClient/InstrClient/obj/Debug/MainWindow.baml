   M S B A M L   `   `   `  ����F  BInstrClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:InstrClientInstrClient  5          InstrClient.MainWindow   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:InstrClient     5        N� Title$%  Клієнт викладача��5       N� WindowHeight$	 650Q�6     N� WindowWidth$
 1100Q�63    N� ShowsNavigationUI .  .��5
      � -   5         �Name$ MainGrid��5
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
   $��1��6   $��0��6"   �� 5   
   -   5         ��Name$ 
SubjectBox��5       �� 
IsEditable .  �� Text$ Предмет��69    �� 
IsReadOnly . $��16(�6Z   $
��Left=�6h   $	��Top=�6�   $��26��6�   $	��200��6�   $��1��6�   $��1��6�   $��	10,10,0,0q�6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ SummaryGrid��5      $��1��6(   $��1��65      
IsReadOnly . $��Stretch=�6W   $��Stretch=�6u   $��
10,50,10,5q�6�   6�   5      5      