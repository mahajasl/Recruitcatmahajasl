using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RecruitCatmahajasl.Pages
{
    public class contactModel : PageModel
    {
        public bool hasData = false;
        public string firstname = "";
        public string lastname = "";
        public string address = "";
        public string message = "";

        public void OnGet()
        {
        }

        public void Onpost()
        {
            hasData = true;
            firstname = Request.Form["FirstName"];
            lastname = Request.Form["LastName"];
            address = Request.Form["Address"];
            message = Request.Form["subject"];
            

        }
    }
}
