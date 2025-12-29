using Aspire.Hosting.AWS.Lambda;

var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder
    .AddProject<Projects.AWSLambdaRepro>("apiservice");

var sqsFunctionA = builder
    .AddAWSLambdaFunction<Projects.AWSLambdaRepro>(
        "sqs-lambda-function-a",
        "AWSLambdaRepro::AWSLambdaRepro.Handlers.SqsEventHandlerA::HandleAsync");

var sqsFunctionV = builder
    .AddAWSLambdaFunction<Projects.AWSLambdaRepro>(
        "sqs-lambda-function-b",
        "AWSLambdaRepro::AWSLambdaRepro.Handlers.SqsEventHandlerB::HandleAsync");

builder.Build().Run();
