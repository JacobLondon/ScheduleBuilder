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

    }
}
