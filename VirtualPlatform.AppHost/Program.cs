var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.VirtualPlatform_ApiService>("apiservice");

builder.AddProject<Projects.VirtualPlatform_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService)
    .WaitFor(apiService);

builder.AddViteApp("vite", "../VirtualPlatform.Frontend")
    .WithYarnPackageInstallation()
    .WithReference(apiService)
    .WaitFor(apiService)
    .WithHttpEndpoint(env: "PORT")
    .WithExternalHttpEndpoints()
    .PublishAsDockerFile();

builder.Build().Run();
