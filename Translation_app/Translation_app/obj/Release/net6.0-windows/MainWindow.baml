   M S B A M L   `   `   `  ���� J  FTranslation_app, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Translation_appTranslation_app       Translation_app.MainWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     /localclr-namespace:Translation_app       � Title$  Translation��$	��250��$	��500������  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ Black��� $ 	#FFA7BEE4�� � Offset$ 1Q�.���  � ColumnDefinitions �� $��10 ��� $��* ��� $��10 � � RowDefinitions �� $��10 ��� $��* ��� $��5 ��� $��* ��� $��10 ��� $��30 ��� $��10 �.+��� -    ��Name$	 TXB��$��1��$��1�� �� AcceptsReturn$
 True��"	 �� VerticalScrollBarVisibility$
	 Auto=�$��0q�
 �� TextWrapping$

 Wrap=��� -   $ 
TXB_Result��$��3��$��1�� �� 
IsReadOnly$
 True��$
 True��$
	 Auto=�$

 Wrap=����	#FFE0DFDF�� -    ��Name$ 	BTN_Debug��$��1��$��3��$��Debug��
���   �
�������$��5q�$��Right=�$��Bottom=�$y�Hidden=�� $��5��$��1�� �� $
��0.8* ��� $��10 ��� $
��0.8* ��� $��10 ��� $
��0.5* ��� $��10 ��� $��2* �.+��� -   $ 
BTN_ENtoJA��$��0��$��0��$��0q�$��日本語 → 英語��${�False��
���   �
��������� -   $ 
BTN_JAtoEN��$��2��$��0q�$��英語 → 日本語��${�False��
���   �
��������� -    ��Name$ CKB_Topmost��$��4��$��Center=�$	��Top�� d� 	IsChecked$
 TrueY�� $��6�� �� $��50 ��� $��* ��� $��5 ��� $��65 ��� $��5 ��� $	��100 �.+��� -   $ 	BTN_Clear��$��0��$��Clear��
���   �
�������${�false���� -   $ BTN_TxChange��$��3��$��	txtChange��
���   �
�������$y�Visible=�${�False���� -	   $ BTN_Clipboad��$��5��$!��クリップボード取得��
���   �
�������