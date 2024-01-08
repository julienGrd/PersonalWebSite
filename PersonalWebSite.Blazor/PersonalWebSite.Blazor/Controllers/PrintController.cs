using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using PersonalWebSite.Blazor.Client.Pages;
using PersonalWebSite.Blazor.Components;
//using PersonalWebSite.Blazor.Services;
//using WkHtmlToPdfDotNet;

namespace PersonalWebSite.Blazor.Controllers
{
    public class PrintController : Controller
    {
        //private BlazorRenderer _renderer;
        //public PrintController(BlazorRenderer renderer)
        //{
        //    _renderer = renderer;
        //}


        // GET: PrintController
        //[HttpGet]
        //[Route("print/cv/{lang}")]
        //public async Task<ActionResult> Cv(string lang)
        //{
        //    //get the html
        //    string html = await _renderer.RenderComponent<PageCvPrint>();

        //    //ajout du css
        //    html += @$"{Environment.NewLine}<link href='C:\Users\julie\source\repos\PersonalWebSite\PersonalWebSite.Blazor\PersonalWebSite.Blazor\wwwroot\css\site.min.css' rel='stylesheet'/>);"; 


        //    var converter = new SynchronizedConverter(new PdfTools());
        //    var doc = new HtmlToPdfDocument()
        //    {
        //        GlobalSettings = {
        //            ColorMode = ColorMode.Color,
        //            Orientation = Orientation.Portrait,
        //            PaperSize = PaperKind.A4,
        //        },
        //        Objects = {
        //            new ObjectSettings() {
        //                //PagesCount = true,
        //                HtmlContent = html,
        //                WebSettings = { DefaultEncoding = "utf-8" },
        //                //HeaderSettings = { FontSize = 9, Right = "Page [page] of [toPage]", Line = true, Spacing = 2.812 }
        //            }
        //        }
        //    };
        //    byte[] pdf = converter.Convert(doc);

        //    var cd = new ContentDispositionHeaderValue("attachment")
        //    {
        //        FileNameStar = $"cv_julien_gourdon_{lang}.pdf"
        //    };
        //    Response.Headers.Append(HeaderNames.ContentDisposition, cd.ToString());

        //    return File(pdf, "application/pdf");
        //}

    }
}
