using System;   
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ugur_Form_Project.Models;
using Ugur_Form_Project.Models.ViewModels;

namespace Ugur_Form_Project.Controllers
{
    public class FormController : Controller
    {
        // GET: Form
        public ActionResult SikayetOneri(string recordResult)
        {

            var db = new UgurFormsModel();
            ViewBag.Nitelikler = db.Nitelik.ToList();
            if(recordResult != null) { 
            if(recordResult.Length > 0)
                ViewBag.KayitMesaji = recordResult;
            }
            return View( new SikayetlerVM());
        }

        [HttpPost]
        public ActionResult SikayetOneri(SikayetlerVM model)
        {

            var db = new UgurFormsModel();
            var statusMessage = "";
            Bilgiler yeniBilgi = new Bilgiler()
            {
                AdSoyad = Request.Form["AdSoyad"].ToString(),
                SicilNo = Request.Form["SicilNo"].ToString(),
                Telefon = Request.Form["Telefon"].ToString(),
                Email = Request.Form["Email"].ToString(),
                Tarih = Convert.ToDateTime(Request.Form["Tarih"]),
                NitelikID = Convert.ToInt32(Request.Form["NitelikID"]),
                Konu = Request.Form["Konu"].ToString()
            };

             db.Bilgiler.Add(yeniBilgi);
           

            try
            {
                db.SaveChanges();
                statusMessage = "Kayıt Başarılı Şekilde Gerçekleşti.";
            }
            catch (Exception ex)
            {
                statusMessage = "Kayıt Kaydedilemedi" + ex.Message;

            }
            ViewBag.Nitelikler = db.Nitelik.ToList();
            return RedirectToAction("SikayetOneri", new { recordResult = statusMessage });
        }

        public ActionResult RamakKala(string recordResult)
        {

            var db = new UgurFormsModel();

            if (recordResult != null)
            {
                if (recordResult.Length > 0)
                    ViewBag.KayitMesaji = recordResult;
            }
            ViewBag.Durum = db.Durum.ToList();
            return View();
        }

        [HttpPost]
        public ActionResult RamakKala(OlaylarVM model)
        {
            var db = new UgurFormsModel();
            var statusMessage = "";
            Olay yeniOlay = new Olay()
            {
                Tarih = Convert.ToDateTime(Request.Form["Tarih"]),
                Saat = Convert.ToDateTime(Request.Form["Saat"]),
                Yer = Request.Form["Yer"].ToString(),
                Olay1 = Request.Form["Olay1"].ToString(),
                Oneri= Request.Form["Oneri"].ToString(),
                DurumID = Convert.ToInt32(Request.Form["DurumID"]),
                AdSoyad = Request.Form["AdSoyad"].ToString()

            };

            db.Olay.Add(yeniOlay);

            try
            {
                db.SaveChanges();
                statusMessage = "Kayıt Başarılı Şekilde Gerçekleşti.";
            }
            catch (Exception ex)
            {
                statusMessage = "Kayıt Kaydedilemedi" +  ex.Message;
                
            }
            ViewBag.Durum = db.Durum.ToList();
            return RedirectToAction("RamakKala", new { recordResult = statusMessage });

            
        }
    }
} 