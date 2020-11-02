using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AuthSystem.Models;

namespace AuthSystem.Data
{
    public class AuthSystemContext : DbContext
    {
        public AuthSystemContext (DbContextOptions<AuthSystemContext> options)
            : base(options)
        {
        }

        public DbSet<AuthSystem.Models.MembersModel> MembersModel { get; set; }
    }
}
