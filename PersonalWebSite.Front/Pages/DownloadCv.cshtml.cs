using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace PersonalWebSite.Front.Pages
{
    public class DownloadCvModel : PageModel
    {

        public async Task<IActionResult> OnGet([FromServices] IWebHostEnvironment webHostEnvironment)
        {
            //var fileName = "cv Julien Gourdon.pdf";
            //var cssFileLocations = new List<string>() { Path.Combine(webHostEnvironment.WebRootPath, "css", "site.min.css"), Path.Combine(webHostEnvironment.WebRootPath, "css", "bootstrap.min.css") };
            //var jsFileLocations = new List<string>();
            //var llBase64Results = await blazorPdf.GetBlazorInPdfBase64<CvPrint>(x => { }, fileName, cssFileLocations, jsFileLocations);

            //return File(Convert.FromBase64String(llBase64Results), "application/pdf", fileName);

            return NotFound();
        }
    }
}
