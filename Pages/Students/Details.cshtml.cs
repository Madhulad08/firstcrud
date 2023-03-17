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
    public class DetailsModel : PageModel
    {
        private readonly firstcrud.Data.firstcrudContext _context;

        public DetailsModel(firstcrud.Data.firstcrudContext context)
        {
            _context = context;
        }

      public student student { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.student == null)
            {
                return NotFound();
            }

            var student = await _context.student.FirstOrDefaultAsync(m => m.Id == id);
            if (student == null)
            {
                return NotFound();
            }
            else 
            {
                student = student;
            }
            return Page();
        }
    }
}
