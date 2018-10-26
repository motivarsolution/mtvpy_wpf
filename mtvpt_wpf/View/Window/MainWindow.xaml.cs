using mtvpt_wpf.Constants;
using mtvpt_wpf.Controller;
using mtvpt_wpf.Model.Internal;
using mtvpt_wpf.Utility;
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
        CustomerUserControl _customerUserControl = new CustomerUserControl();
        EmployeeUserControl _employeeUserControl = new EmployeeUserControl();
        HistoryUserControl _historyUserControl = new HistoryUserControl();
        ReportUserControl _reportUserControl = new ReportUserControl();
        SalesUserControl _salesUserControl = new SalesUserControl();
        SearchUserControl _searchUserControl = new SearchUserControl();
        SettingUserControl _settingUserControl = new SettingUserControl();
        UserManagementUserControl _userManagementUserControl = new UserManagementUserControl();
        MaterialManagementUserControl _materialManagementUserControl = new MaterialManagementUserControl();

        public MainWindow()
        {
            InitializeComponent();

            //DatabaseConnection.SetConnection();
            //DatabaseConnection.querySystemDetail();

            //ListViewItemTest.Selected += new RoutedEventHandler(ListViewItemSearch_Selected);
            //ListViewItemHome.Selected += new RoutedEventHandler(MainWindowXaml_Loaded);
        }

        private void MainWindowXaml_Loaded(object sender, RoutedEventArgs e)
        {
            ListViewItemHome.IsSelected = true;
        }

        public void SetUserControlMenu(UserControl _UserControlSelected)
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
            GlobalFunctions.getMainWindow(this);
            SetUserControlMenu(_loginUserControl);
        }

        public void ListViewItemHome_Selected(object sender, RoutedEventArgs e)
        {
            SetUserControlMenu(_homeUserControl);
        }

        private void ListViewItemCustomer_Selected(object sender, RoutedEventArgs e)
        {
            SetUserControlMenu(_customerUserControl);
        }

        private void ListViewItemEmployee_Selected(object sender, RoutedEventArgs e)
        {
            SetUserControlMenu(_employeeUserControl);
        }

        private void ListViewItemReport_Selected(object sender, RoutedEventArgs e)
        {
            SetUserControlMenu(_reportUserControl);
        }

        private void ListViewItemSales_Selected(object sender, RoutedEventArgs e)
        {
            SetUserControlMenu(_salesUserControl);
        }

        private void ListViewItemSearch_Selected(object sender, RoutedEventArgs e)
        {
            SetUserControlMenu(_searchUserControl);
        }

        private void ListViewItemSetting_Selected(object sender, RoutedEventArgs e)
        {
            SetUserControlMenu(_settingUserControl);
        }

        private void ListViewItemUserManagement_Selected(object sender, RoutedEventArgs e)
        {
            SetUserControlMenu(_userManagementUserControl);
        }

        private void ListViewItemMaterialManagement_Selected(object sender, RoutedEventArgs e)
        {
            SetUserControlMenu(_materialManagementUserControl); 
        }

        private void ListViewItemTest_Selected(object sender, RoutedEventArgs e)
        {

        }


    }
}
