   M S B A M L   `   `   `  ����I  EPracProjectGui, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:PracProjectGuiPracProjectGui  5   	       PracProjectGui.AddStudent   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:PracProjectGui     5   	     � Title$  
AddStudent��5   	   $	��520��6   $	��839��6)    � WindowStartupLocation$ CenterScreen=�65   ���	#FFCBDFEB.��5	      �  � RowDefinitions 5
   
   �� 5      $
��131* �6   �� 5      $
��359* �6   .+�5   
   �� -   5         ��Name$ 	LogOutBtn��5      $��Log Out��6$   $
��Left=�66   $��
582,22,0,0q�6Q   $	��Top=�6e   $	��107��6}   $��31��6�   $��18(�6�   6�   �� 5   
   $
��Left=�6   $��36,18.542,0,0q�6/   $
��Wrap=�6F   $
��Name��6Z   $	��Top=�6f   $��40��6~   $	��133��6�   $��22(�6�   $��1��6�   �� 5   
   $
��Left=�6   $��36,89.542,0,0q�6/   $
��Wrap=�6F   $��Email��6Z   $	��Top=�6g   $��40��6   $	��133��6�   $��22(�6�   $��1��6�   �� 5   
   $
��Left=�6   $��36,153.542,0,0q�6/   $
��Wrap=�6G   $��Address��6[   $	��Top=�6j   $��40��6�   $	��133��6�   $��22(�6�   $��1��6�   �� 5   
   $
��Left=�6   $��36,231.542,0,0q�6/   $
��Wrap=�6G   $��Admission Semester��6[   $	��Top=�6u   $��40��6�   $	��309��6�   $��22(�6�   $��1��6�   �� 5   
   -   5         ��Name$ StdName��5      $
��Left=�6#   $��40��6>   $��254,19.542,0,0q�6J    �� TextWrapping$
 Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��298��6�   $��18(�6�   $��1��6�   �� 5   
   -   5        $ StdMail��5      $
��Left=�6#   $��40��6>   $��254,90.542,0,0q�6J   $
 Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��298��6�   $��18(�6�   $��1��6�   �� 5   
   -   5        $ 
StdAddress��5      $
��Left=�6&   $��54��6A   $��254,154.542,0,0q�6M   $
 Wrap=�6f   $�� ��6z   $	��Top=�6�   $	��298��6�   $��18(�6�   $��1��6�   �� 5   
   -   5        $ StdSem��5      $
��Left=�6"   $��40��6=   $��254,232.542,0,0q�6I   $
 Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��298��6�   $��18(�6�   $��1��6�   �� 5   
   -   5        $ LoadBtn��5      $
��Load��6"   $
��Left=�61   $��582,100,0,0q�6L   $	��Top=�6a   $	��107��6y   $��31��6�   $��18(�6�   6�   �� 5   
   -   5        $ 	UpdateBtn��5      $��Update��6$   $
��Left=�65   $��463,305.542,0,0q�6P   $	��Top=�6i   $��89��6�   $��31��6�   $��18(�6�   {�.  $��1��6�   �� 5   
   -   5        $ 	DeleteBtn��5      $��Delete��6$   $
��Left=�65   $��359,305.542,0,0q�6P   $	��Top=�6i   $��90��6�   $��31��6�   $��18(�6�   {�.  $��1��6�   �� 5   
   -	   5        $ 	InsertBtn��5      $��Insert��6$   $
��Left=�65   $��254,305.542,0,0q�6P   $	��Top=�6i   $��90��6�   $��31��6�   $��18(�6�   $��1��6�   �� 5   
   -
   5        $ HomeBtn��5      $
��Home��6"   $
��Left=�61   $��
712,22,0,0q�6L   $	��Top=�6`   $	��107��6x   $��31��6�   $��18(�6�   6�   �� 5   
   $
��Left=�6   $��	36,97,0,0q�6/   $
��Wrap=�6B   $��ID��6V   $	��Top=�6`   $��40��6x   $	��133��6�   $��22(�6�   $��2��6�   �� 5   
   -   5        $ StdId��5      $
��Left=�6!   $��33��6<   $��
254,98,0,0q�6H   $
 Wrap=�6\   $�� ��6p   $	��Top=�6x   $	��298��6�   $��18(�6�   �� 5   
   -   5        $ btncClr��5      $��Refresh��6"   $
��Left=�64   $��582,232.8,0,0q�6O   $	��Top=�6f   $	��107��6~   $��1��6�   $��27��6�   $��18(�6�   �� 5   
   $��Student Details��6   $
��Left=�6*   $��
170,23,0,0q�6E   $	��Top=�6Y   $	��348��6q   $��58��6}   $��36(�6�   ���	#FF093A0F$
��Bold"�6�   5!      5"      