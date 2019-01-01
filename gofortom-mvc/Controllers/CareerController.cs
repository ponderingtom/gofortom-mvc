using gofortom_mvc.Models;
using gofortom_mvc.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace gofortom_mvc.Controllers
{
    public class CareerController : Controller
    {
		// GET: Career
		public ActionResult Index()
		{
			var careers = new List<Career>
			{
				new Career { Id = 1, Title = "It Begins", Image = "images/ti-994a.jpg", StartYear = 1981, Description = "<p>My path to becoming a software engineer began in 10th grade. My school had received its first batch of computers. Some of you may remember the TRS-80. I was able to play with them a little, but in 11th grade, they switched over to the Texas Instruments TI99-4A with 16K of RAM. I ended up buying one for home and played with writing programs in Basic for many hours.</p><p>By the time I graduated from High School, I had upgraded to the Commodore 64. As you may suspect, it had 64K of RAM. I didn't know what to do with it all!</p>"  },
				new Career { Id = 2, Title = "School", Image = "images/MTC_logo1.jpg", StartYear = 1989, EndYear = 1991, Description = "<p>In 1989, my father-in-law decided to write software for public school food service and asked if I would help him write the applications. The deal we made was I would work for him full time and he would pay for me to go to school.</p><p>I ended up writing all of the application and he focused on selling the software prepackaged on IBM clone computers. We would both go to the schools to install, train and maintain these systems. Since everything was completely custom written by me, the food service employees loved it. Whatever they wanted the system to do, I made it happen.</p>"}
			};

			var viewModel = new CareerViewModel
			{
				Careers = careers
			};

            return View(viewModel);
        }
    }
}