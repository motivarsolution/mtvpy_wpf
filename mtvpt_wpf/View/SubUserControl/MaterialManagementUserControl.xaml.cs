using mtvpt_wpf.Utility;
using mtvpt_wpf.View.Popup;
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
    /// Interaction logic for MaterialManagementUserControl.xaml
    /// </summary>
    public partial class MaterialManagementUserControl : UserControl
    {
        public MaterialManagementUserControl()
        {
            InitializeComponent();
        }

        private void NewMaterialButton_Click(object sender, RoutedEventArgs e)
        {
            NewMaterialPopup newMaterialPopup = new NewMaterialPopup();
            GlobalVariables._mainWindow.SetUserControlMenu(newMaterialPopup);
        }

        /*
         public void SetUserControlMenu(UserControl _UserControlSelected)
        {
            ClearUserControlGrid();
            UserControlGrid.Children.Add(_UserControlSelected);
        }

        public void ClearUserControlGrid()
        {
            UserControlGrid.Children.Clear();
        }
         */
    }
}
