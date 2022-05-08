// See https://aka.ms/new-console-template for more information
using asagiv.common.databases;
using asagiv.common.Logging;
using asagiv.common.mongodb;
using asagiv.dbmanager.common.MongoDB;
using asagiv.dbmanager.common.Utilities;
using MongoDB.Driver.Linq;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

Console.WriteLine("Initializing Console Diagnostics");

var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.UseSerilog();
        services.AddSingleton<IDbClient, MongoDbClient>();
        services.AddSingleton<IDbDatabase, MongoDbDatabase>();
        services.AddSingleton<CsvExporter>();
        services.AddSingleton<FamilyCollection>();
        services.AddSingleton<AddressCollection>();
        services.AddSingleton<PeopleCollection>();
        services.AddSingleton<EventsCollection>();
        services.AddSingleton<EventGiftCollection>();
        services.AddSingleton<FamilyEventGiftCollection>();
    })
    .Build();

var familyCollection = host.Services.GetService<FamilyCollection>();
var addressCollection = host.Services.GetService<AddressCollection>();

if(familyCollection == null || addressCollection == null)
{
    return;
}

await foreach (var family in familyCollection.GetEnumerable())
{
    if(family == null)
    {
        continue;
    }

    var address = await addressCollection
        .AsQueryable()
        .Where(x => x.FamilyId == family.Id)
        .FirstOrDefaultAsync();

    if(address == null)
    {
        continue;
    }

    address.IsPrimary = true;

    await addressCollection.AppendAsync(address);
}