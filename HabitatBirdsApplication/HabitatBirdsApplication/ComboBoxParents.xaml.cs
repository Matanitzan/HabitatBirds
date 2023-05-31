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
    /// Interaction logic for ComboBoxParents.xaml
    /// </summary>
    public partial class ComboBoxParents : Window
    {
        public string[] parents { get; set; }
        public string selectParents { get; set; }
        public ComboBoxParents(string[] parents)
        {
            this.parents = parents;
            DataContext = this;
            InitializeComponent();
        }

        //private void parentsOption_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    var select = sender as ComboBox;
        //    selectParents = select.SelectedItem as string;

        //}
        //public string getParents()
        //{
        //    return selectParents;
        //}

        private void SubmitCombobox(object sender, RoutedEventArgs e)
        {
            selectParents = parentsOption.SelectedItem.ToString();
            this.DialogResult = true;
            this.Close();
        }
    }
}
