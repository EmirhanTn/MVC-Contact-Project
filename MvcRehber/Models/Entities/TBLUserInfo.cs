using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MvcRehber.Models.Entities
{
    public class TBLUserInfo
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "Kullanıcı adı boş bırakılamaz.")]
        [DisplayName("Kullanıcı adı")]
        public string Username { get; set; }


        [Required(ErrorMessage = "Şifre boş bırakılamaz.")]
        [DisplayName("Şifre")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Required(ErrorMessage = "Şifre boş bırakılamaz.")]
        [DisplayName("Şifre (Tekrar)")]
        [DataType(DataType.Password)]
        [NotMapped]
        [Compare("Password", ErrorMessage = "Girilen şifreler farklı olamaz")]
        public string RePassword { get; set; }
    }
}