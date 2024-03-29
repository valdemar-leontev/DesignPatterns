using System.Text;

namespace BuilderPattern;

public class EmployeeReport
{
    public string Header { get; set; }

    public string Body { get; set; }

    public string Footer { get; set; }

    public override string ToString()
    {
        return new StringBuilder()
            .Append(Header)
            .Append(Body)
            .Append(Footer)
            .ToString();
    }
}