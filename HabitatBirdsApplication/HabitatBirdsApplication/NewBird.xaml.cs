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
//using Microsoft.Office.Interop.Excel;


namespace HabitatBirdsApplication
{
    /// <summary>
    /// Interaction logic for NewBird.xaml
    /// </summary>
    public partial class NewBird : Window
    {
        public string[] ganders { get; set;}
        public string[] species { get; set; }
        public string[] subspecies { get; set; }
        public string selectSpecies;
        public string selectSubspecies;
        public string gender;
        string fileNameXls = @"C:\Users\Osnat\Desktop\Birds.xlsx";
        private int nR = int.Parse(ConfigurationManager.AppSettings["LastRowIndex"]) + 1;
        //private int nR = 2;


        public NewBird()
        {
            InitializeComponent();
            ganders = new string [] { "Male", "Female" };
            species = new string[] { "American Gouldian", "European Gouldian", "Australian Gouldian" };
            subspecies = new string[] { "North America", "Central America", "South America", "Eastern Europe", "Western Europe", "Central Australia", "Coast Cities" };
            DataContext = this;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
        private Boolean isValidSerial(string serial,string type)
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

        private Boolean isValidSubspecies(string species, string subspecies)
        {
            bool flag = (species == "American Gouldian") && (subspecies == "North America" || subspecies == "Central America" || subspecies == "South America");
            flag = flag || (species == "European Gouldian" && (subspecies == "Eastern Europe" || subspecies == "Western Europe"));
            flag = flag || (species == "Australian Gouldian" && subspecies == "Central Australia" || subspecies == "Coast Cities");
            if (!flag)
            {
                MessageBox.Show("Error: Subspecies does not match the species!");
                return false;
            }
            return flag;
        }
        private Boolean isNotNullOrEmpty(string s, string box)
        {
            if (string.IsNullOrEmpty(s))
            {
                MessageBox.Show("Error: "+box+"'s box is empty");
                return false;
            }
            return true;
        }

        private void sumbit(object sender, RoutedEventArgs e)
        {
            string serialNumber = serialNumberText.Text;
            string hatchDate = hatchDateText.Text;
            string cageNumber = cageNumberText.Text;
            string fatherSerial = fatherSerialText.Text;
            string motherSerial = motherSerialText.Text;
            if(isNotNullOrEmpty(serialNumber,"Srial Number") && isNotNullOrEmpty(hatchDate, "Hatch Date") && isNotNullOrEmpty(cageNumber, "Cage Number") && isNotNullOrEmpty(fatherSerial, "Father Serial") && isNotNullOrEmpty(motherSerial,"Mother Serial") && isNotNullOrEmpty(selectSpecies, "Species") && isNotNullOrEmpty(selectSubspecies, "Subspecies") && isNotNullOrEmpty(gender, "Gender"))
            {
                if(isValidSerial(serialNumber, "Serial Number")&& isValidSerial(motherSerial, "Mother Serial") && isValidSerial(fatherSerial,"Father Serial"))
                {
                    MessageBox.Show(serialNumber + " " + hatchDate + " " + cageNumber + " " + fatherSerial + " " + motherSerial + " " + selectSpecies + " " + selectSubspecies + " " + gender);
                    openFile(serialNumber, hatchDate, cageNumber, fatherSerial, motherSerial, selectSpecies, selectSubspecies, gender);
                }
              
            }

        }

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

        private void subsprciesText_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var select = sender as ComboBox;
            selectSubspecies = select.SelectedItem as string;
        }

        private void genderText_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var select = sender as ComboBox;
            gender = select.SelectedItem as string;
        }

        private void openFile(string serialNumber, string hatchDate, string cageNumber, string fatherSerial, string motherSerial, string selectSpecies, string selectSubspecies, string gender)
        {
            try
            {
                WorkBook workBook = WorkBook.Load(fileNameXls);
                WorkSheet workSheet = workBook.GetWorkSheet("Birds");


                //int lastRow = workSheet.Cells.Find("*", System.Reflection.Missing.Value,
                //                   System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                //                   XlSearchOrder.xlByRows, XlSearchDirection.xlPrevious,
                //                   false, System.Reflection.Missing.Value, System.Reflection.Missing.Value).Row;
                //lastRow++;

                // Find the next available row in the worksheet
                string nextRow = nR.ToString();
                //string nextRow = lastRow.ToString();


                // Set the cell values for the bird information
                workSheet['A'+nextRow].Value = serialNumber;
                workSheet['B'+nextRow].Value = selectSpecies;
                workSheet['C'+nextRow].Value = selectSubspecies;
                workSheet['D'+nextRow].Value = hatchDate;
                workSheet['E'+nextRow].Value = gender;
                workSheet['F'+nextRow].Value = cageNumber;
                workSheet['G'+nextRow].Value = fatherSerial;
                workSheet['H'+nextRow].Value = motherSerial;
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["LastRowIndex"].Value = nR.ToString();
                config.Save(ConfigurationSaveMode.Modified);

                
                nR++;

                // Save the workbook
                workBook.Save();
            }
            catch (Exception)
            {
                MessageBox.Show("Error - unable to save to Excel file");
            }
        }



    }
}
