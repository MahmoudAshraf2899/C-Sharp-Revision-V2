using HashSets_SortedLists.services;
using System.Numerics;
using System.Xml.Linq;

#region HashSets
var customersList = new List<customers>
{
  new customers { Name = "Ahmed", Phone = "01004516578" },
  new customers { Name = "Ahmed", Phone = "01004516578" },
  new customers { Name = "Mahmoud", Phone = "01007821111" },
  new customers { Name = "Ayman", Phone = "01148851666" },
  new customers { Name = "Hend", Phone = "01254624159" },
  new customers { Name = "Hend", Phone = "01254624159" },
};
Console.WriteLine("Hashsets");
Console.WriteLine("------------");
var customerHashSet1 = new HashSet<customers>(customersList);

//Hash Set avoid Duplicates values 
foreach (var item in customerHashSet1)
{
	Console.WriteLine(item.ToString());
}

//var customer1 = new customers { Name = "Mahmoud", Phone = "01007821111" };
//var customer2 = new customers { Name = "Mahmoud", Phone = "01007821111" };
//Console.WriteLine(customer1.Name.GetHashCode());
//Console.WriteLine(customer1.Equals(customer2));
//Console.WriteLine(object.ReferenceEquals(customer1, customer2)); 
#endregion

#region Sorted List
Console.WriteLine("Sorted Set");
Console.WriteLine("------------");

var customerSortedList = new SortedSet<customers>(customersList);
foreach (var item in customerSortedList)
{
    Console.WriteLine(item.ToString());
}


#endregion
Console.ReadKey();