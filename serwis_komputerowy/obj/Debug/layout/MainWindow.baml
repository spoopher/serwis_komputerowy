   M S B A M L   `   `   `  ����M  Iserwis_komputerowy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:serwis_komputerowyserwis_komputerowy  5   	   #    serwis_komputerowy.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:serwis_komputerowy     5   	   -   5          �Name$
  Main��5   	   $	��600��6?   $	��800��6L    � Title$ 
BazaDanych��5   	    � WindowStartupLocation$ Manual=�6   $��Stretch=�6;   $��Stretch=�6^    � 
ResizeMode$ NoResize=�6�   ��5	      �� 5
   
    �� ImageSource$ background.png��6   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��95* �6   �� 5      $
��190* �6   �� 5      $
��112* �6    � RowDefinitions 5   
   �� 5      $��0* �6   �� 5      $	��40* �6   �� 5      $
��530* �6   .+�5   
    � -   5          �Name$
 main��5      $	��530��6   $��Bottom=�6+     � NavigationUIVisibility$ Hidden=�6F   $��2��6f   $��3��6s   o� 5   
   -   5        	 o�Name$
	 menu��5      $��50��6   $��1��6)   $	��794��66   $��3��6B   $��2��6V   $	��Top=�6g   $
��Left=�6   .@�5      �� -   5        
 ��Name$
 button1��5      $�� ��6?   $
��Left=�6J   $	��Top=�6e   $	��113��6}   $��40��6�   {�.   J� RenderTransformOrigin$ 0.836,3.724&�6�   ��5      �� 5      $ 	maths.png��6!    j� Stretch$ Uniform=�69   5      �� 5       -   5        $
 button��5       $�� ��6%   $
��Left=�60   $	��Top=�6K   $	��105��6c   $��40��6o   {�.  ��5!      �� 5"      $ user.png��6!   $ Uniform=�68   5$      �� 5%      -   5        $
 button3��5%      $�� ��6?   $
��Left=�6J   $	��Top=�6e   $��95��6}   $��40��6�    �� 	IsDefault . {�.  ��5&      �� 5'      $ repairing.png��6!   $ Uniform=�6=   5)      �� 5*      -   5        $
 button2��5*      $�� ��6&   $	��Top=�61   $��95��6I   $��40��6T   $ 	2.137,1.4&�6v   $��0q�6�   ��5+      �� 5,      $ exit.png��6!   $
 None=�68   5.      �� 5/      -   5         ��Name$ label��5/      $1��+System zarządzania zleceniami v 1.0.2 2017��6#   $	��312��6X   50      �� 51   
   
���   �$��1q�6%   $��3��69   $
��Left=�6M   $��3��6h   $��0,10,0,0q�6s   $��2��6�   $	��Top=�6�   $	��794��6�   
���   �6�   55      58      