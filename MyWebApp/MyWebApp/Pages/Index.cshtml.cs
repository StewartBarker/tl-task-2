using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyWebApp.Pages
{
    public class Index : PageModel
    {
        public string testField { get; set; }

        public void OnGet()
        {
            testField = System.DateTime.Now.ToString();
        }

        public IActionResult OnPost(string getName)
        {
            return RedirectToPage("./Hello", new { name = getName });
        }
    }
}