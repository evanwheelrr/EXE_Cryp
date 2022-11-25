using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Main_Program : Window
    {
        public Main_Program()
        {
            InitializeComponent();
            //this.Tool_Menue.IsDropDownOpen = true;
            //bool Dropdownatstart == True;
        }
        private void Tool_Menue_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void Crypter_page_Button(object sender, RoutedEventArgs e)
        {
            Main_Menue_Windows_Frame.Navigate(new EXE_Selection_Page());
        }

        private void Connections_Page_Button(object sender, RoutedEventArgs e)
        {
            Main_Menue_Windows_Frame.Navigate(new Connections_Page());
        }
        private void Minimize_Button_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Program_Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            DragMove();
        }
    }
}
