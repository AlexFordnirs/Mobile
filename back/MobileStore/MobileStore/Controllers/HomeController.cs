using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MobileStore.Models;

namespace MobileStore.Controllers
{
    public class HomeController : Controller
    {
        MobileContext db;
        public HomeController(MobileContext context)
        {
            db = context;
        }

        [Route("{company:maxlength(255)?}")]
        public IEnumerable<Phone> Get(string? company)
        {
            
            if(company != null)
            {
                return db.Phones.Where(i => i.Company == company).ToArray();
            }
            else
            {
                return db.Phones.ToArray();
            }
        }
    }
}
