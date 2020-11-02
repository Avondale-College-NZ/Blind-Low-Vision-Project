using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AuthSystem.Controllers
{
    public class MembersController : Controller
    {
        public IActionResult MembersList()
        {
            return View();
        }
    }
}
