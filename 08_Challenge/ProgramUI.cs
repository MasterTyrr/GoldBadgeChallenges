using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Challenge
{
    internal class ProgramUI
    {
        private InsuranceRepository _insurancerepo = new InsuranceRepository();
        private InsurancePoco _insurancePoco = new InsurancePoco();

        public void Run()
        {
            bool ProgramIsStillRunning = true;

            while (ProgramIsStillRunning)
            {
                Console.Clear();
                Console.WriteLine("Welcome To the Best Insurance Menu. Please Choose a option.\n" +
                    "1. Get someone insured\n" +
                    "2. See who is insured\n" +
                    "3. exit");
                int userMenuInput = int.Parse(Console.ReadLine());
                switch (userMenuInput)
                {
                    case 1:
                        InsureSomeone();
                        break;
                    case 2:
                        SeeInsuredList();
                        break;
                    case 3:
                        ProgramIsStillRunning = false;
                        break;
                }
            }
        }

        private void SeeInsuredList()
        {
            Console.Clear();
            List<InsurancePoco> _insuranceList = _insurancerepo.GetInsuranceList();
            foreach (InsurancePoco insurancePoco in _insuranceList)
            {
                Console.WriteLine($"{insurancePoco.DriverName} is insured for {insurancePoco.DriverCost}");
            }
        }

        private void InsureSomeone()
        {
            Console.Clear();
            Console.WriteLine("Let us get you insured! What is their name?");
            string CustomerName = Console.ReadLine();

            Console.WriteLine("How often do they follow the speed limit?");
            int FollowSpeedLimit = int.Parse(Console.ReadLine());

            Console.WriteLine("How often do they Swerve outside their lane?");
            int swerveOutOfLane = int.Parse(Console.ReadLine());

            Console.WriteLine("How often do they do a Callifornia Stop?");
            int CaliStop = int.Parse(Console.ReadLine());

            Console.WriteLine("How often do they TailGate?");
            int TailGate = int.Parse(Console.ReadLine());

            InsurancePoco NewDriverToList = new InsurancePoco(CustomerName, FollowSpeedLimit, swerveOutOfLane, CaliStop, TailGate);

            _insurancerepo.InsuranceCost(NewDriverToList);

            _insurancerepo.AddDriverToList(NewDriverToList);

            Console.WriteLine("They are now insured! Press any key to continue");
            Console.ReadKey();

        }
    }
}