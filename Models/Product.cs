using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace CerasWorkshop.Models;

public class Product
{
    public int ProductID {get; set;} //Primary key

    [StringLength(50, MinimumLength = 3)]
    public string Name {get; set;} = string.Empty;

    [StringLength(150, MinimumLength = 20)]
    public string Description {get; set;} = string.Empty;

    [DataType(DataType.Currency)]
    public decimal Price {get; set;}

    [Display(Name = "Product Image")]
    public string ImageURL {get; set;} = string.Empty;

    public List<ProductOrder>? ProductOrders {get; set;} = default!; //Navigation property
}