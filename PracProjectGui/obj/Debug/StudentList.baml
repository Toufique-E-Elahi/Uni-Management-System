   M S B A M L   `   `   `  ����I  EPracProjectGui, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:PracProjectGuiPracProjectGui  5   	        PracProjectGui.StudentList   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:PracProjectGui     5   	     � Title$  StudentList��5   	   $	��450��6   $	��800��6*    � WindowStartupLocation$ CenterScreen=�66   ���	#FFCBDFEB.��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ Stdlst��5
      $
��Left=�6#   $	��263��6>   $��
67,124,0,0q�6K   $	��Top=�6_   $	��556��6w      AutoGenerateColumns .     CanUserReorderColumns .     CanUserResizeColumns .     CanUserResizeRows .     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 68     CanUserAddRows .  	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 
Student ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   �� *SId+   ClipboardContentBinding 6Q   Z�   5      $

 Name��6%    63   �� *SName+ 6M   Z�   5      $
 Email��6%    64   �� *SEmail+ 6O   Z� 5      �� 5   
   $��Student List��6   $
��Left=�6'   $��
205,59,0,0q�6B   $	��Top=�6V   $��60��6n   $	��286��6z   $��36(�6�   ���	#FF093A0F$
��Bold"�6�   �� 5   
   -   5         ��Name$ 	btnLogout��5      $��Logout��6$   $
��Left=�65   $��
611,24,0,0q�6P   $	��Top=�6d   $��80��6|   $��35��6�   $��18(�6�   �� 5   
   -   5        $ btnHome��5      $
��Home��6"   $
��Left=�61   $��
709,24,0,0q�6L   $	��Top=�6`   $��75��6x   $��35��6�   $��18(�6�   5      5      