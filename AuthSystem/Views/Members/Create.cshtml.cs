using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AuthSystem.Data;
using AuthSystem.Models;

namespace AuthSystem.Views.Members
{
    public class CreateModel : PageModel
    {
        private readonly AuthSystem.Data.AuthSystemContext _context;

        public CreateModel(AuthSystem.Data.AuthSystemContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public MembersModel MembersModel { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.MembersModel.Add(MembersModel);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
