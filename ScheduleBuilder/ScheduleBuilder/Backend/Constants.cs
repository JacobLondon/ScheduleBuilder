using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleBuilder.Backend
{
    public class Constants
    {
        // priority of an event
        public enum Priority {Low, Medium, High};

        // how often an event repeats (if it does)
        public enum RepeatOccurence {NA, Daily, Weekly, Monthly, Yearly};


    }
}
