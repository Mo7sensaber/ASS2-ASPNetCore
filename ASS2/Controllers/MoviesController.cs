using Microsoft.AspNetCore.Mvc;
using System;
namespace ASS2.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult GetMovie(int[] arr )
        {
            return Content($"your id is ");
        }
        public IActionResult index()
        {
            //ContentResult result = new ContentResult();
            //result.Content = "hallo from index";
            return Content("welcome", "text/html");
        }
        public IActionResult Test()
        {
            //RedirectResult result =new RedirectResult();
            //return RedirectToRoute(nameof(index));
            return RedirectToRoute(new { Controller = "Movies", Action = "index" });
        }
    }
}
