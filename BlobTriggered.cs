using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace MyBlobFunctionProj
{
    public static class BlobTriggered
    {
        [FunctionName("BlobTriggered")]
        public static void Run(
            [BlobTrigger("mycontainer/{name}", Connection = "StorageConnection")] Stream blob,
            string name,
            ILogger log)
        {
            log.LogInformation($"Blob trigger fired for: {name}");
        }
    }
}
