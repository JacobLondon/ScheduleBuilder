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

        //Daniel Added DateTime variable for current WeekDay to handle Week arrows.
        //DateTime weekTemp;

        public Form1()
        {
            InitializeComponent();

            InitializeVariables();

            InitializeEvents();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DayLabel.Text = DayDateTimePicker.Value.ToShortDateString();

            //if (Users.Count() <= 0)
            //    MessageBox.Show(
            //        "There are no users in the program. Please add one before continuing.",
            //        "Warning",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Warning);

            // Daniel Added label update for initial load
            int dow = Convert.ToInt32(DayDateTimePicker.Value.DayOfWeek);
            WeekLabel.Text = "Week of "
                + DayDateTimePicker.Value.AddDays(-1 * dow).ToShortDateString()
                + " through " + DayDateTimePicker.Value.AddDays(6 - dow).ToShortDateString();

            /*
            // Daniel Created Row and Time Loading for WeekDGV
            for (int i = 0; i < 24; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(WeekDGV);
                row.Cells[0].Value = new TimeSpan(i, 0, 0);
                WeekDGV.Rows.Add(row);
            }
            */

            // Daniel Added update to weekTemp variable.
            //weekTemp = DayDateTimePicker.Value;

            // check if the save location exists
            if (!Directory.Exists(Backend.Constants.SAVE_DIRECTORY))
            {
                Directory.CreateDirectory(Backend.Constants.SAVE_DIRECTORY);
            }

            // try to deserialize all files to users
            foreach (var file in Directory.EnumerateFiles(Backend.Constants.SAVE_DIRECTORY, "*.json"))
            {
                Console.WriteLine(file);
                var user = new JavaScriptSerializer().Deserialize<Backend.User>(File.ReadAllText(file));
                Users.Add(user);
            }

            UpdateUserComboBox();
            UpdateInterface();
        }

        private void InitializeVariables()
        {
            Users = new List<Backend.User>();
            CurrentUser = new Backend.User();

            //weekTemp = new DateTime();
        }

        private void InitializeEvents()
        {
            AddUserTextBox.KeyDown += AddUserTextBox_KeyDown;
        }
        
        public void UpdateInterface()
        {
            // update the user dgv
            UpdateUserDGV();

            // update the day datagridview with event items
            FillDayDGV(ref DayDGV);

            // Daniel Added FillWeekDGV to UpdateInterface
            FillWeekDGV(ref WeekDGV);

            // MADE BY DAVID
            LoadMonthDGV();
            MonthLabelUpdate(DayDateTimePicker.Value.Month);

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
        private void UserComboBox_SelectedIndexChanged(object sender, EventArgs e)
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
            // Daniel Added update to weekTemp variable on DayDateTimePicker change.
            //weekTemp = DayDateTimePicker.Value;

            UpdateInterface();
        }

        // Alex Created FillDayDGV
        public void FillDayDGV(ref DataGridView DayDGV)
        {
            // clear rows       
            DayDGV.Rows.Clear();
            DayLabel.Text = DayDateTimePicker.Value.ToShortDateString();

            // put event items in the day row
            foreach (Backend.Event item in CurrentUser.Events)
            {
                DataGridViewRow StartRow = new DataGridViewRow();
                StartRow.CreateCells(DayDGV);
                StartRow.Cells[0].Value = item.StartDate.ToString("hh:mm tt");
                StartRow.Cells[1].Value = item.Subject.ToString();
                DayDGV.Rows.Add(StartRow);
            }
            DayDGV.Refresh();
        }

        #endregion

        #region Week Tab

        // Daniel Added WeekPrevButton Click Handler Function
        private void WeekPrevButton_Click(object sender, EventArgs e)
        {
            //weekTemp = weekTemp.AddDays(-7);
            DayDateTimePicker.Value = DayDateTimePicker.Value.AddDays(-7);
            UpdateInterface();
        }

        // Daniel Added WeekNextButton Click Handler Function
        private void WeekNextButton_Click(object sender, EventArgs e)
        {
            //weekTemp = weekTemp.AddDays(7);
            DayDateTimePicker.Value = DayDateTimePicker.Value.AddDays(7);
            UpdateInterface();
        }

        // Daniel Created FillWeekDGV
        public void FillWeekDGV(ref DataGridView WeekDGV)
        {
            // Clear Rows
            WeekDGV.Rows.Clear();

            // Update Grid
            for (int i = 0; i < 24; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(WeekDGV);
                row.Cells[0].Value = new DateTime(DayDateTimePicker.Value.Year, DayDateTimePicker.Value.Month, DayDateTimePicker.Value.Day, i, 0, 0).ToString("hh:mm tt");
                WeekDGV.Rows.Add(row);
            }
            // Add Week Label Text
            int dow = Convert.ToInt32(DayDateTimePicker.Value.DayOfWeek);
            WeekLabel.Text = "Week of "
                + DayDateTimePicker.Value.AddDays(-1 * dow).ToShortDateString()
                + " through "
                + DayDateTimePicker.Value.AddDays(6 - dow).ToShortDateString();

            // Fill Cells
            foreach (Backend.Event item in CurrentUser.Events)
            {
                FillWeekCell((int)item.StartTime.Hour, item);
            }
        }

        // Daniel Added Sub-function for adding the specific week cell.
        public void FillWeekCell(int time, Backend.Event item)
        {
            int dow = Convert.ToInt32(DayDateTimePicker.Value.DayOfWeek);
            // End of Week DateTime
            DateTime eow = new DateTime();
            eow = DayDateTimePicker.Value.AddDays(6 - dow);
            // Beginning of Week DateTime
            DateTime bow = new DateTime();
            bow = DayDateTimePicker.Value.AddDays(-1 * dow);

            // CompareTo for DateTime returns less than 0 if earlier than, 0 when equal, and greater than 0 when later than.
            // This if statement ensures that the event falls on the selected calendar week. 
            if (item.StartDate.CompareTo(eow) <= 0 && item.StartDate.CompareTo(bow) >= 0)
                WeekDGV.Rows[time].Cells[(int)item.StartDate.DayOfWeek + 1].Value = item.Subject.ToString();
            // +1 for the Time Column Offset
        }

        #endregion

        #region Month Tab

        // MADE BY DAVID
        private void MonthPrevButton_Click(object sender, EventArgs e)
        {
            //updates the monthlabel
            int nowmonth = DayDateTimePicker.Value.Month;
            if (nowmonth == 1)
            {
                nowmonth = 12;
                DayDateTimePicker.Value = new DateTime(DayDateTimePicker.Value.Year, nowmonth, DayDateTimePicker.Value.Day);
                DayDateTimePicker.Value = new DateTime(DayDateTimePicker.Value.Year - 1, nowmonth, DayDateTimePicker.Value.Day);
            }
            else
            {
                nowmonth--;
                DayDateTimePicker.Value = new DateTime(DayDateTimePicker.Value.Year, nowmonth, DayDateTimePicker.Value.Day);
            }
            MonthLabelUpdate(nowmonth);
            LoadMonthDGV();
        }
        // MADE BY DAVID
        private void MonthNextButton_Click(object sender, EventArgs e)
        {
            //updates the monthlabel
            int nowmonth = DayDateTimePicker.Value.Month;
            if (nowmonth == 12)
            {
                nowmonth = 1;
                DayDateTimePicker.Value = new DateTime(DayDateTimePicker.Value.Year, nowmonth, DayDateTimePicker.Value.Day);
                DayDateTimePicker.Value = new DateTime(DayDateTimePicker.Value.Year + 1, nowmonth, DayDateTimePicker.Value.Day);
            }
            else
            {
                nowmonth++;
                DayDateTimePicker.Value = new DateTime(DayDateTimePicker.Value.Year, nowmonth, DayDateTimePicker.Value.Day);
            }
            MonthLabelUpdate(nowmonth);
            LoadMonthDGV();
        }
        // MADE BY DAVID
        private string MonthLabelUpdate(int month)
        {
            string monthviewer = "Insert Date Here";
            switch (month)
            {
                case 1:
                    monthviewer = "January"; break;
                case 2:
                    monthviewer = "February"; break;
                case 3:
                    monthviewer = "March"; break;
                case 4:
                    monthviewer = "April"; break;
                case 5:
                    monthviewer = "May"; break;
                case 6:
                    monthviewer = "June"; break;
                case 7:
                    monthviewer = "July"; break;
                case 8:
                    monthviewer = "August"; break;
                case 9:
                    monthviewer = "September"; break;
                case 10:
                    monthviewer = "October"; break;
                case 11:
                    monthviewer = "November"; break;
                case 12:
                    monthviewer = "December"; break;
                default:
                    monthviewer = "MonthLabel is BROKEN";
                    break;
            }
            MonthLabel.Text = monthviewer;
            return monthviewer;
        }
        // MADE BY DAVID
        private void LoadMonthCell()
        {
            for (int k = 0; k < 7; k++)
                MonthDGV.Rows.Add();
        }
        // MADE BY DAVID
        private void ResetMonthDGV()
        {
            MonthDGV.Rows.Clear();
        }
        // MADE BY DAVID
        private void LoadMonthDGV()
        {
            ResetMonthDGV();
            LoadMonthCell();
            //select the beginning of the month to have an easier load
            DateTime loadDay = new DateTime(DayDateTimePicker.Value.Year, DayDateTimePicker.Value.Month, 1);
            int currentMonth = DayDateTimePicker.Value.Month;
            int weekTracker = 0;
            int dayTracker = (int)loadDay.DayOfWeek;


            if (currentMonth == 1 || currentMonth == 3 || currentMonth == 5 || currentMonth == 7 || currentMonth == 8 || currentMonth == 10 || currentMonth == 12) // Month's with 31 days
                for (int i = 0; i < 31; i++)
                {

                    DayPlacer(dayTracker, weekTracker, i + 1, loadDay);


                    if (dayTracker == 6)
                    {
                        dayTracker = 0;
                        weekTracker++;
                    }
                    else
                        dayTracker++;
                    loadDay = new DateTime(DayDateTimePicker.Value.Year, DayDateTimePicker.Value.Month, i + 1);
                }
            else if (currentMonth != 2)
                for (int j = 0; j < 30; j++)
                {
                    DayPlacer(dayTracker, weekTracker, j + 1, loadDay);

                    if (dayTracker == 6)
                    {
                        dayTracker = 0;
                        weekTracker++;
                    }
                    else
                        dayTracker++;
                }
            else if (DateTime.IsLeapYear(DayDateTimePicker.Value.Year))
                for (int k = 0; k < 29; k++)
                {
                    DayPlacer(dayTracker, weekTracker, k + 1, loadDay);

                    if (dayTracker == 6)
                    {
                        dayTracker = 0;
                        weekTracker++;
                    }
                    else
                        dayTracker++;
                }
            else
                for (int l = 0; l < 28; l++)
                {
                    DayPlacer(dayTracker, weekTracker, l + 1, loadDay);

                    if (dayTracker == 6)
                    {
                        dayTracker = 0;
                        weekTracker++;
                    }
                    else
                        dayTracker++;
                }


        }

        // MADE BY DAVID
        private void DayPlacer(int d, int w, int c, DateTime e)
        {
            switch (d)
            {
                case 0://Sunday
                    MonthDGV[0, w].Value = c;
                    break;
                case 1: // Monday
                    MonthDGV[1, w].Value = c;
                    break;
                case 2: // Tuesday
                    MonthDGV[2, w].Value = c;
                    break;
                case 3: //Wednesday
                    MonthDGV[3, w].Value = c;
                    break;
                case 4: // Thursday
                    MonthDGV[4, w].Value = c;
                    break;
                case 5: //Friday
                    MonthDGV[5, w].Value = c;
                    break;
                case 6: //Saturday
                    MonthDGV[6, w].Value = c;
                    break;
                default:
                    Console.WriteLine("DAYOFWEEK DOES NOT EXIST");
                    break;
            }

            foreach (Backend.Event item in CurrentUser.Events)
            {
                if (item.StartDate.Month == e.Date.Month && item.StartDate.Year == e.Date.Year && item.StartDate.Day == e.Date.Day)
                    switch (d)
                    {
                        case 0://Sunday
                            MonthDGV[0, w].Value += "  " + item.Subject.ToString();
                            break;
                        case 1: // Monday
                            MonthDGV[1, w].Value += "  " + item.Subject.ToString();
                            break;
                        case 2: // Tuesday
                            MonthDGV[2, w].Value += "  " + item.Subject.ToString();
                            break;
                        case 3: //Wednesday
                            MonthDGV[3, w].Value += "  " + item.Subject.ToString();
                            break;
                        case 4: // Thursday
                            MonthDGV[4, w].Value += "  " + item.Subject.ToString();
                            break;
                        case 5: //Friday
                            MonthDGV[5, w].Value += "  " + item.Subject.ToString();
                            break;
                        case 6: //Saturday
                            MonthDGV[6, w].Value += "  " + item.Subject.ToString();
                            break;
                        default:
                            Console.WriteLine("DAYOFWEEK DOES NOT EXIST");
                            break;
                    }
            }
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(Backend.User u in Users)
            {
                foreach (Backend.Event ev in u.Events)
                {
                    Console.WriteLine(ev.StartDate.ToString());
                }
            }
            
        }
    }
}
