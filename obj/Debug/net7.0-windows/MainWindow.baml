   M S B A M L   `   `   `  ����M  ICurrency_Convertor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Currency_ConvertorCurrency_Convertor  5   	   #    Currency_Convertor.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Currency_Convertor     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � WindowStartupLocation$ CenterScreen=�65   .��5	      � $��10q�6    � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� -   5         ��Name$ ApiPlacement��5       �� TextAlignment$ Center=�6(   $��25(�6?   $��40��6M   $��0��6Y   $��120,120,120,10q�6f    �� SelectionBrush �	#FF1AD700
���   ����	#FF8A8585$��Input your API key��6�   6  �� 5   
   -   5         ��Name$ ActivationButton��5      $	��Top=�6+   $��Center=�6C   $��0,10,0,0q�6`   $��DemiBold"�6r   $��30(�6�   $��1��6�   
��� � �
���   �
�������$	��324��6�   .��6  
Validate6  �� 5   
   -   5         ��Name$ 
InvalidKey��5      $��Invalid API Key��6$   $	��Top=�6>   $��0��6V   $��Center=�6c   $��	0,104,0,0q�6�   
���  ��$y�Hidden=�6�   5      5      