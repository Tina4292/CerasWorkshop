using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CerasWorkshop.Models;

namespace CerasWorkshop.Pages;

public class ProductModel : PageModel
{
    private readonly AppDbContext _context;

    private readonly ILogger<IndexModel> _logger;

    public IList<Product> Product {get; set;} = default!;

    public ProductModel(AppDbContext context, ILogger<IndexModel> logger)
    {
        _context = context;
        _logger = logger;
    }

    public void OnGet()
    {
        Product = _context.Products.ToList();
    }
}
