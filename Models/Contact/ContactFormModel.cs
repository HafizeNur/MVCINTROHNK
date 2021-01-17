using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BasicMvcExample.Models.Contact
{
    public class ContactFormModel
    {
        public int ContactFormId { get; set; }

        [Required(ErrorMessage="Lütfen bir ad giriniz")]
        public string NameSurname { get; set; }

        [Display(Name ="Email")]
        [Required(ErrorMessage = "Lütfen bir e-mail giriniz")]
        [EmailAddress(ErrorMessage ="Email adresi geçersiz")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Lütfen bir konu giriniz")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Lütfen bir mesaj giriniz")]
        public string Message { get; set; }
    }
}