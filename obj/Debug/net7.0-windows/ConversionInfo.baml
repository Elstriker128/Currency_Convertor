   M S B A M L   `   `   `  ����M  ICurrency_Convertor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Currency_ConvertorCurrency_Convertor  5   	   '    !Currency_Convertor.ConversionInfo   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Currency_Convertor     5   	     � Title$  ConversionInfo��5   	   $	��450��6    $	��800��6-    � WindowStartupLocation$ CenterScreen=�69   .��5	      �  � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ ConversionButton��5      $	��Top=�6+   $��Center=�6C   $��0,10,0,0q�6`   $��DemiBold"�6r   $��30(�6�   $��2��6�   $��1��6�   
��� � �
���   �
�������$	��324��6  .��6  	Convert6!  �� 5   
   -   5        $ ExchangeButton��5      $	��Top=�6)   $��Center=�6A   $��DemiBold"�6^   $��36(�6t   $��0��6�   $��2��6�   $��1��6�   
�������
�������
��� � �$��68��6  $��	0,110,0,0q�6  .��6%  ⇄6(  �� 5   
   -   5         ��Name$ FirstCurrency��5      $��Center=�6*   $��Center=�6N   $��
10,50,10,0q�6p   $��30��6�   6�   �� 5   
   -   5        $ SecondCurrency��5      $��Center=�6+   $��Center=�6O   $��
10,50,10,0q�6q   $��30��6�   $��2��6�   �� 5   
   -   5         ��Name$ InputAmount��5      $��Center=�6'   $��Center=�6K    �� TextAlignment$ Right=�6�   $��30(�6�   $��40��6�   $��1��6�   $��10q�6�    �� SelectionBrush �	#FF98FF8A
���   �
��� � �$��0��6(  �� 5   
   -   5        $ ResultAmount��5      $��Center=�6(   $��Center=�6L   $ Right=�6n   $��30(�6�   $��40��6�   $��1��6�   $��2��6�   $��10q�6�    �	#FF98FF8A
���   �
��� � �$��0��6	  	 �� 
IsReadOnly$
	 True��6  5      5       