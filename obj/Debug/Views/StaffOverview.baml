   M S B A M L   `   `   `  ����C  ?ShirtBiz, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:ShirtBiz.ViewsShirtBiz.Views  5   	   "    ShirtBiz.Views.StaffDataGrid   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:ShirtBiz.Views     5   	     � Title$  StaffDataGrid��5   	   
�������$	��700��61   $	��800��6>   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DataGridXAML��5
      $
��Left=�6)   $��	10 10 0 0q�6D   $	��Top=�6W   $	��772��6o   $	��248��6{    � 	Resources 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value��%�   '        �� 5      "  6   .�5      ��  � ��
 ���@�63   �� 5       � ��$ SemiBold"�63   �� 5       � ��$ 0 0 1 2q�68   �� 5       � ��
 �   �64   5      5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Staff ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 6S   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 67   �� *	staffID+6S     5      $ 
Staff Name��6%   $	 150 6W   	 69   �� *	staffName+6W     5      $ Staff Address��6%   $	 150 6]   	 6<   �� *staffAddress+6]     5      $ 
Staff City��6%   $	 150 6W   	 69   �� *	staffCity+6W     5      $ Staff State��6%   $ * 6Y   	 6:   �� *
staffState+6Y   5      �� 5   
   -   5        
 ��Name$
 AddBtn��5      $��SemiBold"�6!   $��ADD NEW STAFF��68   $��Center=�6P   $	��top=�6m   $��356,609,350,0q�6�   6�   �� 5   
   -   5         ��Name$
 IDTb��5      $
��Left=�6    $��23��6;   $��342,456,0,0q�6G    �� TextWrapping$
 Wrap=�6\   $	��Top=�6q   $	��120��6�   �� 5   
   -   5        $ NameTb��5      $
��Left=�6"   $��23��6=   $��342,485,0,0q�6I   $
 Wrap=�6^   $	��Top=�6r   $	��120��6�   �� 5    
   -   5        $ AddrTb��5       $
��Left=�6"   $��23��6=   $��342,514,0,0q�6I   $
 Wrap=�6^   $	��Top=�6r   $	��120��6�   �� 5!   
   -   5        $ CityTb��5!      $
��Left=�6"   $��23��6=   $��342,573,0,0q�6I   $
 Wrap=�6^   $	��Top=�6r   $	��120��6�   �� 5"   
   -   5        $ StateTb��5"      $
��Left=�6#   $��23��6>   $��342,543,0,0q�6J   $
 Wrap=�6_   $	��Top=�6t   $	��120��6�   5&      5'      