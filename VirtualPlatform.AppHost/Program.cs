using Microsoft.Extensions.DependencyInjection;

var builder = DistributedApplication.CreateBuilder(args);

var mongo = builder.AddMongoDB("mongo")
                   .WithLifetime(ContainerLifetime.Persistent);

var mongodb = mongo.AddDatabase("mongodb");

var rabbitmq = builder.AddRabbitMQ("messaging").WithManagementPlugin();
builder.Services.AddSignalR()
                .AddNamedAzureSignalR("signalr");



var apiService = builder.AddProject<Projects.VirtualPlatform_ApiService>("apiservice")
    .WithReference(mongodb)
    .WaitFor(mongodb);

var identityService = builder.AddProject<Projects.VirtualPlatform_Services_Identity_Api>("identity")
    .WithReference(mongodb)
    .WaitFor(mongodb)
    .WithReference(rabbitmq)
    .WaitFor(rabbitmq);


// builder.AddViteApp("vite", "../VirtualPlatform.Frontend")
//     .WithYarnPackageInstallation()
//     .WithReference(apiService)
//     .WaitFor(apiService)
//     .WithHttpEndpoint(env: "PORT")
//     .WithExternalHttpEndpoints()
//     .PublishAsDockerFile();

builder.Build().Run();
