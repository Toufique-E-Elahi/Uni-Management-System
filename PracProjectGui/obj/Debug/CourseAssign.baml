   M S B A M L   `   `   `  ����I  EPracProjectGui, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:PracProjectGuiPracProjectGui  5   	   !    PracProjectGui.CourseAssign   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:PracProjectGui     5   	     � Title$  CourseAssign��5   	   $	��520��6   $	��839��6+    � WindowStartupLocation$ CenterScreen=�67   ���	#FFCBDFEB.��5	      � .+�5
   
   �� -   5         ��Name$ 	LogOutBtn��5
      $��Log Out��6$   $
��Left=�66   $��
557,10,0,0q�6Q   $	��Top=�6e   $	��107��6}   $��31��6�   $
��Bold"�6�   $��18(�6�   $��Segoe UI Light)�6�   �� 5   
   -   5        $ HomeBtn��5      $
��Home��6"   $
��Left=�61   $��
690,10,0,0q�6L   $	��Top=�6`   $	��107��6x   $��31��6�   $
��Bold"�6�   $��18(�6�   $��Segoe UI Light)�6�   �� 5   
   -   5         ��Name$ ComboSelectCourse��5      $
��Left=�6.   $��118,102,0,0q�6I   $	��Top=�6^   $	��179��6v   $��24��6�   $ �� IsSynchronizedWithCurrentItem$ FalseY�6�   $��18(�6�   $
��Bold"�6�   $��Segoe UI Light)�6
  ��5      �� 5       �� EndPoint$	 0,1&�6&    �� 
StartPoint$	 0,0&�65   .��5      �  � Color$ 	#FFF0F0F0��6#    � Offset$ 0Q�65   � 5      $ 	#FFB1BACD��6#   $ 1Q�65   5      5      �� 5   
   -   5        $ ComboSelectTeacher��5      $
��Left=�6/   $��349,104,0,0q�6J   $	��Top=�6_   $	��197��6w   $��25��6�   $��Segoe UI Light)�6�   ��5      �� 5      $	 0,1&�6&   $	 0,0&�65   .��5      � $ 	#FFF0F0F0��6#   $ 0Q�65   � 5      $ 	#FFB1BACD��6#   $ 1Q�65   5      5      �� 5   
   $
��Left=�6   $��
119,70,0,0q�6/   $
��Wrap=�6C   $��Select Course��6W   $	��Top=�6l   $��30��6�   $	��179��6�   $��22(�6�   $
��Bold"�6�   $��Segoe UI Light)�6�   �� 5   
   $
��Left=�6   $��
367,68,0,0q�6/   $
��Wrap=�6C   $��Select Teacher��6W   $	��Top=�6m   $��30��6�   $	��180��6�   $��22(�6�   $
��Bold"�6�   $��Segoe UI Light)�6�   �� 5   
   -   5        $ ComboSelectSem��5      $
��Left=�6+   $��118,183,0,0q�6F   $	��Top=�6[   $	��179��6s   $��24��6   $ FalseY�6�   $��18(�6�   $
��Bold"�6�   $��Segoe UI Light)�6  ��5      �� 5       $	 0,1&�6&   $	 0,0&�65   .��5!      � $ 	#FFF0F0F0��6#   $ 0Q�65   � 5"      $ 	#FFB1BACD��6#   $ 1Q�65   5#      .@�5%      �� $
��Fall��6   �� 5&      $��Spring��6   5'      �� 5(   
   -   5        $ ComboSelectYear��5(      $
��Left=�6,   $��349,185,0,0q�6G   $	��Top=�6\   $	��197��6t   $��24��6�   $��Segoe UI Light)�6�   ��5)      �� 5*      $	 0,1&�6&   $	 0,0&�65   .��5+      � $ 	#FFF0F0F0��6#   $ 0Q�65   � 5,      $ 	#FFB1BACD��6#   $ 1Q�65   5-      .@�5/      �� $
��2019��6   �� 50      $
��2020��6   �� 51      $
��2021��6   �� 52      $
��2022��6   53      �� 54   
   $
��Left=�6   $��119,151,0,0q�6/   $
��Wrap=�6D   $��Select Semester��6X   $	��Top=�6o   $��30��6�   $	��179��6�   $��22(�6�   $
��Bold"�6�   $��Segoe UI Light)�6�   �� 55   
   $
��Left=�6   $��367,148,0,0q�6/   $
��Wrap=�6D   $��Select Year��6X   $	��Top=�6k   $��30��6�   $	��180��6�   $��22(�6�   $
��Bold"�6�   $��Segoe UI Light)�6�   �� 56   
   -   5        $ LoadBtn��56      $
��Load��6"   $
��Left=�61   $��344,233,0,0q�6L   $	��Top=�6a   $	��107��6y   $��31��6�   $
��Bold"�6�   $��18(�6�   $��Segoe UI Light)�6�   ���	#FFB1BACD6�   �� 57   
   -   5        $ 	UpdateBtn��57      $��Renew��6$   $
��Left=�64   $��151,429,0,0q�6O   $	��Top=�6d   $	��107��6|   $��31��6�   $
��Bold"�6�   $��18(�6�   {�.  $��Segoe UI Light)�6�   ���	#FFB1BACD6�   �� 58   
   -	   5        $ 	DeleteBtn��58      $��Remove��6$   $
��Left=�65   $��325,429,0,0q�6P   $	��Top=�6e   $	��107��6}   $��31��6�   $
��Bold"�6�   $��18(�6�   {�.  $��Segoe UI Light)�6�   ���	#FFB1BACD6�   �� 59   
   -
   5        $ 	InsertBtn��59      $��Assign��6$   $
��Left=�65   $��190,233,0,0q�6P   $	��Top=�6e   $	��107��6}   $��31��6�   $
��Bold"�6�   $��18(�6�   $��Segoe UI Light)�6�   ���	#FFB1BACD6�   &   System.Windows.Controls.DataGrid  5:   
   -   5        	  Name$	 CAList��5:      $
��Left=�6$   $	��131��6?   $��
74,283,0,0q�6L   $	��Top=�6`   $	��501��6x   
   AutoGenerateColumns
 .     CanUserReorderColumns .     CanUserResizeColumns .     CanUserResizeRows .     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6�      CanUserAddRows .  $��Segoe UI Light)�6H  ���	#FF5F978A   Columns 5;      0  *System.Windows.Controls.DataGridTextColumn  5<      ,  &System.Windows.Controls.DataGridColumn   Header$ 	Assign ID��6%      Width$
 auto 6t   1  +System.Windows.Controls.DataGridBoundColumn   Binding 68   �� *CaId+   ClipboardContentBinding 6Q   Z� 6t     5=      $ Course��6%   $
 auto 6r    65   �� *CName+ 6O   Z� 6r     5>      $ Teacher��6%   $
 auto 6t    67   �� *TName+ 6Q   Z� 6t     5?      $
 Year��6%   $
 auto 6o    63   �� *Year+ 6L   Z� 6o     5@      $ Semester��6%    67   �� *Sem+ 6O   Z� 5B      �� 5C   
   -   5        $ 	btnGetAll��5C      $��Get All��6$   $
��Left=�66   $��598,305,0,0q�6Q   $	��Top=�6f   $	��107��6~   $��Segoe UI Light)�6�   ���	#FFB1BACD$��36��6�   �� 5D   
   -   5        $ btncClr��5D      $��CLear��6"   $
��Left=�62   $��598,365,0,0q�6M   $	��Top=�6b   $	��107��6z   $��Segoe UI Light)�6�   ���	#FFB1BACD$��36��6�   5G      5H      