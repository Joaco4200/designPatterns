public class StandardPayroll : IPayrollStrategy
{
    public double Calculate(Employee employee)
    {
        return employee.HoursWorked * employee.HourlyRate;
    }
}