using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SoftwareMaintenanceAPI.Models;

namespace SoftwareMaintenanceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmpContext _context;

        public EmployeeController(EmpContext context)
        {
            _context = context;
        }
        
        [HttpGet("GetAllEmployees")]
        public async Task<IActionResult> GetAllEmployees()
        {
            return Ok(await _context.Employees.ToListAsync());
        }

        [HttpPost("AddEmployee")]
        public async Task<IActionResult> AddEmployee(Employee employee)
        {
            await _context.Employees.AddAsync(employee);
            await _context.SaveChangesAsync();
            return Ok(employee);
        }
    }
}
