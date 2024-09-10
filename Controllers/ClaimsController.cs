using System.Collections.Generic;
using CMCS.Models;
using Microsoft.AspNetCore.Mvc;

namespace CMCS.Controllers
{
    public class ClaimsController : Controller
    {
        // Simulate a list of claims
        private static List<Claim> claims = new List<Claim>
        {
            new Claim { ClaimId = 1, LecturerName = "John Doe", HoursWorked = 10, HourlyRate = 20, ClaimAmount = 200, Status = "Pending", SubmissionDate = System.DateTime.Now },
            new Claim { ClaimId = 2, LecturerName = "Jane Smith", HoursWorked = 15, HourlyRate = 22, ClaimAmount = 330, Status = "Approved", SubmissionDate = System.DateTime.Now.AddDays(-1) }
        };
        public IActionResult Index()
        {
            return View(claims);
        }

        // Claim submission form
        public ActionResult Submit()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Submit(Claim claim)
        {
            claim.ClaimId = claims.Count + 1;
            claim.Status = "Pending";
            claims.Add(claim);
            return RedirectToAction("Index");
        }

        // Programme Coordinator and Academic Manager dashboard
        public ActionResult Approvals()
        {
            return View(claims);
        }
    }
}
