//using System.IO;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.Azure.WebJobs;
//using Microsoft.Azure.WebJobs.Extensions.Http;
//using Microsoft.Extensions.Logging;
//using Newtonsoft.Json;

//namespace AzureFunction
//{
//    public static class GetFromCosmos
//    {
//        [FunctionName("GetFromCosmos")]
//        public static async Task<IActionResult> Run(
//            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req,
//            [CosmosDB(databaseName: "IOT20", collectionName: "Measurement", CreateIfNotExists = true,
//            ConnectionStringSetting = "iot20cosmosdatabas")]out dynamic cosmos,
//            ILogger log)
//        {
//            return new OkObjectResult(cosmos);
//        }
//    }
//}

