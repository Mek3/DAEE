   M S B A M L   `   `   `  ����Q  MMonitorSistemaVentanas, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:MonitorSistemaVentanasMonitorSistemaVentanas  5   	   %    MonitorSistemaVentanas.AcercaDe   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:MonitorSistemaVentanas     5   	     � Title$  AcercaDe��5   	   $	��600��6   $	��830��6'   .��5	      � $
��Left=�6   $��Stretch=�6&   $��0,0,0,3q�6B   $	��772��6S   #��� ��6_    J� OpacityMask �	#FFA04DC7 � Cursor$ SizeAll��6�    � ColumnDefinitions 5
   
   �� 5      $��2* �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5       $
��Auto �6   �� 5!      $
��Auto �6   �� 5"      $
��Auto �6   �� 5#      $
��Auto �6   .+�5'   
   �� $��Monitor de actividad��6   $��1��6/   6>   �� 5(   
   $��	Ordenador��6   $��2��6$   �� 5)   
   $��
Fabricante��6   $��3��6%   64   �� 5*   
   -   5         ��Name$ labelValorFabricante��5*      $��ValorFabricante��6.   $��4��6H   6W   �� 5+   
   $��Modelo��6   $��5��6!   60   �� 5,   
   $��
Procesador��6   $��6��6%   65   �� 5-   
   $	��CPU��6   $��7��6   6/   �� 5.   
   $��Memoria��6   $��8��6"   61   �� 5/   
   $��Física��6   $��9��6!   60   �� 50   
   $��Virtual��6   $��10��6"   63   �� 51   
   $��Disco��6   $��11��6    60   �� 52   
   $��Valor discos lógicos��6   $��12��6/   
������ 6=   �� 53   
   $��Lectura��6   $��13��6"   62   �� 54   
   $��	Escritura��6   $��14��6$   64   �� 55   
   $��Lectura/Escritura��6   $��15��6,   6<   �� 56   
   $	��Red��6   $��16��6   6.   �� 57   
   $��Paquedes recibidos��6   $��17��6-   6=   �� 58   
   $��Paquetes enviados��6   $��18��6,   6<   �� 59   
   $(��"Red de paquetes recibidos/enviados��6   $��19��6=   6M   �� 5:   
   -   5         ��Name$ btnActualizar��5:      $��Iniciar��6(   $��20��6:   $��168,48,219,-73q�6H    J� RenderTransformOrigin$ 	0.43,0.41&�6`   6�   �� 5;   
   -   5         ��Name$ actualizarFrecuencia��5;      $��20��6/   $	��100��6=   	 � Value$	 50Q�6I   
 �� Orientation$
 
Horizontal=�6T   $
��Left=�6m    �� IsSnapToTickEnabled .  � Maximum$ 3Q�5<   ,    �� TickPlacement$ BottomRight=�68    �� AutoToolTipPlacement$ BottomRight=�5=       �� AutoToolTipPrecision$ 2��64    �� Ticks$ 
0, 1, 2, 3R�5>      $��60,48,0,-48q�6$   $ 	0.45,0.24&�69   $��1��6[   6k   �� 5?   
   -   5        $ labelValorModelo��5?      $��ValorModelo��6*   $��5��6@   $��2��6M   #��� ��6]    �	#FFA04DC7$ SizeAll��6�   �� 5@   
   -   5        $ labelValorProcesador��5@      $��ValorProcesador��6.   $��6��6H   $��2��6U   #��� ��6e    �	#FFA04DC7$ SizeAll��6�   �� 5A   
   -   5        $ labelValorCPU��5A      $��ValorCPU��6'   $��7��6:   $��2��6G   #��� ��6W    �	#FFA04DC7$ SizeAll��6�   �� 5B   
   -   5        $ labelMF��5B      $��MF��6!   $��9��6.   $��2��6;   #��� ��6K    �	#FFA04DC7$ SizeAll��6�   �� 5C   
   -   5        $ labelMV��5C      $��MV��6!   $��10��6.   $��2��6<   #��� ��6L    �	#FFA04DC7$ SizeAll��6�   �� 5D   
   -	   5        $ labelDR��5D      $��DR��6!   $��13��6.   $��2��6<   #��� ��6L    �	#FFA04DC7$ SizeAll��6�   �� 5E   
   -
   5        $ labelDW��5E      $��DW��6!   $��14��6.   $��2��6<   #��� ��6L    �	#FFA04DC7$ SizeAll��6�   �� 5F   
   -   5        $ labelDRW��5F      $	��DRW��6"   $��15��60   $��2��6>   #��� ��6N    �	#FFA04DC7$ SizeAll��6�   �� 5G   
   -   5        $ labelNR��5G      $��NR��6!   $��17��6.   $��2��6<   #��� ��6L    �	#FFA04DC7$ SizeAll��6�   �� 5H   
   -   5        $ labelNPS��5H      $	��NPS��6"   $��18��60   $��2��6>   #��� ��6N    �	#FFA04DC7$ SizeAll��6�   �� 5I   
   -   5        $ 	labelNPRS��5I      $
��NPRS��6#   $��19��62   $��2��6@   #��� ��6P    �	#FFA04DC7$ SizeAll��6�   5L      5M      