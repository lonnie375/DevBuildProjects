using Assessment8FOCPotLuckPart2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assessment8FOCPotLuckPart2.Controllers
{
    public class TeamMemberController : Controller
    {
        public IActionResult Index()
        {
            List<TeamMember> member = DAL.GetAllTeamMembers();
            return View(member);
        }

        public IActionResult AddMember()
        {
            return View(); 
        }

        public IActionResult RSVPComplete(TeamMember member)
        {

            bool errorfound = false;
            if (member.firstname == null || member.firstname.Length < 1)
            {
                ViewBag.FirstNameMessage = "The First Name must be at least 1 character long";
                errorfound = true;
            }

            if (member.lastname == null || member.lastname.Length < 1)
            {

                ViewBag.LastNameMessage = "The Last Name must be at least 1 character long";
                errorfound = true;
            }

            if (member.emailaddress == null || !member.emailaddress.Contains("@"))
            {
                ViewBag.EmailMessage = "Your Email address must contain an @ symbol";
                errorfound = true;
            }

            if (member.attendancedate <= DateTime.Now)
            {
                ViewBag.DateMessage = "Please select a date that is not today or prior"; 
            }

            if (errorfound == false)
            {
                DAL.InsertTeamMember(member);
                return View("RSVPComplete", member);
            }
            else
            {
                return View("AddMember"); 
            }


            
        }
    }
}
