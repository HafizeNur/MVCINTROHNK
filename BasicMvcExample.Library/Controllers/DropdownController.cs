using BasicMvcExample.Library.Models.DropDown;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BasicMvcExample.Library.Controllers
{
    public class DropdownController : Controller
    {
        // GET: Dropdown
        public ActionResult DummyProvincialPlate()
        {
            List<ProvincialPlateViewModel> _dumyProvincialPlate = new List<ProvincialPlateViewModel>
            {
                new ProvincialPlateViewModel{ID=1,ProvinceName="Antalya",ProvinceNo=07},
                new ProvincialPlateViewModel{ID=2,ProvinceName="Samsun",ProvinceNo=55},
                new ProvincialPlateViewModel{ID=3,ProvinceName="Ordu",ProvinceNo=52},
            };

            //Bu şekilde tanımlayınca viewde dönmesi zor
            //ViewBag.DummyProvincialPlate = _dumyProvincialPlate;

            //Doğru kullanım
            ViewBag._dumyProvincialPlate = new SelectList(_dumyProvincialPlate,"ID","ProvinceName");
            return View();
        }

        [HttpPost]
        public ActionResult DummyProvincialPlatePost(string _dumyProvincialPlate)
        {
            ViewBag.ProvinceID = _dumyProvincialPlate;
            return View();
        }
    }
}