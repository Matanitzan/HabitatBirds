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
using Microsoft.Office.Interop.Excel;
using Application = Microsoft.Office.Interop.Excel.Application;
using System.Diagnostics;
using System.IO;
using IronXL;

namespace HabitatBirdsApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : System.Windows.Window
    {
        SignUpWindow signUpWindow;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SignUpButton(object sender, RoutedEventArgs e)
        {
            string currentDirectory = Directory.GetCurrentDirectory();

            // Print the current directory
            Trace.WriteLine("Current directory: " + currentDirectory);
            signUpWindow = new SignUpWindow(this);
            signUpWindow.Show();
        }
        private void loginButton(object sender, RoutedEventArgs e)
        {
            string filePath = @"C:\Users\Matan\Desktop\Birds.xlsx";
            // Check if the file exists
            if (System.IO.File.Exists(filePath))
            {
                // If the file exists, open it and get the worksheet
                Application excel = new Application();
                Workbook workbook = excel.Workbooks.Open(filePath);
                Worksheet worksheet = (Worksheet)workbook.Worksheets[1];

                // Get the last row of data
                int lastRow = worksheet.Cells.Find("*", System.Reflection.Missing.Value,
                                    System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                                    XlSearchOrder.xlByRows, XlSearchDirection.xlPrevious,
                                    false, System.Reflection.Missing.Value, System.Reflection.Missing.Value).Row;

                // Check if the entered username and password exist in the excel file
                bool foundUser = false;
                bool foundPassword = false;
                for (int i = 2; i <= lastRow; i++)
                {
                    if (worksheet.Cells[i, 4].Value != null && worksheet.Cells[i, 4].Value.ToString() == userNameTextBox.Text)
                    {
                        foundUser = true;
                        if (worksheet.Cells[i, 5].Value != null && worksheet.Cells[i, 5].Value.ToString() == PasswordTextBox.Password)
                        {
                            foundPassword = true;
                            break;
                        }
                    }
                }

                // Close the workbook and Excel
                workbook.Close();
                excel.Quit();

                // If the user-entered data exists in the excel file, go to the main window
                if (foundUser && foundPassword)
                {
                    //Bird bird = new Bird("123", "Sparrow", "Common", "2023-01-01", "Male", "Cage 1", "456", "789");
                    //ShowBird showBird = new ShowBird(bird);
                    //showBird.Show();
                    //this.Close();

                    MainPage mainPage = new MainPage();
                    mainPage.Show();
                    this.Close();
                }
                else // Otherwise, display an error message
                {
                    MessageBox.Show("One of the details is incorrect.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else // If the file doesn't exist, display an error message
            {
                MessageBox.Show("The user data file is missing.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

    }

}
