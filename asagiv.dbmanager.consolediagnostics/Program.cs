// See https://aka.ms/new-console-template for more information
using asagiv.dbmanager.common.Models;
using asagiv.dbmanager.common.MongoDB;
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;

Console.WriteLine("Initializing Console Diagnostics");

// Initialize Mongo Client
MongoDbClient.Instance.ConnectAsync("mongodb://192.168.4.4:27017");

// Initialize Address Book Database
var addressBookDatabase = MongoDbClient.Instance.GetMongoDatabase("AddressBook");

// Initialize Collections
var familiesCollection = addressBookDatabase?.GetCollection<Family>("Families");
var addressesCollection = addressBookDatabase?.GetCollection<Address>("Addresses");
var peopleCollection = addressBookDatabase?.GetCollection<Person>("People");
var eventCollection = addressBookDatabase?.GetCollection<EventInfo>("Events");
var eventGiftCollection = addressBookDatabase?.GetCollection<EventGift>("EventGifts");
var familyEventGiftCollection = addressBookDatabase?.GetCollection<FamilyEventGift>("FamilyEventGift");

// Create Rob's baby gift event info.
var eventInfo = new EventInfo
{
    EventName = "Rob's Birth",
    Description = "Baby gifts from when Rob was born."
};

eventCollection?.InsertOne(eventInfo);

Family[] families;
Address[] addresses;
Person[] people;
EventGift[] eventGifts;
FamilyEventGift[] familyEventGifts;

// Import the Families.
using (var reader = new StreamReader(@"C:\Users\DonSa\Desktop\PgBackup\Families\_Families__202202131353.csv"))
{
    using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

    csv.Context.RegisterClassMap<ClassMapFamily>();
    families = csv.GetRecords<Family>().ToArray();

    familiesCollection?.InsertMany(families);
}

// Import the addresses.
using(var reader = new StreamReader(@"C:\Users\DonSa\Desktop\PgBackup\Addresses\_Addresses__202202131351.csv"))
{
    using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

    csv.Context.RegisterClassMap<ClassMapAddress>();
    addresses = csv.GetRecords<Address>().ToArray();

    foreach (var address in addresses)
    {
        // address.FamilyId = families.First(x => x.OldFamilyId == address.OldFamilyId).Id;
    }

    addressesCollection.InsertMany(addresses);
}

// Import people
using (var reader = new StreamReader(@"C:\Users\DonSa\Desktop\PgBackup\People\_Person__202202131354.csv"))
{
    using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

    csv.Context.RegisterClassMap<ClassMapPerson>();
    people = csv.GetRecords<Person>().ToArray();

    foreach (var person in people)
    {
        // person.FamilyId = families.First(x => x.OldFamilyId == person.OldFamilyId).Id;
    }

    peopleCollection.InsertMany(people);
}

// Import Gifts
using (var reader = new StreamReader(@"C:\Users\DonSa\Desktop\PgBackup\BabyGifts\_BabyGifts__202202131352.csv"))
{
    using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

    csv.Context.RegisterClassMap<ClassMapEventGift>();
    eventGifts = csv.GetRecords<EventGift>().ToArray();

    eventGiftCollection.InsertMany(eventGifts);
 }

// Import Joined Family-Event-Gifts
using (var reader = new StreamReader(@"C:\Users\DonSa\Desktop\PgBackup\FamilyBabyGifts\_FamilyBabyGifts__202202131353.csv"))
{
    using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

    csv.Context.RegisterClassMap<ClassMapFamilyEventGift>();
    familyEventGifts = csv.GetRecords<FamilyEventGift>().ToArray();

    foreach(var familyEventGift in familyEventGifts)
    {
        familyEventGift.EventId = eventInfo.Id;
        // familyEventGift.FamilyId = families.First(x => x.OldFamilyId == familyEventGift.OldFamilyId).Id;
        // familyEventGift.GiftId = eventGifts.First(x => x.OldGiftId == familyEventGift.OldGiftId).Id;
    }

    familyEventGiftCollection.InsertMany(familyEventGifts);
}

Console.ReadLine();

public class ClassMapFamily : ClassMap<Family>
{
    public ClassMapFamily()
    {
        // Map(x => x.OldFamilyId).Index(0);
        Map(x => x.FamilyName).Index(1);
        Map(x => x.AddressHeader).Index(2);
    }
}

public class ClassMapAddress : ClassMap<Address>
{
    public ClassMapAddress()
    {
        // Map(x => x.OldFamilyId).Index(1);
        Map(x => x.Street).Index(2);
        Map(x => x.City).Index(3);
        Map(x => x.State).Index(4);
        Map(x => x.Zip).Index(5);
        Map(x => x.Country).Index(6);
    }
}

public class ClassMapPerson : ClassMap<Person>
{
    public ClassMapPerson()
    {
        // Map(x => x.OldFamilyId).Index(1);
        Map(x => x.Name).Index(2);
        Map(x => x.DateOfBirth).Index(3);
    }
}

public class ClassMapEventGift : ClassMap<EventGift>
{
    public ClassMapEventGift()
    {
        // Map(x => x.OldGiftId).Index(0);
        Map(x => x.GiftDescription).Index(1);
    }
}

public class ClassMapFamilyEventGift : ClassMap<FamilyEventGift>
{
    public ClassMapFamilyEventGift()
    {
        // Map(x => x.OldFamilyId).Index(1);
        // Map(x => x.OldGiftId).Index(2);
        Map(x => x.ThankYouNoteWritten).Index(3);
    }
}