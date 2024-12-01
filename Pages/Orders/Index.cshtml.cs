using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CerasWorkshop.Models;

namespace CerasWorkshop.Pages_Orders
{
    public class IndexModel : PageModel
    {
        private readonly CerasWorkshop.Models.AppDbContext _context;

        public IndexModel(CerasWorkshop.Models.AppDbContext context)
        {
            _context = context;
        }

        public IList<Order> Order { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Order = await _context.Orders.Include(po => po.ProductOrders!).ThenInclude(p => p.Product).ToListAsync();
        }
    }
}
