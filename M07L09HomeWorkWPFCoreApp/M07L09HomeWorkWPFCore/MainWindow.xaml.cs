using HomeWorkLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace M07L09HomeWorkWPFCore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, ISaveAddress
    {
        BindingList<AddressModel> addresses = new BindingList<AddressModel>();
        public MainWindow()
        {
            InitializeComponent();

            listAddressBox.ItemsSource = addresses;
        }

        public void SaveToAddressListBox(AddressModel address)
        {
            addresses.Add(address);
        }

        private void addPersonButton_Click(object sender, RoutedEventArgs e)
        {
            string fn = firstNameText.Text;
            string ln = lastNameText.Text;
            if ( string.IsNullOrWhiteSpace(fn) )
            {
                MessageBox.Show("Please input first name", "Null error", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else if ( string.IsNullOrWhiteSpace(ln) )
            {
                MessageBox.Show("Please input last name", "Null error", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                PersonModel person = new PersonModel();
                person.FirstName = fn;
                person.LastName = ln;
                person.PersonsAddress = addresses.ToList();
                AddressWPF addressWPF = new AddressWPF(this);
                firstNameText.Text = "";
                lastNameText.Text = "";
                addressWPF.Show();
            }
        }
    }
}
