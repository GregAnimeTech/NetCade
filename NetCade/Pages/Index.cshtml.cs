using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using NetCade.Data;
using NetCade.Models;
using Microsoft.EntityFrameworkCore;

namespace NetCade.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        /*For game database*/
        //private readonly NetCadeContext db;
        //public IndexModel(NetCadeContext db) => this.db = db;
        //public List<UserAccount> UserAccount { get; set; } = new List<UserAccount>();
        //public UserAccount FeaturedUserName { get; set; }
        //public async Task OnGetAsync()
        //{
        //    UserAccount = await db.UserAccounts.ToListAsync();
        //    FeaturedUserName = UserAccount.ElementAt(new Random().Next(UserAccount.Count));
        //}

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public string Time { get; set; }
        public void OnGet()
        {
            Time = DateTime.Now.ToShortTimeString();
        }
    }
}
