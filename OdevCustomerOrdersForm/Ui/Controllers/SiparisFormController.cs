using BL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Ui.Controllers
{
    public class SiparisFormController : Controller
    {
        private ICustomerService customerService;
        private IOrderService orderService;
        private IOrderDetaylariService orderDetailService;
        public SiparisFormController(ICustomerService customerService, IOrderService orderService, IOrderDetaylariService orderDetailService)
        {
            this.customerService = customerService;
            this.orderService = orderService;
            this.orderDetailService = orderDetailService;
        }
        public IActionResult Index()
        {
            ViewBag.musteriler = new SelectList(customerService.sirketGetir(null), "CustomerId", "CompanyName");
            return View();
        }

        [HttpPost]
        public PartialViewResult seciliMusteri(string musteri)
        {
          var veri = customerService.sirketGetir(x=>x.CustomerId == musteri).FirstOrDefault();

            return PartialView("_seciliMusteri", veri);
        }
        
        [HttpPost]
        public PartialViewResult seciliMusteriOrder(string musteri)
        {
           
                var veri = orderService.sirketGetir(x => x.CustomerId == musteri);

                return PartialView("_seciliMusteriOrder", veri);
          

        }

        [HttpPost]
        public PartialViewResult filtre(string musteri, string radio)
        {
            if (radio == "Hepsi")
            {
                var veri = orderService.sirketGetir(x => x.CustomerId == musteri);

                return PartialView("_seciliMusteriOrder", veri);
            }
            else if (radio == "Acik")
            {
                var veri = orderService.sirketGetir(x => x.CustomerId == musteri && x.ShippedDate == null);

                return PartialView("_seciliMusteriOrder", veri);
            }
            else
            {
                var veri = orderService.sirketGetir(x => x.CustomerId == musteri && x.ShippedDate != null);

                return PartialView("_seciliMusteriOrder", veri);
            }

        }

        public PartialViewResult seciliMusteriOrderDetaylari(int orderid)
        {
           var orders = orderDetailService.sirketGetir(p=>p.OrderId == orderid);
            

            return PartialView("_seciliMusteriOrderDetaylari", orders);
        }
    }
}
