using System.ComponentModel.DataAnnotations;

namespace CerasWorkshop.Models;

public class Order
{
    public int OrderID {get; set;} //Primary Key

    [Display(Name = "First Name")]
    [StringLength(50, MinimumLength = 3)]
    public string FirstName {get; set;} = string.Empty;

    [Display(Name = "Last Name")]
    [StringLength(50, MinimumLength = 3)]
    public string LastName {get; set;} = string.Empty;

    [Display(Name = "Product(s)")]
    public List<ProductOrder>? ProductOrders {get; set;} = default!; //Navigation property
}

public class ProductOrder
{
    public int ProductID {get; set;} //Composite Primary key, Foreign Key 1
    public int OrderID {get; set;} //Composite Primary key, Foreign Key 2
    public Product Product {get; set;} = default!; //Navigation Property
    public Order Order {get; set;} = default!; //Navigation Property
}