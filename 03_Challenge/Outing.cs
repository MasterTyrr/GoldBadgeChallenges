using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Challenge
{
    public enum EventType
    {
        Golf = 1, Bowling, Amusement_Park, Concert
    }
    public class Outing
    {
        public int Attendees { get; set; }
        public DateTime DateOfEvent { get; set; }
        public decimal CostOfEventPerPerson { get; set; }
        public decimal TotalCostOfEvent { get; set; }
        public EventType TypeOfEvent { get; set; }

        public Outing() { }
        public Outing(int attendees, DateTime dateOfEvent, decimal costOfEventPerPerson, decimal totalCostOfEvent, EventType typeOfEvent)
        {
            Attendees = attendees;
            DateOfEvent = dateOfEvent;
            CostOfEventPerPerson = costOfEventPerPerson;
            TotalCostOfEvent = totalCostOfEvent;
            TypeOfEvent = typeOfEvent;
        }
    }
}
