using System.Collections.Generic;

namespace Uptick.Models
{
    public class Break
    {
        public Break()
        {
            completed = false;
        }
        public string breakId { get; set; }
        public string breakName { get; set; }
        public string breakImageURL { get; set; }
        public string startTime { get; set; }
        public int maxUsers { get; set; }
        public string breakPrice { get; set; }
        public int currentUsers { get; set; }

        public List<BreakSlot> breakResults { get; set; } 

        public bool completed { get; set; }

    }
}
