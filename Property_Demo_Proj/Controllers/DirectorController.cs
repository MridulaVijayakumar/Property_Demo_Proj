using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Property_Demo_Proj.Controllers
{
    public class DirectorController : Controller
    {
        private Property_Demo_Proj.Models.PropModel pro = new Models.PropModel();

        // GET: Director
        public ActionResult Index()
        {
            directorDetails("XYZ Movie");
            return View(pro);
        }



        public void abcDetails()
        {
            pro.Movie = "ABC Movie";
            pro.Rating = 5;
            pro.Director = "ABC Director";
        }

        public void xyzDetails()
        {
            pro.Movie = "XYZ Movie";
            pro.Rating = 1;
            pro.Director = "XYZ Director";
        }

        public void directorDetails(String movie)
        {
            if (movie.Equals("ABC Movie"))
                abcDetails();
            else
                xyzDetails();
        }
    }
}