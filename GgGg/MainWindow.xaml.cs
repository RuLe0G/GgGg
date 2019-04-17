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
using System.Windows.Media.Animation;

namespace GgGg
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        int i = 100;
        
        public MainWindow()
        {
            InitializeComponent();
            Frame.NavigationUIVisibility = NavigationUIVisibility.Hidden;
        }


      

        

        private void But1_Click(object sender, RoutedEventArgs e)
        {
            string a = tb.Text.ToString();
            Frame.Navigate(new Page1(a));

        }

        private void But2_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new Page2());

        }

        private void But3_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new Page3());

        }

            private void btnLeftMenuHide_Click(object sender, RoutedEventArgs e)
            {
                ShowHideMenu("sbHideLeftMenu", btnLeftMenuHide, btnLeftMenuShow, Stack);
            }
        private void btnLeftMenuShow_Click(object sender, RoutedEventArgs e)
        {
            ShowHideMenu("sbShowLeftMenu", btnLeftMenuHide, btnLeftMenuShow, Stack);
        }

        private void ShowHideMenu(string Storyboard, Button btnHide, Button btnShow, StackPanel pnl)
        {
            Storyboard sb = Resources[Storyboard] as Storyboard;
            sb.Begin(pnl);

            if (Storyboard.Contains("Show"))
            {
                btnHide.Visibility = System.Windows.Visibility.Visible;
                btnShow.Visibility = System.Windows.Visibility.Hidden;
            }
            else if (Storyboard.Contains("Hide"))
            {
                btnHide.Visibility = System.Windows.Visibility.Hidden;
                btnShow.Visibility = System.Windows.Visibility.Visible;
            }
        }
    }
}
