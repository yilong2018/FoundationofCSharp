using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M07L06MessageWall
{
    public partial class Dashboard : Form
    {
        BindingList<string> messages = new BindingList<string>();
        public Dashboard()
        {
            InitializeComponent();

            WireUpLists();
        }

        private void WireUpLists()
        {
            messageListBox.DataSource = messages;
            messageListBox.DisplayMember = nameof(Dashboard.Text);
        }

        private void addMessage_Click(object sender, EventArgs e)
        {
            if ( string.IsNullOrWhiteSpace(messageText.Text) )
            {
                MessageBox.Show("Please enter a message before trying to add it to the list.",
                    "Blnank Message Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                messages.Add(messageText.Text);
                messageText.Text = "";
            }
            messageText.Focus();
        }

        //Homework: Build a WinForms application that has a simple data-entry screen with First
        //and Last name fields. Have a button say "Hi {FN} {LN}" when pressed.
    }
}
