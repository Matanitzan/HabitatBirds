using HabitatBirdsApplication;
using System;
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

namespace HabitatBirdsApplication
{
    /// <summary>
    /// Interaction logic for ShowBird.xaml
    /// </summary>
    public partial class ShowBird : Window
    {
        private Bird bird;

        public ShowBird(Bird bird)
        {
            this.bird = bird;
            InitializeComponent();
            MessageBox.Show("opennnnn");
            //this.bird = bird;
            FillTextBoxes();
        }
        //public ShowBird()
        //{
        //    InitializeComponent();
        //}
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
            //NewBird newChicken = new NewBird(bird);
            //newChicken.Show();
            //this.Close();
        }
    }
}


