   M S B A M L   `   `   `  ����L  HTomra Test System, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Tomra_Test_SystemTomra_Test_System  5   	   &     Tomra_Test_System.ManuallyVerify   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:Tomra_Test_System     5   	     � Title$  ManuallyVerify��5   	   $	��400��6    $	��600��6-   .��5
      �  � RowDefinitions 5   
   �� 5      $��6* �6   �� 5      $��1* �6   �� 5      $��1* �6    � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   .+�5   
   �� -   5        $
��IRef��5      $��2��6   �� 5   
   -   5        $��TbInstrument��5      $��1��6(   $��2��65   $��20(�5       �� TextAlignment$ Center=�5      $��请判断是否PASS！��5      �� 5   
   -   5        $��BtnPass��5      $��2��6    $��0��6-   
��� � �$
��PASS��5      $��20(�5      $��5q�5      �� 5    
   -   5        $��BtnFail��5       $��2��6    $��1��6-   
���  ��$
��FAIL��5#      $��20(�5$      $��5q�5%      5'      5(      