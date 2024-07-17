using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProject.Models
{
    internal class Event
    {
        private readonly int Id;
        private Location Location;
        private int priority;
        private TimeOnly StartTime;
        private TimeOnly FinishTime;
        public Event(int id,String startTime,String finishTime,String location, int priorty) {
        
            this.Id = id;
            this.Location = Map.AddNewLocations(location);
            this.StartTime = TimeOnly.Parse( startTime);
            this.FinishTime = TimeOnly.Parse(finishTime);
            this.priority = priorty;
         }

        public int getId => Id;

        public int Priority { get => priority; set => priority = value; }
        public TimeOnly GetStartTime1 { get => StartTime; set => StartTime = value; }
        public TimeOnly GetFinishTime1 { get => FinishTime; set => FinishTime = value; }
        internal Location GetLocation1 { get => Location; set => Location = value; }
    }
}
