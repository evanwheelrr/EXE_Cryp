using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;
using System.Security.Cryptography;


namespace EXE_Crypter
{
    /// <summary>
    /// Interaction logic for Custom_EXE_Page.xaml
    /// </summary>
    public partial class Custom_EXE_Page : Page
    {
        Payload_window.static_Names names = new EXE_Crypter.Payload_window.static_Names();
        public Custom_EXE_Page()
        {
            InitializeComponent();
        }
        public void custom_exe_Build()
        {
            //MessageBox.Show("Saving to: " + names.folderPath.ToString());
            string exe = exe_Name.Text;
            if (exe != "" && names.folderPath != "")
            {
                exe += ".exe";
                //MessageBox.Show($"Encrypting: {exe}");
                string sourceCode = @"
                using System;
            
                class Program
                {
                static void Main(string[] args)
                {
                    Console.WriteLine(""Hello, world!"");
                    Console.ReadKey();
                }
                }
                "; // Define the source code for your program here

                // Compile the source code into an executable file
                var provider = new CSharpCodeProvider();
                var parameters = new CompilerParameters(new[] { "mscorlib.dll", "System.Core.dll" }, Path.Combine(names.folderPath, exe), false);
                parameters.GenerateExecutable = true;
                parameters.CompilerOptions = "/target:exe";
                CompilerResults results = provider.CompileAssemblyFromSource(parameters, sourceCode);


                // Check if the compilation was successful
                if (results.Errors.HasErrors)
                {
                    MessageBox.Show("Compilation failed!");
                    foreach (CompilerError error in results.Errors)
                    {
                        Console.WriteLine(error.ErrorText);
                    }
                }
                else
                {
                    EncryptFile(names.folderPath, exe, names.folderPath, names.folderPath);
                }
            }
            else
            {
                if (exe_Name.Text == "")
                {
                    MessageBox.Show("Enter a EXE name...");
                }
                if (path_of_EXE.ToString() == "")
                {
                    MessageBox.Show("Choose path to save the EXE to...");
                }
            }
        }
        private static byte[] key = new byte[32]; // 256-bit key
        private static byte[] iv = new byte[16];  // 128-bit IV

        public static void EncryptFile(string inputFile, string outputFile, string name, string folderPath)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;

                using (FileStream inputFileStream = new FileStream(inputFile, FileMode.Open))
                {
                    using (FileStream outputFileStream = new FileStream(outputFile, FileMode.Create))
                    {
                        using (CryptoStream cryptoStream = new CryptoStream(outputFileStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            inputFileStream.CopyTo(cryptoStream);
                        }
                    }
                }
            }

            MessageBox.Show("Executable file saved as: " +name+ ".exe" + "\nSaved to: " + folderPath, "Compilation succeeded!");
        }

        private void EXE_Image_Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();
            if (fileDialog.FileName != string.Empty)
            {
                //exe_image_Path.Content = fileDialog.FileName;
                //static_Names.EXE_Content = (string)exe.Content;
                //Use_image_button.IsChecked = true;
                //static_Names.use_image = true;
            }
        }
        private void Get_path_of_exe(object sender, RoutedEventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.SelectedPath))
                {
                    names.folderPath = dialog.SelectedPath;
                    path_of_EXE.Content = dialog.SelectedPath;
                }
            }
        }
    }
}