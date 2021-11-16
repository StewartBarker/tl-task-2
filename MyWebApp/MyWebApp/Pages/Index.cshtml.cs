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
       
        public bool IsEmpty;
        public void OnGet()
        {
           
        }

        public IActionResult OnPost(string getName)
        {
            if (string.IsNullOrEmpty(getName))
            {
                IsEmpty = true;
                return Page();

            }

            


            return RedirectToPage("./Hello", new { name = getName });
        }
    }
}