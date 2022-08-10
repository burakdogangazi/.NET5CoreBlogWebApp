using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class MessageController : Controller
    {

        Message2Manager manager = new Message2Manager(new EFMessage2Repository());
        [AllowAnonymous]
        public IActionResult InBox()
        {
            int id = 2;
            var values = manager.GetInboxListByWriter(id);
            return View(values);
        }

        public IActionResult MessageDetails(int id)
        {
            var value = manager.GetById(id);
           
            return View(value);
        }


    }
}
