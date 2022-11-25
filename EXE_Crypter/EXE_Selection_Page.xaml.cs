using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace EXE_Crypter
{
    /// <summary>
    /// Interaction logic for Page3.xaml
    /// </summary>
    public partial class EXE_Selection_Page : Page
    {
        public EXE_Selection_Page()
        {
            InitializeComponent();
        }
        private void Default_Payload_Move(object sender, RoutedEventArgs e)
        {
            Default_EXE_Page defualt_exe_page = new Default_EXE_Page();
            Display_Payload_Frame.Navigate(defualt_exe_page);

        }

        private void Custom_Payload_Page_move(object sender, RoutedEventArgs e)
        {
            Custom_EXE_Page custom_exe_page = new Custom_EXE_Page();
            Display_Payload_Frame.Navigate(custom_exe_page);

        }
    }
}
