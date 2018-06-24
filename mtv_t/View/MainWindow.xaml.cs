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

        public MainWindow()
        {
            InitializeComponent();
        }

        private void lb1_Selected(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("List Box 1");
        }

        private void lb2_Selected(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("List Box 2");
        }
    }
}
