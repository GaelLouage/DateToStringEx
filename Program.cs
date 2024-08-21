using DateStringFormatterExercise.Helpers;


var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => 
{
    return TimeConvert.CurrentDateToString(DateTime.Now);
});

app.Run();
