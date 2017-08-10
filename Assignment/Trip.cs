using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Trip
    {
        public int tripId { get; set; }
        //e.g. if a train departs at 2:14 A.M., set startTime as 134.
        public int startTime { get; set; }
        public int endTime { get; set; }
        //station numbers are set to be numbers
        public int from { get; set; }
        public int to { get; set; }
        //duration in minutes or seconds, just be consistent
        public int duration { get; set; }
        public int assignedCrewNumber { get; set; }
        public int assignedTrainNumber { get; set; }

        public Trip()
        {
            //0 means it is not assigned
            this.assignedCrewNumber = 0;
            this.assignedTrainNumber = 0;
        }
    }
}
