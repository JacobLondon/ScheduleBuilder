using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleBuilder.Backend
{
    public class User
    {
        public string Username { get; set; }
        public List<Event> Events { get; set; }

        public User(string Username)
        {
            this.Username = Username;
            Events = new List<Event>();
        }

        public User()
        {
            this.Username = string.Empty;
            Events = new List<Event>();
        }

        public override String ToString()
        {
            return Username;
        }

        public List<Event> GetRepeatingEvents(DateTime day)
        {
            List<Event> repeatingEvents = new List<Event>();

            // traverse user's events and compare with the day's repetition to put in repeatingEvents
            foreach(Event e in Events)
            {
                // if the event is normally today
                if (e.StartDate.Date == day.Date)
                {
                    repeatingEvents.Add(e);
                    continue;
                } // today case over, if not originally scheduled today, it can be put in below

                // the event does not repeat
                if (e.EventRepeats == false)
                    break;

                // repeats daily, so always put in for the day
                if (e.RepeatOccurence == Constants.RepeatList[(int)Constants.RepeatOccurence.Daily])
                {
                    repeatingEvents.Add(e);
                    continue;
                }
                // repeats weekly, check if the day of the week is the same
                else if(e.RepeatOccurence == Constants.RepeatList[(int)Constants.RepeatOccurence.Weekly]
                    && e.StartDate.DayOfWeek == day.DayOfWeek)
                {
                    repeatingEvents.Add(e);
                    continue;
                }
                // repeats monthly, check if the day of the month is the same
                else if(e.RepeatOccurence == Constants.RepeatList[(int)Constants.RepeatOccurence.Monthly]
                    && e.StartDate.Day == day.Day)
                {
                    repeatingEvents.Add(e);
                    continue;
                }

                else if(e.RepeatOccurence == Constants.RepeatList[(int)Constants.RepeatOccurence.Yearly]
                    && e.StartDate.DayOfYear == day.DayOfYear)
                {
                    repeatingEvents.Add(e);
                    continue;
                }
            }

            return repeatingEvents;
        }

    }
}
