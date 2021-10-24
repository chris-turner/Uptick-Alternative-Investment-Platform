using System;
using System.Collections.Generic;

namespace Uptick.Models
{
    public class User
    {
        public Guid userID { get; set; }
        public string username { get; set; }

        public List<Asset> portfolio { get; set; }

        public List<Break> breaks { get; set; }

        public List<Asset> withdraw { get; set; }

        public bool onWaitlist { get; set; }
    }
}
