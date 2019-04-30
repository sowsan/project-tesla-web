using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Project.Tesla.Web.Models;
using Project.Tesla.Web.ApiClients;

namespace Project.Tesla.Web.Pages.Session
{
    public class CreateModel : PageModel
    {     

        public IActionResult OnGet()        {
            
            return Page();
        }

        [BindProperty]
        public Sessions Session { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            SessionAPI sessionApi = new SessionAPI();

            string sessionId = await sessionApi.CreateSession(Session);

           // _context.Session.Add(Session);
           // await _context.SaveChangesAsync();
        
           return RedirectToPage("./Details", new { id = sessionId });
        }
    }
}