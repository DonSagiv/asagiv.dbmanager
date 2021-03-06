using asagiv.common;
using asagiv.common.databases;
using asagiv.common.Logging;
using asagiv.common.mongodb;
using asagiv.dbmanager.common.MongoDB;
using asagiv.dbmanager.common.Services;
using asagiv.dbmanager.common.Utilities;
using BlazorDownloadFile;
using Blazorise;
using Blazorise.Bootstrap;
using Blazorise.Icons.FontAwesome;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.UseSerilog();
builder.Services.AddSingleton<IDbClient, MongoDbClient>();
builder.Services.AddSingleton<IDbDatabase, MongoDbDatabase>();
builder.Services.AddSingleton<CsvExporter>();
builder.Services.AddSingleton<FamilyCollection>();
builder.Services.AddSingleton<AddressCollection>();
builder.Services.AddSingleton<PeopleCollection>();
builder.Services.AddSingleton<EventsCollection>();
builder.Services.AddSingleton<EventGiftCollection>();
builder.Services.AddSingleton<FamilyEventGiftCollection>();
builder.Services.AddSingleton<AddressBookDbService>();
builder.Services.AddBlazorDownloadFile(lifetime: ServiceLifetime.Scoped);

// Implement Blazorise
builder.Services.AddBlazorise(o => o.Immediate = true)
    .AddBootstrapProviders()
    .AddFontAwesomeIcons();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();

app.MapFallbackToPage("/_Host");

app.Run();
