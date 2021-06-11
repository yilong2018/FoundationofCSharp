using HomeWorkLibrary;
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

namespace M07L09HomeWorkWPFCore
{
    /// <summary>
    /// Interaction logic for AddressWPF.xaml
    /// </summary>
    public partial class AddressWPF : Window
    {
        private ISaveAddress _parent;

        public AddressWPF(ISaveAddress parent)
        {
            InitializeComponent();

            _parent = parent;
        }

        private void addAddressButton_Click(object sender, RoutedEventArgs e)
        {
            string street = streetText.Text;
            string city = cityText.Text;

            AddressModel address = new AddressModel { Street = street, City = city };

            _parent.SaveToAddressListBox(address);

            this.Close();
        }
    }
}
