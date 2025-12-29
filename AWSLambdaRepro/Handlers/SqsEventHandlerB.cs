using Amazon.Lambda.Core;
using Amazon.Lambda.SQSEvents;

namespace AWSLambdaRepro.Handlers
{
    public class SqsEventHandlerB
    {
        public async Task InvokeAsync(SQSEvent sqsEvent, ILambdaContext lambdaContext)
        {
            Console.WriteLine($"Processing {sqsEvent.Records.Count} SQS events (B).");
        }
    }
}
