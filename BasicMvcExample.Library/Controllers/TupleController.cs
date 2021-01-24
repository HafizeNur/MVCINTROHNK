using BasicMvcExample.Library.Models.Tuple;
using System;
using System.Web.Mvc;

namespace BasicMvcExample.Library.Controllers
{
    public class TupleController : Controller
    {
        // GET: Tuple
        public ActionResult TupleExample()
        {
            var model1 = new PersonalInformation();
            var model2 = new ContactInformation();

            model1.Name = "Hafize Nur";
            model1.Surname = "Korkmaz";
            model2.Address = "İstanbul";
            model2.Phone = "05554443322";
            return View(Tuple.Create(model1,model2));
        }
        [HttpPost]
        public ActionResult TupleExamplePost([Bind(Prefix="Item1")]PersonalInformation person)
        {
            //Buraya database kayıt işlemleri yapılabilir
            return View(person);
        }
        [HttpPost]
        public ActionResult TupleExamplePost2([Bind(Prefix = "Item2")]ContactInformation contact)
        {
            return View(contact);
        }
    }
}