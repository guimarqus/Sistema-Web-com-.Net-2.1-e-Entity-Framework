using SalesWebMvc.Data;
using System.Collections.Generic;
using SalesWebMvc12.Models;
using System.Linq;

namespace SalesWebMvc12.Services
{
    public class DepartmentService
    {

        private readonly SalesWebMvcContext _context;

        public DepartmentService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }

    }
}
