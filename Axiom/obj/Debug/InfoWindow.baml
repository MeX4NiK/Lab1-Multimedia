   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5   	   a ]PresentationFramework.Aero, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35gJclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.AeroMicrosoft.Windows.Themes 5   	   b ^PresentationFramework.Aero2, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35hKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2Microsoft.Windows.Themes 5	   	   @ <Axiom, Version=1.9.6.0, Culture=neutral, PublicKeyToken=nullclr-namespace:AxiomAxiom 5
   	   %clr-namespace:ViewModel	ViewModel 5   	   3clr-namespace:Axiom.PropertiesAxiom.Properties 5   	      Axiom.InfoWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9System&clr-namespace:System;assembly=mscorlib     5   	   ]ThemesJclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero     5   	   _Themes1Kclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2     5	   	   "myclr-namespace:Axiom     5
   	   )localclr-namespace:ViewModel     5   	   3settingsclr-namespace:Axiom.Properties     5   	   -   5          �Name$  
windowInfo��5   	    � Title$
 Info��5   	   $	��500��5   	   $	��400��5   	    � UseLayoutRounding .  � Icon$% Resources/Images/Icons/info.ico��5   	    � DataContext 5        ViewModel.VM  5   
    � 	Resources 5         TextBox.Static.Border �� Color  TextBox.MouseOver.Border  TextBox.Focus.Border  TextBoxStyleInfo �� 
TargetType �� Property	 �� Value-  'System.Windows.Input.KeyboardNavigation
 �� 
TargetType ��Name J� SnapsToDevicePixels ��Name �� Triggers P� Property P� Value �� 
TargetName �� Triggers ]� 
Conditions �� Property �� Value��%,  &	        &	 '     &	 N     &	 u     7   7  7  �� 5   
   $ 	#FFABAdB3��5      �� 5   
   $ 	#FF7EB4EA��5      �� 5   
   $ 	#FF569DE5��5      �� 5    
   " ��5!      .�5"      ��  � ��$	 5q�5#      �� 5$       � ��#	 � ��5%      �� 5&       � ��8	   5'      �� 5(       � ��#	 � ��5)      �� 5*       � ��$	 1q�5+      �� 5,       �@ TabNavigation$
	 None=�5-      �� 5.       � ��$
	 Left=�5/      �� 50       �@�FocusVisualStyle	 51      Z� �� 52       �@J�	AllowDrop	 . 53      �� 54       �@��PanningMode$	 VerticalFirst=�55      �� 56       �@��IsFlicksEnabled	 .  57      �� 58       � ��	 59      �� 5:      "
 ��6&   .R�5;      �� $ border��6!   #��z��5<   !   #��z��5=   !   #��z��5>   !    . ._�5@      �� $ PART_ContentHost��6+   |�.  $��Hidden=�5B   +   $��Hidden=�5C   +   5D       5E      P� 5F       � {� .  . �5H   "   �� $ border��5I   )    �@J�Opacity$
	 0.56Q�5J   )   5K      P� 5L       �@J�IsMouseOver . . �5N   "   �� $ border��5O   )   8	   � ��5P   )   5Q      P� 5R       �@J�IsKeyboardFocused . . �5T   "   �� $ border��5U   )   8	   � ��5V   )   5W      5Y      5[       5\      ]� 5]       5^      �� 5_      + �@��#IsInactiveSelectionHighlightEnabled . 5`   $   �� 5a       �@��IsSelectionActive .  5b   $   ./�5d      ��  �@��SelectionBrush#	 � /�5e      5f      5h      5i      .��5j      � .+�5k   
   �� #���  6   $��Disabled=�5l      $
��Auto=�5m      $��10q�5n      $��10q�5o       �� TextWrapping$
 Wrap=�5p       �� TextAlignment$
 Left=�5q       �� 
IsReadOnly .  5s      �� *
MainView+��5t      �� *	Info_Text+5u      5v      