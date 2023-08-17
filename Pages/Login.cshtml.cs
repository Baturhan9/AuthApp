using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace AuthApp.Pages
{
    public class Login : PageModel
    {
        private readonly ILogger<Login> _logger;
        private readonly MyDbContext _context;

        public Login(ILogger<Login> logger, MyDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost(string loginName, string loginPassword)
        {
            var userobj = _context.Users.FirstOrDefault(x => x.UName == loginName && x.UPassword == loginPassword);
            if(userobj == null)
            {
                // ViewData["Not Found User"] = "Not correct Name or Password";
                return RedirectToPage();
            }

            return RedirectToPage("/MainPage");
        }
    }
}