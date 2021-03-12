using IoTHubTrigger = Microsoft.Azure.WebJobs.EventHubTriggerAttribute;

using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Azure.EventHubs;
using System.Text;
using System.Net.Http;
using Microsoft.Extensions.Logging;
using AzureFunction.Models;
using Newtonsoft.Json;

namespace AzureFunction
{
    public static class Routemessages
    {
        private static HttpClient client = new HttpClient();

        [FunctionName("Routemessages")]
        public static void Run([IoTHubTrigger("messages/events", Connection = "iothub_ehub_iothub20_2_8763167_3f6420fdd2", ConsumerGroup = "functionapp")] EventData message,
            //[CosmosDB(databaseName: "iot20cosmosdatabas", collectionName: "Measurement", CreateIfNotExists = true, ConnectionStringSetting = "iot20cosmosdatabas")] out dynamic cosmos,
            ILogger log)
        {
            var _data = JsonConvert.DeserializeObject<dynamic>(Encoding.UTF8.GetString(message.Body.Array));
            var _deviceId = message.SystemProperties["iothub-connection-device-id"].ToString();
            var _deviceType = message.Properties["deviceType"].ToString();
            var _latitude = message.Properties["latitude"].ToString();
            var _longitude = message.Properties["longitude"].ToString();
            var _epochTime = message.Properties["epochTime"].ToString();

            var measurement = new MeasurementModel()
            {
                deviceId = _deviceId,
                deviceType = _deviceType,
                epochTime = _epochTime,
                location = new Location { latitude = _latitude, longitude = _longitude},
                data = _data
            };

            measurement.ConverEpochTime();

            var json = JsonConvert.SerializeObject(measurement);
            log.LogInformation(json);
        }
    }
}