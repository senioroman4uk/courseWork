   M S B A M L   `   `   `  ����  InstrClient"    InstrClient.AddDiplomaWIndow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$0  *Додати дипломну роботу��5   	   $	��400��6(   $	��500��65   $	��500��6A   $	��400��6P   $	��500��6`   $	��400��6o    � 	Resources 5         TreeViewItemStyle �� 
TargetType �� Property �� Value �� Mode-  'System.Windows.Input.KeyboardNavigation  CheckBoxItemTemplate �� ItemsSource �� Orientation d� 	IsChecked�� 5   
   %�  &	        &	 �     �� 5      " Q�6.   .�5      ��  �@Q�
IsExpanded . 6/   �� 5	       �@Q�
IsSelected 6/   �� *IsInitiallySelected+$ OneTime=��� 5
       �@ AcceptsReturn . 6E   5      �� 5       6D   �� *
Children+$ OneTime=�.R�5      �� $ 
Horizontal=�6   .+�5      �� |�.  $��Center=�6Q    61   �� *	IsChecked+6Q   �� 5      $	��2,0q�6N   ��6'   �� *Name+$ OneTime=�6N   5      5      5      .��5      � 	 � RowDefinitions	 5   
   ��5   
   �� 5      
 �� EndPoint$
 0.5,1&�6"    � MappingMode$ RelativeToBoundingBox=�63    �� 
StartPoint$ 0.5,0&�6W   .��5      �  � Color$ 	#FFBFD7EC��6    � Offset$ 0Q�61   � 5      $ White��6   $ 1Q�6-   5      .+�5   
   �� -   5         ��Name$
 Name��5      $	��239��6    $��Right=�6,   $	��Top=�6H   $��14(�6`   $��	0,10,15,0q�6o   $��22��6�   �� 5   
   -   5         ��Name$ GreyName��5       J� IsHitTestVisible .  $	��Top=�6?   $��14(�6W   $0��*Назва дипломної роботи��6e   $
��Left=�6�   $��237,10,15,0q�6�   
�������$��22��6�   $	��200��6�   ��5      �� 5       " ��6   .�5!      ��  � y�$ 	Collapsed=�63    �� Triggers 5"      �� 5#       �� Binding 6&   �� *Text+ �� ElementName$
 Name�� �� Value  6Q   .a�5$      ��  � y�$ Visible=�6;   5%      5'      5)      �� 5*   
   -   5         ��Name$ Subject��5*      $	��200��6$    �� Text$# Оберіть предмет��60   $
��Left=�6G   $	��Top=�6b   $��	15,10,0,0q�6z   �� 5+   
   -   5         ��Name$ Description��5+      " �� VerticalScrollBarVisibility$
 Auto=�6+   $��60��6N   $��Stretch=�6Z   $��14(�6x   $	��Top=�6�   $��
15,50,15,0q�6�   R� 5,   
   -   5         R�Name$ 	treeView1��5,   S   $��1��6   $��Stretch=�6    $��12,130,12,0q�6>   $	��Top=�6f   $	��185��6~   #��[  5-      #��[ 5.      �� 5/   
   -   5         ��Name$ OK��5/      $��OK��6   $	��120��6*   $��25��66   $��Bottom=�6B   $
��Left=�6]   $��	15,0,0,10q�6x   6�   �� 50   
   -   5        $ Not_OK��50      $��Відмінити��6!   $	��120��65   $��25��6A   $��Bottom=�6M   $��Right=�6h   $��	0,0,15,10q�6�   6�   51      52      