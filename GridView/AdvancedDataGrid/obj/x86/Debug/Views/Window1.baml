   M S B A M L   `   `   `  ����G  CExtendedGrid, Version=4.0.0.0, Culture=neutral, PublicKeyToken=nulliDclr-namespace:ExtendedGrid.ExtendedGridControl;assembly=ExtendedGrid ExtendedGrid.ExtendedGridControl  5      _?clr-namespace:ExtendedGrid.ExtendedColumn;assembly=ExtendedGridExtendedGrid.ExtendedColumn  5       WpfControlKit   TestClient.Views.Window1   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      dExtendedGridControlDclr-namespace:ExtendedGrid.ExtendedGridControl;assembly=ExtendedGrid     5      ZExtendedColumn?clr-namespace:ExtendedGrid.ExtendedColumn;assembly=ExtendedGrid     5        � 	Resources  5	       �� MergedDictionaries�� 5   
    5      %    5      .��5      � .+�5   
   7   1ExtendedGrid.ExtendedGridControl.ExtendedDataGrid  -   5          Name$
 grid��5   /   &   System.Windows.Controls.DataGrid   RowHeaderWidth$ 17Q�6a      AutoGenerateColumns .     HideColumnChooser .  $ �� IsSynchronizedWithCurrentItem$
 TrueY�5   /      SelectionMode$ Extended=�6U      SelectionUnit$ CellOrRowHeader=�6n   ��5   =   �� *SourceTable+	   Columns	 5      <   6ExtendedGrid.ExtendedColumn.ExtendedDataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 	Game Name��6<      AllowAutoFilter .  1  +System.Windows.Controls.DataGridBoundColumn   Binding 5   ,   �� *
GameName+  5      $
 Creator��6<    .   5   ,   �� *	Creator+  5      $
 Owner��6<    .   5   ,   �� *Owner+6F     5      $
 	Publisher��6<    .     CanUserSort .     Width5  /System.Windows.Controls.DataGridLengthConverter$ * 5   @    5   ,   �� *	Publisher+5   @      FooterDataTemplate 5       �� 5!      .R�5"      ��  �� Orientation$ 
Horizontal=�6!   .+�5#      �� $��
RowsCount:��6$   $
��Bold"�66   �� 5$      $��3,0,0,0q�6$   
��� d ���6M   ��  �� ElementName$
 grid�� �� Path$ Items.Count�6�   5%      5&      5(      5)      5*      