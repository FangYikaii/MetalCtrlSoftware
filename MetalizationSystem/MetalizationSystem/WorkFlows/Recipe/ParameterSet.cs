using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MetalizationSystem.WorkFlows.Recipe
{
    /// <summary>
    /// 配方参数：包含温度、时间、PH值三个参数
    /// </summary>
    [Serializable]
    public class ParameterSet
    {
        public double Temperature { get; set; }
        public TimeSpan Time {  get; set; }
        public double PHValue { get; set; }

        public ParameterSet() 
        {
            Temperature = 20.0;
            Time = new TimeSpan(0, 0, 1);
            PHValue = 7.0;
        }

        public ParameterSet(double temperature, TimeSpan time, double phValue)
        {
            Temperature = temperature;
            Time = time;
            PHValue = phValue;
        }

        public override string ToString()
        {
            return $"Temperature: {Temperature}, Time:{Time}, PHValue: {PHValue}";
        }
    }
}
