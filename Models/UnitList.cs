using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ShoppingList.Models
{
    public enum UnitList
    {
        [Display(Name = "--ingen--")]
        none = 0,
        stk = 1,
        kg = 2,
        gram = 3,
        liter = 4,
        poser = 5,
        kasser = 6,
        glas = 7
    }
}
