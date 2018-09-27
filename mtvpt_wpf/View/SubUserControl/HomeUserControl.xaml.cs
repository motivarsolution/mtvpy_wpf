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

namespace mtvpt_wpf.View.SubUserControl
{
    /// <summary>
    /// Interaction logic for HomeUserControl.xaml
    /// </summary>
    public partial class HomeUserControl : UserControl
    {
        public HomeUserControl()
        {
            InitializeComponent();
        }

        private void HomeNotificationIcon_MouseEnter(object sender, MouseEventArgs e)
        {
            HomeNotificationIcon.Foreground = new SolidColorBrush(Colors.Yellow); 
        }

        private void HomeNotificationIcon_MouseLeave(object sender, MouseEventArgs e)
        {
            HomeNotificationIcon.Foreground = new SolidColorBrush(Colors.Gray);
        }

        private void HomeNotificationIcon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            HomeNotificationIcon.Foreground = new SolidColorBrush(Colors.White);
        }

        private void HomeNotificationIcon_MouseUp(object sender, MouseButtonEventArgs e)
        {
            HomeNotificationIcon.Foreground = new SolidColorBrush(Colors.Yellow);
        }

        private void HomeSettingIcon_MouseEnter(object sender, MouseEventArgs e)
        {
            HomeSettingIcon.Foreground = new SolidColorBrush(Colors.Yellow);
        }

        private void HomeSettingIcon_MouseLeave(object sender, MouseEventArgs e)
        {
            HomeSettingIcon.Foreground = new SolidColorBrush(Colors.Gray);
        }

        private void HomeSettingIcon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            HomeSettingIcon.Foreground = new SolidColorBrush(Colors.White);
        }

        private void HomeSettingIcon_MouseUp(object sender, MouseButtonEventArgs e)
        {
            HomeSettingIcon.Foreground = new SolidColorBrush(Colors.Yellow);
        }
    }
}
