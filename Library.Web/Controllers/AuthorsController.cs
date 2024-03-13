using Library.Web.Data;
using Library.Web.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Library.Web.Controllers
{
    public class AuthorsController : Controller
    {
        private readonly DataContext _context;

        public AuthorsController(DataContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Author> list = await _context.Authors.ToListAsync();

            return View(list);
        }
    }
}
