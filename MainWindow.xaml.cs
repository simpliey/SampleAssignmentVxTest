using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1_Assignment_Valorx
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public class Item
    {
        public string Name { get; set; }
    }
    public partial class MainWindow : Window
    {
        private List<Item> _itemlist;
        
        public MainWindow()
        {
            _itemlist = new List<Item> { }; //Initialize list to handle null exception.
            InitializeComponent();
            InitializeFilterList(); //Initialize list with predefined data.
        }

        private void InitializeFilterList()
        {
            //binding
            _itemlist = new List<Item>
            {
                new Item  { Name = "Siddharth Parmar" },
                new Item  { Name = "Bhargav Parmar" },
                new Item  { Name = "Smith Johns" },
                new Item  { Name = "Sandy Brokways" },
                new Item  { Name = "Kamila Patil" },
                
            };
            ItemListBox.ItemsSource = _itemlist;
        }

        //text box event to handle search for list fix.
        private void FiltertextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string filtertext = FiltertextBox.Text.ToLower();
            //filtertext = "Search";
            var FilteredItems = _itemlist.Where(item => item.Name.ToLower().Contains(filtertext)).ToList(); //Binding data list on text box event change to list box

            ItemListBox.ItemsSource = FilteredItems;
        }
    }
}
