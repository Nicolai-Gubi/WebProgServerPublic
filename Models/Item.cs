using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ShoppingList.Models
{
    public class Item
    {
        public int Id { get; set; }

        [Display(Name = "Vare")]
        [Required]
        public string ItemName { get; set; }

        [Display(Name = "Antal")]
        [Required]
        public int Amount { get; set; }

        [Display(Name = "Enhed")]
        [Required]
        public UnitList UnitType { get; set; }

        [Display(Name = "Afdeling")]
        public DepartmentList Department { get; set; }

    }
}
