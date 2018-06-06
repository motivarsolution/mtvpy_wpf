using mtv_t.Controller;
using mtv_t.Model;
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

namespace mtv_t
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AccountModel accountModel = new AccountModel();
        List<AccountModel> accountModelsList = new List<AccountModel>();

        public MainWindow()
        {
            for (int i = 0; i < 5; i++)
            {
                accountModelsList.Add(new AccountModel()
                {
                    account_id = "000" + i.ToString()  ,
                    account_username = "test00" + i.ToString()
                });

                ShowController.Show();
            }

            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Text1.Text = Calendar1.DisplayDate.ToString(); 
        }
    }
}
