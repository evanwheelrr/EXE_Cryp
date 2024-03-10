using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
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
            Main_Menue_Windows_Frame.Navigate(new Payload_window());
        }
        private void Tool_Menue_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void Crypter_page_Button(object sender, RoutedEventArgs e)
        {
            Main_Menue_Windows_Frame.Navigate(new Payload_window());
        }

        private void Connections_Page_Button(object sender, RoutedEventArgs e)
        {
            Buttons_Grid.Background = Brushes.Black;
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
