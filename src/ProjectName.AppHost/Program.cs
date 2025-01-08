var builder = DistributedApplication.CreateBuilder(args);

var api = builder.AddProject<Projects.ProjectName_ApiService>("projectname-api");

builder.AddProject<Projects.ProjectName_UserInterface>("projectname-ui")
    .WithReference(api)
    .WaitFor(api);

builder.Build().Run();
