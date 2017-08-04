using MongoDB.Bson;
using System;
using System.ComponentModel.DataAnnotations;

namespace VMVSite.Domain.Core
{
    public class OrderProject
    {
        [Display(Name="Ідентифікатор замовлення")]
        public ObjectId Id { get; set; }
        [Required]
        [Display(Name = "Назва проекту")]
        [StringLength(100)]
        [MaxLength(100), MinLength(10)]
        public string Name { get; set; }
        [DataType(DataType.DateTime)]
        [Display(Name="Дата замовлення")]
        public DateTime CreateOrder { get; set; }
        [DataType(DataType.DateTime)]
        [Display(Name ="Дата початку проекта")]
        public DateTime BeginProject { get; set; }
        [Display(Name ="СУБД")]
        [StringLength(200)]
        public string NameDB { get; set; }
        [Display(Name ="Назва технологій")]
        [StringLength(200)]
        public string NameFranework { get; set; }
        [Display(Name ="Короткий опис")]
        public string Description { get; set; }
        [Display(Name ="Примітка")]
        public string Comment { get; set; }
    }
}
