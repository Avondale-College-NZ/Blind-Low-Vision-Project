using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AuthSystem.Data;
using AuthSystem.Models;

namespace AuthSystem.Views.Members
{
    public class DetailsModel : PageModel
    {
        private readonly AuthSystem.Data.AuthSystemContext _context;

        public DetailsModel(AuthSystem.Data.AuthSystemContext context)
        {
            _context = context;
        }

        public MembersModel MembersModel { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MembersModel = await _context.MembersModel.FirstOrDefaultAsync(m => m.ID == id);

            if (MembersModel == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
