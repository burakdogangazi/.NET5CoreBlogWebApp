using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents.Writer
{

    public class WriterAboutOnDashboard: ViewComponent
    {
        WriterManager wm = new WriterManager(new EFWriterRepository());

        Context c = new Context();

       // private readonly UserManager<AppUser> _userManager;

        //public WriterAboutOnDashboard(UserManager<AppUser> userManager)
        //{
        //    _userManager = userManager;
        //}

        public IViewComponentResult Invoke()
        {

           // var user = await _userManager.FindByNameAsync(User.Identity.Name);

            var username = User.Identity.Name;

            ViewBag.v = username;

            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();

            var writerId = c.Writers.Where(x => x.WriterMail == username)
                .Select(y => y.WriterID).FirstOrDefault();


            var values = wm.GetWriterById(writerId);
            return View(values);

        }

    }
}
