using System;
using System.Collections.Generic;
using System.Text;

namespace AzureFunction.Models
{
    public class DhtMeasurement
    {
        public DhtMeasurement()
        {

        }

        //public DhtMeasurement(string deviceId, DateTime created, decimal temperature, decimal humidity)
        //{
        //    DeviceId = deviceId;
        //    Created = created;
        //    Temperature = temperature;
        //    Humidity = humidity;

        //}

        public long Id { get; set; }
        public string DeviceId { get; set; }
        public decimal Temperature { get; set; }
        public decimal Humidity { get; set; }

        public DateTime Created { get; set; }
        public long EpochTime { get; set; }
    }



}


