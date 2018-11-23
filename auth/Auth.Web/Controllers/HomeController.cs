using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System.Threading.Tasks;
using System.Data.Entity;
using System.IO;

namespace DoE.Auth.Identity.Controllers
{
    using Auth.Api;
    using Lsm.Data.Repositories;
    using Models;

    [Authorize(Roles = "Administrators")]
    public class HomeController : BaseController
    {
        public HomeController(RepositoryStoreManager dataStoreManager) : base(dataStoreManager){}

        public ActionResult Index()
        {
           return RedirectToAction("Index","Account");
        }

        [ActionName(name: "uploadImgTocloud")]
        [HttpPost]
        public ActionResult MoveImageToCloud(HttpPostedFileBase  file)
        {
            var p = "";

            if (file != null)
            {
                if (file.ContentLength > 0)
                {
                    if (Path.GetExtension(file.FileName).ToLower() == ".jpg" ||
                        Path.GetExtension(file.FileName).ToLower() == ".png")
                    {
                        p = Path.Combine(Server.MapPath("~/Content/Images"), file.FileName);
                        file.SaveAs(p);
                        ViewBag.PostedFileState = "success"; 
                        return PartialView("_ImageDisplayer", new HomeViewModel{
                           uploadedFile = file.FileName
                        });
                    }
                  
                }
            }
            return PartialView("_ImageDisplayer");
        }
    }
}