using AlgorithmProject.Models;
using AlgorithmProject.Utils;
List<Event> events = new List<Event>
{

    new Event(1, "10:00", "12:00", "A", 50),
                new Event(2, "10:00", "11:00", "B", 30),
                new Event(3, "11:30", "12:30", "A", 40),
                new Event(4, "14:30", "16:00", "C", 70),
                new Event(5, "14:25", "15:30", "B", 60),
                new Event(6, "13:00", "14:00", "D", 80)
            };

Map.AddNewNeighbour("A", "B", 15);
Map.AddNewNeighbour("A", "C", 20);
Map.AddNewNeighbour("A", "D", 10);
Map.AddNewNeighbour("B", "C", 5);
Map.AddNewNeighbour("B", "D", 25);
Map.AddNewNeighbour("C", "D", 25);

Helper.Order(events, Map.GetLocations());

