   M S B A M L   `   `   `  ����J  FWpfApplication1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApplication1WpfApplication1  5      "    WpfApplication1.pageSchedule   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:WpfApplication1     5        N� Title$  pageSchedule��5      $��1186.28��6   $��683.245��6,   .��5
      �� $��2q�6   ���	#FF00456A �� CornerRadius$ 10��69   
�������._�5   
   � 
�������.+�5      �� -   5         ��Name$ 
grpSubject��5      $��Sched��6+   $
��Left=�6:   $��	10,50,0,0q�6U   $	��Top=�6h   $
��1162��6�   $	��380��6�   .��5      �� .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ subGrid��5         AutoGenerateColumns .     
IsReadOnly .  �� Left$ 10��6v   
 �� Top$ 65��6�   $
��1130��6�   $	��266��6�    J� RenderTransformOrigin$ 0.495,0.633&�6�   ��60   �� 	   Columns	 5      4  .System.Windows.Controls.DataGridTemplateColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$	
 Set��65      
IsReadOnly .    CellTemplate 5   "   �� 5   &   .R�5   *   �� -   5        $	��SET��5   1   $��60��6?   6b   5   '   5      0  *System.Windows.Controls.DataGridTextColumn  5      $

 Code��61   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   �� *code+  5      $
 Description��61    6F   �� *Description+  5      $	
 Day��61    6>   �� *day+  5      $

 Time��61    6?   �� *time+5      5      5      5      5       5!      