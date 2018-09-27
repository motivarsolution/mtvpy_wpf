using mtvpt_wpf.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace mtvpt_wpf.Utility
{
    public static class GlobalVariables
    {
        public static string SYSTEM_LANGUEGE { get; set; }
        public static Grid _UserControlGrid { get; set; }
        public static ListViewItem _ListViewItem { get; set; }
        public static MainWindow _mainWindow { get; set; }

    }
}
