using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using IronXL;

namespace HabitatBirdsApplication
{
    /// <summary>
    /// Interaction logic for SignUpWindow.xaml
    /// </summary>
    public partial class SignUpWindow : Window
    {
        private MainWindow mainWindow;
        private DataGrid dataGrid;

        public object ExcelPackage { get; private set; }

        // Default constructor for SignUpWindow
        public SignUpWindow()
        {
            InitializeComponent();
            this.mainWindow = new MainWindow();
        }

        // Constructor for SignUpWindow with a reference to the main window
        public SignUpWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }

        // Saves user sign-up data to an Excel file
        private void SaveToExcel(string firstName, string lastName, string id, string userName, string password)
        {
            string filePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "Birds.xlsx");
            //string filePath = @"C:\Users\Matan\Desktop\Birds.xlsx";

            WorkBook workbook = WorkBook.Load(filePath);
            WorkSheet worksheet = workbook.GetWorkSheet("Users");
            
            string lastRow = (worksheet.RowCount+1).ToString();

            worksheet["A" + lastRow].Value = firstName;
            worksheet["B" + lastRow].Value = lastName;
            worksheet["C" + lastRow].Value = id;
            worksheet["D" + lastRow].Value = userName;
            worksheet["E" + lastRow].Value = password;

            workbook.SaveAs(filePath);
        }

        // Checks if a username is valid and unique
        private bool IsValidUserName(string userName)
        {
            if (userName.Length < 6 || userName.Length > 8)
            {
                return false;
            }

            int digitCount = 0;
            int letterCount = 0;

            foreach (char c in userName)
            {
                if (char.IsDigit(c))
                {
                    digitCount++;
                }
                else if (char.IsLetter(c))
                {
                    letterCount++;
                }
            }

            if (digitCount > 2 || letterCount != userName.Length - digitCount)
            {
                return false;
            }
            string filePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "Birds.xlsx");
            WorkBook workbook = WorkBook.Load(filePath);
            WorkSheet worksheet = workbook.GetWorkSheet("Users");

            for (int row = 2; row <= worksheet.RowCount; row++) 
            {
                string existingUserName = worksheet["D" + row].StringValue;
                if (existingUserName == userName)
                {
                    return false; // Username already exists
                }
            }

            return true; // Username is valid and unique
        }

        // Checks if a character is a special character
        private bool IsSpecialCharacter(char c)
        {
            string specialCharacters = "!@#$%^&*()";

            return specialCharacters.Contains(c);
        }

        // Checks if a password is valid
        private bool IsValidPassword(string password)
        {
            if (password.Length < 8 || password.Length > 10)
            {
                return false;
            }

            int letterCount = 0;
            int digitCount = 0;
            int specialCharCount = 0;

            foreach (char c in password)
            {
                if (char.IsLetter(c))
                {
                    letterCount++;
                }
                else if (char.IsDigit(c))
                {
                    digitCount++;
                }
                else if (IsSpecialCharacter(c))
                {
                    specialCharCount++;
                }
            }

            if (letterCount == 0 || digitCount == 0 || specialCharCount == 0)
            {
                return false;
            }

            return true;
        }

        // Checks if an ID is valid
        private bool IsValidID(string id)
        {
            if (id.Length != 9 || !id.All(char.IsDigit))
            {
                return false;
            }

            return true;
        }

        // Event handler for the save button click
        private void saveButton(object sender, RoutedEventArgs e)
        {
            string firstName = firstNameText.Text;
            string lastName = lastNameText.Text;
            string id = IDtext.Text;
            string userName = userNameTextBox.Text;
            string password = passwordTextBox.Text;

            if (!IsValidID(id))
            {
                MessageBox.Show("Invalid ID. It should be a 9-digit number.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (!IsValidPassword(password))
            {
                MessageBox.Show("Invalid password. It should contain between 8 and 10 characters, with at least one letter, one digit, and one special character.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;

            }
            if (!IsValidUserName(userName))
            {
                MessageBox.Show("Invalid username. It should contain between 6 and 8 characters, with at most 2 digits and the rest letters.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            SaveToExcel(firstName, lastName, id, userName, password);
            this.Hide();
            mainWindow.Show();
        }
    }
}








