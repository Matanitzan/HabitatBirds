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
    /// Interaction logic for nainFram.xaml
    /// </summary>
    public partial class MainPage : Window
    {
        public MainPage()
        {
            InitializeComponent();
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{

        //}

        //private void Button_Click_1(object sender, RoutedEventArgs e)
        //{

        //}

        private void addNewBird(object sender, RoutedEventArgs e)
        {
            NewBird newBird = new NewBird();
            this.Visibility = Visibility.Hidden;
            newBird.Show();
        }

        private void birdSearch(object sender, RoutedEventArgs e)
        {
            BirdSearch birdSearch = new BirdSearch();
            this.Visibility = Visibility.Hidden;
            birdSearch.Show();


        }

        //private void Button_Click_2(object sender, RoutedEventArgs e)
        //{

        //}

        private void cageSearch(object sender, RoutedEventArgs e)
        {
            FindCage findCage = new FindCage();
            this.Visibility = Visibility.Hidden;
            findCage.Show();
        }

        private void addNewCge(object sender, RoutedEventArgs e)
        {
            NewCage newCage = new NewCage();
            this.Visibility = Visibility.Hidden;
            newCage.Show();
        }



        private void logOutClick(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Visibility = Visibility.Hidden;
            mainWindow.Show();
        }
    }
}
