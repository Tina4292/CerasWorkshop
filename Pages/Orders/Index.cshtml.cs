using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CerasWorkshop.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

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
        public Product Product {get; set;} = default!;

        [BindProperty(SupportsGet = true)]
        public int PageNum {get; set;} = 1;
        public int PageSize {get; set;} = 10;
        public int TotalPages {get; set;}

        [BindProperty(SupportsGet = true)]
        public string CurrentSort {get; set;} = string.Empty;

        [BindProperty(SupportsGet = true)]
        public string CurrentSearch{get; set;} = string.Empty;

        [DataType(DataType.Currency)]
        public decimal Shipping {get; set;}

        [DataType(DataType.Currency)]
        public decimal Tax {get; set;}

        [DataType(DataType.Currency)]
        public List<decimal> Total {get; set;} = new();

        public async Task OnGetAsync()
        {
            var query = _context.Orders.Include(po => po.ProductOrders!).ThenInclude(p => p.Product).Select(p => p);

            if (!string.IsNullOrEmpty(CurrentSearch))
            {
                query = query.Where(p => p.FirstName.ToUpper().Contains(CurrentSearch.ToUpper()) || p.LastName.ToUpper().Contains(CurrentSearch.ToUpper()) || p.OrderID.ToString().Contains(CurrentSearch) || p.ProductOrders!.Any(p => p.Product.Name.ToUpper().Contains(CurrentSearch.ToUpper())));
            }

            switch (CurrentSort)
            {
                case "first_asc":
                    query = query.OrderBy(p => p.FirstName);
                    break;
                case "first_desc":
                    query = query.OrderByDescending(p => p.FirstName);
                    break;
                case "last_asc":
                    query = query.OrderBy(p => p.LastName);
                    break;
                case "last_desc":
                    query = query.OrderByDescending(p => p.LastName);
                    break;
            }

            TotalPages = (int)Math.Ceiling(_context.Orders.Count() / (double)PageSize);

            Order = await query.Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();

            foreach (var order in Order)
            {
                Shipping = 19.99M;
                Tax = 0M;
                var total = 0M;

                foreach (var p in order.ProductOrders!)
                {
                    Tax = p.Product.Price * .0825M;
                    total += p.Product.Price + Shipping + Tax;
                }

                Total.Add(total);
            }
        }
    }
}
