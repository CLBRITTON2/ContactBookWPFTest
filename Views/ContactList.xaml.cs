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

namespace ContactBook.Views
{
    /// <summary>
    /// Interaction logic for ContactList.xaml
    /// </summary>
    public partial class ContactList : Window
    {
        public static List<Person> PeopleList = new();

        public Dictionary<string, Person> PeopleDictionary = PeopleList.ToDictionary(x => x.FirstName.ToLower());
        public ContactList()
        {
            InitializeComponent();
            AddressBookGrid.ItemsSource = PeopleList;
        }

        private void DeleteContact(object sender, RoutedEventArgs e)
        {
            var firstName = PeopleList.ElementAt(0).FirstName.ToString();
            var result = MessageBox.Show($"Are you sure you want to delete {firstName}?", "Confirmation", MessageBoxButton.YesNo);

            if(MessageBoxResult.Yes == result)
            {
                var selectedRow = AddressBookGrid.SelectedItem as Person;
                PeopleList.Remove(selectedRow);
                RefreshContactListView();
            }
        }
        private void RefreshContactListView()
        {
            AddressBookGrid.ItemsSource = null;
            AddressBookGrid.ItemsSource = PeopleList;
        }
        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            List<Person> filteredPeopleList = new List<Person>();
            filteredPeopleList.Clear();

            if (SearchBox.Text.Equals(""))
            {
                filteredPeopleList.AddRange(PeopleList);
            }
            else
            {
                foreach (Person person in PeopleList)
                {
                    if (person.FirstName.Contains(SearchBox.Text))
                    {
                        filteredPeopleList.Add(person);
                    }
                }
            }
            AddressBookGrid.ItemsSource = filteredPeopleList.ToList();
        }
    }
}
