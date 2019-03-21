using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Challenge
{
    public class InsurancePoco
    {
        public int SpeedLimit { get; set; }
        public int SwerveOutSideLane { get; set; }
        public int CaliStopSign { get; set; }
        public int TailGating { get; set; }
        public string DriverName { get; set; }
        public decimal DriverCost { get; set; }

        public InsurancePoco() { }
        public InsurancePoco(string driverName, int speedLimit, int swerveOutSideLane, int caliStopSign, int tailGating)//, decimal driverCost)
        {
            DriverName = driverName;
            SpeedLimit = speedLimit;
            SwerveOutSideLane = swerveOutSideLane;
            CaliStopSign = caliStopSign;
            TailGating = tailGating;
           // DriverCost = driverCost;
        }
    }
}
