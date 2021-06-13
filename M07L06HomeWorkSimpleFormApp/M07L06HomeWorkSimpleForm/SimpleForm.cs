using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M07L06HomeWorkSimpleForm
{
    public partial class SimpleForm : Form
    {
        BindingList<string> fullNameList = new BindingList<string>();
        public SimpleForm()
        {
            InitializeComponent();
            WrapUp();
        }

        private void WrapUp()
        {
            userNameListBox.DataSource = fullNameList;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void helloButton_Click(object sender, EventArgs e)
        {

            if ( CheckTextBox(firstNameText) == true )
            {
                if (CheckTextBox(lastNameText) == true)
                {
                    string fullName = $"{ firstNameText.Text } { lastNameText.Text }";
                    //fullNameList.Add(fullName);

                    MessageBox.Show($"Hello {fullName}", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    firstNameText.Text = "";
                    lastNameText.Text = "";

                    firstNameText.Focus();
                }
            }
        }

        private static bool CheckTextBox(TextBox textBox)
        {
            bool output = true;
            if (string.IsNullOrWhiteSpace(textBox.Text) == true )
            {
                output = false;
                MessageBox.Show($"Please Enter {textBox.Name} before Press Button.");
                textBox.Focus();
            }
            return output;
            
        }
        
    }
}
