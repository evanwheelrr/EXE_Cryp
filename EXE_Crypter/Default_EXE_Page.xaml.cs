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
    /// Interaction logic for Page4.xaml
    /// </summary>
    public partial class Default_EXE_Page : Page
    {
        public Default_EXE_Page()
        {
            InitializeComponent();
        }
        private void Build_Payload(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("EXE Saved to Desktop");
        }
        private void EXE_Image_Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();
            EXE_Image.Content = fileDialog.FileName;
        }
    }
}
