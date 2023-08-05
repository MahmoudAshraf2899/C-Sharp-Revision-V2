// See https://aka.ms/new-console-template for more information
using MultiCast_Delegate.Services;
using static MultiCast_Delegate.Services.RectangleHelper;

Console.WriteLine("Hello, World!");
var helper = new RectangleHelper();
helper.GetArea(10m, 10m);
helper.GetPerimeter(10m, 10m);

//Multi Cast delegate will call the two methods at same time
Console.WriteLine("Multi Cast");

rectangleDelegate rectangle_Delegate;
rectangle_Delegate = helper.GetArea;
rectangle_Delegate += helper.GetPerimeter;
rectangle_Delegate(10, 10);

Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
Console.WriteLine($"After unsubscribing to rectangle delegate");
rectangle_Delegate -= helper.GetArea;
rectangle_Delegate(10, 10);
Console.WriteLine($"After unsubscribing to rectangle delegate");
Console.ReadKey();
