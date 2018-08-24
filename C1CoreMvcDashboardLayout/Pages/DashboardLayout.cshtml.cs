using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using C1CoreMvcDashboardLayout.Models; 

namespace C1CoreMvcDashboardLayout.Pages
{
    public class DashboardLayoutModel : PageModel
    {
        public IEnumerable<ProductData> data = ProductDashboardData.GetProductData();

        public void OnGet()
        {

        }


    }
}