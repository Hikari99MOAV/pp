   M S B A M L   `   `   `  ����K  Gпопытка22, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:попытка22попытка22  5          попытка22.OnePage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:попытка22     5      -   5          N�Name$
  crud��5	       N� Title$ OnePage��6   .��5      � .+�5   
   ]� 
�������.+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ 
mydataGrid��5         AutoGenerateColumns .     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6G   $��Comic Sans MS)�6W   $��18(�6r   $	��902��6�   $	��158��6�   $	��Top=�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$	 №��6)      Width$ 40 6K   1  +System.Windows.Controls.DataGridBoundColumn   Binding 64   �� *id+6K     5      $ ФИО��6)   $	 200 6O    66   �� *name+6O     5      $! Номер телефона��6)   $	 200 6\    6A   �� *number+6\     5      $! Дата обращения��6)   $	 160 6Z    6A   �� *date+6Z     5      $ Вид услуги��6)   $	 150 6V    6=   �� *type+6V     5      $ Стоимость��6)   $	 150 6U    6<   �� *cost+6U   5      5      �� 5   
   $
�� №��6   $
��Left=�6   $��
10,177,0,0q�68   $	��Top=�6L   $��33��6d   $��Comic Sans MS)�6p   $��18(�6�   �� 5   
   $��ФИО :��6   $
��Left=�6    $��
10,215,0,0q�6;   $	��Top=�6O   $��40��6g   $��Comic Sans MS)�6s   $��18(�6�   �� 5   
   $#��Номер телефона :��6   $
��Left=�6+   $��
10,260,0,0q�6F   $	��Top=�6Z   $��40��6r   $��Comic Sans MS)�6~   $��18(�6�   �� 5   
   $#��Дата обращения :��6   $
��Left=�6+   $��
10,305,0,0q�6F   $	��Top=�6Z   $��40��6r   $��Comic Sans MS)�6~   $��18(�6�   �� 5   
   $��Стоимость :��6   $
��Left=�6&   $��
10,400,0,0q�6A   $	��Top=�6U   $��40��6m   $��Comic Sans MS)�6y   $��18(�6�   �� 5    
   $��Вид услуги :��6   $
��Left=�6'   $��
10,350,0,0q�6B   $	��Top=�6V   $��40��6n   $��Comic Sans MS)�6z   $��18(�6�   	 J� RenderTransformOrigin$	 0.576,-0.905&�6�   �� 5!   
   -   5        
 ��Name$
 textBoxName��5!      $
��Left=�6'   $��35��6B   $��204,215,0,0q�6N    �� TextWrapping$
 Wrap=�6c   $	��Top=�6w   $	��221��6�   $��16(�6�   $��Comic Sans MS)�6�   �� 5"   
   -   5        $
 	textBoxId��5"      $
��Left=�6%   $��35��6@   $��204,175,0,0q�6L   $
 Wrap=�6a   $	��Top=�6u   $	��221��6�   $��16(�6�   $��Comic Sans MS)�6�   �� 5#   
   -   5        $
 textBoxNumber��5#      $
��Left=�6)   $��35��6D   $��204,260,0,0q�6P   $
 Wrap=�6e   $	��Top=�6y   $	��221��6�   $��16(�6�   $��Comic Sans MS)�6�   �� 5$   
   -   5        $
 textBoxDate��5$      $
��Left=�6'   $��35��6B   $��204,305,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $	��221��6�   $��16(�6�   $��Comic Sans MS)�6�   �� 5%   
   -   5        $
 textBoxType��5%      $
��Left=�6'   $��35��6B   $��204,350,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $	��221��6�   $��16(�6�   $��Comic Sans MS)�6�   �� 5&   
   -   5        $
 textBoxCost��5&      $
��Left=�6'   $��35��6B   $��204,400,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $	��221��6�   $��16(�6�   $��Comic Sans MS)�6�   �� 5'   
   -	   5         ��Name$ buttonInsert��5'      $��Добавить��6'   $
��Left=�6:   $��460,235,0,0q�6U   $	��Top=�6j   $	��120��6�   $��35��6�   $��Comic Sans MS)�6�   $��18(�6�   6�   �� 5(   
   -
   5        $ buttonUpdate��5(      $��Изменить��6'   $
��Left=�6:   $��460,304,0,0q�6U   $	��Top=�6j   $	��120��6�   $��35��6�   $��Comic Sans MS)�6�   $��18(�6�   6�   �� 5)   
   -   5        $ buttonDelete��5)      $��Удалить��6'   $
��Left=�69   $��460,375,0,0q�6T   $	��Top=�6i   $	��120��6�   $��35��6�   $��Comic Sans MS)�6�   $��18(�6�   6�   5,      5-      