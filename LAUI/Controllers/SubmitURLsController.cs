using LABLL;
using LABOL;
using LAUI.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LAUI.Controllers
{
    public class SubmitURLsController : Controller
    {
        readonly UserManager<LAUser> userManager;       
        ILAUrlBs LAUrlBs;
        ICategoryBs CategoryBs;

        public SubmitURLsController(UserManager<LAUser> _userManager, ILAUrlBs _LAUrlBs, ICategoryBs _categoryBs)
        {
            LAUrlBs = _LAUrlBs;
            userManager = _userManager;
            CategoryBs = _categoryBs;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreateURL()
        {
            ViewBag.Categories = CategoryBs.GetAll();
            return View();
        }

        [HttpPost]
        public async Task <IActionResult> CreateURL(CreateURLViewModel model)
        {
            var user = await userManager.FindByNameAsync(User.Identity.Name);
            if(ModelState.IsValid)
            {
                LAUrl lAUrl = new LAUrl()
                {
                    UrlTitle = model.UrlTitle,
                    LAUrlName = model.LAUrlName,
                    Description = model.Description,
                    CategoryId = model.CategoryId,
                    IsApproved = false,
                    Id = user.Id
                };

                LAUrlBs.Create(lAUrl);
                return RedirectToAction("CreateURL");
            }
            ViewBag.Categories = CategoryBs.GetAll();
            return View();
        }
    }
}
