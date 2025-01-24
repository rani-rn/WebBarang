using Barang.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using System.Diagnostics;

namespace Barang.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        private readonly IMemoryCache _memoryCache;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context, IMemoryCache memoryCache)
        {
            _logger = logger;
            _context = context;
            _memoryCache = memoryCache;
        }

        public async Task<IActionResult> Index()
        {
            List<CardViewModel> cards;

            if (!_memoryCache.TryGetValue("itemsCache", out cards))
            {
                var items = await _context.Items
                    .AsNoTracking()
                    .Include(i => i.Category)
                    .ToListAsync();

                cards = items.Select(item => new CardViewModel
                {
                    ItemId = item.ItemId,
                    Title = item.ItemName,
                    BadgeText = item.ItemStatus == true ? null : "Sold",
                    ImageUrl = item.ImagePath,
                    ImageAltText = item.ItemName,
                    Category = item.Category?.CategoryName
                }).ToList();

                _memoryCache.Set("itemsCache", cards, TimeSpan.FromMinutes(5));
            }

            return View(cards);
        }

        public IActionResult Details(Guid itemId)
        {
            var item = _context.Items
                .FirstOrDefaultAsync(i => i.ItemId == itemId);

            if (item == null)
            {
                return NotFound();
            }
            return View(item);
        }

        public IActionResult Form()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Item()
        {
            return PartialView("~/Views/Shared/_TableItem.cshtml");
        }

        [HttpGet]
        public IActionResult Section()
        {
            return PartialView("~/Views/Shared/_TableSection.cshtml");
        }

        [HttpGet]
        public IActionResult Category()
        {
            return PartialView("~/Views/Shared/_TableCategory.cshtml");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
