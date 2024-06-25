using EmployeesAPI.DataContext;
using EmployeesAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeesAPI.Services.EmployeeServices
{
    public class EmployeeService : IEmployeeInterface
    {

        private readonly ApplicationDBContext _context;
        public EmployeeService(ApplicationDBContext context) 
        {
            _context = context;

        }

        public async Task<ServiceResponse<EmployeeModel>> ActivateEmployee(int id)
        {
            ServiceResponse<EmployeeModel> serviceResponse = new ServiceResponse<EmployeeModel>();

            try
            {
                EmployeeModel employee = _context.Employees.FirstOrDefault(x => x.Id == id);
                if (employee == null)
                {
                    serviceResponse.Success = false;
                    serviceResponse.Data = null;
                    serviceResponse.Message = "Usuário não localizado!";
                    return serviceResponse;
                }

                employee.Active = true;
                employee.LastUpdated = DateTime.Now.ToLocalTime();

                _context.Employees.Update(employee);
                await _context.SaveChangesAsync();

                serviceResponse.Data = employee;
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }

            return serviceResponse;
        }

        public async Task<ServiceResponse<EmployeeModel>> CreateEmployee(EmployeeModel newEmployee)
        {
            ServiceResponse<EmployeeModel> serviceResponse = new ServiceResponse<EmployeeModel>();
            try
            {
                if(newEmployee == null) 
                {
                    serviceResponse.Success = false;
                    serviceResponse.Message = "Dados não informados";
                    serviceResponse.Data = null;

                    return serviceResponse;
                }

                _context.Add(newEmployee);
                await _context.SaveChangesAsync();

                serviceResponse.Data = newEmployee;
            } catch (Exception ex) 
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }

            return serviceResponse;
        }

        public async Task<ServiceResponse<string>> DeleteEmployee(int id)
        {
            ServiceResponse<string> serviceResponse = new ServiceResponse<string>();
            try
            {
                EmployeeModel employee = _context.Employees.AsNoTracking().FirstOrDefault(x => x.Id == id);
                if (employee == null)
                {
                    serviceResponse.Success = false;
                    serviceResponse.Data = null;
                    serviceResponse.Message = "Usuário não localizado!";
                    return serviceResponse;
                }

                _context.Employees.Remove(employee);
                await _context.SaveChangesAsync();
                serviceResponse.Message = "Deletado com sucesso!";
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }

            return serviceResponse;
        }

        public async Task<ServiceResponse<EmployeeModel>> GetEmployeeById(int id)
        {
            ServiceResponse<EmployeeModel> serviceResponse = new ServiceResponse<EmployeeModel>();
            try
            {
                EmployeeModel employee = _context.Employees.FirstOrDefault(x => x.Id == id);

                if(employee == null)
                {
                    serviceResponse.Success = false;
                    serviceResponse.Data= null;
                    serviceResponse.Message = "Usuário não localizado!";
                    return serviceResponse;
                }

                serviceResponse.Data = employee;
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }

            return serviceResponse;
        }

        public async Task<ServiceResponse<List<EmployeeModel>>> GetEmployees()
        {
            ServiceResponse<List<EmployeeModel>> serviceResponse = new ServiceResponse<List<EmployeeModel>>();
            try
            {
                serviceResponse.Data = _context.Employees.ToList(); 
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }

            return serviceResponse;
        }

        public async Task<ServiceResponse<EmployeeModel>> InactivateEmployee(int id)
        {
            ServiceResponse<EmployeeModel> serviceResponse = new ServiceResponse<EmployeeModel>();

            try
            {
                EmployeeModel employee = _context.Employees.FirstOrDefault(x => x.Id == id);
                if (employee == null)
                {
                    serviceResponse.Success = false;
                    serviceResponse.Data = null;
                    serviceResponse.Message = "Usuário não localizado!";
                    return serviceResponse;
                }

                employee.Active = false;
                employee.LastUpdated = DateTime.Now.ToLocalTime();

                _context.Employees.Update(employee);
                await _context.SaveChangesAsync();

                serviceResponse.Data = employee;
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }

            return serviceResponse;
        }

        public async Task<ServiceResponse<EmployeeModel>> UpdateEmployee(EmployeeModel updatedEmployee)
        {
            ServiceResponse<EmployeeModel> serviceResponse = new ServiceResponse<EmployeeModel>();

            try
            {
                EmployeeModel employee = _context.Employees.AsNoTracking().FirstOrDefault(x => x.Id == updatedEmployee.Id);
                if (employee == null)
                {
                    serviceResponse.Success = false;
                    serviceResponse.Data = null;
                    serviceResponse.Message = "Usuário não localizado!";
                    return serviceResponse;
                }

                updatedEmployee.LastUpdated = DateTime.Now.ToLocalTime();
                _context.Employees.Update(updatedEmployee);
                await _context.SaveChangesAsync();

                serviceResponse.Data = updatedEmployee;
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }

            return serviceResponse;
        }
    }
}
