using Microsoft.AspNetCore.Mvc;
using SportsManagement.Models;
using SportsManagement.PersistenceModels;
using System.Linq;

namespace SportsManagement.Controllers
{
    public class SportsController : Controller
    {
        private SportsManagementContext _context;
        public SportsController(SportsManagementContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ViewSportsPersons()
        {
            var sportsPersons = _context.SportsPersons.ToList();
            var model = sportsPersons.Select(x => new SportsPersonViewModel
            {
                Id = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName,
                PlayingProfessionallySince = x.PlayingProfessionallySince,
                AssociatedSports = x.AssociatedSports,
                GravatarUrl = x.GravatarUrl,
                IsActive = x.IsActive
            }).ToList();

            return PartialView("_SportsPersonsListPartial", model);
        }
    }
}