   M S B A M L   `   `   `  ���� M  ILaminasyonMakinesi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:LaminasyonMakinesiLaminasyonMakinesi  S.clr-namespace:LaminasyonMakinesi.View.UControl LaminasyonMakinesi.View.UControl  #    LaminasyonMakinesi.MainWindow   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     2local clr-namespace:LaminasyonMakinesi     V RXamlAnimatedGif, Version=2.0.0.0, Culture=neutral, PublicKeyToken=20a987d8023d9690<gif2https://github.com/XamlAnimatedGif/XamlAnimatedGif  =controls.clr-namespace:LaminasyonMakinesi.View.UControl  -     � Title$  
MainWindow��$
��1080��$
��1920�� � WindowStyle$
 None=� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=�
����  � � AllowsTransparency$
 True��.��� .+���  �� CornerRadius$ 0�� J� Opacity$
 0.85Q�����  �� ImageSource$" /View/images/background2.png�� j� Stretch$
 fill=��� ._�� $��0,0,0,0q�	 � RowDefinitions	 �� $��60 ��� �� $��80 �.+�� $��0��.+��� -   $��/View/images/logo.png��$��50��$��Uniform=�$	��Top=�$��Right=�$��10,10,1690,0q�
 � Cursor$

 Hand���� $��1�� �� Orientation$ Vertical=�$��	0,10,0,10q�.+� � -     �Name$ Pages��  � Source$ /View/Anasayfa.xaml?�  � NavigationUIVisibility$ Hidden=�$	��916��� � $��2��
���   � � ColumnDefinitions �� �� �� �� �� �� �� �� .+��� -    ��Name$ btnAnasayfa��$��Center=�$��Center=�$	��240��$��80��$��0��$��0,0,0,0q�$��0q�$��ANASAYFA��
�������$
��Bold"�$��20(�$��
Montserrat)�$

 Hand������  �� 
TargetType" ��.���  �� Property � �� �� Value
 ����  �� Triggers P�  P� Property �@J�IsMouseOver P� Value$
 True��. ���  � �� �#c62b1e��  �� Binding �� *
ActivePage+ �� Value btnAnasayfa.a���  � �� �#c62b1e����  �� 
TargetType" ��.R��� #��z��._��� $��Center=�$��Center=��� -   $ btnLaminasyon��$��Center=�$��Center=�$	��240��$��80��$��1��$��0,0,0,0q�$��0q�$��LAMİNASYON��
�������$
��Bold"�$��20(�$��
Montserrat)�$

 Hand������ " ��.���  � ��
 ����  P�  �@J�IsMouseOver$
 True��. ���  � �� �#c62b1e��  �� *
ActivePage+ btnLaminasyon.a���  � �� �#c62b1e���� " ��.R��� #��z��._��� $��Center=�$��Center=��� -   $ 	btnSunger��$��Center=�$��Center=�$	��240��$��80��$��2��$��0,0,0,0q�$��0q�$��SÜNGER��
�������$
��Bold"�$��20(�$��
Montserrat)�$

 Hand������ " ��.���  � ��
 ����  P�  �@J�IsMouseOver$
 True��. ���  � �� �#c62b1e��  �� *
ActivePage+ 	btnSunger.a���  � �� �#c62b1e���� " ��.R��� #��z��._��� $��Center=�$��Center=��� -   $ btnAstar��$��Center=�$��Center=�$	��240��$��80��$��3��$��0,0,0,0q�$��0q�$��ASTAR��
�������$
��Bold"�$��20(�$��
Montserrat)�$

 Hand������ " ��.���  � ��
 ����  P�  �@J�IsMouseOver$
 True��. ���  � �� �#c62b1e��  �� *
ActivePage+ btnAstar.a���  � �� �#c62b1e���� " ��.R��� #��z��._��� $��Center=�$��Center=��� -   $ btnKumas��$��Center=�$��Center=�$	��240��$��80��$��4��$��0,0,0,0q�$��0q�$��KUMAŞ��
�������$
��Bold"�$��20(�$��
Montserrat)�$

 Hand������ " ��.���  � ��
 ����  P�  �@J�IsMouseOver$
 True��. ���  � �� �#c62b1e��  �� *
ActivePage+ btnKumas.a���  � �� �#c62b1e���� " ��.R��� #��z��._��� $��Center=�$��Center=��� -	   $ btnDogSarma��$��Center=�$��Center=�$	��240��$��80��$��5��$��0,0,0,0q�$��0q�$��	DOG SARMA��
�������$
��Bold"�$��20(�$��
Montserrat)�$

 Hand������ " ��.���  � ��
 ����  P�  �@J�IsMouseOver$
 True��. ���  � �� �#c62b1e��  �� *
ActivePage+ btnDogSarma.a���  � �� �#c62b1e���� " ��.R��� #��z��._��� $��Center=�$��Center=��� -
   $ 	btnRecete��$��Center=�$��Center=�$	��240��$��80��$��6��$��0,0,0,0q�$��0q�$��REÇETE��
�������$
��Bold"�$��20(�$��
Montserrat)�$

 Hand������ " ��.���  � ��
 ����  P�  �@J�IsMouseOver$
 True��. ���  � �� �#c62b1e��  �� *
ActivePage+ 	btnRecete.a���  � �� �#c62b1e���� " ��.R��� #��z��._��� $��Center=�$��Center=��� -   $ btnBakim��$��Center=�$��Center=�$	��240��$��80��$��7��$��0,0,0,0q�$��0q�$��BAKIM��
�������$
��Bold"�$��20(�$��
Montserrat)�$

 Hand������ " ��.���  � ��
 ����  P�  �@J�IsMouseOver$
 True��. ���  � �� �#c62b1e��  �� *
ActivePage+ btnBakim.a���  � �� �#c62b1e���� " ��.R��� #��z��._��� $��Center=�$��Center=�-   'LaminasyonMakinesi.View.UControl.Errors  -     Name$ txbError��-   'LaminasyonMakinesi.View.UControl.Errors   MouseLeftButtonDown$" txbError_MouseLeftButtonDown��$��25,75,1521,895q�   IsError$
 True��/   )LaminasyonMakinesi.View.UControl.loginBtn  -     Name$ btnLogin��/   )LaminasyonMakinesi.View.UControl.loginBtn   MouseLeftButtonDown$" btnLogin_MouseLeftButtonDown��$��1870,10,10,1015q�