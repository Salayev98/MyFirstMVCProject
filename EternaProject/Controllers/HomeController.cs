

using EternaProject.Models;
using EternaProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EternaProject.Controllers
{
    
    public class HomeController : Controller
    {
        private List<Services> _services;

        public HomeController()
        {

            _services= new List<Services>
            {
                new Services{Id=1, Title="Lorem Ipsum", Icon="bx bxl-dribbble", Text="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"},
                new Services{Id=2, Title="Sed ut perspiciatis", Icon="bx bx-file", Text="Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore"},
                new Services{Id=3, Title="Magni Dolores", Icon="bx bx-tachometer", Text="Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia"},
                new Services{Id=4, Title="Nemo Enim", Icon="bx bx-world", Text="At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis"},
                new Services{Id=5, Title="Dele cardo", Icon="bx bx-slideshow", Text="Quis consequatur saepe eligendi voluptatem consequatur dolor consequuntur"},
                new Services{Id=6, Title="Divera don", Icon="bx bx-arch", Text="Modi nostrum vel laborum. Porro fugit error sit minus sapiente sit aspernatur"}
            };
        }

        public IActionResult Index()
        {
            List<Sliders> sliders = new List<Sliders>
            {
                new Sliders{Id=1, Title1="Welcome to ", Title2="Eterna", Content="Ut velit est quam dolor ad a aliquid qui aliquid. Sequi ea ut et est quaerat sequi nihil ut aliquam. Occaecati alias dolorem mollitia ut. Similique ea voluptatem. Esse doloremque accusamus repellendus deleniti vel. Minus et tempore modi architecto.", Image="slide-1.jpg", RedirectUrl="https://en.wikipedia.org/wiki/ASP.NET#Versions"},
                new Sliders{Id=2, Title1="Lorem Ipsum ", Title2="Dolor", Content="Ut velit est quam dolor ad a aliquid qui aliquid. Sequi ea ut et est quaerat sequi nihil ut aliquam. Occaecati alias dolorem mollitia ut. Similique ea voluptatem. Esse doloremque accusamus repellendus deleniti vel. Minus et tempore modi architecto.", Image="slide-2.jpg", RedirectUrl="https://en.wikipedia.org/wiki/ASP.NET#Programming_models"},
                new Sliders{Id=3, Title1="Sequi ea ", Title2="Dime Lara", Content="Ut velit est quam dolor ad a aliquid qui aliquid. Sequi ea ut et est quaerat sequi nihil ut aliquam. Occaecati alias dolorem mollitia ut. Similique ea voluptatem. Esse doloremque accusamus repellendus deleniti vel. Minus et tempore modi architecto.", Image="slide-3.jpg", RedirectUrl="https://en.wikipedia.org/wiki/ASP.NET#References"}
            };
            List<Feautures> feautures = new List<Feautures>
            {
                new Feautures{Id=1, Title="Lorem Ipsum", Content="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident", Logo="bi bi-card-checklist"},
                new Feautures{Id=2, Title="Dolor Sitema", Content="Minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat tarad limino ata", Logo="bi bi-bar-chart"},
                new Feautures{Id=3, Title="Sed ut perspiciatis", Content="Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur", Logo="bi bi-binoculars"}
            };
            
            HomeViewModels homeVM = new HomeViewModels
            {
                Services = _services,
                Feautures = feautures,
                Sliders=sliders
            };
            return View(homeVM);
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Services()
        {
            return View(_services);
        }
        public IActionResult Portfolio()
        {
            return View();
        }
       



    }
}
