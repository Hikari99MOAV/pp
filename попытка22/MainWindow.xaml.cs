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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace попытка22
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer _timer = new DispatcherTimer();
        TimeSpan _time;
        public MainWindow()
        {
            InitializeComponent();
            _timer.Interval = new TimeSpan(0, 0, 1);
            _timer.Tick += timer_Tick;
        }
      
        void timer_Tick(object sender, EventArgs e)
        {
            _time = TimeSpan.FromSeconds(10);
            _timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                blockLabel.Text = _time.ToString("c");
                if (_time == TimeSpan.Zero)
                {
                    blockLabel.Visibility = Visibility.Hidden;
                    authorizationBorder.Visibility = Visibility.Visible;
                    authorizationLabel.Visibility = Visibility.Visible;
                    textBoxLogin.Visibility = Visibility.Visible;
                    passwordBox.Visibility = Visibility.Visible;
                    showPassword.Visibility = Visibility.Visible;
                    //passwordTextBox.Visibility = Visibility.Visible;
                    textBoxKapcha.Visibility = Visibility.Visible;
                    textBoxKapcha2.Visibility = Visibility.Visible;
                    buttonRestart.Visibility = Visibility.Visible;
                    buttonIn.Visibility = Visibility.Visible;
                    loginLabel.Visibility = Visibility.Visible;
                    passwordLabel.Visibility = Visibility.Visible;
                    captchaLabel.Visibility = Visibility.Visible;
                    _timer.Stop();
                }
                _time = _time.Add(TimeSpan.FromSeconds(-1));
            }, Application.Current.Dispatcher);
            _timer.Start();
        }
       
        private void showPassword_Click(object sender, RoutedEventArgs e)
        {
            if (showPassword.IsChecked == true)
            {
                passwordTextBox.Text = passwordBox.Password;
                passwordTextBox.Visibility = Visibility.Visible;
                passwordBox.Visibility = Visibility.Hidden;
            }
            else
            {
                passwordBox.Password = passwordTextBox.Text;
                passwordTextBox.Visibility = Visibility.Hidden;
                passwordBox.Visibility = Visibility.Visible;
            }
        }

        private void refreshButton_Click(object sender, RoutedEventArgs e)
        {
            String allowchar = "";
            allowchar = "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z";
            allowchar += "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,y,z";
            allowchar += "1,2,3,4,5,6,7,8,9,0";
            char[] a = { ',' };
            String[] ar = allowchar.Split(a);
            String pwd = "";
            string temp = "";

            Random r = new Random();
            for (int i = 0; i < 4; i++)
            {
                temp = ar[(r.Next(0, ar.Length))];
                pwd += temp;
            }

            if (textBoxKapcha.Text != "")
            {
                textBoxKapcha.Text = null;
            }

            textBoxKapcha.Text = pwd;
        }

        private void loginButton_Click_1(object sender, RoutedEventArgs e)
        {
            string login = "olya";
            string pass = "12345";

            if (textBoxLogin.Text != login)
            {
                MessageBox.Show("Логин неверный");
            }

            else if (passwordBox.Password != pass)
            {
                MessageBox.Show("Пароль неверный");
            }

            else if (textBoxKapcha.Text != textBoxKapcha2.Text)
            {
                MessageBox.Show("Капча введена неверно или не введена вовсе ");
                MessageBox.Show("Блокировка 10 секунд");
                _timer.Start();
                authorizationLabel.Visibility = Visibility.Hidden;
                authorizationBorder.Visibility = Visibility.Hidden;
                blockLabel.Visibility = Visibility.Visible;
                textBoxLogin.Visibility = Visibility.Hidden;
                passwordBox.Visibility = Visibility.Hidden;
                showPassword.Visibility = Visibility.Hidden;
                passwordTextBox.Visibility = Visibility.Hidden;
                textBoxKapcha.Visibility = Visibility.Hidden;
                textBoxKapcha2.Visibility = Visibility.Hidden;
                buttonRestart.Visibility = Visibility.Hidden;
                buttonIn.Visibility = Visibility.Hidden;
                loginLabel.Visibility = Visibility.Hidden;
                passwordLabel.Visibility = Visibility.Hidden;
                captchaLabel.Visibility = Visibility.Hidden;
            }

            else
            {
                MessageBox.Show("Вы успешно вошли");
                Menu menu = new Menu();
                menu.Owner = this;
                menu.Show();
                this.Hide();
            }

        }
    }
}
