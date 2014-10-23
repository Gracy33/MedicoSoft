using DAL;
using MVCMedicoSoft.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMedicoSoft.Areas.Agenda.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Agenda/Home/
        public ActionResult Index()
        {
            if (MySession.User == null)
            {
                return RedirectToRoute(new { controller = "Home", action = "Index", area= "" });
            }

            else
            {
                if (MySession.User.getRole() == DAL.TypeOfUser.Secretaire)
                {
                    MySession.LesPatients = Personne.getInfos();

                    return View(MySession.LesPatients);
                }
                else
                {
                    return RedirectToRoute(new { controller = "Home", action = "Index", area= "" });                    
                }
            }
        }

        [HttpPost]
        public ActionResult Index(string txtSearchName, DateTime dtNaiss)
        {
            List<Personne> listeFiltre = new List<Personne>();
            foreach (var item in MySession.LesPatients)
            {
                if(item.Nom.ToUpper().Contains(txtSearchName.ToUpper())
                    ||
                    item.DateNaissance == dtNaiss)
                    listeFiltre.Add(item);
            }
            return View(listeFiltre);
        }
	}
}