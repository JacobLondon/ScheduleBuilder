using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleBuilder
{
    public partial class Form1 : Form
    {
        public List<Backend.User> Users;

        private Backend.User CurrentUser;

        public Form1()
        {
            InitializeComponent();

            InitializeVariables();

            InitializeEvents();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Users.Count() <= 0)
                MessageBox.Show(
                    "There are no users in the program. Please add one before continuing.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
        }

        private void InitializeVariables()
        {
            Users = new List<Backend.User>();
            CurrentUser = new Backend.User();
        }

        private void InitializeEvents()
        {
            AddUserTextBox.KeyDown += AddUserTextBox_KeyDown;

        }
        
        public void UpdateInterface()
        {
            // update the user dgv
            UpdateUserDGV();

            // update the user combobox
            UpdateUserComboBox();


        }

        #region Main Window

        private void NewEventButton_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm(this);
            eventForm.Show();
        }

        public void CreateEvent(Backend.Event tempEvent)
        {
            CurrentUser.Events.Add(tempEvent);
            CurrentUser.Events = CurrentUser.Events.OrderBy(d => d.StartDate).ToList();

        }

        // add a new user by pressing enter
        private void AddUserTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                AddUserButton_Click(this, e);

                // prevent error sound effect by telling the program the event has been dealt with
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        // add a user to the list if they are not already in it
        private void AddUserButton_Click(object sender, EventArgs e)
        {
            // check if the user is in the list
            if(Users.Where(u => u.Username == AddUserTextBox.Text).Count() == 0)
            {
                Users.Add(new Backend.User(AddUserTextBox.Text));
                AddUserTextBox.Text = string.Empty;
                UpdateInterface();
            }
        }

        // remove user from the user list and update dgv
        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            // exit if there are no items
            if (UserDGV.SelectedCells.Count <= 0)
                return;

            // find the index of the user with the specified username
            string username = UserDGV.SelectedCells[0].Value.ToString();
            int index = Users.IndexOf(Users.Where(u => u.Username == username).FirstOrDefault());

            // if the item was found in the list
            if (index != -1)
            {
                Users.RemoveAt(index);
                UpdateInterface();
            }
        }

        // fill the dgv with users to view
        private void UpdateUserDGV()
        {
            UserDGV.Rows.Clear();

            foreach(Backend.User user in Users)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(UserDGV);

                row.Cells[0].Value = user.Username;

                UserDGV.Rows.Add(row);
            }

            UserDGV.Refresh();
        }

        private void UpdateUserComboBox()
        {
            UserComboBox.Items.Clear();

            foreach(Backend.User user in Users)
            {
                UserComboBox.Items.Add(user);
            }

            // if there are no items selected, select the one just added
            if(UserComboBox.SelectedIndex == -1
                && Users.Count() > 0)
            {
                UserComboBox.SelectedIndex = 0;
            }

            UserComboBox.Refresh();
        }

        // update the currently selected user
        private void UserComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MyList.IndexOf(MyList.Where(p => p.Name == "ComTruise").FirstOrDefault());
            string currentUsername = UserComboBox.Text;
            var temp = Users.Where(u => u.Username == currentUsername).FirstOrDefault();
            if (temp == null)
            {
                Console.WriteLine("User not found when changing combo selection");
                return;
            }
            CurrentUser = temp;
        }

        #endregion

        private void MonthPrevButton_Click(object sender, EventArgs e)
        {

        }

    }
}
