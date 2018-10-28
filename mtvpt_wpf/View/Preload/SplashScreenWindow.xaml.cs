using mtvpt_wpf.Controller;
using mtvpt_wpf.Utility;
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

namespace mtvpt_wpf.View.Preload
{
    /// <summary>
    /// Interaction logic for SplashScreenWindow.xaml
    /// </summary>
    public partial class SplashScreenWindow : Window
    {
        public SplashScreenWindow()
        {           
            InitializeComponent();
        }

        private void SplashScreenWindowXaml_Loaded(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();

            if (DatabaseConnection.DatabaseConnectionCheck())
            {
                DatabaseConnection.querySystemDetail();

                //Timer.CountDownTimer();
                loginWindow.Show();
                this.Close();
            }
            else
            {
                GlobalFunctions.ShowDebug("Connect Database Failed.");
            }
        }
    }
}
