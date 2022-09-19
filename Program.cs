using CalculatorClassLibrary;
using Microsoft.Extensions.Options;
using MongoDB.Bson.Serialization;
using static System.Net.WebRequestMethods;
using WebAppAPI;
using Microsoft.AspNetCore.Components.Web;
using WebApp.Services;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<HttpClient>();


//void ConfigureServices(IServiceCollection services)
//{
IServiceCollection services=new ServiceCollection();
    services.AddRazorPages();
    services.AddServerSideBlazor();

IHttpClientBuilder httpClientBuilder = services.AddHttpClient<ICalculatorService, CalculatorService>(client =>
    {
        client.BaseAddress = new Uri("https://localhost:5151/calculator");
    });


    var app = builder.Build();



    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseAuthorization();

    app.MapControllers();

    app.Run();
//}