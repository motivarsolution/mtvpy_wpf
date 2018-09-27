using mtvpt_wpf.Controller;
using mtvpt_wpf.Model.Internal;
using mtvpt_wpf.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for LoginUserControl.xaml
    /// </summary>
    public partial class LoginUserControl : UserControl, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        LoginMessage loginMessage = new LoginMessage();
        LoginModel loginModel = new LoginModel();

        public LoginUserControl()
        {
            InitializeComponent();
        }

        private void LoginUserControlXaml_Loaded(object sender, RoutedEventArgs e)
        {
            usernameTextblock.Focus();
        }

        private void signinButton_Click(object sender, RoutedEventArgs e)
        {
            Login(sender,e);
        }

        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

        private void usernameTextblock_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                passwordTextblock.Focus();
            }
        }

        private void passwordTextblock_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Login(sender,e);
            }
        }

        private void Login(object sender, RoutedEventArgs e)
        {
            HomeUserControl _homeUserControl = new HomeUserControl();

            DatabaseConnection.SetConnection();
            DatabaseConnection.querySystemDetail();

            loginModel.login_username = usernameTextblock.Text;
            loginModel.Login_password = passwordTextblock.Password;

            loginMessage = LoginController.Login(loginModel);
            GlobalFunctions.ShowDebug(loginMessage.returnStatusModel.error_message);


            if (loginMessage.returnStatusModel.status == true)
            {
                //test solution store in GlobalVar but not recommend
                GlobalVariables._mainWindow.ListViewItemHome_Selected(sender, e);
            }
            else
            {
                passwordTextblock.Clear();
            }
        }
    }


}
