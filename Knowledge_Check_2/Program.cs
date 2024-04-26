// See https://aka.ms/new-console-template for more information
using Knowledge_Check_2;
using System.Text.Json;

Console.WriteLine("How many records do you want to add? ");
var numberOfRecords = int.Parse(Console.ReadLine());

var recordList = new List<CityAddress>();
for (int i = 0; i < numberOfRecords; i++)
{
    // In this loop, populate the object's properties using Console.ReadLine()
    CityAddress address = new CityAddress();

    Console.WriteLine("Enter the values for your address " +
        "(State, zip code, city, street name, street number).");
    address.State = Console.ReadLine();
    address.ZipCode = Console.ReadLine();
    address.CityName = Console.ReadLine();
    address.StreetName = Console.ReadLine();
    address.StreetNumber = Console.ReadLine();

    recordList.Add(address);
    recordList.ToString();
    
    
}
    
// Print out the list of records using Console.WriteLine()

Console.WriteLine($"{JsonSerializer.Serialize(recordList)} has been added.");

Console.ReadKey();