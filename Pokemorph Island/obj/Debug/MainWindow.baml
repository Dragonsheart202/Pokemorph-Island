   M S B A M L   `   `   `  ����K  GPokemorph Island, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Pokemorph_IslandPokemorph_Island  5   	   !    Pokemorph_Island.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Pokemorph_Island     5   	     � Title$  Pokemorph Island��5   	    � 
ResizeMode$ CanMinimize=�6"   $	��600��6;   $	��800��6H    � 	Resources 5
       �� DataType-  'Pokemorph_Island.MainInterfaceViewModel$   Pokemorph_Island.MainInterface2  ,Pokemorph_Island.Character_CreationViewModel)   #Pokemorph_Island.Character_Creation��%�   (��       5      *, +)(�� 2     5      *, +)�� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5        5      5      ��5      �� 5   
    �� ImageSource$I Cpack://application:,,,/Pokemorph Island;component/images/cover1.jpg��6   .��5      �  � RowDefinitions 5   
   �� 5      $
��535* �6   �� 5      $	��36* �6    � ColumnDefinitions 5   
   �� 5      $	��90* �6   �� 5      $
��307* �6   .+�5   
   ]� $��2��6   $��2��6(   .+�5      �� -   5         ��Name$ 
FullScreen��5      $��Right=�61   ��6H   �� *SelectedViewModel+5       ]� 5!   
   $��0��6   $��2��6$   .+�5"      �� -   5        $
 User��5"      5#      �� 5$   
   -   5        $	��>>>��5$      $
��Left=�6(      RoundCorner#��[  6[   $��66,0,0,0q�6�   $	��Top=�6�   $��51��6�   $��31��6�   
�������$��16(�6�   $
��Bold"�6�   $��Rockwell Extra Bold)�6�   $��1��6  �� 5%   
   -   5        $	��<<<��5%      $
��Left=�6(   #��[  6]   $��10,0,0,0q�6�   $	��Top=�6�   $��51��6�   $��31��6�   
�������$��16(�6�   $
��Bold"�6�   $��Rockwell Extra Bold)�6�   $��1��6  �� 5&   
   -   5        $��Image Source��5&      $
��Left=�6(   #��[  6X   $��	431,0,0,0q�6}   $	��Top=�6�   $��84��6�   $��31��6�   
�������$��1��6�   $��1��6�   �� 5'   
   -   5        $��PATREON��5'      $
��Left=�6#   #��[  6S   $��	520,0,0,0q�6x   $	��Top=�6�   $��84��6�   $��31��6�   
�������$��1��6�   $��1��6�   �� 5(   
   $��Button��6   $��	0,507,0,0q�6"   $	��Top=�65   $��75��6M   ��6X   �� *MainCommand+�� 5)   
   $��Button��6   $��134,507,584,0q�6"   $	��Top=�69   $��75��6Q   $��2��6�   ��6\   �� *CharCreaCommand+6�   5,      5-      