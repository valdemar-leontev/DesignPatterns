namespace BuilderPattern;

public class EmployeeReportBuilder : IEmployeeReportBuilder
{
    private EmployeeReport _employeeReport;

    private readonly IEnumerable<Employee> _employees;

    public EmployeeReportBuilder(IEnumerable<Employee> employees)
    {
        _employees = employees;
        _employeeReport = new EmployeeReport();
    }
    
    public IEmployeeReportBuilder BuildHeader()
    {
        _employeeReport.Header = $"EMPLOYEES REPORT ON DATE: {DateTime.Now}\n\n";

        return this;
    }

    public IEmployeeReportBuilder BuildBody()
    {
        _employeeReport.Body = string.Join(Environment.NewLine,
            _employees.Select(e => $"Name: {e.Name}\nSalary: {e.Salary} $")
        );
        
        return this;
    }

    public IEmployeeReportBuilder BuildFooter()
    {
        _employeeReport.Footer = $"\n\nTOTAL EMPLOYEES: {_employees.Count()}\n" +
                                 $"TOTAL SALATY: {_employees.Sum(e => e.Salary)} $";
        
        return this;
    }

    public EmployeeReport GetReport()
    {
        var employeeReport = _employeeReport;

        _employeeReport = new EmployeeReport();

        return employeeReport;
    }
}