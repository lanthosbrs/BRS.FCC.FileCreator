using BRS.FCC.FileCreator;
using CsvHelper;
using System.Globalization;


Console.WriteLine("Hello, World! Lets create a file");


int startingNumber = 1349428793;
int endingNumber   = 1349459425;

int count = endingNumber - startingNumber;

IEnumerable<int> allLocationCodes = Enumerable.Range(startingNumber, count);
var records = new List<FCCEntry>();

foreach (var i in allLocationCodes)
{
    records.Add(new FCCEntry(i.ToString()));
}


using (var writer = new StreamWriter("C:\\Users\\brian\\OneDrive\\Desktop\\fcc_submission.csv"))
using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
{
    csv.WriteRecords(records);
}

Console.WriteLine("Finished!");
