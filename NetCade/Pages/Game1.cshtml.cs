using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.StaticFiles;

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

        //app.UseFileServer();
        //        StaticFileOptions option = new StaticFileOptions();
        //FileExtensionContentTypeProvider contentTypeProvider = (FileExtensionContentTypeProvider)option.ContentTypeProvider ??
        //new FileExtensionContentTypeProvider();
        //contentTypeProvider.Mappings.Add(".unityweb", "application/octet-stream");
        //        option.ContentTypeProvider = contentTypeProvider;
        //        app.UseStaticFiles(option);
    }
}
