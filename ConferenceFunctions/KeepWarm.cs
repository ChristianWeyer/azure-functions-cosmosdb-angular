using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;

namespace ConferenceFunctions
{
    public static class KeepWarm
    {
        [FunctionName("KeepWarm")]
        public static void Run(
            [TimerTrigger("0 */5 * * * *")]
            TimerInfo myTimer, TraceWriter log)
        {
            log.Info($"C# Timer trigger function executed at: {DateTime.Now}");
        }
    }
}
