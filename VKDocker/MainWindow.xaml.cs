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

namespace VKDocker
{
    public partial class MainWindow : Window
    {
        Authorizate a = new Authorizate();
        public MainWindow()
        {   
            InitializeComponent();
            WinSize(); 
            wb.Navigate(a.aut); 
        }

        private void WinSize()
        {
            MaxHeight = 460;
            MaxWidth = 700;
            MinHeight = 460;
            MinWidth = 700;
        }

        private void wb_LoadCompleted(object sender, NavigationEventArgs e)
        {
             a.VKAuth(wb.Source.AbsoluteUri.ToString());
        }
    }
}
