using asagiv.dbmanager.common.MongoDB;
using asagiv.dbmanager.webportal.Data;
using Blazorise;
using Blazorise.Bootstrap;
using Blazorise.Icons.FontAwesome;

MongoDbClient.Instance.Connect("mongodb://192.168.4.4:27017");

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<FamilyCollection>();
builder.Services.AddSingleton<AddressCollection>();
builder.Services.AddSingleton<PeopleCollection>();
builder.Services.AddSingleton<EventsCollection>();
builder.Services.AddSingleton<EventGiftCollection>();
builder.Services.AddSingleton<FamilyEventGiftCollection>();
builder.Services.AddSingleton<AddressBookDbService>();

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
