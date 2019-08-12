using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using appglobal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace wasco_q1.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {

        }

        public JsonResult OnPost (int n_number) {
            AppResponseMessage arm = new AppResponseMessage ();
            
            arm.success();
            arm.message = "Success";
            arm.data = count(n_number);
            return new JsonResult (arm);
        }

        public static int count(int n)
        {
            if (n <= 1) 
            { 
                return n; 
            } 
            else
            { 
                return count(n - 1) + count(n - 2); 
            }
          
        }
    }
}
