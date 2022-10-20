using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDBContext _dbContext;
        public HomeController(ILogger<HomeController> logger, AppDBContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public async Task<IActionResult> FriendsTable(string searched)
        {

            var search = from m in _dbContext.users select m; 

            if (!String.IsNullOrEmpty(searched))
            {
                search = search.Where(s => s.FirstName.Contains(searched));
            }

            return View(await search.ToListAsync());
        }

        public async Task<IActionResult> HomesTable(string searched)
        {

            var searchHome = from m in _dbContext.home select m;

            if (!String.IsNullOrEmpty(searched))
            {
                searchHome = searchHome.Where(s => s.HomeType.Contains(searched));
            }

            return View(await searchHome.ToListAsync());
        }

    }

}