   M S B A M L   `   `   `  ����S  OBusi.Alessandro.4H.Meteo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Busi.Alessandro._4H.MeteoBusi.Alessandro._4H.Meteo  5   	   *    $Busi.Alessandro._4H.Meteo.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:Busi.Alessandro._4H.Meteo     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � ��5
   
   �� 5       �� ImageSource$ 	meteo.jpg��6   64    � ColumnDefinitions 5   
   �� 5      $	��300 �6   6-   �� 5      6!   .+�5   
   �� $��Meteo��6   
���  ��$��60(�62   $��1��6@   $��Center=�6P   $��95��6k   $��128,0,188,324q�6w   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgdati��5   %   $��0��6      AutoGenerateColumns .  
���   �$��3q�6e      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Citta��6>      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6M   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *Nome+6[     5      $	 Max��6=   $	 100 6J    6%   �� *Max+6X     5      $	 Min��6=   $	 100 6J    6%   �� *Min+6X     5      $ 
Escursione��6D   $	 100 6X    6%   �� *
Escursione+6f   5"      �� 5$   
   	 �� Orientation$	 Vertical=�6   $��1��6,   $
��Left=�6<   $��81,0,0,0q�6W   $	��391��6i   .+�5&      �� $	 
Horizontal=�6   $��25q�62   �� 5'      -   5        $��70��5'   ,   $��265,300,10,30q�68   $��AGGIUNGI��6O   
 J� RenderTransformOrigin$
 0.514,0.583&�6b   5*      5+      5,      