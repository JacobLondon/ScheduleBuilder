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
    public partial class EventForm : Form
    {
        public Form1 MainForm { get; set; }

        public EventForm(Form1 MainForm)
        {
            InitializeComponent();

            this.MainForm = MainForm;

        }

        // on form load
        private void EventForm_Load(object sender, EventArgs e)
        {
            // fill comboboxes with data
            TimeSpan builder = new TimeSpan();

            // traverse for all times of the day
            for(int i = 0; i < 24; i++)
            {
                builder = new TimeSpan(i, 0, 0);
                StartTimeComboBox.Items.Add(builder);
                FinishTimeComboBox.Items.Add(builder);
            }

            StartTimeComboBox.SelectedIndex = 12;
            FinishTimeComboBox.SelectedIndex = 13;
            SubjectTextBox.Text = "Subject";

            foreach(string s in Backend.Constants.RepeatList)
            {
                RepeatOccurrencesComboBox.Items.Add(s);
            }
            RepeatOccurrencesComboBox.SelectedIndex = 0;

            foreach (string s in Backend.Constants.PriorityList)
            {
                PriorityComboBox.Items.Add(s);
            }
            PriorityComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            Backend.Event temp = new Backend.Event(
                SubjectTextBox.Text,
                AllDayCheckBox.Checked,
                StartDateTimePicker.Value.Date,
                DateTime.Parse(StartTimeComboBox.SelectedItem.ToString()),
                FinishDateTimePicker.Value.Date,
                DateTime.Parse(FinishTimeComboBox.SelectedItem.ToString()),
                RepeatCheckBox.Checked,
                RepeatOccurrencesComboBox.Text,
                LocationTextBox.Text,
                PriorityComboBox.Text,
                DescriptionTextBox.Text);

            MainForm.CreateEvent(temp);
            Close();
        }

    }
}
