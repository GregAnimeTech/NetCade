using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NetCade.Pages
{
    public class Game1Model : PageModel
    {
        public string Time { get; set; }
        public void OnGet()
        {
            Time = DateTime.Now.ToShortTimeString();
        }
    }
}
