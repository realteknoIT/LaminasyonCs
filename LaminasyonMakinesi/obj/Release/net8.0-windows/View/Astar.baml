   M S B A M L   `   `   `  ���� M  ILaminasyonMakinesi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:LaminasyonMakinesiLaminasyonMakinesi  S.clr-namespace:LaminasyonMakinesi.View.UControl LaminasyonMakinesi.View.UControl  #    LaminasyonMakinesi.View.Astar   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     2local clr-namespace:LaminasyonMakinesi     Ccontrols.clr-namespace:LaminasyonMakinesi.View.UControl       N� 
Background
  ����  N� Title$ Astar��.��� ����  �� ImageSource$ /View/images/astar.png�� j� Stretch$ Uniform=� �� Opacity$	 0.5Q�.+�1   +LaminasyonMakinesi.View.UControl.spinnerSag  -     Name$ laminasyonSungerGirisSag��$��80��$��80��$��920,70,915,650q�   TargetWidth$ 80��$y�Hidden=�
   Run$ false��1   +LaminasyonMakinesi.View.UControl.spinnerSol  -     Name$ laminasyonSungerGirisSol��$��80��$��80��$��920,70,915,650q�	   TargetWidth$	 80��$y�Visible=�

   Run$
 false��  -   $ laminasyonKumasGirisSag��$��80��$��80��$��920,250,915,580q�$ 80��$y�Visible=�$ false��  -   $ laminasyonKumasGirisSol��$��80��$��80��$��920,259,915,580q�$	 80��$y�Hidden=�$
 false��  -   $ laminasyonAstarGirisSag��$��80��$��80��$��920,350,915,487q�$ 80��$y�Hidden=�$ false��  -   $ laminasyonAstarGirisSol��$��80��$��80��$��920,350,915,440q�$	 80��$y�Visible=�$
 false��1   +LaminasyonMakinesi.View.UControl.flameAnima  -     Name$ 
kumasFlame��$��750,180,1050,0q�$��30��$	��Top=�
   Run$
 True��  -   $ 
astarFlame��$��1020,300,880,0q�$��30��$	��Top=�$
 True��/   )LaminasyonMakinesi.View.UControl.textBox1  -	     Name$ sicaklikGiris��   Value$ Giriş Sıcaklık��$	��100��$��30��$��1070,0,720,700q�  -
   $ sicaklikCikis��$ Çıkış Sıcaklık��$	��100��$��30��$��450,0,1250,700q�/   )LaminasyonMakinesi.View.UControl.textBox2  -     Name$ lbl_süngerDereceGiris��   Unit$	 °C��   Value$ 0��$��40��$��17��$��1090,90,750,675q�  -   $ lbl_kumasDereceGiris��$	 °C��$ 0��$��40��$��17��$��1090,200,750,530q�  -   $ lbl_astarDereceGiris��$	 °C��$ 0��$��40��$��17��$��1090,320,750,410q�  -   $ lbl_süngerDereceCikis��$	 °C��$ 0��$��40��$��17��$��450,0,1250,560q�  -   $ lbl_kumasDereceCikis��$	 °C��$ 0��$��40��$��17��$��450,0,1250,330q�  -   $ lbl_astarDereceCikis��$	 °C��$ 0��$��40��$��17��$��450,0,1250,100q�4   .LaminasyonMakinesi.View.UControl.UpDownTextbox  -     Name$# lbl_sungerKumasSilindirMesafe��4   .LaminasyonMakinesi.View.UControl.UpDownTextbox   	MouseDown$) #sungerKumasSilindirMesafe_MouseDown��   Title$( "Sünger - Kumaş Silindir Mesafesi��$	��150��$��90��   Unit$ mm��   Value$ 0��$��1211,195,559,675q� � Cursor$
 Hand��/   )LaminasyonMakinesi.View.UControl.textBox3  -     Name$" lbl_kumasAstarSilindirMesafe��/	   )LaminasyonMakinesi.View.UControl.textBox3 	  	MouseDown$( "kumasAstarSilindirMesafe_MouseDown��   Title$&  Kumaş - Astar Silindir Mesafesi��$	��150��$��90��   Unit$ mm��   Value$ 0��$��1211,374,559,496q�$
 Hand��  -   $ sagCekiciMotorKontrol��$" Çekici Motor Manual Kontrol��$	��200��$��30��$��1290,515,430,415q�  -   $ solCekiciMotorKontrol��$" Çekici Motor Manual Kontrol��$	��200��$��30��$��445,515,1275,415q�  -   $ lbl_solBrulorMesafe��$ solBrulorMesafe_MouseDown��$ Brülör Mesafesi��$	��150��$��60��$ mm��$ 0��$��250,30,1350,550q�$
 Hand��  -   $ lbl_sagBrulorMesafe��$ sagBrulorMesafe_MouseDown��$ Brülör Mesafesi��$	��150��$��60��$ mm��$ 0��$��1457,320,313,580q�$
 Hand��1
   +LaminasyonMakinesi.View.UControl.whiteArrow
  -    
 Name$( "sungerKumasSilindirMesafesiArrowUp��1   +LaminasyonMakinesi.View.UControl.whiteArrow   	MouseDown$2 ,sungerKumasSilindirMesafesiArrowUp_MouseDown��$��80��$��80��$��1350,160,490,720q�$
 Hand��5   /LaminasyonMakinesi.View.UControl.whiteArrowDown  -     Name$* $sungerKumasSilindirMesafesiArrowDown��5   /LaminasyonMakinesi.View.UControl.whiteArrowDown    	MouseDown$4  .sungerKumasSilindirMesafesiArrowDown_MouseDown��$��80��$��80��$��1350,245,490,635q�$
 Hand��
  -   $% kumasAstarSilindirMesafeArrowUp��$/ )kumasAstarSilindirMesafeArrowUp_MouseDown��$��80��$��80��$��1350,341,490,539q�$
 Hand��  -   $' !kumasAstarSilindirMesafeArrowDown��$1  +kumasAstarSilindirMesafeArrowDown_MouseDown��$��80��$��80��$��1350,425,490,455q�$
 Hand��
  -   $ sagbrulorMesafeArrowUp��$&  sagbrulorMesafeArrowUp_MouseDown��$��80��$��80��$��1595,270,245,610q�$
 Hand��  -   $ sagbrulorMesafeArrowDown��$(  "sagbrulorMesafeArrowDown_MouseDown��$��80��$��80��$��1595,355,245,525q�$
 Hand��5   /LaminasyonMakinesi.View.UControl.whiteArrowLeft  -   !  Name$$! sagCekiciMotorKontrolArrowLeft��5   /LaminasyonMakinesi.View.UControl.whiteArrowLeft"   	MouseDown$." (sagCekiciMotorKontrolArrowLeft_MouseDown��$��80��$��80��$��1310,545,530,335q�$
 Hand��6   0LaminasyonMakinesi.View.UControl.whiteArrowRight  -   #  Name$%# sagCekiciMotorKontrolArrowRight��6   0LaminasyonMakinesi.View.UControl.whiteArrowRight$   	MouseDown$/$ )sagCekiciMotorKontrolArrowRight_MouseDown��$��80��$��80��$��1395,545,445,335q�$
 Hand��  -   $$! solCekiciMotorKontrolArrowLeft��$." (solCekiciMotorKontrolArrowLeft_MouseDown��$��80��$��80��$��465,545,1375,335q�$
 Hand��  -    $%# solCekiciMotorKontrolArrowRight��$/$ )solCekiciMotorKontrolArrowRight_MouseDown��$��80��$��80��$��550,545,1290,335q�$
 Hand��
  -!   $ solbrulorMesafeArrowUp��$&  solbrulorMesafeArrowUp_MouseDown��$��80��$��80��$��250,140,1590,740q�$
 Hand��  -"   $ solbrulorMesafeArrowDown��$(  "solbrulorMesafeArrowDown_MouseDown��$��80��$��80��$��250,225,1590,655q�$
 Hand��,   &LaminasyonMakinesi.View.UControl.onOff  -#   %  Name$% lbl_onOffBtn��& �� TextAlignment$& Center=�$	��200��$	��100��$��1680,820,40,40q�