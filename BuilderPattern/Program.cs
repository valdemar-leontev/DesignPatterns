using BuilderPattern;

var employees = new List<Employee>()
{
    new Employee { Name = "Ivan 3", Salary = 100 },
    new Employee { Name = "Petr 1", Salary = 200 }
};

var builder = new EmployeeReportBuilder(employees);

var director = new EmployeeReportDirector(builder);

director.Build();

var report = builder.GetReport();

Console.WriteLine(report);