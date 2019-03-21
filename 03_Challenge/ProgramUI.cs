using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Challenge
{
    public class ProgramUI
    {
        private OutingRepository _outingRepo = new OutingRepository();
        private Outing _outing = new Outing();

        public void Run()
        {
            bool ProgramStillRunning = true;

            while (ProgramStillRunning)
            {
                Console.Clear();
                Console.WriteLine("Hello how may I help you today? Please choose the number assoicated with your choice.\n" +
                    "1. Add a new outing to the list\n" +
                    "2. See list types\n" +
                    "3. Exit Application");
                string UserinputOnMenuOne = Console.ReadLine();
                if (!int.TryParse(UserinputOnMenuOne, out int input))
                {
                    continue;
                }
                switch (input)
                {
                    case 1:
                        AddNewOutingToList();
                        break;
                    case 2:
                        SeeListOfOutings();
                        break;
                    case 3:
                        ProgramStillRunning = false;
                        break;
                }
            }
        }

        private void SeeListOfOutings()
        {
            EventType TheEventType = new EventType();
            List<Outing> _outinglist = _outingRepo.GetEventList();
            List<Outing> _Golflist = _outingRepo.GetGolfList();
            List<Outing> _APlist = _outingRepo.GetAPList();
            List<Outing> _Bowlinglist = _outingRepo.GetBowlingList();
            List<Outing> _Concertlist = _outingRepo.GetConcertList();
            Console.Clear();
            Console.WriteLine("What would you like t do?\n" +
                "1. See All Events and total cost?\n" +
                "2. See a Specific Event Type total cost");
            string UserinputMenu = Console.ReadLine();


            switch (UserinputMenu)
            {
                case "1":
                    foreach (Outing outing in _outinglist)
                    {
                        Console.WriteLine($"{outing.TypeOfEvent} {outing.DateOfEvent.ToString("d")} \n" +
                            $"Attendance - {outing.Attendees} Cost Per-Person - {outing.CostOfEventPerPerson.ToString("C2")}\n " +
                            $"Total Cost - {outing.TotalCostOfEvent.ToString("C2")}");
                    }
                    Console.WriteLine($"Total Cost = {_outingRepo.AllEventTotalCost(_outinglist).ToString("C2")}");
                    Console.ReadKey();
                    break;
                case "2":
                    Console.WriteLine("what is the type of event?\n" +
                        "1. golf\n" +
                        "2. bowling\n" +
                        "3. amusement park\n" +
                        "4. concert");
                    string userinputoftypeofevent = Console.ReadLine();
                    int numberofevent = int.Parse(userinputoftypeofevent);
                    switch (numberofevent)
                    {
                        case 1:
                            foreach (Outing outing in _Golflist)
                            {
                                Console.WriteLine($"{outing.TypeOfEvent} {outing.DateOfEvent.ToString("d")} \n" +
                                    $"Attendance - {outing.Attendees} Cost Per-Person - {outing.CostOfEventPerPerson.ToString("C2")}\n " +
                                    $"Total Cost - {outing.TotalCostOfEvent.ToString("C2")}");
                            }
                            Console.WriteLine($"Total Cost = {_outingRepo.AllEventTotalCost(_Golflist).ToString("C2")}");
                            Console.ReadKey();
                            break;
                        case 2:
                            foreach (Outing outing in _APlist)
                            {
                                Console.WriteLine($"{outing.TypeOfEvent} {outing.DateOfEvent.ToString("d")} \n" +
                                    $"Attendance - {outing.Attendees} Cost Per-Person - {outing.CostOfEventPerPerson.ToString("C2")}\n " +
                                    $"Total Cost - {outing.TotalCostOfEvent.ToString("C2")}");
                            }
                            Console.WriteLine($"Total Cost = {_outingRepo.AllEventTotalCost(_APlist).ToString("C2")}");
                            Console.ReadKey();
                            break;
                        case 3:
                            foreach (Outing outing in _Bowlinglist)
                            {
                                Console.WriteLine($"{outing.TypeOfEvent} {outing.DateOfEvent.ToString("d")} \n" +
                                    $"Attendance - {outing.Attendees} Cost Per-Person - {outing.CostOfEventPerPerson.ToString("C2")}\n " +
                                    $"Total Cost - {outing.TotalCostOfEvent.ToString("C2")}");
                            }
                            Console.WriteLine($"Total Cost = {_outingRepo.AllEventTotalCost(_Bowlinglist).ToString("C2")}");
                            Console.ReadKey();
                            break;
                        case 4:
                            foreach (Outing outing in _Concertlist)
                            {
                                Console.WriteLine($"{outing.TypeOfEvent} {outing.DateOfEvent.ToString("d")} \n" +
                                    $"Attendance - {outing.Attendees} Cost Per-Person - {outing.CostOfEventPerPerson.ToString("C2")}\n " +
                                    $"Total Cost - {outing.TotalCostOfEvent.ToString("C2")}\n");
                            }
                            Console.WriteLine($"Total Cost = {_outingRepo.AllEventTotalCost(_Concertlist).ToString("C2")}");
                            Console.ReadKey();
                            break;
                    }
                    break;

            }
        }

        private void AddNewOutingToList()
        {
            Console.Clear();
            EventType TheEventType = new EventType();
            Console.WriteLine("What is the type of Event?\n" +
                "1. Golf\n" +
                "2. Bowling\n" +
                "3. Amusement Park\n" +
                "4. Concert");
            string userinputOfTypeOfEvent = Console.ReadLine();
            int NumberofEvent = int.Parse(userinputOfTypeOfEvent);
            switch (NumberofEvent)
            {
                case 1:
                    TheEventType = EventType.Golf;
                    break;
                case 2:
                    TheEventType = EventType.Bowling;
                    break;
                case 3:
                    TheEventType = EventType.Amusement_Park;
                    break;
                case 4:
                    TheEventType = EventType.Concert;
                    break;
            }

            Console.WriteLine("How many people were in attendance?");
            int AttendanceAtEvent = int.Parse(Console.ReadLine());

            Console.WriteLine("What was the date of the event? DD/MM/YYYY");
            DateTime dateTime = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("What was the cost of the event in total?");
            decimal CostofWholeEvent = decimal.Parse(Console.ReadLine());

            decimal TotalCostofEventPerPerson = CostofWholeEvent / AttendanceAtEvent;

            Outing EventToList = new Outing(AttendanceAtEvent, dateTime, TotalCostofEventPerPerson, CostofWholeEvent, TheEventType);
            switch (NumberofEvent)
            {
                case 1:
                    _outingRepo.AddGolfToList(EventToList);
                    break;
                case 2:
                    _outingRepo.AddBowlingToList(EventToList);
                    break;
                case 3:
                    _outingRepo.AddAPToList(EventToList);
                    break;
                case 4:
                    _outingRepo.AddconcertToList(EventToList);
                    break;
            }
            _outingRepo.AddEventToList(EventToList);

            Console.WriteLine("Event was successfully added to the list please press any key to continue.");
            Console.ReadKey();
        }
    }
}