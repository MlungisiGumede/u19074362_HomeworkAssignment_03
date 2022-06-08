using u19074362_HomeworkAssignment_03.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace u19074362_HomeworkAssignment_03.Controllers
{
    public class ImagesController : Controller
    {
        static public List<FileModel> items = new List<FileModel>();
        // GET: Images
        public ActionResult Index()
        {
            
                items = ((List<FileModel>)Session["files"]);
                items = items.Where(x => x.type == "img").ToList();

                return View(items);
            
        }
        public ActionResult Delete(int id)
        {
            items = ((List<FileModel>)Session["files"]);
            items = items.Where(x => x.type == "img").ToList();
            FileModel fileModel = new FileModel();
            fileModel = items.FirstOrDefault(x => x.id == id);
         
            items.Remove(fileModel);
            Session["files"] = items;
            return View("Index",items);
        }
        public FileResult Download(int  id)
        {
            items = ((List<FileModel>)Session["files"]);
            FileModel fileModel = new FileModel();
            fileModel = items.FirstOrDefault(x => x.id == id);
            string path = Server.MapPath("~/UploadedFiles/" + fileModel.FileName);
            byte[] bytes = System.IO.File.ReadAllBytes(path);

            return File(bytes, "application/octet-stream", fileModel.FileName);
        }
    }
}