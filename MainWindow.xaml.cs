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
using System.Windows.Navigation;
using System.Windows.Shapes;
using ContactBook.Views;

namespace ContactBook
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();           
        }

        private void DisplayContactList(object sender, RoutedEventArgs e)
        {
            ContactList contactList = new ContactList();
            contactList.Show();
        }

        public void AddNewPerson(object sender, RoutedEventArgs e)
        {
            Person newPerson = new Person();
            {
                newPerson.FirstName = firstNameBox.Text;
                newPerson.LastName = lastNameBox.Text;
                newPerson.MobilePhoneNumber = mobilePhoneBox.Text;
                newPerson.WorkPhoneNumber = workPhoneBox.Text;
                newPerson.Address = addressBox.Text;
            }
            ContactList.PeopleList.Add(newPerson);
            ClearPersonalInfoFields();
        }

        private void ClearPersonalInfoFields()
        {
            firstNameBox.Text = "";
            lastNameBox.Text = "";
            mobilePhoneBox.Text = "";
            workPhoneBox.Text = "";
            addressBox.Text = "";
        }
    }
}
