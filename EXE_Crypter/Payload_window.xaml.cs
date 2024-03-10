using Microsoft.Win32;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.IO;
using System.Windows.Forms;
using System;
using System.Linq;
using MessageBox = System.Windows.Forms.MessageBox;
using OpenFileDialog = System.Windows.Forms.OpenFileDialog;
using Application = System.Windows.Forms.Application;
using static EXE_Crypter.Custom_EXE_Page;
using EXE_Crypter;

namespace EXE_Crypter
{
    /// <summary>
    /// Interaction logic for Payload_window.xaml
    /// </summary>
    public partial class Payload_window : Page
    {
        Custom_EXE_Page custom_page = new Custom_EXE_Page();
        Default_exe_page default_page = new Default_exe_page();
        static_Names names = new static_Names();
        public Payload_window()
        {
            InitializeComponent();
        }
        public class static_Names
        {
            public bool use_image = false;
            public string folderPath;
            public string exePath;
            public string exe_image_Path;
            public bool use_defualt_EXE = true;
        }
        public static implicit operator string(Payload_window v)
        {
            throw new NotImplementedException();
        }

        private void use_image_checked(object sender, RoutedEventArgs e)
        {
            //user wants a exe image
        }

        private void Default_EXE_Checked(object sender, RoutedEventArgs e)
        {

            names.use_defualt_EXE = true;
            EXE_page_frame.Navigate(default_page);
        }

        private void Custom_exe_Page_Checked(object sender, RoutedEventArgs e)
        {
            names.use_defualt_EXE = false;
            EXE_page_frame.Navigate(custom_page);
        }

        private void Payload_Build_Button_Click(object sender, RoutedEventArgs e)
        {
            if (names.use_defualt_EXE == true)
            {
                //use default payload
               
            }
            else
            {
                //use default payload
                custom_page.custom_exe_Build();
            }
        }
        private void dont_use_image_checked(object sender, RoutedEventArgs e)
        {
            //user doesn't want an image for the executable, default one will be used.
        }
    }
}