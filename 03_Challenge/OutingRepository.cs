using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Challenge
{
    public class OutingRepository
    {
        //This is the list of MenuItems
        private List<Outing> _EventList = new List<Outing>();
        private List<Outing> _GolfList = new List<Outing>();
        private List<Outing> _APList = new List<Outing>();
        private List<Outing> _BowlingList = new List<Outing>();
        private List<Outing> _ConcertList = new List<Outing>();

        //This will allow the user to add a new menu item to the menu
        public void AddEventToList(Outing newEventItem)
        {
            _EventList.Add(newEventItem);
        }

        public void AddGolfToList(Outing newEventItem)
        {
            _GolfList.Add(newEventItem);
        }

        public void AddAPToList(Outing newEventItem)
        {
            _APList.Add(newEventItem);
        }

        public void AddBowlingToList(Outing newEventItem)
        {
            _BowlingList.Add(newEventItem);
        }

        public void AddconcertToList(Outing newEventItem)
        {
            _ConcertList.Add(newEventItem);
        }

        //This will allow the program to call the Current menu list
        public List<Outing> GetEventList()
        {
            return _EventList;
        }

        public List<Outing> GetGolfList()
        {
            return _GolfList;
        }

        public List<Outing> GetAPList()
        {
            return _APList;
        }

        public List<Outing> GetBowlingList()
        {
            return _BowlingList;
        }

        public List<Outing> GetConcertList()
        {
            return _ConcertList;
        }

        //This is where calculations will be made in the repository
        public decimal SpeciEventTotalCost(List<Outing> outings, EventType eventType)
        {
            decimal EventTotal = 0m;
            List<Outing> localevents = outings;

            var SpecificEventList = localevents.Where(p => p.TypeOfEvent == eventType);

            foreach (Outing _outing in SpecificEventList)
            {
                EventTotal += _outing.TotalCostOfEvent;
            }

            return EventTotal;
        }

        public decimal AllEventTotalCost(List<Outing> outings)
        {
            decimal EventTotal = 0m;
            List<Outing> localevents = outings;

            
            foreach (Outing _outing in localevents)
            {
                EventTotal += _outing.TotalCostOfEvent;
            }

            return EventTotal;
        }

    }
}
