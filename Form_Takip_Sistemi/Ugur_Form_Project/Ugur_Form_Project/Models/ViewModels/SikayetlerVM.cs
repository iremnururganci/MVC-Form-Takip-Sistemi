using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ugur_Form_Project.Models.ViewModels
{
    public class SikayetlerVM
    {


        [Display(Name = "Adı Soyadı")]
        //[Required(ErrorMessage = "Please enter the customer id")]
        public string AdSoyad { get; set; }

        [Display(Name = "Sicil No:")]
        //[Required(ErrorMessage = "Please enter the customer id")]
        public string SicilNo { get; set; }

        [Display(Name = "Telefon:")]
        //[Required(ErrorMessage = "Please enter the customer id")]
        public string Telefon { get; set; }

        [Display(Name = "E-Mail")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Lütfen doğru bir mail adresi giriniz")]
        public string Email { get; set; }
        [Display(Name = "Öneri-Şikayet Tarihi:")]
        
        [Required(ErrorMessage = "Lütfen tarih bilgisini giriniz...!")]
        public DateTime Tarih { get; set; }
        [Display(Name = "Niteliği:")]
        [Required(ErrorMessage = "Öneri-Şikayet niteliğini seçiniz...")]
        public int NitelikID { get; set; }
        [Display(Name = "Şikayet-Öneri Konusu:")]
        [Required(ErrorMessage = "Öneri-Şikayet Konusunu Belirtiniz...")]
        public string Konu { get; set; }
    }
}