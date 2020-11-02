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
    public class DeleteModel : PageModel
    {
        private readonly AuthSystem.Data.AuthSystemContext _context;

        public DeleteModel(AuthSystem.Data.AuthSystemContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MembersModel = await _context.MembersModel.FindAsync(id);

            if (MembersModel != null)
            {
                _context.MembersModel.Remove(MembersModel);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
