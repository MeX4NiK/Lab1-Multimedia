   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5   	   a ]PresentationFramework.Aero, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35gJclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.AeroMicrosoft.Windows.Themes 5   	   b ^PresentationFramework.Aero2, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35hKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2Microsoft.Windows.Themes 5   	   @ <Axiom, Version=1.9.6.0, Culture=neutral, PublicKeyToken=nullclr-namespace:AxiomAxiom 5	   	   %clr-namespace:ViewModel	ViewModel 5
   	      Axiom.CropWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9System&clr-namespace:System;assembly=mscorlib     5   	   ]ThemesJclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero     5   	   _Themes1Kclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2     5   	   "myclr-namespace:Axiom     5	   	   )localclr-namespace:ViewModel     5
   	     � Title$
  Crop��5   	   $	��270��5   	   $	��480��5   	    � Icon$ 	axiom.ico��5   	    � 
ResizeMode$ CanMinimize=�5   	    �� BitmapScalingMode$
 Fant=�5   	    � UseLayoutRounding .    
WindowCrop#���   5   	    � DataContext 5        ViewModel.VM  5   
   .��5      � .+�5   
   ��   
LabelStyle#���  6   $��X��5      $
��Left=�5      $��
15,107,0,0q�5      $	��Top=�5       $��20��5!      �� 5"   
   -   5         ��Name$ tbxCropX��5"      $
��Left=�5$      $��22��5%      $��
32,109,0,0q�5&       �� TextWrapping$ NoWrap=�5'       �� MaxLines$ 1��5(      $	��Top=�5)      $��60��5*        TextBoxStyle#���  5+      	 ^� ShowOnDisabled	 . 
 � ToolTip$ 
 Position of Crop from Left��5.      ��5#      �� *VideoView.Video_Crop_X_Text+ �� Mode$ TwoWay=�5.      �� 51   
   #���  6   $��Y��52      $
��Left=�53      $��
186,15,0,0q�54      $	��Top=�55      $��21��56      �� 57   
   -   5        $ tbxCropY��57      $
��Left=�59      $��22��5:      $��
202,17,0,0q�5;      $ NoWrap=�5<      $ 1��5=      $	��Top=�5>      $��60��5?      #���  5@      	 . $
 Position of Crop from Top��5C      ��58      �� *VideoView.Video_Crop_Y_Text+$ TwoWay=�5C      �� 5F   
   #���  6   $��Width��5G      $
��Left=�5H      $��
178,84,0,0q�5I      $	��Top=�5J      $��44��5K      �� 5L   
   -   5        $ tbxCropWidth��5L      $
��Left=�5N      $��22��5O      $��170,109,0,0q�5P      $ NoWrap=�5Q      $ 1��5R      $	��Top=�5S      $��60��5T      #���  5U      	 . $
 Width of Cropped Area��5X      ��5M      �� *!VideoView.Video_Crop_Width_Text+$ TwoWay=�5X      �� 5[   
   #���  6   $��Height��5\      $
��Left=�5]      $��
241,84,0,0q�5^      $	��Top=�5_      $��48��5`      �� 5a   
   -   5        $ tbxCropHeight��5a      $
��Left=�5c      $��22��5d      $��235,109,0,0q�5e      $ NoWrap=�5f      $ 1��5g      $	��Top=�5h      $��60��5i      #���  5j      	 . $
 Height of Cropped Area��5m      ��5b      �� *" VideoView.Video_Crop_Height_Text+$ TwoWay=�5m      �� 5p   
   $
��Left=�6   $	��152��5q      $��	97,44,0,0q�5r      
�������$	��Top=�5t      $	��270��5u      $��1��5v      �� 5y   
   -   5         ��Name$ 	buttonSet��5y        ButtonStyle#���  5z      $
��Left=�5{      $��387,194,0,0q�5|      $	��Top=�5}      $��60��5~      $��22��5       � Cursor$
 Hand��5�      .��5�      �� $	��Set��6   $��0,-2,0,0q�5�      5�      �� 5�   
   -   5        $ btnClear��5�      #���  5�      $
��Left=�5�      $��
17,194,0,0q�5�      $	��Top=�5�      $��60��5�      $��22��5�      $
 Hand��5�      .��5�      �� $��Clear��6   $��0,-2,0,0q�5�      5�      5�      5�      