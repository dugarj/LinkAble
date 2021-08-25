using LABLL;
using LAUI.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LAUI.Controllers
{
    [AllowAnonymous]
    public class BrowseURLsController : Controller
    {
        ILAUrlBs LAUrlBs;
        public BrowseURLsController(ILAUrlBs _LAUrlBs)
        {
            LAUrlBs = _LAUrlBs;
        }
        public IActionResult Index()
        {
            List<BrowseURLsViewModel> browseURLs = new List<BrowseURLsViewModel>();
            var urls = LAUrlBs.GetAll(true);
            foreach (var item in urls)
            {
                BrowseURLsViewModel model = new BrowseURLsViewModel()
                {
                    UrlId = item.UrlId,
                    UrlTitle = item.UrlTitle,
                    LAUrlName = item.LAUrlName,
                    Description = item.Description,
                    CategoryName = item.Category.CategoryName,
                    //UserName = item.User.UserName
                };
                browseURLs.Add(model);
            }
            return View(browseURLs);
        }
    }
}
