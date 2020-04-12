using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Web;

namespace NetCade.Pages
{
    public class Game1Model : PageModel
    {
        [BindProperty]
        public string Time { get; set; }
        public void OnGet()
        {
            Time = DateTime.Now.ToShortTimeString();
        }
        //public void Link_Click()
        //{
        //    Response.ContentType = "application/octect-stream";
        //    Response.AppendHeader("content-disposition", "filename=SEP Game 1.exe");
        //    Response.TransmitFile(Server.MapPath("~/JellyRunBuild/Sep Game 1.exe"));
        //    Response.End();
        //}

    }
}
