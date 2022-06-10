using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ugur_Form_Project.Models.ViewModels
{
    public class OlaylarVM
    {
        [Display(Name = "Tarih:")]
        
        public DateTime Tarih { get; set; }

        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = true)]
        public string Saat { get; set; }

        [Display(Name = "Yer:")]
        [Required(ErrorMessage = "Bu alanı boş geçmeyiniz!")]
        public string Yer { get; set; }


        [Display(Name = "Olayı Açıklayınız;")]
        [Required(ErrorMessage = "Bu alanı boş geçmeyiniz!Size yardımcı olabilmemeiz için lütfen yaşadığınız olayı açıklayınız!!")]
        public string Olay1 { get; set; }


        [Display(Name = "Tehlikeli durumu ortadan kaldırdınız mı?")]
        public int DurumID { get; set; }
        


        [Display(Name = "Önerilerinizi Yazınız:")]
        public string Oneri { get; set; }



        [Display(Name = "Adı-Soyadı:")]
        public string AdSoyad { get; set; }
    }
}
