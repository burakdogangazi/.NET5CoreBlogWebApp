using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using CoreDemo.Models;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    //[Authorize] //class üstüne yazınca buraya bütün hepsi auth ister
    //Controller Seviyesinde Authorize
    public class WriterController : Controller
    {
        WriterManager wm = new WriterManager(new EFWriterRepository());

        UserManager userManager = new UserManager(new EFUserRepository());


        private readonly UserManager<AppUser> _userManager;

        public WriterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [Authorize]
        //[AllowAnonymous]
        public IActionResult Index()
        {
            var userMail = User.Identity.Name;
            ViewBag.v = userMail;

            Context c = new Context();

            var writerName = c.Writers.Where(x => x.WriterMail == userMail).Select(y => y.WriterName).FirstOrDefault();
            ViewBag.v2 = writerName;

            return View();
        }

        public IActionResult WriterProfile()
        {
            return View();
        }

        //[Authorize] // Controller Part Seviyesinde Auth
        public IActionResult WriterMail()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult Test()
        {
            return View();
        }

        [AllowAnonymous]
        public PartialViewResult WriterNavbarPartial()
        {
            return PartialView();
        }

        [AllowAnonymous]
        public PartialViewResult WriterFooterPartial()
        {
            return PartialView();
        }

        [HttpGet]
        public async Task<IActionResult> WriterEditProfile()
        {
            //Context c = new Context();
            //var username = User.Identity.Name;
            //var userMail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            //var id = c.Users.Where(x => x.Email == userMail).Select(y=>y.Id).FirstOrDefault();
            //var values = userManager.GetById(id);

            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserUpdateViewModel userUpdateViewModel = new UserUpdateViewModel();
            userUpdateViewModel.mail = values.Email;
            userUpdateViewModel.namesurname = values.NameSurname;
            userUpdateViewModel.imageurl = values.ImageUrl;
            userUpdateViewModel.username = values.UserName;
            return View(userUpdateViewModel);

        }


        [HttpPost]
        public async Task<IActionResult> WriterEditProfile(UserUpdateViewModel userUpdateViewModel)
        {

            var values = await _userManager.FindByNameAsync(User.Identity.Name);

            values.NameSurname = userUpdateViewModel.namesurname;
            values.ImageUrl = userUpdateViewModel.imageurl;
            values.UserName = userUpdateViewModel.username;
            values.PasswordHash = _userManager.PasswordHasher.HashPassword(values, userUpdateViewModel.password);
            values.Email = userUpdateViewModel.mail;

            var result = await _userManager.UpdateAsync(values);

            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Dashboard");

            }

            return View();

        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult WriterAdd()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult WriterAdd(AddProfileImage p)
        {
            Writer w = new Writer();

            if(p.WriterImage != null)
            {
                var extension = Path.GetExtension(p.WriterImage.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/WriterImageFiles/", newImageName);
                var stream = new FileStream(location,FileMode.Create);
                p.WriterImage.CopyTo(stream);
                w.WriterImage = newImageName;

            }

            w.WriterMail = p.WriterMail;
            w.WriterName = p.WriterName;
            w.WriterPassword = p.WriterPassword;
            w.WriterStatus = true;
            w.WriterAbout = p.WriterAbout;


            wm.TAdd(w);
            return RedirectToAction("Index", "Dashboard");
        }




    }
}
