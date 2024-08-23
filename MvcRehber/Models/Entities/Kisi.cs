using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcRehber.Models.Entities
{
    [Table("Kisiler")]
    public class Kisi
    {
        public int Id { get; set; }

        [DataType(DataType.Text)]
        [DisplayName("İsim")]
        public string Ad { get; set; }

        [DataType(DataType.Text)]
        [DisplayName("Soyisim")]
        public string Soyad { get; set; }


        [DataType(DataType.PhoneNumber)]
        [DisplayName("Ev numarası")]
        public string EvTelefon { get; set; }

        [DataType(DataType.PhoneNumber)]
        [DisplayName("Kişisel Numara")]
        public string CepTelefon { get; set; }

        [DataType(DataType.PhoneNumber)]
        [DisplayName("İş numarası")]
        public string IsTelefon { get; set; }

        [DataType(DataType.EmailAddress)]
        [DisplayName("E-mail adresi")]
        public string EmailAdres { get; set; }

        [DataType(DataType.Text)]
        [DisplayName("Adres")]
        public string Adres { get; set; }

        [DisplayName("Şehir")]
        public int SehirId { get; set; }
 

        public int CurrentId { get; set; }


        public Sehir Sehir { get; set; }

        public TBLUserInfo TBLUserInfo { get; set; }
    }
}