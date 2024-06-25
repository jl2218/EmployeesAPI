using EmployeesAPI.Models;

namespace EmployeesAPI.Services.EmployeeServices
{
    public interface IEmployeeInterface
    {

        Task<ServiceResponse<List<EmployeeModel>>> GetEmployees();
        Task<ServiceResponse<EmployeeModel>> GetEmployeeById(int id);
        Task<ServiceResponse<EmployeeModel>> CreateEmployee(EmployeeModel newEmployee);        
        Task<ServiceResponse<EmployeeModel>> UpdateEmployee(EmployeeModel updatedEmployee);
        Task<ServiceResponse<string>> DeleteEmployee(int id);
        Task<ServiceResponse<EmployeeModel>> InactivateEmployee(int id);
        Task<ServiceResponse<EmployeeModel>> ActivateEmployee(int id);

    }
}
