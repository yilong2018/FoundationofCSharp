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

namespace M07L08HomeworkWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BindingList<string> userNameList = new BindingList<string>();
        public MainWindow()
        {
            InitializeComponent();

            userNameListBox.ItemsSource = userNameList;
        }

        private void sayHello_Click(object sender, RoutedEventArgs e)
        {
            string fn = firstNameText.Text;
            string ln = lastNameText.Text;
            if ( string.IsNullOrWhiteSpace(fn) )
            {
                MessageBox.Show("Please enter your first name.", "Null Error", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else if ( string.IsNullOrWhiteSpace(ln) )
            {
                MessageBox.Show("Please enter your last name.", "Null Error", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                string message = $"Hello { fn } { ln }";
                firstNameText.Text = "";
                lastNameText.Text = "";
                firstNameText.Focus();

                userNameList.Add($"{ fn } { ln }");

                MessageBox.Show(message);
            }

        }

  
    }
}
