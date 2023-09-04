using Generics.Services;

T print<T>(T value)
{
    return value;
}

print("Mahmoud");
print(true);
print(123);
print(new { });


var numbers = new Any<int>();
numbers.AddItems(1);
numbers.AddItems(2);
numbers.AddItems(3);
numbers.DisplayList();
