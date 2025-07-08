public class EmployeeManager
{
    private List<Employee> employees = new List<Employee>();
    private IPayrollStrategy payrollStrategy;

    public void SetPayrollStrategy(IPayrollStrategy strategy)
    {
        payrollStrategy = strategy;
    }

    public void AddEmployee(Employee employee)
    {
        employees.Add(employee);
    }

    public double CalculateTotalPayroll()
    {
        double total = 0;
        foreach (var employee in employees)
        {
            total += payrollStrategy.Calculate(employee);
        }
        return total;
    }
}