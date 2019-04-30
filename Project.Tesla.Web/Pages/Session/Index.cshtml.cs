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
    public class IndexModel : PageModel
    {

        public IList<Sessions> Session { get;set; }

        public async Task OnGetAsync()
        {
            Session.Add(new Sessions { Id = "1" });

        }
    }
}
