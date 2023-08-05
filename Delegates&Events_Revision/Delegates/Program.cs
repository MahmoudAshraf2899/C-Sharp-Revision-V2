using Delegates.Services;

var emp = new Employee[]
{
    new Employee { Id = 1,Name="Mahmoud",Gender="Male",totalSales=1500m},
    new Employee { Id = 2,Name="Ahmed",Gender="Male",totalSales=1160m},
    new Employee { Id = 3,Name="Ali",Gender="Male",totalSales=2450m},
    new Employee { Id = 4,Name="Abdo",Gender="Male",totalSales=2600m},
    new Employee { Id = 5,Name="Sara",Gender="Female",totalSales=950m},
    new Employee { Id = 6,Name="Omnia",Gender="Female",totalSales=1480m},
};

//Our Goal Is : Three Reports 
// 1-) List Of Employees that there total sales more than 1000
// 2-) List Of Employees That there total sales more than 800 and less than 1500
// 3-) List Of Employees That There total sales less than 3000


var report = new Reports();
#region Before Create Delegate
//report.ProcessEmployeeWithBigThan1000(emp);
//report.ProcessEmployeeWithTotalSalesLessThan1500AndMoreThan800(emp);
//report.ProcessEmployeeWithTotalSalesLessThan3000(emp); 
#endregion

report.processEmployees(emp, "sales more than 1000", IsGreaterThan1000);
report.processEmployees(emp, "sales more than 800 and less than 1500", IsGreaterThan800andLessThan1500);
report.processEmployees(emp, "sales less than 3000", IsLessThan3000);


#region Anonymous Delegate
report.processEmployees(emp, "sales more than 1000 Using Anonymous Delegate", delegate (Employee e) { return e.totalSales > 1000; });
report.processEmployees(emp, "sales more than 800 and less than 1500 Using Anonymous Delegate", delegate (Employee e) { return e.totalSales >= 800 && e.totalSales <= 1500; });
report.processEmployees(emp, "sales less than 3000 Using Anonymous Delegate", delegate (Employee e) { return e.totalSales < 3000; });
#endregion




#region Lambda Expression
report.processEmployees(emp, "sales more than 1000 Using Lambda Expression", (Employee e) => e.totalSales > 1000m);
report.processEmployees(emp, "sales more than 800 and less than 1500 Using Lambda Expression", (Employee e) => e.totalSales >= 800m && e.totalSales <= 1500m);
report.processEmployees(emp, "sales less than 3000 Using Lambda Expression", (Employee e) => e.totalSales < 3000m);
#endregion


#region More And More
report.processEmployees(emp, "sales more than 1000 ", e => e.totalSales > 1000m);
report.processEmployees(emp, "sales more than 800 and less than 1500 ", e => e.totalSales >= 800m && e.totalSales <= 1500m);
report.processEmployees(emp, "sales less than 3000 ", e => e.totalSales < 3000m);
#endregion

Console.ReadKey();

static bool IsGreaterThan1000(Employee e) => e.totalSales >= 1000;
static bool IsGreaterThan800andLessThan1500(Employee e) => e.totalSales >= 800 && e.totalSales <= 1500;
static bool IsLessThan3000(Employee e) => e.totalSales < 3000;