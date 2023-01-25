using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ShoppingList.Models
{
    public enum DepartmentList
    {
        [Display(Name = "Frugt og Grønt")]
        FrugtOgGrønt,
        Mejeri,
        Brød,
        Konserves,
        Frost,
        Kolonial
    }
}
