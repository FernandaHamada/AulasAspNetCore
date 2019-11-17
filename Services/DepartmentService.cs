using AulasAspNetCore.Models;
using Microsoft.EntityFrameworkCore;
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

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
