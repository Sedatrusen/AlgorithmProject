using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProject.Models
{
    internal static class Map
    {
        public  static List<Location> _locations = new List<Location>();

        

        public static Location AddNewLocations(String location)
        {
            if (!_locations.Any(x=> x.Name==location) ){ 
               var locations = new Location(location);
            _locations.Add(locations);
                return _locations.First(x=> x.Name==location);
            }
            else
            {
               return Map.GetLocation(location);
            }
        }
        public static void AddNewNeighbour(string from, string to, int time)
        {
            var From = Map.GetLocation(from);
            var To = Map.GetLocation(to);
            From.addNeigbour(To, time);
            To.addNeigbour(From, time);            
        }

        public static void RemoveLocations(Location location)
        {
            _locations.Remove(location);
        }

        public static List<Location> GetLocations() {  return _locations; }

        public static Location GetLocation(String location)
        {
            if (_locations.Any(x=>x.Name==location))
            {
                return _locations.First(x => x.Name == location);
            }
            else {
                throw new ArgumentException();
            }
        }
    }
}
