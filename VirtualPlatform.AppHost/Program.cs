var builder = DistributedApplication.CreateBuilder(args);

var mongo = builder.AddMongoDB("mongo")
                   .WithLifetime(ContainerLifetime.Persistent);

var mongodb = mongo.AddDatabase("mongodb");


var apiService = builder.AddProject<Projects.VirtualPlatform_ApiService>("apiservice")
    .WithReference(mongodb)
    .WaitFor(mongodb);

builder.AddProject<Projects.VirtualPlatform_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService)
    .WaitFor(apiService);

// builder.AddViteApp("vite", "../VirtualPlatform.Frontend")
//     .WithYarnPackageInstallation()
//     .WithReference(apiService)
//     .WaitFor(apiService)
//     .WithHttpEndpoint(env: "PORT")
//     .WithExternalHttpEndpoints()
//     .PublishAsDockerFile();

builder.Build().Run();
