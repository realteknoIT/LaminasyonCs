   M S B A M L   `   `   `  ���� M  ILaminasyonMakinesi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:LaminasyonMakinesi.View.UControl LaminasyonMakinesi.View.UControl  ,    &LaminasyonMakinesi.View.UControl.onOff   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     @local.clr-namespace:LaminasyonMakinesi.View.UControl     $	��100��$	��200��.����   �� CornerRadius$  15�����	#7F000000$��1q�!  System.Windows.SystemColors   MenuHighlightBrushKey#���  $	��200��$	��100��._�� $��-1,-1,-1,-1q� � ColumnDefinitions �� �� $��0* �.+��� -    ��Name$ deger��$��
Oto/Manual��$	��Top=�$��Center=�
�������$��20(�$
��Bold"�$��34��$	��180��$��0,4,0,0q�d� -    d�Name$ OnOffToggleButton��$	��180��$��44��$��20(�$��Center=�$	��Top=�$��0,37,0,0q�   DesktopBrushKey#���  ����  �� 
TargetType" d�.R�� .+���  ��Name$ Border��$  5�����	#7D6479EF$��	3,6,3,-12q�._�� $
��Left=�$	��154��$��10,0,0,0q�.+��� $ 
ButtonText��$��Manual��
�������$
��Bold"�$��Center=�$
��Left=�$��10,0,0,0q�$��74��d� $��60��$��30��$
��Left=�$	��Top=�
������ $��0q�$��
112,53,0,0q�
���   ����� " d�.R�� .+��� $ BackgroundBorder��$  15��
�������$��30��$��60��A�  A�Name$ Thumb��
�������$��26��$��26��$
��Left=�$��2q�	 �� Triggers	 P� 
 P� Property
 �@d�	IsChecked P� Value$
 TrueY�. ���  �� 
TargetName$ BackgroundBorder�� �� Property � �� �� Value
 � � ��� $ Thumb�� � ��$ Right=�P� 
 �@d�	IsChecked$ FalseY�. ��� $ BackgroundBorder�� � ��
 ������� $ Thumb�� � ��$
 Left=�