   M S B A M L   `   `   `  ���� M  ILaminasyonMakinesi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:LaminasyonMakinesiLaminasyonMakinesi       LaminasyonMakinesi.Loading   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     V RXamlAnimatedGif, Version=2.0.0.0, Culture=neutral, PublicKeyToken=20a987d8023d9690<gif2https://github.com/XamlAnimatedGif/XamlAnimatedGif  ,local clr-namespace:LaminasyonMakinesi  -     � Title$  Loading��$
��1080��$
��1920�� � WindowStyle$
 None=� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=�
������  � AllowsTransparency$
 True��.��� .+��� '  !XamlAnimatedGif.AnimationBehavior   	SourceUri$ /View/images/1.gif?�$
��Fill=�$��/View/images/1.gif����  �� CornerRadius$ 0�� J� Opacity$	 0.6Q�����  �� ImageSource$! /View/images/background.png��	 j� Stretch$
	 Fill=�._��� $ 0��$��2q�$
 0.75Q����� 
 �� 
StartPoint$	
 0,0&� �� EndPoint$	 1,1&�.���  � Color$ #462ad8�� � Offset$ 0Q�� $ 	AliceBlue��$
 0.75Q�� $ #8a16c1��$ 1Q����� $	
 0,1&�$	 1,0&�.��� $ #060531��$ 0Q�� $ #1b1448��$
 0.75Q��� ._�� $��0,0,0,0q� � RowDefinitions �� $��30 ��� �� $��60 �.+�� $��0��.+��� $ ��RealTekno Makine Otomasyon��
�������$��13(�$��
Montserrat)�$��0��$��Center=�$��10,0,0,0q��� -    ��Name$ btnClose��$	��Top=�$��Right=�$��50��$��25��$��0,1,1,0q�$��0q�$��X��
�������$��13(�$��
Montserrat)� � Cursor$
 Hand������  �� 
TargetType" ��.���  �� Property � �� �� Value
 ����  �� Triggers P�  P� Property �@J�IsMouseOver P� Value$
 True��. ���  � �� �#c62b1e����  �� 
TargetType" ��.R��� #��z��._��� $��Center=�$��Center=��� $	��650��$��1�� �� Orientation$ Vertical=�$��Center=�.+��� $��/View/images/logo.png��$	��650��$	��150��$
��Fill=��� $!��REALTEKNO MAKİNE OTOMASYON��
�������$��34(�$��Medium"�$��
Montserrat)�$��Center=��� $��LAMİNASYON MAKİNESİ��
�������$��30(�$��Medium"�$��
Montserrat)�$��Center=�� � $��2��.+��� -    ��Name$ 	txtLoaded��$!��REALTEKNO MAKİNE OTOMASYON��
�������$��13(�$��Medium"�$��
Montserrat)�$
��Left=�$��10,0,0,0q�$
��Wrap=�$��Bottom=�$��30��$
��1748���� -   $ 
txtLoading��$��Yükleniyor....��
�������$��12(�$��Medium"�$��
Montserrat)�$��Right=�$��0,0,20,0q�$��1��$��Bottom=�