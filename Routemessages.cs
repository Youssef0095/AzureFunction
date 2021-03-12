using IoTHubTrigger = Microsoft.Azure.WebJobs.EventHubTriggerAttribute;

using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Azure.EventHubs;
using System.Text;
using System.Net.Http;
using Microsoft.Extensions.Logging;

namespace AzureFunction
{
    public static class Routemessages
    {
        private static HttpClient client = new HttpClient();

        [FunctionName("Routemessages")]
        public static void Run([IoTHubTrigger("messages/events", Connection = "iothub-ehub-iothub20-2-8763167-3f6420fdd2", ConsumerGroup = "functionapp")]EventData message, ILogger log)
        {
            log.LogInformation($"C# IoT Hub trigger function processed a message: {Encoding.UTF8.GetString(message.Body.Array)}");

            var deviceId = message.SystemProperties["iothub-connection-device-id"].ToString();
            var deviceType = message.Properties["deviceType"].ToString();
            var latitude = message.Properties["latitude"].ToString();
            var longitude = message.Properties["longitude"].ToString();


        }
    }
}