   M S B A M L   `   `   `  ����a  ]Sport Application Teacher (New Design), Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:Sport_Application_Teacher__New_Design_&Sport_Application_Teacher__New_Design_  5   	   7    1Sport_Application_Teacher__New_Design_.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Flocal4clr-namespace:Sport_Application_Teacher__New_Design_     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   $	��600��5      $
��1080��6'     � WindowStartupLocation$  CenterScreen=�64   
������� � WindowStyle$
 None=�6l    � 
ResizeMode$ NoResize=�6    � 	Resources 5
         MenuOpen �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value  	MenuClose��%�  &	        &	 �     �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ MenuBar��6a   .\�5        $ 0��6'   $ 60Q�63     5      $ 0:0:0.5��6'   $	 200Q�69   5      5      �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ MenuBar��6a   .\�5        $ 0��6'   $	 200Q�63     5      $ 0:0:0.5��6'   $ 60Q�69   5      5      5       � Triggers 5      :� 5   
   	 :� RoutedEvent$	 ButtonBase.Click��6   
 :� 
SourceName$
 ButtonOpenMenu��66   .[�5      �� #��[  6   5      :� 5   
   $	 ButtonBase.Click��6   $
 ButtonCloseMenu��66   .[�5      �� #��[ 6   5      .��5"      � 
�������.+�5%   
   � $��60��6   $	��Top=�6   ���	#FF0193D6.+�5&      �� $��Journal Hunter��6   $��Center=�6.   $��Center=�6K   $��22(�6f   �� 5'      $��Center=�6    �� Orientation$ 
Horizontal=�64   $��Right=�6M   .+�5(      �� $��v1.1.1��6   $��Center=�6*   $��18(�6E   '  !MaterialDesignThemes.Wpf.PopupBox  5)      $��10q�6*      PlacementMode$ BottomAndAlignRightEdges=�66      	StaysOpen .     PopupContent. 5*      �� $	��150��6!   .+�5+      �� $��Аккаунт��6!   {�.  63   �� 5,      $��Настройки��6!   {�.  65   �� 5-      $��Помощь��6!   {�.  62   �� 5.      �� 5/      -   5         ��Name$ ButtonPopUpLogout��5/   !   $��Завершить��6<   6P   50      51      52      53      � 56   
   -   5         �Name$ MenuBar��56      $��60��6    $
��Left=�6+   ���	#FF174B89{�.  .+�57      �� .+�58      � $	��150��6   ���	#FFEEEEEE.+�59      �� -   5        $ ButtonOpenMenu��59      $��60��65   $��60��6@   $	��Top=�5:      $��Right=�65   ��59   L   Z� ��6b   Z� .��5;      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Menu=�62   $��25��6>   $��25��6I   ���	#FF174B896U   5<      �� 5=      -   5        $ ButtonCloseMenu��5=      $��60��66   $��60��6A   $	��Top=�5>      $��Right=�65   $y�	Collapsed=�6Q   ��5=   M   Z� ��6c   Z� .��5?        $ 	ArrowLeft=�62   $��25��6C   $��25��6N   ���	#FF174B896Z   5@      �� 5A      -   5         ��Name$ 	namePanel��5A   !   $��Bottom=�64   $y�Hidden=�6O   .+�5B      �� -   5         ��Name$ 
nameNumber��5B   $   $��Right=�68   $
��10 0q�6T   $��16(�6b   
���   �6p   �� 5C      -   5        $ nameText��5C   $   $��Right=�66   $��10q�6R   $��50��6^   $��16(�6j   $��WrapWithOverflow=�6x   
���   �6�   5D      5E      �� 5F      $��Disabled=�6   
�������.@�5G      �� -   5        $��60��5G   #   .��5H      �� $ 
Horizontal=�6%   .+�5I        $ ViewDashboard=�66   $��25��6K   $��25��6V   $��10q�6b   $��Center=�6n   �� 5J      $��Главная��6(   $��Center=�67   $��20 10q�6R   5K      5L      �� 5M      -	   5        $��60��5M   #   .��5N      �� $ 
Horizontal=�6%   .+�5O        $ TableAccount=�66   $��25��6J   $��24��6U   $��10q�6a   $��Center=�6m   �� 5P      $��Анализ��6(   $��Center=�66   $��20 10q�6Q   5Q      5R      �� 5S      -
   5        $��60��5S   #   .��5T      �� $ 
Horizontal=�6%   .+�5U        $ GoogleAnalytics=�66   $��25��6M   $��25��6X   $��10q�6d   $��Center=�6p   �� 5V      $��Статистика��6(   $��Center=�6:   $��20 10q�6U   5W      5X      �� 5Y      -   5        $��60��5Y   #   .��5Z      �� $ 
Horizontal=�6%   .+�5[        $ Github=�66   $��25��6D   $��25��6O   $��10q�6[   $��Center=�6g   �� 5\      $��Разработка��6(   $��Center=�6:   $��20 10q�6U   5]      5^      �� 5_      -   5        $��60��5_   #   .��5`      �� $ 
Horizontal=�6%   .+�5a        $ Shutdown=�66   $��25��6F   $��25��6Q   $��10q�6]   $��Center=�6i   �� 5b      $��Завершить��6(   $��Center=�69   $��20 10q�6T   5c      5d      5e      5f      5g       � 5i   
   -   5          �Name$ frame��5i        � NavigationUIVisibility$ Hidden=�6   5k      5l      