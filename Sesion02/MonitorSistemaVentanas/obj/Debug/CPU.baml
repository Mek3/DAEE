   M S B A M L   `   `   `  ����Q  MMonitorSistemaVentanas, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:MonitorSistemaVentanasMonitorSistemaVentanas  5           MonitorSistemaVentanas.CPU   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:MonitorSistemaVentanas     5        N� Title$	  CPU��5	      .��5      � $
��Left=�6   $��Stretch=�6&   $��	0,0,0,341q�6B   $	��764��6U   #��� ��6a    J� OpacityMask �	#FFA04DC7 � Cursor$ SizeAll��6�    � ColumnDefinitions 5   
   �� 5      $��2* �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $	��CPU��6   $��1��6   6.   �� 5   
   $��Memoria��6   $��2��6"   61   �� 5   
   $��Física��6   $��3��6!   60   �� 5   
   -   5         ��Name$ labelValorCPU��5      $��ValorCPU��6'   $��1��6:   $��2��6G   #��� ��6W    �	#FFA04DC7$ SizeAll��6�   �� 5   
   -   5        $ labelMF��5      $��MF��6!   $��3��6.   $��2��6;   #��� ��6K    �	#FFA04DC7$ SizeAll��6�   �� 5   
   $��Virtual��6   $��4��6"   62   �� 5    
   -   5        $ labelMV��5       $��MV��6!   $��4��6.   $��2��6;   #��� ��6K    �	#FFA04DC7$ SizeAll��6�   �� 5!   
   -   5         ��Name$ btnActualizar��5!      $��Iniciar��6(   $��Center=�6:   $��5��6W   6d   5"      5#      