using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models;
using Services;

namespace MyFirstRazor.Pages
{
    public class MyPageModel : PageModel   //ta hand om HTTP request
    {
        ICoolLists service = null;

        public string Greetings { get; set; } = "Hello everyone!";
        public List<LatinSentence> Latin { get; set; }
        // public int LoopMax { get; set; } = 10;

        public void OnGet()
        {
            ViewData["Title"] = "Quan's Page";

            var seeder = new csSeedGenerator();

            Latin = service.LatinSentences.Take(5).ToList();
            //Latin = seeder.LatinSentences(10);
        }
        public MyPageModel(ICoolLists service)
        {
            this.service = service;
        }
    }
}
