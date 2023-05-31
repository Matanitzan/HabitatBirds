using System.Windows;


namespace HabitatBirdsApplication
{
    /// <summary>
    /// Interaction logic for ComboBoxParents.xaml
    /// </summary>
    public partial class ComboBoxParents : Window
    {
        /// <summary>
        /// Gets or sets the selected parent name.
        /// </summary>
        public string[] parents { get; set; }
        public string selectParents { get; set; }

        /// <summary>
        /// Gets or sets the selected parent name.
        /// </summary>
        public ComboBoxParents(string[] parents)
        {
            this.parents = parents;
            DataContext = this;
            InitializeComponent();
        }

        /// <summary>
        /// Handles the event when the "Submit" button is clicked.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        private void SubmitCombobox(object sender, RoutedEventArgs e)
        {
            selectParents = parentsOption.SelectedItem.ToString();
            this.DialogResult = true;
            this.Close();
        }
    }
}
