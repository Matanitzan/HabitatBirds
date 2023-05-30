using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
using IronXL;
namespace HabitatBirdsApplication
{
    /// <summary>
    /// Interaction logic for CageInfo.xaml
    /// </summary>
    public partial class CageInfo : System.Windows.Window
    {
        FindCage selected_cage;
        string fileNameXls = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "CageFile.xlsx");

        public CageInfo(FindCage Fcage)
        {
            InitializeComponent();
            this.selected_cage = Fcage;

            ShowInfo();
        }
        public void ShowInfo()
        {
            WorkBook myWorkBook = WorkBook.Load(fileNameXls);
            WorkSheet sheet = myWorkBook.GetWorkSheet("Sheet1");

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
                        break;
                    }
                    i++;
                }
            }
            if(selected_cage.OptionTypeToFind.Text == "By Metiral")
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
                        break;
                    }
                    i++;
                }
            }
            
            
        }

    }
}
