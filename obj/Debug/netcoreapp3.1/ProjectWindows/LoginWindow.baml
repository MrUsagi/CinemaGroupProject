   M S B A M L   `   `   `  ����H  DCinemaProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:CinemaProject.ProjectWindowsCinemaProject.ProjectWindows  5   	   .    (CinemaProject.ProjectWindows.LoginWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:CinemaProject.ProjectWindows     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	      MaterialDesignBody#���   5	   	   $��Regular"�5
   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � Title$ LoginWindow��5   	   $	��700��6   $	��500��6*   .��5      � ���	#FF1E1E1E.+�5   
   G� -   5         G�Name$ Password��5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Password��5      
�������   
Foreground
 � � �.  (MaterialDesignThemes.Wpf.TextFieldAssist   UnderlineBrush
 � � � ) %MaterialDesignFloatingHintPasswordBox#��[ 5      $��104,389,110,221q�6B   ���	#89FFFFFF6[   �� 5   
   -   5         ��Name$ Login��5      $ Login��5         
HelperText$ More than 5 symbols��5      $��104,260,110,365q�6>   
����������	#89FFFFFF.��6�   ��5      �� 5      	 �� Path$
	 Name�5       
 �� UpdateSourceTrigger$
 PropertyChanged=�5!       �� ValidationRules 5"      5$      .��5%      5&      �� 5'   
   -   5        $��LoginBtn��5'   9    K� ZIndex$ 2��6   $��104,514,110,100q�6I   ���	#FF673AB7$��20(�6�    � Cursor$
 Hand��6�   ��6y   Z� .��6�   Login6�   �� 5(   
   $��Don`t have an account?��6   $��104,578,0,34q�61   $��15(�6G   
�������$
��Left=�6~   $	��169��6�   ��6h   Z� 6�   �� 5)   
   -   5        $��	SingUpBtn��5)   "   $ 3��6   $��278,0,57,52q�6L   ���	#FF673AB7$��20(�6y   $��32��6�   $��Bottom=�6�   .��6�   	Sing up6�   5*      5+      