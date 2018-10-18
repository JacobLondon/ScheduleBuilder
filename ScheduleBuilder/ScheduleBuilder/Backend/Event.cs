using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleBuilder.Backend
{

    public class Event
    {
        public string Subject { get; set; }
        public bool AllDay { get; set; }

        public DateTime StartDate { get; set; }
        public string StartTime { get; set; }
        public DateTime FinishDate { get; set; }
        public string FinishTime { get; set; }

        public bool EventRepeats { get; set; }
        public string RepeatOccurence { get; set; }
        public string Location { get; set; }
        public string Priority { get; set; }
        public string Description { get; set; }

        public Event(
            string Subject,
            bool AllDay,

            DateTime StartDate,
            string StartTime,
            DateTime FinishDate,
            string FinishTime,
            
            bool EventRepeats,
            string RepeatOccurence,
            string Location,
            string Priority,
            string Description)
        {
            this.Subject = Subject;
            this.AllDay = AllDay;

            this.StartDate = Convert.ToDateTime(StartDate + " " + StartTime);
            this.FinishDate = Convert.ToDateTime(FinishDate + " " + FinishTime);

            this.EventRepeats = EventRepeats;
            this.RepeatOccurence = RepeatOccurence;
            this.Location = Location;
            this.Priority = Priority;
            this.Description = Description;

        }

        public Event()
        {

        }

        public void FillEvent(
            string Subject,
            bool AllDay,

            DateTime StartDate,
            string StartTime,
            DateTime FinishDate,
            string FinishTime,

            bool EventRepeats,
            string RepeatOccurence,
            string Location,
            string Priority,
            string Description)
        {
            this.Subject = Subject;
            this.AllDay = AllDay;

            this.StartDate = Convert.ToDateTime(StartDate + " " + StartTime);
            this.FinishDate = Convert.ToDateTime(FinishDate + " " + FinishTime);

            this.EventRepeats = EventRepeats;
            this.RepeatOccurence = RepeatOccurence;
            this.Location = Location;
            this.Priority = Priority;
            this.Description = Description;
        }

        public void FillDayDGV(ref DataGridView DayDGV)
        {
            //clear row
            //add row
            //get data from form 1
            //repeat (as many times as necessary)
            //sort data by time
        }
    }
}
