using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMedicoSoft.Areas.saveme.Controllers
{
    public class homeController : Controller
    {
        //
        // GET: /saveme/home/
        [HttpGet]
        public ActionResult index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult index(string num)
        {
            Personne p = Personne.getInfo(num);
            string NomMedecin = "";
            if (p != null)
            {
                if (p.getReferent(out NomMedecin))
                {
                    ViewBag.Medecin = NomMedecin;
                    return View("rescue", p);
                }
                else
                {
                    return View("death", p);
                }
            }
            else
            {
                return View("death", p);
            }

        }
    }
}