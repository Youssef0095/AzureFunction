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
            MeasurementTime = dateTimeOffset.DateTime;
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

























//public DhtMeasurement()
//{

//}

//public DhtMeasurement(string deviceId, decimal temperature, decimal humidity, long epochTime)
//{
//    DeviceId = deviceId;
//    Temperature = temperature;
//    Humidity = humidity;
//    EpochTime = epochTime;

//}

//public DhtMeasurement(long id, string deviceId, DateTime created, decimal temperature, decimal humidity)
//{
//    Id = id;
//    DeviceId = deviceId;
//    Created = created;
//    Temperature = temperature;
//    Humidity = humidity;

//}

//public long Id { get; set; }
//public string DeviceId { get; set; }
//public decimal Temperature { get; set; }
//public decimal Humidity { get; set; }

//public DateTime Created { get; set; }
//public long EpochTime { get; set; }

//public void ConverEpochTime()
//{
//    DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(EpochTime);
//    Created = dateTimeOffset.UtcDateTime;
//}

