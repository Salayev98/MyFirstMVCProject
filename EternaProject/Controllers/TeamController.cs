using EternaProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EternaProject.Controllers
{
    public class TeamController:Controller
    {
        private List<Team> _teams;
        public TeamController()
        {
            _teams = new List<Team>
            {
                new Team{Id=1, Name="Walter White", Profession="Chief Executive Officer", About="Magni qui quod omnis unde et eos fuga et exercitationem. Odio veritatis perspiciatis quaerat qui aut aut aut", Image="team-1.jpg"},
                new Team{Id=2, Name="Sarah Jhinson", Profession="Product Manager", About="Repellat fugiat adipisci nemo illum nesciunt voluptas repellendus. In architecto rerum rerum temporibus", Image="team-2.jpg"},
                new Team{Id=3, Name="William Anderson", Profession="CTO", About="Voluptas necessitatibus occaecati quia. Earum totam consequuntur qui porro et laborum toro des clara", Image="team-3.jpg"},
               
            };
        }
        public IActionResult Index()
        {
            return View(_teams);
        }

        public IActionResult Detail(int id)
        {
            Team teamdetail = _teams.Find(x => x.Id == id);
            return View(teamdetail);
        }
    }
}
