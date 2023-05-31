using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Window = System.Windows.Window;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Diagnostics;
using System.Text.RegularExpressions;
using Excel = Microsoft.Office.Interop.Excel;
using OfficeWindow = Microsoft.Office.Interop.Excel.Window;
using System.Runtime.InteropServices;
using IronXL;
using System.Configuration;
using System.Diagnostics;
//using Microsoft.Office.Interop.Excel;


namespace HabitatBirdsApplication
{
    /// <summary>
    /// Interaction logic for NewBird.xaml
    /// </summary>
    public partial class NewBird : Window
    {
        // Properties to hold gender, species, and subspecies data
        public string[] ganders { get; set;}
        public string[] species { get; set; }
        public string[] subspecies { get; set; }
        // Variables to store selected species and subspecies
        public string selectSpecies;
        public string selectSubspecies;
        // Variable to store selected gender
        public string gender;
        // Path to the Excel file
        string fileNameXls = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "Birds.xlsx");
        //string fileNameXls = @"C:\Users\Matan\Desktop\Birds.xlsx";
        private Bird bird;



        public NewBird()
        {
            // Initialize gender, species, and subspecies data
            InitializeComponent();
            WorkBook workBook = WorkBook.Load(fileNameXls);
            WorkSheet workSheet = workBook.GetWorkSheet("Birds");
            ganders = new string [] { "Male", "Female" };
            species = new string[] { "American Gouldian", "European Gouldian", "Australian Gouldian" };
            subspecies = new string[] { "North America", "Central America", "South America", "Eastern Europe", "Western Europe", "Central Australia", "Coast Cities" };
            // Set the data context to the current instance of the class
            DataContext = this;
            serialNumberText.Text = workSheet.RowCount.ToString();
            serialNumberText.IsEnabled = false;
            fatherSerialText.Text = "777";
            motherSerialText.Text = "777";
            fatherSerialText.IsEnabled = false;
            motherSerialText.IsEnabled = false;
        }
        public NewBird(Bird bird)
        {
            this.bird = bird;
            InitializeComponent();
            ganders = new string[] { "Male", "Female" };
            species = new string[] { "American Gouldian", "European Gouldian", "Australian Gouldian" };
            subspecies = new string[] { "North America", "Central America", "South America", "Eastern Europe", "Western Europe", "Central Australia", "Coast Cities" };
            // Set the data context to the current instance of the class
            DataContext = this;
            this.cageNumberText.Text = this.bird.CageNumber;
            this.speciesOfBirdText.SelectedItem = this.bird.Species;
            this.subsprciesText.SelectedItem = this.bird.Subspecies;
            genderText.SelectedItem = this.bird.Gender;
            hatchDateText.Text = this.bird.HatchDate;
            serialNumberText.Text = this.bird.SerialNumber;
            fatherSerialText.Text = this.bird.FatherSerial;
            motherSerialText.Text = this.bird.MotherSerial;
        }
        public NewBird(Bird bird,string message)
        {
            this.bird = bird;
            InitializeComponent();
            WorkBook workBook = WorkBook.Load(fileNameXls);
            WorkSheet workSheet = workBook.GetWorkSheet("Birds");
            ganders = new string[] { "Male", "Female" };
            species = new string[] { "American Gouldian", "European Gouldian", "Australian Gouldian" };
            subspecies = new string[] { "North America", "Central America", "South America", "Eastern Europe", "Western Europe", "Central Australia", "Coast Cities" };
            // Set the data context to the current instance of the class
            DataContext = this;
            this.cageNumberText.Text = this.bird.CageNumber;
            this.speciesOfBirdText.SelectedItem = this.bird.Species;
            this.subsprciesText.SelectedItem = this.bird.Subspecies;
            genderText.SelectedItem = null;
            hatchDateText.Text = "";
            serialNumberText.Text = workSheet.RowCount.ToString();
            serialNumberText.IsEnabled = false;
            if (bird.Gender=="Male")
            {
                fatherSerialText.Text = this.bird.SerialNumber;
                motherSerialText.Text = message;
            }
            else
            {
                motherSerialText.Text = this.bird.SerialNumber;
                fatherSerialText.Text = message;
            }
            cageNumberText.IsEnabled = false;
            speciesOfBirdText.IsEnabled = false;
            subsprciesText.IsEnabled = false;
            fatherSerialText.IsEnabled = false;
            motherSerialText.IsEnabled = false;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
        // Method to validate the serial number format and uniqueness
        public bool isValidSerial(string serial,string type)
        {
            if (string.IsNullOrEmpty(serial))
            {
                MessageBox.Show("Error: "+ type+"'s box is empty!");
                return false;
            }
            foreach (char c in serial)
            {
                if (!char.IsDigit(c)) 
                {
                    MessageBox.Show("Error:You can only write digits to "+type+"'s box!");
                    return false;
                }
            }
            return true;
        }
        // Method to check if the serial number is unique
        public bool IsSerialNumberUnique(string serialNumber)
        {
            try
            {
                WorkBook workBook = WorkBook.Load(fileNameXls);
                WorkSheet workSheet = workBook.GetWorkSheet("Birds");

                // Iterate over the rows in the worksheet and check for matching serial numbers
                for (int i = 2; i <= workSheet.RowCount; i++)
                {
                    string value = workSheet["A" + i].Value.ToString();
                    if (value.Equals(serialNumber))
                    {
                        MessageBox.Show("Serial number found, not unique");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error - unable to search in Excel file\n" + ex.Message);
            }
            return true;
        }

        private bool IsCageIn(string cage)
        {
            try
            {
                WorkBook workBook = WorkBook.Load(fileNameXls);
                WorkSheet workSheet = workBook.GetWorkSheet("Cage");
                // Iterate over the rows in the worksheet and check for matching serial numbers
                for (int i = 2; i < workSheet.RowCount+1; i++)
                {
                    string value = workSheet["A" + i].Value.ToString();
                    Trace.WriteLine(value);
                    if (value==cage)
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error - unable to search in Excel file\n" + ex.Message);
            }
            MessageBox.Show("Cage name does not exist in the system.");
            return false;
        }

        // Method to check if a string is not null or empty
        private bool isNotNullOrEmpty(string s, string box)
        {
            if (string.IsNullOrEmpty(s))
            {
                MessageBox.Show("Error: "+box+"'s box is empty");
                return false;
            }
            return true;
        }

        // Event handler for the submit button click
        private void sumbit(object sender, RoutedEventArgs e)
        {
            string serialNumber = serialNumberText.Text;
            string hatchDate = hatchDateText.Text;
            string cageNumber = cageNumberText.Text;
            string fatherSerial = fatherSerialText.Text;
            string motherSerial = motherSerialText.Text;

            // Validate the input fields
            if (isNotNullOrEmpty(serialNumber,"Srial Number") && isNotNullOrEmpty(hatchDate, "Hatch Date") && isNotNullOrEmpty(cageNumber, "Cage Number") && isNotNullOrEmpty(fatherSerial, "Father Serial") && isNotNullOrEmpty(motherSerial,"Mother Serial") && isNotNullOrEmpty(selectSpecies, "Species") && isNotNullOrEmpty(selectSubspecies, "Subspecies") && isNotNullOrEmpty(gender, "Gender"))
            {
                if(isValidSerial(serialNumber, "Serial Number")&& IsSerialNumberUnique(serialNumber) && IsCageIn(cageNumber))
                {
                    MessageBox.Show("New bird has created");
                    openFile(serialNumber, hatchDate, cageNumber, fatherSerial, motherSerial, selectSpecies, selectSubspecies, gender);
                    serialNumberText.Text = " ";
                    hatchDateText.Text = " ";
                    cageNumberText.Text = " ";
                    fatherSerialText.Text = "777";
                    motherSerialText.Text = "777";
                    genderText.SelectedItem = null;
                    speciesOfBirdText.SelectedItem = null;
                    subsprciesText.SelectedItem = null;
                }
            }
        }

        // Event handler for the species selection change
        private void speciesOfBirdText_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var select = sender as ComboBox;
            selectSpecies = select.SelectedItem as string;
            subsprciesText.Items.Clear();
            if (selectSpecies == "American Gouldian")
            {
                subsprciesText.Items.Add("North America");
                subsprciesText.Items.Add("Central America");
                subsprciesText.Items.Add("South America");
            }
            if (selectSpecies == "European Gouldian")
            {
                subsprciesText.Items.Add("Eastern Europe");
                subsprciesText.Items.Add("Western Europe");
            }
            if(selectSpecies == "Australian Gouldian")
            {
                subsprciesText.Items.Add("Central Australia");
                subsprciesText.Items.Add("Coast Cities");
            }
        }

        // Event handler for the subspecies selection change
        private void subsprciesText_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var select = sender as ComboBox;
            selectSubspecies = select.SelectedItem as string;
        }

        // Event handler for the gender selection change
        private void genderText_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var select = sender as ComboBox;
            gender = select.SelectedItem as string;
        }

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DatePicker datePicker = (DatePicker)sender;
            DateTime selectedDate = datePicker.SelectedDate ?? DateTime.MinValue;

            // Check if the selected date is in the future
            if (selectedDate > DateTime.Now.Date)
            {
                // Set the selected date to the current date
                datePicker.SelectedDate = DateTime.Now.Date;
            }
        }
        // Method to open the Excel file and save the bird information
        private void openFile(string serialNumber, string hatchDate, string cageNumber, string fatherSerial, string motherSerial, string selectSpecies, string selectSubspecies, string gender)
        {
            try
            {
                WorkBook workBook = WorkBook.Load(fileNameXls);
                WorkSheet workSheet = workBook.GetWorkSheet("Birds");

                string nextRow = (workSheet.RowCount+1).ToString();
                
                // Set the cell values for the bird information
                workSheet['A'+nextRow].Value = serialNumber;
                workSheet['B'+nextRow].Value = selectSpecies;
                workSheet['C'+nextRow].Value = selectSubspecies;
                workSheet['D'+nextRow].Value = hatchDate;
                workSheet['E'+nextRow].Value = gender;
                workSheet['F'+nextRow].Value = cageNumber;
                workSheet['J' + nextRow].Value = "FALSE";
                if (bird == null)
                {
                    workSheet['G' + nextRow].Value = "777";
                    workSheet['H' + nextRow].Value = "777";
                }
                else
                {
                    workSheet['G' + nextRow].Value = fatherSerial;
                    workSheet['H' + nextRow].Value = motherSerial;
                }
                // Save the workbook
                workBook.SaveAs(fileNameXls);
            }
            catch (Exception)
            {
                MessageBox.Show("Error - unable to save to Excel file");
            }
        }

        // Event handler for the back button click
        private void beckButton(object sender, RoutedEventArgs e)
        {
            MainPage mainPage = new MainPage();
            this.Visibility = Visibility.Hidden;
            mainPage.Show();
        }


    }
}
