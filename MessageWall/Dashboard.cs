using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageWall
{
    public partial class Dashboard : Form
    {
        private BindingList<string> message = new BindingList<string>();
        public Dashboard()
        {
            InitializeComponent();
            WireUpList();
        }

        private void WireUpList()
        {
            MessageList.DataSource = message;
        }

        private void AddMessage_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MessageTextBox.Text))
            {
                MessageBox.Show("Message Cannot Be Empty", "Blank Message Entered", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                message.Add(MessageTextBox.Text);
                MessageTextBox.Text = "";
            }

            MessageTextBox.Focus();
        }


    }
}
