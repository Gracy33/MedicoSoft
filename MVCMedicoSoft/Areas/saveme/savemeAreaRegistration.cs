using System.Web.Mvc;

namespace MVCMedicoSoft.Areas.saveme
{
    public class savemeAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "saveme";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "saveme_default",
                "saveme/{controller}/{action}/{id}",
                new {controller= "home", action = "index", id = UrlParameter.Optional }
            );
        }
    }
}