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
    public class IndexModel : PageModel
    {
        private readonly AuthSystem.Data.AuthSystemContext _context;

        public IndexModel(AuthSystem.Data.AuthSystemContext context)
        {
            _context = context;
        }

        public IList<MembersModel> MembersModel { get;set; }

        public async Task OnGetAsync()
        {
            MembersModel = await _context.MembersModel.ToListAsync();
        }
    }
}
