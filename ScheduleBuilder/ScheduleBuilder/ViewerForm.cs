﻿using System;
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
    public partial class ViewerForm : Form
    {
        private Backend.Event UserEvent;
        private Form1 MainForm;

        public ViewerForm(Form1 MainForm, Backend.Event UserEvent)
        {
            InitializeComponent();

            this.MainForm = MainForm;
            this.UserEvent = UserEvent;
        }

        // load event details into the form
        private void ViewerForm_Load(object sender, EventArgs e)
        {
            SubjectTextBox.Text = UserEvent.Subject;
            StartDateTimePicker.Value = UserEvent.StartDate;
            FinishDateTimePicker.Value = UserEvent.FinishDate;
            StartTextBox.Text = UserEvent.StartDate.TimeOfDay.ToString();
            FinishTextBox.Text = UserEvent.FinishDate.TimeOfDay.ToString();
            RepeatCheckBox.Checked = UserEvent.EventRepeats;
            RepeatOccurrencesTextBox.Text = UserEvent.RepeatOccurence;
            LocationTextBox.Text = UserEvent.Location;
            PriorityTextBox.Text = UserEvent.Priority;
            DescriptionTextBox.Text = UserEvent.Description;
        }

        private void RemoveEventButton_Click(object sender, EventArgs e)
        {
            // delete the event and close the window
            MainForm.DeleteEvent(UserEvent);
            Close();
        }

        private void SubjectTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
