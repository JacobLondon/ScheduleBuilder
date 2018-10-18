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
                StartDateTimePicker.Value,
                StartTimeComboBox.Text,
                FinishDateTimePicker.Value,
                FinishTimeComboBox.Text,
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
