   M S B A M L   `   `   `  ����J  FWpfApplication1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApplication1WpfApplication1  5           WpfApplication1.pageGrades   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      T PMahApps.Metro, Version=1.2.4.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f;Controls,http://metro.mahapps.com/winfx/xaml/controls  5      )localclr-namespace:WpfApplication1  5        N� Title$  
pageGrades��5	      $��1186.28��6   $��683.245��6+   .��5
      �� $��2q�6   ���	#FF00456A �� CornerRadius$ 10��69   
�������._�5   
   �� $��56,48,48,44q�6   .+�5      �� -   5        $��	txtsearch��5      $	��224��6'    �� Left$ 10��63   
 �� Top$ 10��6D   �� 5      -   5        $��Search��5      $	 258��6&   $ 10��68   $��26��6H   $��94��6T   6_   �� 5      $��First Name:��6   $ 10��6*   $ 56��6;   �� 5      $��Middle Name:��6   $	 356��6+   $ 64��6=   �� 5      $��
Last Name:��6   $	 710��6)   $ 64��6;   �� 5      -   5        $��txtfname��5      $	��322��6&   $ 10��62   $ 87��6C   �� 5      -   5        $��txtmname��5      $	��322��6&   $	 356��62   $ 87��6D   �� 5      -   5        $��txtlname��5      $	��322��6&   $	 710��62   $ 87��6D   &   System.Windows.Controls.DataGrid  5      -   5          Name$ 
gradesGrid��5         
IsReadOnly .     AutoGenerateColumns .  $ 10��6r   $	 134��6�   $	��368��6�   $
��1058��6�   ��6+   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Subject Code��6)   	   
IsReadOnly	 . 1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6?   �� *code+6X     5      $ Description��6)   	 . 
 6>   �� *Description+6^     5      $ Units��6)   	 . 
 68   �� *Units+6R     5      $ Status��6)   	 . 
 69   �� *status+6T     5      $ Grades��6)   5      �� 5      $��PRINT��6   $	 884��6%   $	 529��67   $��48��6H   $	��184��6T   �� 5      -   5         ��Name$ btnSave��5      $
��SAVE��6&   $	 784��65   $	 529��6G   $��77��6X   $��48��6c   6o   5      5       5"      