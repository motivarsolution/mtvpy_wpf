using mtvpt_wpf.View.SubUserControl;
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

namespace mtvpt_wpf.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LoginUserControl _loginUserControl = new LoginUserControl();
        HomeUserControl _homeUserControl = new HomeUserControl();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void SetUserControlMenu(UserControl _UserControlSelected)
        {
            ClearUserControlGrid();
            UserControlGrid.Children.Add(_UserControlSelected);
        }

        private void ClearUserControlGrid()
        {
            UserControlGrid.Children.Clear();
        }

        private void ListViewItemLogin_Selected(object sender, RoutedEventArgs e)
        {
            SetUserControlMenu(_loginUserControl);
        }

        private void ListViewItemHome_Selected(object sender, RoutedEventArgs e)
        {
            SetUserControlMenu(_homeUserControl);
        }


    }
}
