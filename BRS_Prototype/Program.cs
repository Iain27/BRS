using BRS_Prototype.Models;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();

//Transient objects are always different; a new instance is provided to every controller and every service.
//Scoped objects are the same within a request, but different across different requests.
//Singleton objects are the same for every object and every request.
builder.Services.AddScoped<INationRepository, MockCountryRepository>();
builder.Services.AddScoped<IBloodRedSkiesPlaneRepository, MockBloodRedSkiesPlaneRepository>();

//builder.Services.AddControllersWithViews

var app = builder.Build();

// app.UseStaticFiles();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

//app.MapGet("/", () => "Hello World!");
app.MapDefaultControllerRoute();

app.Run();

