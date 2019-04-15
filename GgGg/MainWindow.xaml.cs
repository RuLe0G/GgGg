using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace GgGg
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        System.Windows.Threading.DispatcherTimer Timer;
        int i = 100;
        bool st = true;
        public MainWindow()
        {
            InitializeComponent();
            Timer = new System.Windows.Threading.DispatcherTimer();
            Timer.Interval = new TimeSpan(0, 0, 0, 0, 1);
            Frame.NavigationUIVisibility = NavigationUIVisibility.Hidden;
        }


        private void Tick1(object sender, EventArgs e)
        {
            if (i < 4) { Timer.Stop(); st = false; }
            else
            {
                Stack.Width = i;
                Frame.Margin = new Thickness((i - 4), 0, 0, 0);
                i -= 4;
            }
        }

        private void Tick2(object sender, EventArgs e)
        {
            if (i > 96) { Timer.Stop(); st = true; }
            else
            {
                Stack.Width = i;
                Frame.Margin = new Thickness((i + 4), 0, 0, 0);
                i += 4;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (st == true)
            {
                Timer.Tick += new EventHandler(Tick1);
                Timer.Start();
                
            }
            else
            {
                Timer.Tick += new EventHandler(Tick2);
                Timer.Start();
            }
        }

        private void But1_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new Page1());

        }

        private void But2_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new Page2());

        }

        private void But3_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new Page3());

        }
    }
}
