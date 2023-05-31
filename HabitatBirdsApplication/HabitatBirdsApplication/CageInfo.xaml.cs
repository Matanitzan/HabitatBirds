using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using IronXL;
namespace HabitatBirdsApplication
{
    /// <summary>
    /// Interaction logic for CageInfo.xaml
    /// </summary>
    public partial class CageInfo : System.Windows.Window
    {
        FindCage selected_cage;
        //string path = @"C:\Users\Matan\Desktop\Birds.xlsx";
        string path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "Birds.xlsx");
        int index;

        Cage yourCage;

        /// <summary>
        /// Initializes a new instance of the CageInfo class.
        /// </summary>
        /// <param name="Fcage">The FindCage object representing the selected cage.</param>
        /// <param name="yourCage">The Cage object representing the user's cage.</param>
        /// 
        public CageInfo(FindCage Fcage, Cage yourCage)
        {
            this.selected_cage = Fcage;
            this.yourCage = yourCage;
            InitializeComponent();
            BirdsList.ItemsSource = SearchBirdsInExcel(selected_cage.serial_number_cage(), "F");
            ShowInfo();
        }

        /// <summary>
        /// Displays the information about the selected cage.
        /// </summary>
        public void ShowInfo()
        {
            WorkBook myWorkBook = WorkBook.Load(path);
            WorkSheet sheet = myWorkBook.GetWorkSheet("Cage");

            int i = 2;
            string lastindex = sheet.RowCount.ToString();
            string a = "A" + lastindex;
            if(selected_cage.OptionTypeToFind.Text == "serial number")
            {
                foreach (var cell in sheet["A2:" + a])
                {
                    if (cell.Text == selected_cage.FindCageText.Text)
                    {
                        SerialNumberName.Content = selected_cage.FindCageText.Text;
                        MetrialName.Content = sheet["B" + i].ToString();
                        LengthName.Content = sheet["C" + i].ToString();
                        HeigthName.Content = sheet["E" + i].ToString();
                        WidthName.Content = sheet["D" + i].ToString();
                        index = i;
                        break;
                    }
                    i++;
                }
            }
            if(selected_cage.OptionTypeToFind.Text == "By material")
            {
                foreach (var cell in sheet["A2:" + a])
                {
                    if (cell.Text == selected_cage.serial_number_cage())
                    {
                        SerialNumberName.Content = selected_cage.serial_number_cage();
                        MetrialName.Content = sheet["B" + i].ToString();
                        LengthName.Content = sheet["C" + i].ToString();
                        HeigthName.Content = sheet["E" + i].ToString();
                        WidthName.Content = sheet["D" + i].ToString();
                        index = i;
                        break;
                    }
                    i++;
                }
            } 
        }
        /// <summary>
        /// Searches for birds in the Excel file based on a serial number and column.
        /// </summary>
        /// <param name="serialNumber">The serial number to search for.</param>
        /// <param name="col">The column to search in.</param>
        /// <returns>A list of matched Bird objects.</returns>
        private List<Bird> SearchBirdsInExcel(string serialNumber, string col)
        {
            List<Bird> matchedBirds = new List<Bird>();
            try
            {
                // Load the Excel workbook
                WorkBook workBook = WorkBook.Load(path);
                WorkSheet workSheet = workBook.GetWorkSheet("Birds");

                // Iterate over the rows in the worksheet and check for matching serial numbers
                for (int i = 2; i <= workSheet.RowCount; i++)
                {
                    var cell = workSheet[col + i];
                    if (cell.Value != null && cell.Value.ToString().Contains(serialNumber))
                    {
                        // If the serial number matches, create a Bird object and add it to the list
                        string serialNumbe = workSheet["A" + i].Value.ToString();
                        string species = workSheet["B" + i].Value.ToString();
                        string subspecies = workSheet["C" + i].Value.ToString();
                        string hatchDate = workSheet["D" + i].Value.ToString();
                        string gender = workSheet["E" + i].Value.ToString();
                        string cageNumber = workSheet["F" + i].Value.ToString();
                        string fatherSerial = workSheet["G" + i].Value.ToString();
                        string motherSerial = workSheet["H" + i].Value.ToString();

                        Bird bird = new Bird(serialNumbe, species, subspecies, hatchDate, gender, cageNumber, fatherSerial, motherSerial);
                        matchedBirds.Add(bird);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error - unable to search in Excel file\n" + ex.Message);
            }

            return matchedBirds;
        }

        /// <summary>
        /// Handles the event when the "Show Bird" button is clicked.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        /// 
        private void btnShowBird(object sender, RoutedEventArgs e)
        {
            Button selectButton = (Button)sender;
            Bird selectedBird = (Bird)selectButton.DataContext;

            // Access the selected bird's details and perform any actions you want
            string serialNumber = selectedBird.SerialNumber;
            string species = selectedBird.Species;
            string hatchDate = selectedBird.HatchDate;

            // Display the selected bird's details or perform any other actions
            ShowBird showBird = new ShowBird(selectedBird);
            this.Visibility = Visibility.Hidden;
            showBird.Show();
        }

        /// <summary>
        /// Handles the event when the "Edit Cage" button is clicked.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        private void btnEditCage(object sender, RoutedEventArgs e)
        {
            NewCage editCage = new NewCage(yourCage,index);
            this.Visibility = Visibility.Hidden;
            editCage.Show();

        }
        /// <summary>
        /// Handles the event when the "Back" button is clicked.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        private void backButton(object sender, RoutedEventArgs e)
        {
            MainPage mainPage = new MainPage();
            this.Visibility = Visibility.Hidden;
            mainPage.Show();
        }
    }
}
