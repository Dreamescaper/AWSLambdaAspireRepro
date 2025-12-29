using Amazon.Lambda.Core;
using Amazon.Lambda.SQSEvents;

namespace AWSLambdaRepro.Handlers
{
    public class SqsEventHandlerA
    {
        public async Task InvokeAsync(SQSEvent sqsEvent, ILambdaContext lambdaContext)
        {
            Console.WriteLine($"Processing {sqsEvent.Records.Count} SQS events (A).");
        }
    }
}
