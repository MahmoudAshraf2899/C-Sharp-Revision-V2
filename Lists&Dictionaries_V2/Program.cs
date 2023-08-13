#region List
using Lists_Dictionaries_V2.Services;

//var egypt = new Country { ISOCode = "EGY", Name = "Egypt" };
//var jordan = new Country { ISOCode = "JOR", Name = "Jordan" };
//var iraq = new Country { ISOCode = "IRQ", Name = "Iraq" };

//Country[] countriesArr =
//{
//	egypt, jordan, iraq
//};

////Constructor
//List<Country> countries = new List<Country>();
////List<Country> countries = new List<Country>(3); //List Capacity Is 3
//countries.Add(countriesArr[0]);
//countries.Add(new Country { ISOCode = "ENG", Name = "England" }); //This Will Add Item in the End Of List //O(1)
//countries.AddRange(countriesArr);//Also Add Items in The End Of List
//								 //insert is bad at performance
//countries.Insert(0, new Country { ISOCode = "USA", Name = "America" });//O(n)
//																	   //Props (Look At Country Class > Print Method)
//Country.print(countries);


////Methods
////Remove Element From List
//countries.RemoveAt(4);
//countries.RemoveAll(x => x.Name.EndsWith("ce"));

#endregion


#region Dictionary
var article = "Lorem Ipsum is simply dummy text of the printing and typesetting industry." +
    " Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, " +
    "when an unknown printer took a galley of type and scrambled it to make a type specimen book";

//Get How much character called in every word
//Key = o, Value  = Lorem
Dictionary<char, List<string>> letterDictionary = new Dictionary<char, List<string>>();
foreach (var word in article.Split())
{
    foreach (var ch in word)
    {
        if (!letterDictionary.ContainsKey(ch))
        {
            letterDictionary.Add(ch, new List<string> { word });
        }
        else
        {
            letterDictionary[ch].Add(word);
        }
    }
}
foreach (var entry in letterDictionary)
{
    Console.Write($"'{entry.Key}': ");
    foreach (var word in entry.Value)
    {
        Console.WriteLine($"\t\t \"{word}\"");
    }
}

#endregion