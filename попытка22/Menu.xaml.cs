using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace попытка22
{
    /// <summary>
    /// Логика взаимодействия для Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        DispatcherTimer _timer;
        TimeSpan _time;


        public Menu()
        {
            InitializeComponent();
            OneFrame.Content = new OnePage();
            
        }
        private void Time_Loaded(object sender, RoutedEventArgs e)
        {
            _time = TimeSpan.FromMinutes(10);

            _timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                LabelTimer.Text = _time.ToString("c");
                if (_time == TimeSpan.Zero)
                {
                    MessageBox.Show("Время сеанса закончилось");
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Owner = this;
                    mainWindow.Show();
                    this.Hide();
                    _timer.Stop(); }
                else if (_time == TimeSpan.FromMinutes(5)) MessageBox.Show("До выхода из программы осталось 5 минут");
                _time = _time.Add(TimeSpan.FromSeconds(-1));
            }, Application.Current.Dispatcher);
            _timer.Start();
        }
        
        private void timer_Tick(object sender, EventArgs e)
        {
           

        }
    }
}
