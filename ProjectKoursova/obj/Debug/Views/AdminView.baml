   M S B A M L   `   `   `  ����J  FProjectKoursova, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:ProjectKoursova.ViewsProjectKoursova.Views  5   	   G(clr-namespace:ProjectKoursova.ViewModelsProjectKoursova.ViewModels  5   	   A%clr-namespace:ProjectKoursova.HelpersProjectKoursova.Helpers  5   	   %    ProjectKoursova.Views.AdminView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:ProjectKoursova.Views     5   	   7vm(clr-namespace:ProjectKoursova.ViewModels     5   	   4he%clr-namespace:ProjectKoursova.Helpers     5   	     � Title$  	AdminView��5
   	   $
��Auto��6   $
��Auto��6)    � 	Resources 5      5  /ProjectKoursova.Helpers.ContentTemplateSelector   selector4  .ProjectKoursova.ViewModels.ConverterByteArrays  ArrayToBitmap �� DataType1  +ProjectKoursova.ViewModels.StudentViewModel  StudentViewModel � RowDefinitions � ColumnDefinitions �� DecodePixelWidth �� DecodePixelHeight �� 	UriSource:  4ProjectKoursova.ViewModels.AdminAddQuestionViewModel  AdminAddQuestionViewModel �� UpdateSourceTrigger	 �� TextWrapping
 �� AcceptsReturn �� DisplayMemberPath �� SelectedValuePath$ �� IsSynchronizedWithCurrentItem �� SelectedValue � Cursor&   System.Windows.Controls.DataGrid   AutoGenerateColumns �� SelectedItem   Columns0  *System.Windows.Controls.DataGridTextColumn,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter   Header1	  +System.Windows.Controls.DataGridBoundColumn 	  Binding   
IsReadOnly4
  .System.Windows.Controls.DataGridTemplateColumn 
  CellTemplate �� 	Converter �� Orientation4  .ProjectKoursova.ViewModels.CSharpQuizViewModel  CSharpQuizViewModel 	� 	GroupName �� RelativeSource �� Mode d� 	IsChecked��%',  &	        &	      &	 &     &	 �    7  &	 |    7    5   
   6%     5   
   6!   �� 5   
   "  6   .R�5      �  5      �� 5      $
��Auto �6$   �� 5      $
��Auto �6$    5      �� 5      $
��Auto �6'   �� 5      �� 5      $
��Auto �6'   .+�5      �� $��0��6   $��0��6(   $��2��65   $	��250��6I   $
��Left=�6U   $��
10 50 25 0q�6p   ��5      �� 5      $	 200��6&   $	 200��6=   $0 */Resources/pexels-markus-spiske-330771.jpg?�6V   5      �� 5      $��0��6   $��1��6*   $	��250��6:   $��Center=�6F   $��
190 50 0 0q�6c   .+�5      �� $
��Wrap=�6    �� 5       $��20(�6   $
��Bold"�6$   .�66   Lorem Ipsum5"       �� 5#      .�6   ��is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.5&      5'      5(      �� 5)      $��0��6   $��2��6*   $	��350��6:   $��	0 50 25 0q�6F   .+�5*      �� $
��Wrap=�6    �� 5+      .�6   ��Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam suscipit nunc eros, vel dapibus massa rhoncus non. Quisque eu magna mauris. Curabitur mattis, nulla nec scelerisque dictum, neque dui sagittis eros, vel pellentesque ex enim ac odio. Praesent vitae malesuada lacus, eget facilisis diam. Ut rhoncus nunc ut velit iaculis, non ultrices mauris volutpat. Phasellus sed imperdiet diam. Cras euismod tellus augue, ut tempor purus ultricies eu. Cras nunc ex, viverra in feugiat ac, pretium eget mauris. Donec sodales mollis dolor, vitae posuere ante placerat eget. Vivamus ultricies felis turpis, vel mattis mauris vehicula facilisis. Duis convallis nisi et quam lobortis, ac aliquam est luctus. Sed enim dui, ultricies ac viverra nec, tempus vel enim. Aenean volutpat lacus eu posuere ultrices. Quisque sit amet nisi ut libero malesuada tincidunt vel a nisl.5-      5.      5/      �� 50      $
��Wrap=�6   $��10 25q�6)   $��1��68   $��0��6E   $��3��6U   �� 51      .�6   ��Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Phasellus at iaculis nisi. Nullam bibendum, nisl a rhoncus euismod, leo justo interdum urna, at facilisis lacus purus vel libero. Interdum et malesuada fames ac ante ipsum primis in faucibus. Aenean sollicitudin feugiat ullamcorper. Nulla pretium fringilla nisl non venenatis. In hac habitasse platea dictumst. In interdum at ligula nec porttitor. Morbi sit amet convallis turpis. Sed in felis egestas, maximus ante auctor, porta est. Nullam ut augue nec lorem ultrices efficitur. In placerat nisl nibh, at tristique tortor accumsan quis.53      �� 54      �� 55      .�6   ��Fusce egestas neque a turpis efficitur, non varius nulla fringilla. Sed et lectus eu risus venenatis euismod. Nulla sit amet enim eu nibh malesuada efficitur. Mauris ultricies dignissim ligula eget gravida. Mauris ac eros felis. Curabitur varius, nisi non viverra finibus, lacus lectus congue augue, egestas aliquet tortor odio eget nisi. Praesent maximus est lacus, a pharetra elit auctor quis. Etiam eu facilisis mi.57      58      59      5:      �� 5;   
   "  6   .R�5<      �  5=      �� 5>      $
��Auto �6$   �� 5?      $
��Auto �6$   �� 5@      $
��Auto �6$   �� 5A      $
��Auto �6$    5C      �� 5D      $
��Auto �6'   �� 5E      �� 5F      $
��Auto �6'   .+�5H      �� $��0��6   $��35q�6*   $��0��66   $��3��6F   $��Center=�6Z   .+�5I      �� $	��250��6   ��6*   �� *Filter+$ PropertyChanged=�5J      �� 5K      $��10q�6   $��Center=�6)   $��1��6F   $��3��6S   .+�5L      �� $)��#ADD - EDIT - SAVE - DELETE QUESTION��6    
���/kU�$��25(�6g   $��	ExtraBold"�6u   5M      �� 5N      $��2��6   $
��20 0q�6*   .+�5O      �� $��Question��6    $
��0 10q�60   �� 5P      $
	 Wrap=�6   
 . $	��240��6G   ��6S   �� *
Question+�� 5Q      $��Please choose a subject��6    $
��0 10q�6?   �� 5R      $	��240��6   $ subject1��6r   $ 	subjectId��6�   $
 TrueY�6�   ��6+   �� *
Subjects+$ PropertyChanged=� 6�   �� *	SubjectId+6�   �� 5S      $��Please choose an image��6    $
��0 10q�6>   �� 5T      $��30��6   $	��240��6F   ��6)   �� *
Filename+��6R   �� *UploadImage+�� 5U      $��First answer proposition��6    $
��0 10q�6@   �� 5V      $
	 Wrap=�6   
 . $	��240��6G   ��6S   �� *FirstAnswer+$ PropertyChanged=��� 5W      $��Second answer proposition��6    $
��0 10q�6A   �� 5X      $
	 Wrap=�6   
 . $	��240��6G   ��6S   �� *SecondAnswer+$ PropertyChanged=��� 5Y      $��Third answer proposition��6    $
��0 10q�6@   �� 5Z      $
	 Wrap=�6   
 . $	��240��6G   ��6S   �� *ThirdAnswer+$ PropertyChanged=��� 5[      $��Fourth answer proposition��6    $
��0 10q�6A   �� 5\      $
	 Wrap=�6   
 . $	��240��6G   ��6S   �� *FourthAnswer+$ PropertyChanged=��� 5]      $4��.Correct answer proposition(Choose one of them)��6    $
��0 10q�6V   �� 5^      $
	 Wrap=�6   
 . $	��240��6G   ��6S   �� *CorrectAnswer+$ PropertyChanged=��� 5_      $	��Add��6   $	��150��6+   $
��0 20q�67   $��12q�6E   $
 Hand��6R   $��Center=�6`   ��6�   �� *
AddCommand+5`        5a      $��2��6   $��1��6(   $��2��68    .   6L   �� *SelectedItem+$ PropertyChanged=���6�   �� *	Questions+$ PropertyChanged=� 5b        5c      $ * 6-   $ Teacher��67    6H   �� *	question1+  5d      $ * 6-   $ 
Subject id��67    6K   �� *	subjectId+  5e      $ * 6-   $ Question��67    6I   �� *	question1+  5f      $ * 6-   $ Option A��67    6I   �� *firstAnswer+  5g      $ * 6-   $ Option B��67    6J   �� *secondAnswer+  5h      $ * 6-   $ Option C��67    .  6[   �� *thirdAnswer+  5i      $ * 6-   $ Option D��67    .  6[   �� *fourthAnswer+  5j      $ * 6-   $ Correct Answer��67    .  6a   �� *correctAnswer+
  5k      $ Picture��61   $ * 6C    5l      �� 5m   "   .R�5n   &   �� $	��100��61   $��30��6=   .+�5o   *   �� ��61   �� *	picture+8   5p   '   5q   #   5s      5u      �� 5v      $��3��6   $��2��6*   $��2��6:   $ 
Horizontal=�6N   $��Center=�6g   .+�5w      �� $
��Save��6   $	��150��6,   $��12q�68   $��10q�6E   $
 Hand��6Q   ��6_   �� *SaveCommand+�� 5x      $
��Edit��6   $	��150��6,   $��10q�68   $��12q�6D   $
 Hand��6Q   ��6_   �� *EditCommand+�� 5y      $��Delete��6   $	��150��6.   $��10q�6:   $��12q�6F   $
 Hand��6S   ��6a   �� *DeleteCommand+5z      5{      5|      �� 5}   
   "  6   .R�5~      �  5      �� 5�      $
��Auto �6$   �� 5�      $
��Auto �6$   �� 5�      $
��Auto �6$   �� 5�      $
��Auto �6$   �� 5�      $
��Auto �6$    5�      �� 5�      �� 5�      .+�5�      �� $ 
Horizontal=�6   $��20q�66   $��0��6B   $��0��6O   $��2��6_   $
��Left=�6s   .+�5�      �� $��10q�6    �� 5�      $��18(�6   $��DemiBold"�6,   $�
Subject : ��6B    �� 5�      $�C#��6   5�      �� 5�      $��10q�6    �� 5�      $��18(�6   $��DemiBold"�6,   $�Score : ��6B    �� 5�      �6   �� *Score+$ PropertyChanged=�5�      �� 5�      $��18(�6    $��DemiBold"�6.   $��10q�6D   �� 5�      .�6   Time :6'    �� 5�      �6   �� *SecondTimer+$ PropertyChanged=�5�      5�      �� 5�      $��0��6   $	��650��6O   $��Center=�6[   $	��180��6x   $��1��6�   $��2��6�   y�6(   �� *VisibleQuestion+��6�   �� *Image+8   �� 5�      $��2��6   $��0��6P   $��25(�6`   $
��Bold"�6n   $��2��6�   $��Center=�6�   $��40q�6�   y�6)   �� *VisibleQuestion+��6�   �� *	Question1+�� 5�      $��3��6   $��0��6Q   $��Center=�6a   y�6*   �� *VisibleQuestion+.+�5�      	� $
��0 15q�5�   "   $ csharp��5�   "   $��3 0 20 0q�5�   "   ��5�   "   �� *CheckedAnswerCommand+��5�   "   �� *	Content+ �� $
 Self=� 5�   "   �� *IsCheckRadioBtn+��5�      �� 5�      $
��Wrap=�6E   ��6(   �� *FirstAnswer+6E   5�      	� 5�      $
��0 15q�5�      $ csharp��5�      $��3 0 20 0q�5�      ��5�      �� *CheckedAnswerCommand+��5�      �� *	Content+ �� $
 Self=� 5�      �� *IsSecondBtnChecked+��5�      �� 5�      $
��Wrap=�6F   ��6(   �� *SecondAnswer+6F   5�      5�      �� 5�      $��3��6   $��1��6Q   $��Center=�6a   y�6*   �� *VisibleQuestion+.+�5�      	� $
��0 15q�5�      $ csharp��5�      $��3 0 20 0q�5�      ��5�      �� *CheckedAnswerCommand+��5�      �� *	Content+ �� $
 Self=� 5�      �� *IsThirdBtnChecked+��5�      �� 5�      $
��Wrap=�6E   ��6(   �� *ThirdAnswer+6E   5�      	� 5�      $
��0 15q�5�      $ csharp��5�      $��3 0 20 0q�5�      ��5�      �� *CheckedAnswerCommand+��5�      �� *	Content+ �� $
 Self=� 5�      �� *IsFourthBtnChecked+��5�      �� 5�      $
��Wrap=�6F   ��6(   �� *FourthAnswer+6F   5�      5�      �� 5�      $��4��6   $��0��6Q   $��2��6a   $ Vertical=�6u   $��Center=�6�   y�6*   �� *VisibleQuestion+.+�5�      �� 
�������
�������$��20q�6D   
���  ��y�6P   �� *IsBtnVisible+��6�   �� *NextCommand+.��6�   Next6�   �� 5�      
�������
�������$��15q�6k   
��� � �y�6H   �� *IsBtnHidden+��6�   �� *SubmitCommand+.��6�   Submit6�   5�      �� 5�      $��2��6   $��0��6*   $��Center=�6:   $��2��6}   y�6W   �� *HiddenQuestion+.+�5�      �� �� 5�      $��23(�6   $
��Bold"�6,   .�6>   Congratulation5�       �� 5�      $��23(�6   $
��Bold"�6,   �6>   �� *CurrentUsername+$ PropertyChanged=��� 5�      �� 5�      $��12(�6   .�6,   Your final result6?   5�      �� 5�      $��0 12 0 0q�6    �� 5�      $��17(�6   $��SemiBold"�6,   .�6B   	Score :6L    �� 5�      �6   �� *Score+ �� 5�      $	�/10��6   5�      �� 5�      $��17(�6    $��SemiBold"�6.   $��0 12 0 0q�6D   �� 5�      $��17(�6   $��SemiBold"�6,   .�6B   	Subject :5�       �� 5�      .�6   C#5�      5�      �� 5�      $��0 12 0 0q�6    �� 5�      $��17(�6   $��SemiBold"�6,   .�6B   Time :6K    �� 5�      5�      5�      5�      5�      5�      .��5�      �� .��5�   
   � $	��870��6    5�   
   �� 5�      $
��Auto �6   �� 5�      $
��Auto �6   �� 5�      $
��Auto �6   .+�5�   
   �� $ 
Horizontal=�6   $��Right=�6.   $��0��6J   $��10q�6W   .+�5�      o� .@�5�      m� ��6   �� *Username.username+.@�5�      m� $��
Disconnect��6    m� Command$  ��63   m� 5�      $��Change View��6    64   �� *ChangeViewModal+5�      5�      5�      �� 5�   
   $��Center=�6   $��1��62   .+�5�      o� .@�5�      m� $
��Home��6   m� 5�      $��Course Catalog��6   m� 5�      $��	Community��6   m� 5      $��
Ressources��6   m� 5     $��Pass test Quiz��6   .@�5     m� $��C#��6    6+   �� *CSharpViewModelCommand+m� 5     $��
Javascript��6   m� 5     $	��C++��6   m� 5     $
��Java��6   5     5     5     �� 5	  
   $��2��6   #��[  6F   ��6(   �� *	ViewModel+6F   5
     5     5     