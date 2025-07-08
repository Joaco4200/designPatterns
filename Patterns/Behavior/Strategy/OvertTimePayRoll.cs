public class OvertimePayroll : IPayrollStrategy
{
    public double Calculate(Employee employee)
    {
        int overtimeThreshold = 40;
        if (employee.HoursWorked <= overtimeThreshold)
        {
            return employee.HoursWorked * employee.HourlyRate;
        }

        int regularHours = overtimeThreshold;
        int overtimeHours = employee.HoursWorked - regularHours;
        return (regularHours * employee.HourlyRate) +
               (overtimeHours * employee.HourlyRate * 1.5);
    }
}