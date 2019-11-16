using AulasAspNetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulasAspNetCore.Services
{
    public class DepartmentService
    {
        private readonly AulasAspNetCoreContext _context;

        public DepartmentService(AulasAspNetCoreContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
