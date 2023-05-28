using System;
using System.Collections.Generic;
using System.Globalization;
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
using System.Windows.Shapes;
using System.Diagnostics;
using System.Text.RegularExpressions;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using IronXL;
using System.Reflection.Metadata;

namespace HabitatBirdsApplication
{
    /// <summary>
    /// Interaction logic for NewCage.xaml
    /// </summary>
    public partial class NewCage : System.Windows.Window
    {
        List<Cage> cages ;
        Cage cage;
        string path = @"C:\Users\Matan\Desktop\Birds.xlsx";
        public NewCage()
        {
            InitializeComponent();
            cages = new List<Cage>();
        }
        private void openFile()
        {
            try
            {
                var excelApp = new Excel.Application();
                excelApp.Visible = true;
                Workbooks books = excelApp.Workbooks;
                Workbook sheets = books.Open(path);

            }
            catch (Exception)
            {
                MessageBox.Show("Error", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        public static bool CheckString(string input)
        {
            // Regular expression pattern to match the required format
            string pattern = @"^[A-Z][A-Za-z]*\d*$";

            // Use Regex.IsMatch to check if the input matches the pattern
            bool isMatch = Regex.IsMatch(input, pattern);

            return isMatch;
        }
        
        private void btnAddCage_Click(object sender, RoutedEventArgs e)
        {
            
            WorkBook myWorkBook = WorkBook.Load(path);
            WorkSheet sheet = myWorkBook.GetWorkSheet("Cage");
            if (checkSerial(SerialNumberText.Text) && checkNumbers(LenghtCageText.Text) && checkNumbers(WidthCageText.Text) && checkNumbers(HeightCageText.Text))
            {
                if (findSerial(SerialNumberText.Text,sheet))
                {
                    try
                    {
                        cage = new Cage(SerialNumberText.Text, MetiralOptions.Text, float.Parse(LenghtCageText.Text, CultureInfo.InvariantCulture.NumberFormat),
                   float.Parse(WidthCageText.Text, CultureInfo.InvariantCulture.NumberFormat), float.Parse(HeightCageText.Text, CultureInfo.InvariantCulture.NumberFormat));
                        cages.Add(cage);
                        string lastRow = (sheet.RowCount + 1).ToString();

                        sheet['A' + lastRow].Value = cage.getSerial();
                        sheet['B' + lastRow].Value = cage.getMaterial();
                        sheet['C' + lastRow].Value = cage.getLenght();
                        sheet['D' + lastRow].Value = cage.getWidth();
                        sheet['E' + lastRow].Value = cage.getHeigth();
                        Trace.WriteLine("serial:" + cage.getSerial());
                        myWorkBook.SaveAs(path);
                        MessageBox.Show("New Cage created!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
                }
                else
                {
                    MessageBox.Show("Serial number has type allredy exsist");
                }
                
            }
            else {
                MessageBox.Show("Some of your details are wrong please try again");
            }
         
        }
        public bool checkSerial(string serial)
        {
            // Check if the input string contains at least one letter
            bool containsLetters = Regex.IsMatch(serial, @"[a-zA-Z]");

            // Check if the input string contains at least one digit
            bool containsNumbers = Regex.IsMatch(serial, @"\d");

            // Return true if both conditions are met
            return containsLetters && containsNumbers;
        }
        public bool checkNumbers(string number)
        {
            int num;
            num = int.Parse(number);
            bool flag = false;
            if (num < 5 || num > 1000)
            {
                flag = false;
            }
            else
            {
                flag = true;
            }
                // Check if the input string contains at least one digit
            return Regex.IsMatch(number, @"\d") && flag;
            
        }
        public bool findSerial(string serial , WorkSheet sheet)
        {
            string lastindex = sheet.RowCount.ToString();
            string a = "A" + lastindex;
            foreach (var cell in sheet["A2:"+a])
            {
                if (cell.Text == serial)
                    return false;
            }
            return true;
        }

        private void backButton(object sender, RoutedEventArgs e)
        {
            MainPage mainPage = new MainPage();
            this.Visibility = Visibility.Hidden;
            mainPage.Show();
        }
    }
}
