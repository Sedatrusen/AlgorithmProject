using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProject.Models
{
    internal class Location
    {
        public String Name;
        private Dictionary<Location, int> Neighbour = new Dictionary<Location, int>();

       public  Location(String name)
        {
            this.Name = name;
        } 
        
        public void addNeigbour(Location location,int time)
        {
            Neighbour.Add(location, time);
        }

        public Dictionary<Location, int> getNeighbours()
        {
            return Neighbour;
        }
    }
}
