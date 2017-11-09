using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CroperJsExampleGood.Models
{
    public class UserChangeImageViewModel
    {
        [Required(ErrorMessage = "Обов'язкове поле")]
        [Display(Name = "Зображення")]
        public string Image { get; set; }
    }
}