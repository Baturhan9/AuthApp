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

        public Registration(ILogger<Registration> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            _logger.LogInformation("IDI nahfas");
        }

        public IActionResult OnPost(string uname, string upassword, string uemail, int age)
        {
            
            return RedirectToPage("/Login");
        }

    }
}