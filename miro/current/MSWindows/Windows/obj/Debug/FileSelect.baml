   M S B A M L   `   `   `  ����R  NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R8clr-namespace:System.ComponentModel;assembly=WindowsBaseSystem.ComponentModel  5      O KMiroConverter, Version=2.0.3946.21706, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Mirosubs.Converter.WindowsMirosubs.Converter.Windows 5      +   %Mirosubs.Converter.Windows.FileSelect   5      \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      8x,http://schemas.microsoft.com/winfx/2006/xaml     5      Fscm8clr-namespace:System.ComponentModel;assembly=WindowsBase     5      7miro(clr-namespace:Mirosubs.Converter.Windows     5      $	��404��5      $	��365��6     � 	Resources  5         GroupedVideoFormats �� GroupDescriptions2  ,System.Windows.Data.PropertyGroupDescription   PropertyName �� SortDescriptions+   %System.ComponentModel.SortDescription   PropertyName   	Direction  GroupHeader �� Path  VideoFormatTemplate��%�  &	        &	 �     &	 T    �� 5	   
    5
        5      $ 	GroupName��6+    5        5      $ 
GroupOrder��6&   $ 	Ascending=�6@     5      $ Order��6&   $ 	Ascending=�6;     5      $ DisplayName��6&   $ 	Ascending=�6A   5      �� 5   
   .R�5      �� $��0,0,0,0q�63   ��6   �� $
 Name�63   5      �� 5   
   .R�5      �� $��10,0,0,0q�6:   ��6   �� $ DisplayName�6:   5      5      .��5      � -   5        $��grid1��5      .+�5   
   �� -   5        $��topLabel��5   0   $��28��6   $��
12,39,12,0q�6   $	��Top=�6@   $
��Bold"�6X   $��14(�6j   
�������$��Center=�6�   .��6�   Convert a Video6�   � 5   
   -   5        $��finishedGrid��5      $��82��6#   $��
12,12,12,0q�6/   $	��Top=�6C   $y�Hidden=�6[   .+�5      �� -   5        $��finishedTextBlock��5   )   $��6,6,6,0q�6   $
��Wrap=�6B   
������� �� TextAlignment$ Center=�6i   $��45��6�   $	��Top=�6�   +  %Mirosubs.Converter.Windows.LinkButton  5      -   5          Name$ showFileButton��5   N   +  %Mirosubs.Converter.Windows.LinkButton	   Clicked$	 ShowFinishedFile��6�   $��143,0,145,4q�6   $��Bottom=�63   
   
ButtonText$
 	Show File��6f      ForegroundColor
 �����   MouseOverForegroundColor
 �  ��6�   5       � 5!   
   -   5        $��
middleGrid��5!       J� 	AllowDrop . $��12,100,12,157q�6F   ��5"      �� 5#       �� ImageSource$ resources\box.png��6   .+�5%      � -   5        $��convertGrid��5%      $��0q�6   $��26��61   $��Center=�6=   .+�5&      �� -   5        $��convertLabel��5&      $��Right=�6,   $��	6,0,107,0q�6O   
�������.��6u   '%To convert, drag a video file here or6�     5'      $	 ChooseFileClicked��6�   $��0,5,35,0q�6"   $
 choose a file��64   $��Right=�6O   $��73��6k   
 �����
 �  ��6�   5(      �� 5)      -	   5        $��fileNameTextBlock��5)   +   $��	6,42,6,38q�6   $y�Hidden=�6D   $
��Wrap=�6X   $
��Bold"�6l   
�������$��14(�6�   $ Center=�6�   5*      �� 5+   
   -
   5        $��image1��5+   #   $��	30,0,0,91q�6   $
��None=�61   $
��Left=�6@   $��39��6[   $��59��6f   $��Bottom=�6r   $3��-/MiroConverter;component/resources/device.png��6�   }�.  6�   �� 5,   
   -   5        $��videoFormatCombo��5,   (   $��75,0,15,102q�6   $��23��5-      $��Bottom=�6    � DataContext# [  5.      #��[ 50      ��5/      ��  �� 
GroupStyle 52      (  "System.Windows.Controls.GroupStyle  53         HeaderTemplate# [ 6   55      �� 56   
   -   5        $��sendToITunes��56   2   $��16��6   $��	0,0,15,71q�6   $��Bottom=�6F   $��Right=�6a   $	��107��6}   $y�Hidden=�6�   
�������.��6�   Send to iTunes6�   �� 57   
   -   5        $��button1��57   L   $��23��6   $��Right=�6   $��	0,0,12,12q�69   $��Bottom=�6[   $��75��6v   .��6�   
Convert!6�     58   
   $	 AboutHelpClicked��6O   $��10,0,0,7q�6   $
 
About/Help��6,   $��73��6D   $
��Left=�6j   $��25��6�   
 �����
 �  ��$��Bottom=�6�   59      5:      