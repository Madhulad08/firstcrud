using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using firstcrud.Data;
using firstcrud.model;

namespace firstcrud.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly firstcrud.Data.firstcrudContext _context;

        public IndexModel(firstcrud.Data.firstcrudContext context)
        {
            _context = context;
        }

        public IList<student> student { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.student != null)
            {
                student = await _context.student.ToListAsync();
            }
        }
    }
}
