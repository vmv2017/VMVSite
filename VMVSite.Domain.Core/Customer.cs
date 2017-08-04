using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;

namespace VMVSite.Domain.Core
{
    public class Customer
    {
        [Display(Name="Ідентифікатор клієнта")]
        public ObjectId Id { get; set; }
        [Display(Name ="Назва")]
        public string Name { get; set; }
        [Display(Name ="Контактна особа")]
        public string ContactPeople { get; set; }
        [Display(Name="Електронна адреса")]
        public string EMail { get; set; }
        [Display(Name="Скайп")]
        public string SkypeId { get; set; }
        [Display(Name="Мобільний номер телефону")]
        public string PhuneMobile { get; set; }
    }
}
