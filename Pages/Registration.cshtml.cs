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
    public class Registration : PageModel
    {
        private readonly ILogger<Registration> _logger;
        private readonly MyDbContext _context;

        public Registration(ILogger<Registration> logger, MyDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public void OnGet()
        {
            _logger.LogInformation("IDI nahfas");
        }

        public IActionResult OnPost(string uname, string upassword, string uemail, int uage)
        {
            User userobj = new User(_context.Users.Count(),uname,upassword,uemail,uage);
            _context.Users.Add(userobj);
            _context.SaveChanges(); 
            return RedirectToPage("/Login");
        }

    }
}