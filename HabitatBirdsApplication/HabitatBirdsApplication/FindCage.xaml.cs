﻿using System;
using System.Collections.Generic;
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
using System.IO;
using IronXL;
using System.Text.RegularExpressions;
using System.Collections;
using System.Globalization;
using System.Collections.ObjectModel;

namespace HabitatBirdsApplication
{
    /// <summary>
    /// Interaction logic for FindCage.xaml
    /// </summary>
    public partial class FindCage : Window
    {
        List<Cage> cages;
        ObservableCollection<Cage> cages_after_sort;
        Cage yourCage { set; get; }
        string choose;
        //string path = @"C:\Users\Matan\Desktop\Birds.xlsx";
        string path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "Birds.xlsx");
        public string [] option { get; set; }
        public FindCage()
        {
            InitializeComponent();
            cages = new List<Cage>();
            cages_after_sort = new ObservableCollection<Cage>();
            option = new string[] { "By material", "serial number" };
            DataContext = this;

            ListViewCage.Visibility = Visibility.Hidden;
            
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var select = sender as ComboBox;
            choose = select.SelectedItem as string;
            if (choose== "By material")
            {
                Trace.WriteLine(choose);
                matirel_Options.Visibility = Visibility.Visible;
            }
        }
        public string serial_number_cage()
        {
            return yourCage.serialNumber.ToString();
        }
        private void btnInfoCage_Click(object sender, RoutedEventArgs e){
            Button btnInfoCage = (Button)sender;
            yourCage = (Cage)btnInfoCage.DataContext;
            CageInfo card_Cage = new CageInfo(this,yourCage);
            this.Visibility = Visibility.Hidden;
            card_Cage.Show();
        }
        private void btnSearchCage_Click(object sender, RoutedEventArgs e)
        {
            
            WorkBook myWorkBook = WorkBook.Load(path);
            WorkSheet sheet = myWorkBook.GetWorkSheet("Cage");
            cages_after_sort.Clear();
            cages.Clear();
            //for sireal number
            if (OptionTypeToFind.Text == "serial number")
            {
                if (checkSerial(FindCageText.Text))
                {
                    int i = 2;
                    string lastindex = sheet.RowCount.ToString();
                    string a = "A" + lastindex;
                    foreach (var cell in sheet["A2:"+a])
                    {
                        
                        if (cell.Text == FindCageText.Text)
                        {
                            try
                            {
                                Cage cage = new Cage(FindCageText.Text, sheet["B" + i].ToString(), float.Parse(sheet["C" + i].ToString(), CultureInfo.InvariantCulture.NumberFormat)
                                                                , float.Parse(sheet["D" + i].ToString(), CultureInfo.InvariantCulture.NumberFormat), float.Parse(sheet["E" + i].ToString(), CultureInfo.InvariantCulture.NumberFormat));
                                cages.Add(cage);
                                i++;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }

                        }
                        else {
                            i++;
                        }
                        
                    }
                    if (!(cages.Count > 0))
                    {
                        MessageBox.Show("We didnet found Your Serial number cage , try again");
                    }
                }
                else {
                    MessageBox.Show("Some of your details are wrong please try again");
                }
                cages = cages.OrderBy(cage => cage.serialNumber).ToList();
                foreach(var c in cages)
                {
                    cages_after_sort.Add(c);
                }
                if (cages.Count == 1)
                {
                    yourCage = cages[0];
                    CageInfo card_Cage = new CageInfo(this, yourCage);
                    this.Visibility = Visibility.Hidden;
                    card_Cage.Show();
                }
                else
                {
                    ListViewCage.Visibility = Visibility.Visible;
                    ListViewCage.ItemsSource = cages_after_sort;
                }
            }
            //for metiral
            if(OptionTypeToFind.Text== "By material")
            {
                
                if (checkLetters(FindCageText.Text))
                {
                    if(FindCageText.Text == "Iron" || FindCageText.Text == "Wood" || FindCageText.Text == "Plastic")
                    {
                        int i = 2;
                        Trace.WriteLine("test metiral");
                        string lastindex = sheet.RowCount.ToString();
                        string a = "B" + lastindex;
                        foreach (var cell in sheet["B2:" + a])
                        {
                            if (cell.Text == FindCageText.Text)
                            {
                                try
                                {
                                    Cage cage = new Cage(sheet["A" + i].ToString(), sheet["B" + i].ToString(), float.Parse(sheet["C" + i].ToString(), CultureInfo.InvariantCulture.NumberFormat)
                                                                    , float.Parse(sheet["D" + i].ToString(), CultureInfo.InvariantCulture.NumberFormat), float.Parse(sheet["E" + i].ToString(), CultureInfo.InvariantCulture.NumberFormat));
                                    cages.Add(cage);
                                    i++;
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                            }
                            else
                            {
                                i++;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("We didnet found Your material, try again");
                    }
                     
                }
                else {
                    MessageBox.Show(" Please Enter numbers and Letter to serial number,try again");
                }
                cages = cages.OrderBy(cage => cage.serialNumber).ToList();
                foreach (var c in cages)
                {
                    cages_after_sort.Add(c);
                }
                if(cages.Count == 1)
                {
                    yourCage = cages[0];
                    CageInfo card_Cage = new CageInfo(this, yourCage);
                    this.Visibility = Visibility.Hidden;
                    card_Cage.Show();
                }
                else
                {
                    ListViewCage.Visibility = Visibility.Visible;
                    ListViewCage.ItemsSource = cages_after_sort;
                }
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
        public bool checkLetters(string input)
        {
            // Check if the input string contains at least one digit
            return Regex.IsMatch(input, @"^[a-zA-Z]+$");
        }

        private void backButton(object sender, RoutedEventArgs e)
        {
            MainPage mainPage = new MainPage();
            this.Visibility = Visibility.Hidden;
            mainPage.Show();
        }
    }
}