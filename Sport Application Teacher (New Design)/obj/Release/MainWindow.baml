   M S B A M L   `   `   `  ���� a  ]Sport Application Teacher (New Design), Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:Sport_Application_Teacher__New_Design_&Sport_Application_Teacher__New_Design_  7    1Sport_Application_Teacher__New_Design_.MainWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Flocal4clr-namespace:Sport_Application_Teacher__New_Design_     V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  $	��600��$
��1080��  � WindowStartupLocation$  CenterScreen=�
������� � WindowStyle$
 None=� � 
ResizeMode$ NoResize=� � 	Resources    MenuOpen �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value  	MenuClose��%�   &	        &	 p     �� .��U� $ (FrameworkElement.Width)�$ MenuBar��.\�  $ 0��$ 60Q�  $ 0:0:0.5��$	 200Q��� .��U� $ (FrameworkElement.Width)�$ MenuBar��.\�  $ 0��$	 200Q�  $ 0:0:0.5��$ 60Q� � Triggers :� 	 :� RoutedEvent$	 ButtonBase.Click��
 :� 
SourceName$
 ButtonOpenMenu��.[��� #��[  :� $	 ButtonBase.Click��$
 ButtonCloseMenu��.[��� #��[ .��� 
�������.+�� $��60��$	��Top=����	#FF0193D6.+��� $��Journal Hunter��$��Center=�$��Center=�$��22(��� $��Center=� �� Orientation$ 
Horizontal=�$��Right=�.+��� $��v1.1.1��$��Center=�$��18(�'  !MaterialDesignThemes.Wpf.PopupBox  $��10q�   PlacementMode$ BottomAndAlignRightEdges=�   	StaysOpen .     PopupContent. �� $	��150��.+��� $��Аккаунт��{�.  �� $��Настройки��{�.  �� $��Помощь��{�.  �� �� -    ��Name$ ButtonPopUpLogout��$��Завершить��� -    �Name$ MenuBar��$��60��$
��Left=����	#FF174B89{�.  .+��� .+�� $	��150�����	#FFEEEEEE.+��� -   $ ButtonOpenMenu��$��60��$��60��$	��Top=�$��Right=���Z� ��Z� .��'  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Menu=�$��25��$��25�����	#FF174B89�� -   $ ButtonCloseMenu��$��60��$��60��$	��Top=�$��Right=�$y�	Collapsed=���Z� ��Z� .��  $ 	ArrowLeft=�$��25��$��25�����	#FF174B89�� -    ��Name$ 	namePanel��$��Bottom=�$y�Hidden=�.+��� -    ��Name$ 
nameNumber��$��Right=�$
��10 0q�$��16(�
���   ��� -   $ nameText��$��Right=�$��10q�$��50��$��16(�$��WrapWithOverflow=�
���   ��� $��Disabled=�
�������.@��� -   $��60��.���� $ 
Horizontal=�.+�  $ ViewDashboard=�$��25��$��25��$��10q�$��Center=��� $��Главная��$��Center=�$��20 10q��� -	   $��60��.���� $ 
Horizontal=�.+�  $ TableAccount=�$��25��$��24��$��10q�$��Center=��� $��Анализ��$��Center=�$��20 10q��� -
   $��60��.���� $ 
Horizontal=�.+�  $ GoogleAnalytics=�$��25��$��25��$��10q�$��Center=��� $��Статистика��$��Center=�$��20 10q��� -   $��60��.���� $ 
Horizontal=�.+�  $ Github=�$��25��$��25��$��10q�$��Center=��� $��Разработка��$��Center=�$��20 10q��� -   $��60��.���� $ 
Horizontal=�.+�  $ Shutdown=�$��25��$��25��$��10q�$��Center=��� $��Завершить��$��Center=�$��20 10q� � -     �Name$ frame��  � NavigationUIVisibility$ Hidden=�