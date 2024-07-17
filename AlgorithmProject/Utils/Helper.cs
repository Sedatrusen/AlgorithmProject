using AlgorithmProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProject.Utils
{
    internal static class Helper
    {
        public static void Order(List<Event> events, List<Location> locations)
        {
            Location? currentLocation = null;
            TimeOnly? currentTime = null;
            List<Event> resultEvents = new List<Event>();
            events = events.OrderBy(x => x.GetStartTime1).ThenByDescending(x => x.Priority).ToList();
            var eventCounts= events.Count();

            for (int i = 0; i < eventCounts; i++)
            {
                var firstEvent = events.First();
                if (currentLocation == null && currentTime == null)
                {
                    resultEvents.Add(firstEvent);
                    currentLocation = firstEvent.GetLocation1;
                    currentTime = firstEvent.GetFinishTime1;
                    events.Remove(firstEvent);

                }
                else if (currentTime.Value.AddMinutes(firstEvent.GetLocation1.getNeighbours().FirstOrDefault(x=> x.Key == currentLocation).Value) > firstEvent.GetStartTime1)
                {
                    events.Remove(firstEvent);
                }else {
                    currentLocation = firstEvent.GetLocation1;
                    currentTime = firstEvent.GetFinishTime1;
                    resultEvents.Add(firstEvent);
                    events.Remove(firstEvent);
                }

            }
            int totalPriority = resultEvents.Sum(e => e.Priority);

            Console.WriteLine($"Katılınabilecek Maksimum Etkinlik Sayısı: {resultEvents.Count}");
            Console.WriteLine($"Katılınabilecek Etkinliklerin ID'leri: {string.Join(", ", resultEvents.Select(e => e.getId))}");
            Console.WriteLine($"Toplam Değer: {totalPriority}");
        }
    }
}
