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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace mtvpt_wpf.View.Popup
{
    /// <summary>
    /// Interaction logic for NewMaterialPopup.xaml
    /// </summary>
    public partial class NewMaterialPopup : UserControl
    {
        public NewMaterialPopup()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            MaterialManagementUserControl materialManagementUserControl = new MaterialManagementUserControl();
            GlobalVariables._mainWindow.SetUserControlMenu(materialManagementUserControl);
        }
    }
}
