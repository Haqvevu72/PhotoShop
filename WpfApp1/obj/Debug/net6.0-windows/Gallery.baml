   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.Gallery   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  Gallery��5   	   $	��450��6   $	��800��6&   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��0.3* �6   6,   �� 5      $��5* �6   6*   �� 5      $��* �6   6)   .+�5   
   o� $��0��6   
���q�<�.@�5      m� $
��File��6      MenuItemTemplate#��[  6%   .@�5      m� $	��New��6   #��[  6,   m� 5      $
��Open��6   #��[  6-   m� 5      $
��Save��6   #��[  6-   �� 5      m� 5      $
��Exit��6   #��[  6-   5      m� 5      $
��Edit��6   #��[  6)   .@�5      m� $	��Cut��6   m� 5      $
��Copy��6   m� 5      $��Paste��6   5      m� 5      $
��Help��6   #��[  6)   .@�5      m� $��About��6   5      m� 5       $
��View��6   #��[  6)   .@�5!      m� $��Zoom In��6   62   m� 5"      $��Zomm Out��6   63   5#      5&      �� 5(   
   -   5        $��Current��5(      $��1��6    $	��400��6-   $	��250��69   6H   �� 5*   
   -   5        $
��Back��5*      $��2��6     CircularButtonStyle1#��[ 6*   $��	0,0,200,0q�6X   .��5+      �� $��Pictures\507257.png��6   $��30��61   6?   5,      �� 5.   
   -   5        $��Forward��5.      $��2��6    #��[ 6-   $��	269,0,0,0q�6[   .��5/      �� $��Pictures\271226.png��6   $��30��61   6?   50      �� 52   
   -   5        $
��play��52      $��2��6     CircularButtonStyle2#��[ 6*   $��0,0,40,0q�6X   .��53      �� $��Pictures\727245.png��6   $��40��61   $��10,0,0,0q�6=   6Q   54      �� 56   
   -   5        $
��stop��56      $��2��6   #��[ 6*   $��	110,0,0,0q�6X   .��57      �� $��Pictures\3669483.png��6   $��40��62   $��0,0,0,0q�6>   6Q   58      59      5:      