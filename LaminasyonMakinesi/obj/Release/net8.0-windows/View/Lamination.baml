   M S B A M L   `   `   `  ���� M  ILaminasyonMakinesi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:LaminasyonMakinesiLaminasyonMakinesi  S.clr-namespace:LaminasyonMakinesi.View.UControl LaminasyonMakinesi.View.UControl  #    LaminasyonMakinesi.Lamination   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     2local clr-namespace:LaminasyonMakinesi     Ccontrols.clr-namespace:LaminasyonMakinesi.View.UControl     -     N� 
Background
  ����  N� Title$ 
Lamination��.��� ����  �� ImageSource$ /View/images/astar.png�� j� Stretch$ Uniform=� �� Opacity$	 0.5Q�.+�1   +LaminasyonMakinesi.View.UControl.spinnerSol  -     Name$ 	sungerSol��1   +LaminasyonMakinesi.View.UControl.spinnerSol   	MouseDown$ sungerSol_MouseDown��$��910,113,896,685q�   TargetWidth$	 100��$y�Visible=�
   Run$ false��  -   $ kumasSol��$��910,236,896,562q�$	 100��$y�Hidden=�$ false��  -   $ astarSol��$��910,354,896,444q�$	 100��$y�Visible=�$ false��1   +LaminasyonMakinesi.View.UControl.spinnerSag  -   	  Name$	 	sungerSag��$��910,113,896,685q�
   TargetWidth$	
 100��$y�Hidden=�
   Run$ false��  -   $	 kumasSag��$��910,236,896,562q�$	
 100��$y�Visible=�$ false��  -   $	 astarSag��$��910,354,896,444q�$	
 100��$y�Hidden=�$ false��1   +LaminasyonMakinesi.View.UControl.waterArrow  -     Name$ laminasyonSungerAkis��$��80��$��60��$��825,113,1015,743q�
   Run$ false��  -	   $ laminasyonKumasAkis��$��80��$��60��$��825,236,1015,620q�$ false��  -
   $ laminasyonAstarAkis��$��80��$��60��$��825,364,1015,492q�$ false��1   +LaminasyonMakinesi.View.UControl.flameAnima  -     Name$ 
kumasFlame��$��806,181,1106,0q�$��30��$	��Top=�
   Run$
 True��  -   $ 
astarFlame��$��1026,280,886,0q�$��42��$	��Top=�$
 True��0   *LaminasyonMakinesi.View.UControl.TextGroup  -     Name$ LamineliKumas��   Title$ Astar��   	Subtitles$K ESilindir Mesafesi;Brülor Mesafesi;Dog Hızı;Çekme Hızı;Alev Boyu��   Color$! White;White;Red;White;White��   Value$ 	0;1;2;3;4��   Unit$ mm;mm;m/dk;m/dk;%��$��1290,90,354,531q��� -    ��Name$ button��$��Button��$��264,170,1485,670q�