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


namespace HabitatBirdsApplication
{
    /// <summary>
    /// Interaction logic for ShowBird.xaml
    /// </summary>
    public partial class ShowBird : Window
    {
        private Bird bird;
        string fileNameXls = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "Birds.xlsx");
        //string fileNameXls = @"C:\Users\Matan\Desktop\Birds.xlsx";
        public ShowBird(Bird bird)
        {
            this.bird = bird;
            InitializeComponent();
            MessageBox.Show("Welcome to my personal profile");
            FillTextBoxes();
        }
        private void FillTextBoxes()
        {
            if (bird != null)
            {
                SerialNumberTextBox.Text = bird.SerialNumber;
                SpeciesTextBox.Text = bird.Species;
                SubspeciesTextBox.Text = bird.Subspecies;
                HatchDateTextBox.Text = bird.HatchDate;
                GenderTextBox.Text = bird.Gender;
                CageNumberTextBox.Text = bird.CageNumber;
                FatherSerialTextBox.Text = bird.FatherSerial;
                MotherSerialTextBox.Text = bird.MotherSerial;
            }
        }

        private void AddChicksButton_Click(object sender, RoutedEventArgs e)
        {
            string selectSecondParent;
            string[] parents = detailsSerialCages();
            if (parents.Length<=0)
            {
                MessageBox.Show("There are no birds suitable for mating (of a different species or of the same breed) in the cage, check that you have not confused who the chick belongs to.");
                return;
            }
            ComboBoxParents comboBoxParents = new ComboBoxParents(parents);

            if(comboBoxParents.ShowDialog() == true)
            {
                selectSecondParent = comboBoxParents.selectParents;
                if (selectSecondParent != null)
                {
                    // Load the Excel workbook
                    WorkBook workBook = WorkBook.Load(fileNameXls);
                    WorkSheet workSheet = workBook.GetWorkSheet("Birds");
                    int index = searchIndexData(bird.SerialNumber);
                    int indexSEcondParent = searchIndexData(selectSecondParent);
                    workSheet["J" + indexSEcondParent].Value = "TRUE";
                    workSheet["J" + index].Value = "TRUE";
                    workBook.SaveAs(fileNameXls);
                    NewBird newChicken = new NewBird(bird, selectSecondParent);
                    newChicken.Show();
                    this.Close();
                }
            }
            comboBoxParents.Close();

        }

        private void btneditBird(object sender, RoutedEventArgs e)
        {
            // Load the Excel workbook
            WorkBook workBook = WorkBook.Load(fileNameXls);
            WorkSheet workSheet = workBook.GetWorkSheet("Birds");
            int index = searchIndexData(bird.SerialNumber);
            if (workSheet["J"+index].Value.ToString()=="TRUE")
            {
                MessageBox.Show("It is not possible to change the details of the bird, it already has chicks in the cage");
                return;
            }
            else
            {
                workSheet.Rows[index].RemoveRow();
                // Save the changes to the Excel file
                workBook.SaveAs(fileNameXls);
                NewBird editBird = new NewBird(bird);
                this.Visibility = Visibility.Hidden;
                editBird.Show();
            }
            
        }
        private int searchIndexData(string serialNumber)
        {
            try
            {
                // Load the Excel workbook
                WorkBook workBook = WorkBook.Load(fileNameXls);
                WorkSheet workSheet = workBook.GetWorkSheet("Birds");
                //string cell = bird.SerialNumber;
                int index = 2;
                // Iterate over the rows in the worksheet and check for matching serial numbers
                foreach (var cell1 in workSheet["A2:" + "A" + workSheet.RowCount.ToString()])
                {
                    if (serialNumber == cell1.Value.ToString())
                    {
                        return index;
                    }
                    index++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error - unable to search in Excel file\n" + ex.Message);
            }
            return -1;
        }
        private string [] detailsSerialCages()
        {
            // Create a pop-up form


            // Create a combo box
            
            List<string> itemList = new List<string>();
            try
            {
                // Load the Excel workbook
                WorkBook workBook = WorkBook.Load(fileNameXls);
                WorkSheet workSheet = workBook.GetWorkSheet("Birds");

                // Iterate over the rows in the worksheet and check for matching serial numbers
                for (int i = 2; i < workSheet.RowCount+1; i++)
                {
                    if (workSheet["A" + i].Value.ToString() != bird.SerialNumber && workSheet["E" + i].Value.ToString() != bird.Gender && workSheet["F" + i].Value.ToString() == bird.CageNumber)
                    {
                        itemList.Add(workSheet["A" + i].Value.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error - unable to search in Excel file\n" + ex.Message);
            }
            string[] serials = itemList.ToArray();
            return serials;
        }

        private void btnBack(object sender, RoutedEventArgs e)
        {
            MainPage mainPage = new MainPage();
            this.Visibility = Visibility.Hidden;
            mainPage.Show();
        }
    }
}


