using u19074362_HomeworkAssignment_03.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace u19074362_HomeworkAssignment_03.Controllers
{
    public class HomeController : Controller
    {

        public static List<FileModel> files = new List<FileModel>(); //List of all files
        
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(HttpPostedFileBase file, string ch)
        {
            Random random = new Random();

            if (ch == "doc")
            {
                try
                {
                    if (file.ContentLength > 0)
                    {
                        string _FileName = Path.GetFileName(file.FileName);
                        string _path = Path.Combine(Server.MapPath("~/UploadedFiles"), _FileName);

                        FileModel item = new FileModel();

                        item.Link = "~/UploadedFiles/" + _FileName;
                        item.FileName = _FileName;
                        item.id = random.Next(10000);
                        item.type = "doc";
                        files.Add(item);
                        Session["files"] = files;
                        file.SaveAs(_path);
                    }
                    ViewBag.Message = "File Uploaded Successfully!!";
                    return View();
                }
                catch
                {
                    ViewBag.Message = "File upload failed!!";
                    return View();
                }
            }
            if (ch == "img")
            {
                try
                {
                    if (file.ContentLength > 0)
                    {
                        string _FileName = Path.GetFileName(file.FileName);
                        string _path = Path.Combine(Server.MapPath("~/UploadedFiles"), _FileName);
                        
                        FileModel item = new FileModel();
                      
                        item.Link = "~/UploadedFiles/" + _FileName;
                        item.FileName = _FileName;
                        item.id = random.Next(10000);
                        item.type = "img";
                        files.Add(item);
                        Session["files"] = files;
                        file.SaveAs(_path);
                    }
                    ViewBag.Message = "File Uploaded Successfully!!";
                    return View();
                }
                catch
                {
                    ViewBag.Message = "File upload failed!!";
                    return View();
                }
            }
            if (ch == "vid")
            {
                try
                {
                    if (file.ContentLength > 0)
                    {
                        string _FileName = Path.GetFileName(file.FileName);
                        string _path = Path.Combine(Server.MapPath("~/UploadedFiles"), _FileName);

                        FileModel item = new FileModel();
                        item.Link = "~/UploadedFiles/" + _FileName;
                        item.FileName = _FileName;
                        item.id = random.Next(10000);
                        item.type = "vid";
                        files.Add(item);
                        Session["files"] = files;
                        file.SaveAs(_path);
                    }
                    ViewBag.Message = "File Uploaded Successfully!!";
                    return View();
                }
                catch
                {
                    ViewBag.Message = "File upload failed!!";
                    return View();
                }
            }
            return View();

        }
     

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}