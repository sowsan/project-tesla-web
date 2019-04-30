using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Project.Tesla.Web.Models;

namespace Project.Tesla.Web.Pages.Session
{
    public class DetailsModel : PageModel
    {
        public Sessions Session { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        // //   Session = await _context.Session.FirstOrDefaultAsync(m => m.Id == id);

        //    if (Session == null)
        //    {
        //        return NotFound();
        //    }
            return Page();
        }
    }
}
