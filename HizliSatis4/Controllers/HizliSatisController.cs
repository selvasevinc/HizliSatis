using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Net.Mail;

namespace HizliSatis4.Controllers
{
    public class HizliSatisController : Controller
    {
        // GET: HizliSatis
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult Index(Models.Email model)
        {
            MailMessage mailim = new MailMessage();
            mailim.To.Add("bilgi@ceptefaturam.com");
            mailim.From = new MailAddress("bilgi@ceptefaturam.com");
            mailim.Subject = "Hızlı Satış Programından Mesajınız Var!";
            mailim.Body = "Ad:" + model.ad + " <br> Mail:" + " " + model.email + " <br>Konu:" + model.konu + " <br>Mesaj:" + model.mesaj;
            mailim.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new NetworkCredential("bilgi@ceptefaturam.com", "0M5azs0@");
            smtp.Port = 587;
            smtp.Host = "smtp.ceptefaturam.com";
            smtp.EnableSsl = false;

            try
            {
                smtp.Send(mailim);
            }
            catch (Exception)
            {

            }

            return Json("asdasd");
        }



        public ActionResult SiparisVeTeklif()
        {
            return View();
        }
        public ActionResult OtomatikYedekleme()
        {
            return View();
        }
        public ActionResult ExcelVeriAktarim()
        {
            return View();
        }
        public ActionResult StokSayim()
        {
            return View();
        }
        public ActionResult StokRiskLimiti()
        {
            return View();
        }
        public ActionResult Ozellikler()
        {
            return View();
        }
        public ActionResult OnMuhasebe()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}

