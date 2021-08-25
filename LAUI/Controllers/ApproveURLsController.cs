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
    [Authorize(Roles ="Admin")]
    public class ApproveURLsController : Controller
    {
        ILAUrlBs LAUrlBs;
        public ApproveURLsController(ILAUrlBs _LAUrlBs)
        {
            LAUrlBs = _LAUrlBs;
        }

        public IActionResult Index()
        {
            List<ApproveURLsViewModel> approveURLs = new List<ApproveURLsViewModel>();
            var urls = LAUrlBs.GetAll(false);
            foreach (var item in urls)
            {
                ApproveURLsViewModel model = new ApproveURLsViewModel()
                {
                    UrlId = item.UrlId,
                    UrlTitle = item.UrlTitle,
                    LAUrlName = item.LAUrlName,
                    Description = item.Description,
                    CategoryName = item.Category.CategoryName,
                    //UserName = item.User.UserName,
                    IsApproved = item.IsApproved
                };
                approveURLs.Add(model);
            }
                return View(approveURLs);
        }

        [HttpPost]
        public IActionResult Approve(int urlId)
        {
            var laUrl = LAUrlBs.GetById(urlId);
            laUrl.IsApproved = true;
            LAUrlBs.Update(laUrl);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult ApproveAll(List<int> urlIds)
        {
            if(urlIds.Count!=0)
            {
                foreach (var urlId in urlIds)
                {
                    var laUrl = LAUrlBs.GetById(urlId);
                    laUrl.IsApproved = true;
                    LAUrlBs.Update(laUrl);
                }
                return RedirectToAction("Index");
            }
            return View("Index");
        }
    }
}
