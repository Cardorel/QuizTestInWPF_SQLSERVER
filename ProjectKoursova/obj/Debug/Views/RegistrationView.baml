   M S B A M L   `   `   `  ����J  FProjectKoursova, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:ProjectKoursova.ViewsProjectKoursova.Views  5      G(clr-namespace:ProjectKoursova.ViewModelsProjectKoursova.ViewModels  5      ,    &ProjectKoursova.Views.RegistrationView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:ProjectKoursova.Views     5      7vm(clr-namespace:ProjectKoursova.ViewModels     5      .��5      �   � RowDefinitions  5   
   �� 5       � ColumnDefinitions 5   
   �� 5      $
��Auto �6   .+�5   
   �� $��Center=�6T   $
��0 20q�6q   ��6   �� *
Feedback+ �� UpdateSourceTrigger$ PropertyChanged=�6q   �� 5   
   $��10 10q�6   $	��350��6$   $��Center=�60   $��Center=�6s   y�6M   �� *ShowVisibility+.+�5      �� $��Username��6   $	��0 5q�6(   �� 5      ��6   �� *
Username+$ PropertyChanged=��� 5      $��Who are you ?��6   $	��0 5q�6-   �� 5      $	��0 5q�6    �� DisplayMemberPath$ member1��6j    �� SelectedValuePath$ memberId��6�   $ �� IsSynchronizedWithCurrentItem$
 TrueY�6�   ��6$   �� *	Members+$ PropertyChanged=� �� SelectedValue 6�   �� *
MemberId+6�   �� 5      $��E-mail��6   $	��0 5q�6&   �� 5      ��6   �� *Email+$ PropertyChanged=��� 5      $��Password��6   $	��0 5q�6(   /   )ProjectKoursova.Views.PasswordUserControl  5         Password 6(   �� *
Password+ �� Mode$ TwoWay=�$ PropertyChanged=��� 5      $��Sign out��6   $
��0 25q�6(   ��66   �� *LoginCommand+�� 5      $��Center=�6   �� 5      .�6   I have account5        �� 5!      	 � Cursor$
	 Hand��6   
����  �
�������
���������6'   �� *HiddenVisibilityCommand+.��6�   	Sign In5#      5$      5%      �� 5&   
   $	��350��6   $��10 10q�6!   $��Center=�60   $��Center=�6u   y�6M   �� *HiddenVisibility+.+�5'      �� $��E-mail or Username��6   �� 5(      ��6   �� *EmailOrUsername+$ PropertyChanged=��� 5)      $��Password��6     5*       6(   �� *
Password+$ TwoWay=�$ PropertyChanged=��� 5+      $��Sign In��6   $
��0 25q�6'   ��65   �� *LogoutCommand+�� 5,      �� 5-      .�6   I don't have account5/       �� 50      $
	 Hand��6   
����  �
�������
���������69   �� *ShowVisibilityCommand+.��6�   
Sign Out52      53      54      55      56      