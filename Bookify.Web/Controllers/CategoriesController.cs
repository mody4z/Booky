using Bookify.Web.Core.Models;
using Bookify.Web.Core.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Bookify.Web.Controllers
{
    public class CategoriesController : Controller
    {


        private readonly ApplicationDbContext _context;

        public CategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {   //TODO:using viewModel
            var categories = _context.Categories.ToList();

            return View(categories);
        }
        [HttpGet]
        public IActionResult Create ()
        { 
            

            return View("Form");
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CategoryFormViewModel model) 
        { 
            
            
           if(!ModelState.IsValid) 
                return View("Form", model);

            var category = new Category { Name = model.Name };
            _context.Categories.Add(category);
            _context.SaveChanges();


            return RedirectToAction(nameof(Index));
        
        
        }
        public IActionResult Edit(int id)
        {


            return View("Form");
        }
    }
}