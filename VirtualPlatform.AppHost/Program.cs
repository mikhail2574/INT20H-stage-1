var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.VirtualPlatform_ApiService>("apiservice");

builder.AddProject<Projects.VirtualPlatform_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
