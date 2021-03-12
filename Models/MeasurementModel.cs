using System;
using System.Collections.Generic;
using System.Text;

namespace AzureFunction.Models
{

    public class MeasurementModel
    {
        public string deviceId { get; set; }
        public string deviceType { get; set; }
        public string epochTime { get; set; }
        public DateTime MeasurementTime { get; private set; }
        public Location location { get; set; }
        public dynamic data { get; set; }
        public void ConverEpochTime()
        {
            DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(long.Parse(epochTime));
            MeasurementTime = dateTimeOffset.UtcDateTime;
        }

    }

    public class Location
    {
        public string latitude { get; set; }
        public string longitude { get; set; }
    }

    public class Date
    {
        public string created { get; set; }
        public float temperature { get; set; }
        public float humidity { get; set; }
    }

}
