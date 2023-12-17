using QraphQLSample.IServices;
using QraphQLSample.Models;

namespace QraphQLSample.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly List<Employee> _employees;

        public EmployeeService()
        {
            _employees = new List<Employee>();
        }

        public List<Employee> GetEmployees()
        {
            for (int i = 1; i <= 10; i++)
            {
                _employees.Add(new Employee() { Id = i,Name=$"Employee{i}",Age = i+20,PhoneNumber = $"{i}{i}{i}{i}{i}" });
            }
            return _employees;
        }
    }
}
