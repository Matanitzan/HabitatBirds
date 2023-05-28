using IronXL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace HabitatBirdsApplication
{
    /// <summary>
    /// Interaction logic for BirdSearch.xaml
    /// </summary>
    public partial class BirdSearch : Window
    {
        // Properties to hold gender and species data
        public string[] genders { get; set; }
        public string[] species { get; set; }

        // Variables to store selected gender and species
        public string selectedSpecies;
        public string selectedGender;

        // Path to the Excel file
        string fileNameXls = @"C:\Users\Matan\Desktop\Birds.xlsx";

        public BirdSearch()
        {
            InitializeComponent();

            // Initialize gender and species data
            genders = new string[] { "Male", "Female" };
            species = new string[] { "American Gouldian", "European Gouldian", "Australian Gouldian" };

            // Set the data context to the current instance of the class
            DataContext = this;
        }

        // Event handler for gender selection change
        private void genderText_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var comboBox = (ComboBox)sender;
            selectedGender = comboBox.SelectedItem as string;
        }

        // Event handler for species selection change
        private void speciesOfBirdText_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var comboBox = (ComboBox)sender;
            selectedSpecies = comboBox.SelectedItem as string;
        }

        // Method to search birds in Excel based on serial number
        private List<Bird> SearchBirdsInExcel(string serialNumber, string col)
        {
            List<Bird> matchedBirds = new List<Bird>();

            try
            {
                // Load the Excel workbook
                WorkBook workBook = WorkBook.Load(fileNameXls);
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

        // Event handler for select button click
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
            //MessageBox.Show($"Selected Bird:\nSerial Number: {serialNumber}\nSpecies: {species}\nHatch Date: {hatchDate}");
        }
        private Boolean isValidSerial(string serial, string type)
        {
            if (string.IsNullOrEmpty(serial))
            {
                MessageBox.Show("Error: " + type + "'s box is empty!");
                return false;
            }
            foreach (char c in serial)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("Error:You can only write digits to " + type + "'s box!");
                    return false;
                }
            }
            return true;
        }
        // Method to check if a string is not null or empty
        private Boolean isNotNullOrEmpty(string s, string box)
        {
            if (string.IsNullOrEmpty(s))
            {
                MessageBox.Show("Error: " + box + "'s box is empty");
                return false;
            }
            return true;
        }

        // Event handler for searching birds by serial number
        private void SearchBySerialNumber(object sender, RoutedEventArgs e)
        {
            if (isValidSerial(searchSerialNumberText.Text, "Sireal Number"))
                {
                List<Bird> matchedBirds = SearchBirdsInExcel(searchSerialNumberText.Text, "A");
                // Update the ListView with sorted bird data
                BirdsList.ItemsSource = sortedBirds(matchedBirds);
                }
            else
            {
                BirdsList.ItemsSource = null ;
            }
            // Clear the search text box
            searchSerialNumberText.Text = "";
        }

        // Event handler for searching birds by species
        private void SearchBySpecie(object sender, RoutedEventArgs e)
        {
            if (isNotNullOrEmpty(selectedSpecies, "Species"))
            {
                List<Bird> matchedBirds = SearchBirdsInExcel(selectedSpecies, "B");
                // Update the ListView with sorted bird data
                BirdsList.ItemsSource = sortedBirds(matchedBirds);
            }

            // Reset the species selection
            speciesOfBirdText.SelectedItem = null;
        }

        // Event handler for searching birds by gender
        private void SearchByGender(object sender, RoutedEventArgs e)
        {
            if (isNotNullOrEmpty(selectedGender,"Gender")){
                List<Bird> matchedBirds = SearchBirdsInExcel(selectedGender, "E");
                // Update the ListView with sorted bird data
                BirdsList.ItemsSource = sortedBirds(matchedBirds);
            }
            // Reset the gender selection
            genderText.SelectedItem = null;
        }

        // Event handler for searching birds by hatch date
        private void SearchByDate(object sender, RoutedEventArgs e)
        {
            if(isNotNullOrEmpty(hatchDateText.Text,"Hatch Date")){
                List<Bird> matchedBirds = SearchBirdsInExcel(hatchDateText.Text, "D");
                // Update the ListView with sorted bird data
                BirdsList.ItemsSource = sortedBirds(matchedBirds);
            }
            // Clear the hatch date text box
            hatchDateText.Text = "";
        }

        // Method to sort birds based on serial number
        public List<Bird> sortedBirds(List<Bird> birds)
        {
            if(birds.Count == 0)
            {
                MessageBox.Show("There are no matching results for your search");
            }
            else
            {
                birds.Sort((bird1, bird2) =>
                {
                    int serialNumber1 = int.Parse(bird1.SerialNumber);
                    int serialNumber2 = int.Parse(bird2.SerialNumber);
                    return serialNumber1.CompareTo(serialNumber2);
                });
            }

            return birds;
        }

        // Event handler for back button click
        private void beckButton(object sender, RoutedEventArgs e)
        {
            // Create an instance of MainPage and show it
            MainPage mainPage = new MainPage();
            this.Visibility = Visibility.Hidden;
            mainPage.Show();
        }
    }
}
