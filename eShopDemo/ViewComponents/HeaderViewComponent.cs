using eShopDemo.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopDemo.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        //private readonly AppDbContext _context;

        //public HeaderVC(AppDbContext context)
        //{
        //    _context = context;
        //}

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return (await Task.FromResult(View()));
        }
    }
}
