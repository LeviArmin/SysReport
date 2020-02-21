using System;
using System.Collections.Generic;
using System.Text;

namespace SysReport.Core.DAL.Models
{
    public class TestData
    {
        public long Id { get; set; }
        public DateTime DateTest { get; set; }
        public string Artile { get; set; }
        public string ValveName { get; set; }
        public string OperatorName { get; set; }
        public DateTime CreateDate { get; set; }

        public double TimeToIncreaseAirPressureFirst { get; set; }
        public double TimeToReduceAitPressureFirst { get; set; }
        public double TimeToIncreaseAirPressureSecond { get; set; }
        public double TimeToReduceAitPressureSecond { get; set; }
        public double MaintainingConstantPressure { get; set; }
        public double StepPressure { get; set; }
        public double StepwiseIncreaseInPressureInTank { get; set; }
    }
}
