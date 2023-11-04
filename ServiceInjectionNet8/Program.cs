using ServiceInjectionNet8;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IOldService, OldService>();
builder.Services.AddSingleton<INewService, NewService>();

builder.Services.AddKeyedSingleton<IService, BigService>("big");
builder.Services.AddKeyedSingleton<IService, SmallService>("small"); 

builder.Services.AddSingleton<OldWrapper>();
builder.Services.AddSingleton<NewWrapper>();

builder.Services.AddSingleton<BigWrapper>();
builder.Services.AddSingleton<SmallWrapper>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/old", (OldWrapper wrapper) => wrapper.GetOldData());
app.MapGet("/new", (NewWrapper wrapper) => wrapper.GetNewData());

app.MapGet("/big", (BigWrapper wrapper) => wrapper.GetBigData());
app.MapGet("/small", (SmallWrapper wrapper) => wrapper.GetSmallData());

app.Run();
