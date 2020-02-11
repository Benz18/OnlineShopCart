using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopCart.Data.Models
{
    public class Order
    {
        [BindNever]
        public int Id { get; set; }

        [Display(Name = "Your Name")]
        [StringLength(20)]
        [Required(ErrorMessage = "Name must be at least 3 characters long")]
        public string Name { get; set; }

        [Display(Name = "Your Surname")]
        [StringLength(20)]
        [Required(ErrorMessage = "Surname must be at least 3 characters long")]
        public string Surname { get; set; }

        [Display(Name = "Your Address")]
        [StringLength(40)]
        [Required(ErrorMessage = "Address must be at least 7 characters long")]
        public string Adress { get; set; }

        [Display(Name = "Your Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(15)]
        [Required(ErrorMessage = "Phone number must be at least 7 characters long")]
        public string Phone { get; set; }

        [Display(Name = "Your Email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(25)]
        [Required(ErrorMessage = "Email must be at least 7 characters long")]
        public string Email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderTime { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}
