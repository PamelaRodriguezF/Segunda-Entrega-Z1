   M S B A M L   `   `   `  ����G  CMercadoLider, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:MercadoLiderMercadoLider  5	      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 60        MercadoLider.MenuProductos   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      &localclr-namespace:MercadoLider  5	      3System&clr-namespace:System;assembly=mscorlib  60     N� Title$  MenuProductos��5
   Z   .��5      �� -   5         ��Name$" ___CanvasResultadosBusqueda_��5      $	��620��63   $
��1180��6@    �� Left$	 100��6M   
 �� Top$	 100��6_   
�������.+�5   
   �� -   5         ��Name$ BorderLogoEmpresa��5      $��1q�6,   $	��120��6@   $ 10��6M   $	��290��6]   ��5      �� 5       �� ImageSource$; 5/MercadoLider;component/Recursos/MercadoLiderLogo.png��6    j� Stretch$
 None=�6a   5      �� 5   
   -   5         ��Name$ FormatoBusquedaLabel��5      $��25��6.   $	��250��6:   $�� ��6F   $��0q�6Q   $	 809��6]   $ 39��6o   $��14(�6   $��Italic$�6�   $��Right=�6�   �� 5   
   -   5         ��Name$ TextBoxBuscador��5      $��46��6+   $	��730��67   $��Center=�6C   $��Center=�6`   $��	Open Sans)�6{   )  #MaterialDesignThemes.Wpf.HintAssist	   Hint$-	 'Busca aqui los productos que necesitas!��6�   
   
Foreground
 �	#FF2F3E45.  (MaterialDesignThemes.Wpf.TextFieldAssist   UnderlineBrush �	#FF2F3E45 %  !MaterialDesignFloatingHintTextBox#��[  6F   �� 
CaretBrush �	#FF2F3E45���	#FF2F3E45���	#FF2F3E45$��16(�6�   �� SelectionBrush �	#FF2F3E45$��Center=�6  $��0q�6*  $	 330��65  $ 64��6G  ��6�  Z� 6G  �� 5   
   -   5         ��Name$ BotonBuscador��5      $��Buscar!��6(   $ 71��6:   $��70��6J   ���	#FF1C1530���	#FF91B7C0$��Segoe UI Light)�6�   $��Normal"�6�   $��0q�6�   $
 1075��6�   $��32��6�   �� 5   
   -   5        $ 
BotonAtras��5      $��Atrás��6%   $	 557��65   $	��105��6F   ���	#FF1C1530���	#FF91B7C0$��Segoe UI Light)�6�   $��Normal"�6�   $��0q�6�   $
 1025��6�   $��40��6�   � 5   
   -   5         �Name$ 	GridPadre��5      $
��1140��6"   $	��400��6/   $ 20��6<   $	 135��6M    � RowDefinitions 5      �� 5      $	��400 �6     � ColumnDefinitions 5      �� 5       $	��220 �6#   �� 5!      $��10 �6#   �� 5"      $	��220 �6#   �� 5#      $��10 �6#   �� 5$      $	��220 �6#   �� 5%      $��10 �6#   �� 5&      $	��220 �6#   �� 5'      $��10 �6#   �� 5(      $	��220 �6#   .+�5,      #  MaterialDesignThemes.Wpf.Card  $	��220��6"   $��0��6.   ���	#FF1D344E$y�Visible=�6U   .��5-      � -   5        $ PrimerProductoGrid��5-       5.      �� 5/      $	��220 �6(   �� 50      $��* �6(   �� 51      $
��Auto �6(   .+�55      �� -	   5         ��Name$ ImagenPrimerProducto��55      $C��=/MercadoLider;component/Recursos/Temporal/Album The Stage.jpg��56      $	��220��57      $	��220��58      $
��Fill=�59      �� 5<      $��0��5=       0 ,MaterialDesignFloatingActionMiniAccentButton#��[ 5>      $��Right=�5?      $��Bottom=�5@      $��
0,0,16,112q�5A      $��$7000��6-   $��2��6=   $��49��6N   �� 5C      $��1��6!   $��8 24 8 0q�6.   .+�5E      �� -
   5         ��Name$ TituloPrimerProducto��5E   $   $
��Bold"�6B   
�������%#Albúm The Stage - Edición Limitda5G      �� 5I      -   5        $ DescripcionPrimerProducto��5I   $   $
��Wrap=�5J      $��Center=�5K       �� TextAlignment$ Justify=�68   $��11(�6P   
���������Albúm sin abrir en edición coleccionista, con detalles y detrás de escenas además de contenido multimedia exclusivo sobre los artistas y sus giras durante la promoción del mismo en los años de salida, además te trae de ragalo un...5M      5N      �� 5O      $��Right=�6!   $��2��6=    �� Orientation$ 
Horizontal=�6J   $��8q�6c   .+�5Q      �� -   5        $ BotonVerMasPrimerProducto��5Q   !    " MaterialDesignRaisedDarkButton#��[ 5R      $��72��5S      $��2 0 2 0q�5T      +  %MaterialDesignThemes.Wpf.RippleAssist   
IsCentered . $��
Ver mas...��5V      ���	#FF788696���	#FF1D344E5W      5X      5Y      5Z        5\      $	��220��6"   $��2��6.   ���	#FF1D344E
�������$y�Hidden=�6h   .��5]      � -   5        $ SegundoProductoGrid��5]       5^      �� 5_      $	��220 �6(   �� 5`      $��* �6(   �� 5a      $
��Auto �6(   .+�5d      �� -   5        $ ImagenSegundoProducto��5d      $C��=/MercadoLider;component/Recursos/Temporal/Album The Stage.jpg��5e      $	��220��5f      $	��220��5g      $
��Fill=�5h      �� 5j      $��0��5k      #��[ 5l      $��Right=�5m      $��Bottom=�5n      $��
0,0,16,112q�5o      $��2��6-   $��49��6>   $��$7000��6I   �� 5q      $��1��6!   $��8 24 8 0q�6.   .+�5s      �� -   5        $ TituloSegundoProducto��5s   $   $
��Bold"�6C   %#Albúm The Stage - Edición Limitda5u      �� 5w      -   5        $  DescripcionSegundoProducto��5w   $   $
��Wrap=�5x      $��Center=�5y      $ Justify=�68   $��11(�6P   ��Albúm sin abrir en edición coleccionista, con detalles y detrás de escenas además de contenido multimedia exclusivo sobre los artistas y sus giras durante la promoción del mismo en los años de salida, además te trae de ragalo un...5{      5}      �� 5~      $��Right=�6!   $��2��6=   $ 
Horizontal=�6J   $��8q�6c   .+�5�      �� -   5        $! BotonVerMasSegundoProducto1��5�   !   #��[ 5�      $��72��5�      $��2 0 2 0q�5�       . $��
Ver mas...��5�      ���	#FF788696���	#FF1D344E5�      5�      5�      5�        5�      $	��220��6"   $��4��6.   ���	#FF1D344E$y�Hidden=�6U   .��5�      � -   5        $ TercerProductoGrid��5�       5�      �� 5�      $	��220 �6(   �� 5�      $��* �6(   �� 5�      $
��Auto �6(   .+�5�      �� -   5        $ ImagenTercerProducto��5�      $C��=/MercadoLider;component/Recursos/Temporal/Album The Stage.jpg��5�      $	��220��5�      $	��220��5�      $
��Fill=�5�      �� 5�      $��0��5�      #��[ 5�      $��Right=�5�      $��Bottom=�5�      $��
0,0,16,112q�5�      $��2��6-   $��49��6>   $��$7000��6I   �� 5�      $��1��6!   $��8 24 8 0q�6.   .+�5�      �� -   5        $ TituloTercerProducto��5�   $   $
��Bold"�6B   
�������%#Albúm The Stage - Edición Limitda5�      �� 5�      -   5        $ DescripcionTercerProducto��5�   $   $
��Wrap=�5�      $��Center=�5�      $ Justify=�68   $��11(�6P   
���������Albúm sin abrir en edición coleccionista, con detalles y detrás de escenas además de contenido multimedia exclusivo sobre los artistas y sus giras durante la promoción del mismo en los años de salida, además te trae de ragalo un...5�      5�      �� 5�      $��Right=�6!   $��2��6=   $ 
Horizontal=�6J   $��8q�6c   .+�5�      �� -   5        $ BotonVerMasTercerProducto��5�   !   #��[ 5�      $��72��5�      $��2 0 2 0q�5�       . $��
Ver mas...��5�      ���	#FF788696���	#FF1D344E5�      5�      5�      5�        5�      $	��220��6"   $��6��6.   ���	#FF1D344E$y�Hidden=�6U   .��5�      � -   5        $ CuartoProductoGrid��5�       5�      �� 5�      $	��220 �6(   �� 5�      $��* �6(   �� 5�      $
��Auto �6(   .+�5�      �� -   5        $ ImagenCuartoProducto��5�      $C��=/MercadoLider;component/Recursos/Temporal/Album The Stage.jpg��5�      $	��220��5�      $	��220��5�      $
��Fill=�5�      �� 5�      $��0��5�      #��[ 5�      $��Right=�5�      $��Bottom=�5�      $��
0,0,16,112q�5�      $��2��6-   $��49��6>   $��$7000��6I   �� 5�      $��1��6!   $��8 24 8 0q�6.   .+�5�      �� -   5        $ TituloCuartoProducto��5�   $   $
��Bold"�6B   
�������%#Albúm The Stage - Edición Limitda5�      �� 5�      -   5        $ DescripcionCuartoProducto��5�   $   $
��Wrap=�5�      $��Center=�5�      $ Justify=�68   $��11(�6P   
���������Albúm sin abrir en edición coleccionista, con detalles y detrás de escenas además de contenido multimedia exclusivo sobre los artistas y sus giras durante la promoción del mismo en los años de salida, además te trae de ragalo un...5�      5�      �� 5�      $��Right=�6!   $��2��6=   $ 
Horizontal=�6J   $��8q�6c   .+�5�      �� -   5        $ BotonVerMasCuartoProducto��5�   !   #��[ 5�      $��72��5�      $��2 0 2 0q�5�       . $��
Ver mas...��5�      ���	#FF788696���	#FF1D344E5�      5�      5�      5�        5�      $	��220��6"   $��8��6.   ���	#FF1D344E$y�Hidden=�6U   .��5�      � -   5        $ QuintoProductoGrid��5�       5�      �� 5�      $	��220 �6(   �� 5�      $��* �6(   �� 5�      $
��Auto �6(   .+�5�      �� -   5        $ ImagenQuintoProducto��5�      $C��=/MercadoLider;component/Recursos/Temporal/Album The Stage.jpg��5�      $	��220��5�      $	��220��5�      $
��Fill=�5�      �� 5�      $��0��5�      #��[ 5�      $��Right=�5�      $��Bottom=�5�      $��
0,0,16,112q�5�      $��2��6-   $��49��6>   $��$7000��6I   �� 5�      $��1��6!   $��8 24 8 0q�6.   .+�5�      �� -   5        $ TituloQuintoProducto��5�   $   $
��Bold"�6B   
�������%#Albúm The Stage - Edición Limitda5�      �� 5     -   5        $ DescripcionQuintoProducto��5  $   $
��Wrap=�5     $��Center=�5     $ Justify=�68   $��11(�6P   
���������Albúm sin abrir en edición coleccionista, con detalles y detrás de escenas además de contenido multimedia exclusivo sobre los artistas y sus giras durante la promoción del mismo en los años de salida, además te trae de ragalo un...5     5     �� 5     $��Right=�6!   $��2��6=   $ 
Horizontal=�6J   $��8q�6c   .+�5	     �� -    5        $ BotonVerMasQuintoProducto��5	  !   #��[ 5
     $��72��5     $��2 0 2 0q�5      . $��
Ver mas...��5     ���	#FF788696���	#FF1D344E5     5     5     5     5     5     5     