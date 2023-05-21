using IronXL;
using System;
using System.Collections.Generic;
using System.Configuration;
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

namespace HabitatBirdsApplication
{
    /// <summary>
    /// Interaction logic for BirdSearch.xaml
    /// </summary>
    public partial class BirdSearch : Window
    {

        string fileNameXls = @"C:\Users\Osnat\Desktop\Birds.xlsx";
        private int nR = int.Parse(ConfigurationManager.AppSettings["LastRowIndex"]) + 1;


        public BirdSearch()
        {
            InitializeComponent();
        }

        private void searchSirealBut(object sender, RoutedEventArgs e)
        {
            string serialNumber = searchSerialNumberText.Text;
            SearchBirdsBySerialNumber(serialNumber);
        }
        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            string serialNumber = searchSerialNumberText.Text;
            SearchBirdsBySerialNumber(serialNumber);
        }

        private void SearchBirdsBySerialNumber(string serialNumber)
        {
            // Perform the search logic here
            List<Bird> matchedBirds = SearchBirdsInExcel(serialNumber);

            // Display the matched birds
            DisplayMatchedBirds(matchedBirds);
        }

        private List<Bird> SearchBirdsInExcel(string serialNumber)
        {
            List<Bird> matchedBirds = new List<Bird>();

            try
            {
                WorkBook workBook = WorkBook.Load(fileNameXls);
                WorkSheet workSheet = workBook.GetWorkSheet("Birds");

                // Iterate over the rows in the worksheet and check for matching serial numbers
                for (int i = 2; i < nR; i++)
                {
                    var cell = workSheet["A" + i];
                    if (cell.Value != null && cell.Value.ToString().Contains(serialNumber))
                    {
                        // If the serial number matches, create a Bird object and add it to the list
                        string matchedSerialNumber = cell.Value.ToString();
                        string species = workSheet["B" + i].Value.ToString();
                        string subspecies = workSheet["C" + i].Value.ToString();
                        string hatchDate = workSheet["D" + i].Value.ToString();
                        string gender = workSheet["E" + i].Value.ToString();
                        string cageNumber = workSheet["F" + i].Value.ToString();
                        string fatherSerial = workSheet["G" + i].Value.ToString();
                        string motherSerial = workSheet["H" + i].Value.ToString();

                        Bird bird = new Bird(matchedSerialNumber, species, subspecies, hatchDate, gender, cageNumber, fatherSerial, motherSerial);
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
        private void DisplayMatchedBirds(List<Bird> matchedBirds)
        {
            // Clear any existing content in the display area
            searchResultsTextBox.Text = string.Empty;

            // Display the matched birds in the search results text box
            foreach (Bird bird in matchedBirds)
            {
                searchResultsTextBox.Text += $"Serial Number: {bird.SerialNumber}\n";
                searchResultsTextBox.Text += $"Species: {bird.Species}\n";
                searchResultsTextBox.Text += $"Subspecies: {bird.Subspecies}\n";
                searchResultsTextBox.Text += $"Hatch Date: {bird.HatchDate}\n";
                searchResultsTextBox.Text += $"Gender: {bird.Gender}\n";
                searchResultsTextBox.Text += $"Cage Number: {bird.CageNumber}\n";
                searchResultsTextBox.Text += $"Father Serial: {bird.FatherSerial}\n";
                searchResultsTextBox.Text += $"Mother Serial: {bird.MotherSerial}\n";
                searchResultsTextBox.Text += "\n";
            }
        }

        private void searchResultsTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
