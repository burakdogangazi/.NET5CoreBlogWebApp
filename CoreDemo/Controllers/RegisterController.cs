using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
    {

        WriterManager writerManager = new WriterManager(new EFWriterRepository());

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Writer p)
        {

            WriterValidator writerValidator = new WriterValidator();
            ValidationResult results = writerValidator.Validate(p);

            if (results.IsValid)
            {
                p.WriterStatus = true;
                p.WriterAbout = "Deneme test";
                writerManager.TAdd(p);
                return RedirectToAction("Index", "Blog");
            }

            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();


        }



        //Ekleme işlemi yapılırken httpget ve httppost attributeların tanımalndığı 
        //metotların isimleri aynı olmak zorundadır.

        // HTTP GET sayfa yüklenince
        //HTTP POST sayfa tetiklenince

        //HTTPGet attribute komutu sayfada kategorize veya benzeri işlemler kullanılırken
        //sayfa yüklendiği anda listelenmesi istenen niteliklirde kullanılabilir.
        

        //HTTPGET - İLLER İLÇELER 

        //HTTP POST BİR PARAMETRE ALMALI

    }
}
