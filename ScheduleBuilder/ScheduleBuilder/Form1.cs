using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace ScheduleBuilder
{
    public partial class Form1 : Form
    {
        public List<Backend.User> Users;

        private Backend.User CurrentUser;

        // when the program has finished turning on, this becomes false
        // prevent component updates on index changes when the program loads
        bool loading = true;

        public Form1()
        {
            InitializeComponent();

            InitializeVariables();

            InitializeEvents();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // check if the save location exists
            if (!Directory.Exists(Backend.Constants.SAVE_DIRECTORY))
            {
                Directory.CreateDirectory(Backend.Constants.SAVE_DIRECTORY);
            }

            // deserialize all files to users
            foreach (var file in Directory.EnumerateFiles(Backend.Constants.SAVE_DIRECTORY, "*.json"))
            {
                Console.WriteLine(file);
                var user = new JavaScriptSerializer().Deserialize<Backend.User>(File.ReadAllText(file));

                // correct UTC/GMT automatic conversion to local time
                foreach(Backend.Event current in user.Events)
                {
                    current.StartDate = current.StartDate.ToLocalTime();
                    current.FinishDate = current.FinishDate.ToLocalTime();
                }

                Users.Add(user);
            }

            UpdateUserComboBox();
            UpdateInterface();

            loading = false;
        }

        private void InitializeVariables()
        {
            Users = new List<Backend.User>();
            CurrentUser = new Backend.User();
        }

        private void InitializeEvents()
        {
            AddUserTextBox.KeyDown += AddUserTextBox_KeyDown;

            if(loading == false)
                UserDGV.SelectionChanged += UserComboBox_SelectedChanged;

            EventDGV.DoubleClick += EventDGV_DoubleClick;
            DayDGV.DoubleClick += DayDGV_DoubleClick;
            WeekDGV.DoubleClick += WeekDGV_DoubleClick;
            MonthDGV.DoubleClick += MonthDGV_DoubleClick;

            MonthDGV.RowsAdded += new DataGridViewRowsAddedEventHandler(MonthDGV_RowsAdded);
        }
        
        public void UpdateInterface()
        {
            // update the user dgv
            UpdateUserDGV();

            // update all of the tabs
            UpdateEvents();
            UpdateDay();
            UpdateWeek();
            UpdateMonth();

            JSONSerialize();
        }

        public void JSONSerialize()
        {
            // serialize each user into a different file
            foreach(Backend.User u in Users)
            {
                // make a string in json format of the current user
                var json = new JavaScriptSerializer().Serialize(u);

                // write or overwrite data in the file
                File.WriteAllText(Backend.Constants.SAVE_DIRECTORY + "\\" + u.Username + ".json", json);
            }
        }

        #region Main Window

        private void NewEventButton_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm(this);
            eventForm.Show();
        }

        public void CreateEvent(Backend.Event tempEvent)
        {
            // give the current user the built event from the event form
            tempEvent.StartTime = tempEvent.StartDate;
            CurrentUser.Events.Add(tempEvent);
            CurrentUser.Events = CurrentUser.Events.OrderBy(d => d.StartDate).ToList();

            // update the UI with this event item
            UpdateInterface();
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
                
                UpdateUserComboBox(); // update the user combobox
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
                // remove the save file
                File.Delete(Backend.Constants.SAVE_DIRECTORY + "\\" + Users[index].Username + ".json");

                Users.RemoveAt(index);
                UpdateUserComboBox(); // update the user combobox to remove the user
                UpdateInterface();
            }
        }

        // pass in an event, and try to remove it from the currently selected user
        public void DeleteEvent(Backend.Event UserEvent)
        {
            int index = CurrentUser.Events.IndexOf(UserEvent);

            // exit if it was not found
            if (index == -1)
                return;

            // remove the event and update interface
            CurrentUser.Events.RemoveAt(index);
            UpdateInterface();
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
        private void UserComboBox_SelectedChanged(object sender, EventArgs e)
        {
            string currentUsername = UserComboBox.Text;
            var temp = Users.Where(u => u.Username == currentUsername).FirstOrDefault();
            if (temp == null)
            {
                Console.WriteLine("User not found when changing combo selection");
                return;
            }
            CurrentUser = temp;
            UpdateInterface();
        }

        // the day selection was changed
        private void DayDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            UpdateInterface();
        }

        private void UserDGV_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv != null && dgv.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgv.SelectedRows[0];
                if (row != null)
                {
                    int a = UserDGV.SelectedRows[0].Cells[0].RowIndex;
                    UserComboBox.SelectedIndex = a;
                }
            }
        }

        #endregion

        #region Event Tab

        private void UpdateEvents()
        {
            EventLabel.Text = "Your tasks:";

            EventDGV.Rows.Clear();
            foreach(Backend.Event e in CurrentUser.Events)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(EventDGV);

                // color at same index of corresponding priority level
                row.DefaultCellStyle.BackColor = Backend.Constants.PriorityColors[Backend.Constants.PriorityList.IndexOf(e.Priority)];

                row.Cells[0].Value = e.StartDate.ToString();
                row.Cells[1].Value = e.Subject;

                EventDGV.Rows.Add(row);
            }
            EventDGV.Refresh();
        }

        private void EventDGV_DoubleClick(object sender, EventArgs e)
        {
            // get the subject string
            string subject = EventDGV.SelectedRows[0].Cells[1].Value.ToString();

            // search for the currentuser's event with that subject
            var match = CurrentUser.Events.Where(ev => ev.Subject == subject).FirstOrDefault();

            // there was no match found
            if (match == null)
                return;

            ViewerForm v = new ViewerForm(this, match);
            v.Show();

        }

        #endregion

        #region Day Tab

        private void UpdateDay()
        {
            DayLabel.Text = Time.Value.DayOfWeek.ToString() + " " + Time.Value.Date.ToString("MM/dd/yyyy");

            DayDGV.Rows.Clear();

            // iterate through the hours of the day
            DateTime startHour = new DateTime(Time.Value.Year, Time.Value.Month, Time.Value.Day, 0, 0, 0, DateTimeKind.Local);
            DateTime endHour = startHour.AddDays(1);

            // get all events which need to happen at this day
            List<Backend.Event> events = CurrentUser.GetRepeatingEvents(Time.Value);

            while (startHour.Date != endHour.Date)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(DayDGV);
                row.Cells[0].Value = startHour.ToString("hh:mm tt");

                // get the first event at the current hour
                var e = events.Where(current => current.StartDate.Hour == startHour.Hour).ToList().FirstOrDefault();

                // there was a value, add it to the row
                if(e != null)
                {
                    row.Cells[1].Value = e.Subject;

                    // color at same index of corresponding priority level
                    row.DefaultCellStyle.BackColor = Backend.Constants.PriorityColors[Backend.Constants.PriorityList.IndexOf(e.Priority)];
                }

                DayDGV.Rows.Add(row);
                startHour = startHour.AddHours(1);
            }
            
            DayDGV.Refresh();
        }

        private void DayDGV_DoubleClick(object sender, EventArgs e)
        {
            // there is no value in the cell
            if (DayDGV.SelectedRows[0].Cells[1].Value == null)
                return;

            // get the subject string
            string subject = DayDGV.SelectedRows[0].Cells[1].Value.ToString();

            // search for the currentuser's event with that subject
            var match = CurrentUser.Events.Where(ev => ev.Subject == subject).FirstOrDefault();

            // there was no match found
            if (match == null)
                return;

            ViewerForm v = new ViewerForm(this, match);
            v.Show();
        }

        private void DayNextButton_Click(object sender, EventArgs e)
        {
            Time.Value = Time.Value.AddDays(1);
            UpdateInterface();
        }

        private void DayPrevButton_Click(object sender, EventArgs e)
        {
            Time.Value = Time.Value.AddDays(-1);
            UpdateInterface();
        }

        #endregion

        #region Week Tab

        private void UpdateWeek()
        {
            bool updateHeader = true;
            string builder = string.Empty;

            WeekDGV.Rows.Clear();

            // iterate through the hours of the day starting from the first day of the week
            DateTime startHour = new DateTime(Time.Value.Year, Time.Value.Month, Time.Value.Day, 0, 0, 0, DateTimeKind.Local);
            while (startHour.DayOfWeek != 0)
                startHour = startHour.AddDays(-1);

            DateTime endHour = startHour.AddDays(1);

            builder += $"{startHour.ToString("MMMM")} {startHour.Day}";
            builder += $" to {startHour.ToString("MMMM")} {startHour.AddDays(7).Day}";
            WeekLabel.Text = builder;

            // get all events which need to happen at this day
            List<Backend.Event> events;

            // iterate through each hour in the week in order
            while (startHour.Date != endHour.Date)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(WeekDGV);
                row.Cells[0].Value = startHour.ToString("hh:mm tt");

                // iterate through all days of the week one row at a time
                for(int i = 0; i < 7; i++)
                {
                    events = CurrentUser.GetRepeatingEvents(startHour.AddDays(i));

                    // get the first event at the current hour for each day
                    var e = events.Where(current => current.StartDate.Hour == startHour.AddDays(i).Hour).ToList().FirstOrDefault();

                    // there was a value, add it to the row
                    if (e != null)
                    {
                        // don't fill the time column with events
                        row.Cells[1 + i].Value = e.Subject;

                        // color at same index of corresponding priority level
                        row.Cells[1 + i].Style.BackColor = Backend.Constants.PriorityColors[Backend.Constants.PriorityList.IndexOf(e.Priority)];
                    }

                    // update the column header for each column once
                    if(updateHeader == true)
                    {
                        WeekDGV.Columns[1 + i].HeaderText = startHour.AddDays(i).DayOfWeek.ToString() + " " + startHour.AddDays(i).Day;
                    }
                }
                // stop updating the headers, they have been filled
                updateHeader = false;

                WeekDGV.Rows.Add(row);
                startHour = startHour.AddHours(1);
            }

            WeekDGV.Refresh();
        }

        private void WeekDGV_DoubleClick(object sender, EventArgs e)
        {
            // the time of day was double clicked or there is nothing in the cell
            if (WeekDGV.SelectedCells[0].ColumnIndex == 0 || WeekDGV.SelectedCells[0].Value == null)
                return;

            // get the subject string
            string subject = WeekDGV.SelectedCells[0].Value.ToString();

            // search for the currentuser's event with that subject
            var match = CurrentUser.Events.Where(ev => ev.Subject == subject).FirstOrDefault();

            // there was no match found
            if (match == null)
                return;

            ViewerForm v = new ViewerForm(this, match);
            v.Show();
        }

        private void WeekPrevButton_Click(object sender, EventArgs e)
        {
            Time.Value = Time.Value.AddDays(-7);
            UpdateInterface();
        }
        
        private void WeekNextButton_Click(object sender, EventArgs e)
        {
            Time.Value = Time.Value.AddDays(7);
            UpdateInterface();
        }

        #endregion

        #region Month Tab

        private void UpdateMonth()
        {
            MonthDGV.Rows.Clear();

            MonthLabel.Text = Time.Value.ToString("MMMM");

            // find the number of days
            int count = 0;
            int days = DateTime.DaysInMonth(Time.Value.Year, Time.Value.Month);

            DateTime date = new DateTime(Time.Value.Year, Time.Value.Month, 1, 0, 0, 0, DateTimeKind.Local);

            // get the first even shown on this day
            Backend.Event e;

            // start adding days until all are put in
            while(count < days)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(MonthDGV);

                // loop for each week or until the amount of days in the month is hit
                for (int i = (int)date.AddDays(count).DayOfWeek; i < 7; i++, count++)
                {
                    // the end of the month was reached
                    if (count >= days)
                        break;

                    // put the day of the month in the cell
                    row.Cells[(int)date.AddDays(count).DayOfWeek].Value = date.AddDays(count).Day;

                    // if there is an event for today
                    if (CurrentUser.GetRepeatingEvents(date.AddDays(count)).Count > 0)
                    {
                        // get all the CurrentUser's events that can occur on this day
                        e = CurrentUser.GetRepeatingEvents(date.AddDays(count))[0];

                        // add the event subject next to the day of the month
                        row.Cells[(int)date.AddDays(count).DayOfWeek].Value += $" {e.Subject}";

                        // color based on priority
                        row.Cells[(int)date.AddDays(count).DayOfWeek].Style.BackColor
                            = Backend.Constants.PriorityColors[Backend.Constants.PriorityList.IndexOf(e.Priority)];
                    }
                }
                MonthDGV.Rows.Add(row);
            }
            MonthDGV.Refresh();

        }

        private void MonthDGV_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            MonthDGV.Rows[e.RowIndex].Height = Backend.Constants.MonthHeight;
        }

        private void MonthDGV_DoubleClick(object sender, EventArgs e)
        {
            // the time of day was double clicked or there is nothing in the cell
            if (MonthDGV.SelectedCells[0].ColumnIndex == 0 || MonthDGV.SelectedCells[0].Value == null)
                return;

            // get the subject string
            string subject = MonthDGV.SelectedCells[0].Value.ToString();
            subject = subject.Substring(subject.IndexOf(' ') + 1);

            // search for the currentuser's event with that subject
            var match = CurrentUser.Events.Where(ev => ev.Subject == subject).FirstOrDefault();

            // there was no match found
            if (match == null)
                return;

            ViewerForm v = new ViewerForm(this, match);
            v.Show();
        }

        private void MonthNextButton_Click(object sender, EventArgs e)
        {
            Time.Value = Time.Value.AddMonths(1);
            UpdateInterface();
        }
        
        private void MonthPrevButton_Click(object sender, EventArgs e)
        {
            Time.Value = Time.Value.AddMonths(-1);
            UpdateInterface();
        }


        #endregion


    }
}
