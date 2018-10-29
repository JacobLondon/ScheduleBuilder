using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleBuilder.Backend
{
    public class Constants
    {
        // priority of an event
        public enum Priority {Low, Medium, High};
        public static List<string> PriorityList = new List<string>
        {
            "Low",
            "Medium",
            "High"
        };

        // how often an event repeats (if it does)
        public enum RepeatOccurence {NA, Daily, Weekly, Monthly, Yearly};
        public static List<string> RepeatList = new List<string>
        {
            "NA",
            "Daily",
            "Weekly",
            "Monthly",
            "Yearly"
        };

        public static string SAVE_DIRECTORY = "C:\\Users\\" + Environment.UserName + "\\ScheduleBuilder";

        public static Color HIGH_PRIORITY = Color.Red;
        public static Color MED_PRIORITY = Color.Orange;
        public static Color LOW_PRIORITY = Color.Yellow;

    }
}
