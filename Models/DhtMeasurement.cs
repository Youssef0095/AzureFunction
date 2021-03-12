//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace AzureFunction.Models
//{
//    public class DhtMeasurement
//    {
//        public DhtMeasurement()
//        {

//        }

//        public DhtMeasurement(string deviceId, decimal temperature, decimal humidity, long epochTime)
//        {
//            DeviceId = deviceId;
//            Temperature = temperature;
//            Humidity = humidity;
//            EpochTime = epochTime;

//        }

//        public DhtMeasurement(long id, string deviceId, DateTime created, decimal temperature, decimal humidity)
//        {
//            Id = id;
//            DeviceId = deviceId;
//            Created = created;
//            Temperature = temperature;
//            Humidity = humidity;

//        }

//        public long Id { get; set; }
//        public string DeviceId { get; set; }
//        public decimal Temperature { get; set; }
//        public decimal Humidity { get; set; }

//        public DateTime Created { get; set; }
//        public long EpochTime { get; set; }

//        public void ConverEpochTime()
//        {
//            DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(EpochTime);
//            Created = dateTimeOffset.UtcDateTime;
//        }

//    }
//}


