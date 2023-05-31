using System.Windows;


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

        /// <summary>
        /// Handles the event when the "Add New Bird" button is clicked.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        private void addNewBird(object sender, RoutedEventArgs e)
        {
            NewBird newBird = new NewBird();
            this.Visibility = Visibility.Hidden;
            newBird.Show();
        }

        /// <summary>
        /// Handles the event when the "Bird Search" button is clicked.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        private void birdSearch(object sender, RoutedEventArgs e)
        {
            BirdSearch birdSearch = new BirdSearch();
            this.Visibility = Visibility.Hidden;
            birdSearch.Show();
        }

        /// <summary>
        /// Handles the event when the "Cage Search" button is clicked.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        private void cageSearch(object sender, RoutedEventArgs e)
        {
            FindCage findCage = new FindCage();
            this.Visibility = Visibility.Hidden;
            findCage.Show();
        }

        /// <summary>
        /// Handles the event when the "Add New Cage" button is clicked.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        private void addNewCge(object sender, RoutedEventArgs e)
        {
            NewCage newCage = new NewCage();
            this.Visibility = Visibility.Hidden;
            newCage.Show();
        }

        /// <summary>
        /// Handles the event when the "Log Out" button is clicked.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        private void logOutClick(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Visibility = Visibility.Hidden;
            mainWindow.Show();
        }
    }
}
