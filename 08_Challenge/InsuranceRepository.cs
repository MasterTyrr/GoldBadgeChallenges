using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Challenge
{
    public class InsuranceRepository
    {
        private List<InsurancePoco> InsuranceList;
        decimal InsuranceTotalCost = 75m;
        

        public InsuranceRepository()
        {
            InsuranceList = new List<InsurancePoco>();
        }

        public void AddDriverToList (InsurancePoco NewDriver)
        {
            InsuranceList.Add(NewDriver);
        }

        public List<InsurancePoco> GetInsuranceList()
        {
            return InsuranceList;
        }

        public decimal InsuranceCost(InsurancePoco List)
        {
            SpeedingCalc(List);

            SwerveCalc(List);

            CaliStopCalc(List);

            TailGatingCalc(List);

            List.DriverCost = InsuranceTotalCost;

            return InsuranceTotalCost;
        }

        private void TailGatingCalc(InsurancePoco List)
        {
            if (List.TailGating == 0)
            {
                InsuranceTotalCost += 0;
            }
            else if (List.TailGating >= 1 && List.TailGating <= 4)
            {
                InsuranceTotalCost += 25;
            }
            else if (List.TailGating >= 5)
            {
                InsuranceTotalCost += 50;
            }
        }

        private void CaliStopCalc(InsurancePoco List)
        {
            if (List.CaliStopSign == 0)
            {
                InsuranceTotalCost += 0;
            }
            else if (List.CaliStopSign >= 1 && List.CaliStopSign <= 4)
            {
                InsuranceTotalCost += 25;
            }
            else if (List.CaliStopSign >= 5)
            {
                InsuranceTotalCost += 50;
            }
        }

        private void SwerveCalc(InsurancePoco List)
        {
            if (List.SwerveOutSideLane == 0)
            {
                InsuranceTotalCost += 0;
            }
            else if (List.SwerveOutSideLane >= 1 && List.SwerveOutSideLane <= 4)
            {
                InsuranceTotalCost += 25;
            }
            else if (List.SwerveOutSideLane >= 5)
            {
                InsuranceTotalCost += 50;
            }
        }

        private void SpeedingCalc(InsurancePoco List)
        {
            if (List.SpeedLimit == 0)
            {
                InsuranceTotalCost += 0;
            }
            else if (List.SpeedLimit >= 1 && List.SpeedLimit <= 4)
            {
                InsuranceTotalCost += 25;
            }
            else if (List.SpeedLimit >= 5)
            {
                InsuranceTotalCost += 50;
            }
        }
    }
}
