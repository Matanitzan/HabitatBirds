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
namespace HabitatBirdsApplication
{
    /// <summary>
    /// Interaction logic for NewCage.xaml
    /// </summary>
    public partial class NewCage : System.Windows.Window
    {
        List<Cage> cages ;
        string path = @"C:\Users\Jonatan\Desktop\CageFile.xlsx";
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

            Cage cage = new Cage(SerialNumberText.Text, MetiralOptions.Text, float.Parse(LenghtCageText.Text, CultureInfo.InvariantCulture.NumberFormat),
                float.Parse(WidthCageText.Text, CultureInfo.InvariantCulture.NumberFormat), float.Parse(HeightCageText.Text, CultureInfo.InvariantCulture.NumberFormat));
            cages.Add(cage);


            WorkBook myWorkBook = WorkBook.Load(path);

            WorkSheet sheet = myWorkBook.GetWorkSheet("Sheet1");

            string index = (cages.Count()+1).ToString();
            sheet['A'+index].Value = cage.getSerial();
            sheet['B'+index].Value = cage.getMaterial();
            sheet['C'+index].Value = cage.getLenght();
            sheet['D'+index].Value = cage.getWidth();
            sheet['E'+index].Value = cage.getHeigth();

            
            myWorkBook.SaveAs(path);

            //Excel.Application app = new Excel.Application();
            //Workbook MyWorkBook = app.Workbooks.Add(System.Reflection.Missing.Value);
            //Worksheet MySheets = (Worksheet)MyWorkBook.Worksheets.get_Item(1);


            //MySheets.Cells[1, 1] = "Serial";
            //MySheets.Cells[1, 1].Font.Bold = true;

            //MySheets.Cells[1, 2] = "Metiral";
            //MySheets.Cells[1, 2].Font.Bold = true;

            //MySheets.Cells[1, 3] = "Length";
            //MySheets.Cells[1, 3].Font.Bold = true;

            //MySheets.Cells[1, 4] = "Witdh";
            //MySheets.Cells[1, 4].Font.Bold = true;

            //MySheets.Cells[1, 5] = "Height";
            //MySheets.Cells[1, 5].Font.Bold = true;

            //int i = 2;
            //foreach(Cage cage1 in cages)
            //{
            //    MySheets.Cells[i, 1] = cage1.getSerial();
            //    MySheets.Cells[i, 2] = cage1.getMaterial();
            //    MySheets.Cells[i, 3] = cage1.getLenght();
            //    MySheets.Cells[i, 4] = cage1.getWidth();
            //    MySheets.Cells[i, 5] = cage1.getHeigth();
            //    i++;
            //}



            //MyWorkBook.SaveAs2(path, System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value, XlSaveAsAccessMode.xlExclusive,
            //    System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value);
            //MessageBoxResult result = MessageBox.Show("do you want to open the file?", "opennig file", MessageBoxButton.YesNo, MessageBoxImage.Information);

            //if (result.Equals(MessageBoxResult.Yes))
            //{
            //    openFile();
            //}
            //else
            //{
            //    MessageBox.Show("your file located in file folder", "located file", MessageBoxButton.OK, MessageBoxImage.Information);

            //}
            //MyWorkBook.Close(System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value);
            //app.Quit();

            //GC.WaitForPendingFinalizers();
            //GC.Collect();
            //GC.WaitForPendingFinalizers();
            //GC.Collect();

            //Marshal.ReleaseComObject(MySheets);
            //Marshal.ReleaseComObject(MyWorkBook);
            //Marshal.ReleaseComObject(app);

            //this.Close();
            Trace.WriteLine("serial:" + cage.getSerial());

        }
    }
}
