using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CerasWorkshop.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace CerasWorkshop.Pages_Orders
{
    public class DetailsModel : PageModel
    {
        private readonly CerasWorkshop.Models.AppDbContext _context;
        private readonly ILogger<DetailsModel> _logger;

        public DetailsModel(ILogger<DetailsModel> logger, CerasWorkshop.Models.AppDbContext context)
        {
            _context = context;
            _logger = logger;
        }

        public Order Order { get; set; } = default!;

        [BindProperty]
        [Display(Name = "Add Product")]
        [Required(ErrorMessage = "Invalid Product")]
        public int ProductIDToAdd {get; set;}
        public SelectList ProductDropDown {get; set;} = default!;

        [BindProperty]
        public int ProductIDToDelete {get; set;}

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders.Include(po => po.ProductOrders!).ThenInclude(p => p.Product).FirstOrDefaultAsync(m => m.OrderID == id);

            if (order == null)
            {
                return NotFound();
            }
            else
            {
                Order = order;
            }

            ProductDropDown = new SelectList(_context.Products.ToList(), "ProductID", "Name");
            return Page();
        }

        public IActionResult OnPostAddProduct(int? id)
        {
            _logger.LogWarning($"Add Product: ProductID {id}, ADD product {ProductIDToAdd}");

            if (id == null)
            {
                return NotFound();
            }

            var order = _context.Orders.Include(po => po.ProductOrders!).ThenInclude(p => p.Product).FirstOrDefault(m => m.OrderID == id);

            if (order == null)
            {
                return NotFound();
            }
            else
            {
                Order = order;
            }

            ProductDropDown = new SelectList(_context.Products.ToList(), "ProductID", "Name");

            if (!ModelState.IsValid)
            {
                _logger.LogWarning($"Model State is INVALID");
                return Page();
            }

            if (!_context.ProductOrders.Any(po => po.ProductID == ProductIDToAdd && po.OrderID == id))
            {
                ProductOrder productToAdd = new ProductOrder {OrderID = id.Value, ProductID = ProductIDToAdd};
                _context.Add(productToAdd);
                _context.SaveChanges();
            }
            else
            {
                _logger.LogWarning("Product already in order");
            }

            return Page();
        }

        public IActionResult OnPostDeleteProduct(int? id)
        {
            _logger.LogWarning($"Delete Product: OrderId {id}, DELETE product {ProductIDToDelete}");

            if (id == null)
            {
                return NotFound();
            }

            var order = _context.Orders.Include(po => po.ProductOrders!).ThenInclude(p => p.Product).FirstOrDefault(m => m.OrderID == id);

            if (order == null)
            {
                return NotFound();
            }
            else
            {
                Order = order;
            }

            ProductDropDown = new SelectList(_context.Products.ToList(), "ProductID", "Name");

            var productToDelete = _context.ProductOrders.Find(ProductIDToDelete, id);

            if (productToDelete != null)
            {
                _context.Remove(productToDelete);
                _context.SaveChanges();
            }
            else
            {
                _logger.LogWarning("Product NOT found in order");
            }

            return RedirectToPage(new {id = id});
        }
    }
}
