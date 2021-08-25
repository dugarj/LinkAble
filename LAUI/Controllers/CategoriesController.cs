using LABLL;
using LABOL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LAUI.Controllers
{
    
    public class CategoriesController : Controller
    {
        ICategoryBs categoryBs;

        public CategoriesController(ICategoryBs _categoryBs)
        {
            categoryBs = _categoryBs;
        }

        public IActionResult Index()
        {
            var categories = categoryBs.GetAll();
            return View(categories);
        }
    }
}
