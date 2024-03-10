using System;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace EXE_Crypter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class login_Window : Window
    {
        public login_Window()
        {
            //InitializeComponent();
            //Main_Program main_Program = new Main_Program();
            //main_Program.Show();
            //Process Notepadprocess = new Process();
            //Process.Start("notepad.exe");
            //Notepadprocess.StartInfo = new ProcessStartInfo("notepad.exe"); Notepadprocess.Start();
        }
        public class Names
        {
            public string Crypter_Version = "Crypter 1.0.0.5";
        }
        static int login_attempts = 0;
        private void Trylogin(object sender, RoutedEventArgs e)
        {
            Names names = new Names();

            string[] Keys = new string[] {"1", "ashdufioshdvuisbp", "aiohpvoisnovjcbaisu", "aoishnvospbvosjb" };
            string user_key = this.Login_KeyBox.Text;

            if (Keys.Contains(user_key))
            {
                //MessageBox.Show("Enjoy The Exploit!", names.Crypter_Version);
                //this.NavigationService.Navigate(new Program_Main_Page());
                //Thread.Sleep(50);
                Main_Program main_Program = new Main_Program();
                main_Program.Show();
                GetWindow(this).Close();

            }
            else
                if (login_attempts >= 2)
            {
                MessageBox.Show("To many Failed Login Attempts. Closing Window", names.Crypter_Version);

                Close();
            }
            else
            {
                 MessageBox.Show("Enter A Valid key!", names.Crypter_Version);
                 login_attempts += 1;
            }
               
        }
        private void Program_Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void Maximize_button(object sender, RoutedEventArgs e)
        {
            /*if(WindowState == WindowState.Maximized)
            {
                WindowState = WindowState.Normal;
                //Page2 page = new Page2();
                //page.Builder_Version.FontSize = 1;
            }
            else
            {
                WindowState = WindowState.Maximized;
            }*/
        }
        private void Minimize_Button_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            DragMove();
        }

        private void Key_Box_Click(object sender, RoutedEventArgs e)
        {
            Login_KeyBox.Focus();
        }
    }
}