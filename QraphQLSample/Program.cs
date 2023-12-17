using QraphQLSample.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddGraphQLServer().AddQueryType<EmployeeService>();
var app = builder.Build();

app.UseRouting();
app.UseEndpoints(endpoints =>
    endpoints.MapGraphQL()
    );
app.MapGet("/", () => "Hello World!");

app.Run();
