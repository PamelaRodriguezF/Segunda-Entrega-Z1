   M S B A M L   `   `   `  ����G  CMercadoLider, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:MercadoLiderMercadoLider  5   h  #    MercadoLider.ProductosUsuario   6   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    6"   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     6d   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6�   @d2http://schemas.microsoft.com/expression/blend/2008     6�   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  6  &localclr-namespace:MercadoLider  6h    N� Title$  ProductosUsuario��6�  .��5      �� $	��500��6   $	��330��6   ���	#FFDFD7CA.+�5   
   �� -   5         ��Name$ CrearProductoLabel��5      $��Crear un nuevo producto��6,   
 �� Top$	 9.8��6N   $	��276��6_   ���	#FFDFD7CA$��Center=�6�   $��Center=�6�    �� Left$ 28��6�   $��62��6�   ���	#FF1C15306�   �� 5   
   -   5         ��Name$ FotoArticuloBorder��5      
���   �$��1q�6A   $	��118��6U   $	 104��6b   $ 82��6t   $	��118��6�   A� 5	   
   -   5         A�Name$ 	EsferaUno��5	      ���	#FFF4F4F5$��24��66   $	 118��6B   
���   �$	 206��6c   $��22��6t    J� RenderTransformOrigin$ 0.5,0.5&�6   z�5
      V� 5      .~�5      �� �� 5      �� 5       �� Angle$ -1.15Q�6&   T� 5      5      5      A� 5   
   -   5        $ 	EsferaDos��5      ���	#FFF4F4F5$��24��66   $	 151��6B   
���   �$	 206��6c   $��23��6t   $ 0.5,0.5&�6   z�5      V� 5      .~�5      �� �� 5      �� 5      $ -1.15Q�6&   T� 5      5      5      A� 5   
   -   5        $ 
EsferaTres��5      ���	#FFF4F4F5$��24��67   $	 184��6C   
���   �$	 206��6d   $��25��6u   $ 0.5,0.5&�6�   �� 5   
   -   5         ��Name$ 
NombreText��5      $��45��6&   $ 10��62   	 �� TextWrapping$
	 Wrap=�6C   $	 236��6W   $	��310��6h   )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 Nombre��6t      
Foreground �	#FF1C1530.  (MaterialDesignThemes.Wpf.TextFieldAssist   UnderlineBrush �	#FF673AB7 %  !MaterialDesignFloatingHintTextBox#��[  6  �� 5!   
   -   5        $ 
PrecioText��5!      $��45��6&   $ 14��62   $
	 Wrap=�6C   $	 280��6W   $	��155��6h   $
 Precio��6t    �	#FF1C1530 �	#FF673AB7#��[  6  �� 5#   
   -   5        $ DescripcionText��5#       * &MaterialDesignOutlinedTextFieldTextBox#��[ 5$      $	��Top=�5%      $	��100��5&      $	��310��6   $ 10��6&   $	 336��67    �� AcceptsReturn . $
	 Wrap=�5(      " �� VerticalScrollBarVisibility$
 Auto=�5)      $
 Descripción...��5*      �� 5-   
   -	   5         ��Name$ BotonAceptar��5-      $��Aceptar��6'   $	 458��69   $��90��6J   ���	#FF1C1530���	#FF91B7C0$��Segoe UI Light)�6�   $��Normal"�6�   $��0q�6�   $	 230��6�   �� 5.   
   -
   5        $ 	StockText��5.      $��45��6%   $	 190��61   $
	 Wrap=�6C   $	 280��6W   $	��130��6h   $
 Stock��6t    �	#FF1C1530 �	#FF673AB7#��[  6  51      52      