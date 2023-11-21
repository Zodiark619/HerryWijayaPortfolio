using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Globalization;

namespace HerryWijayaPortfolio.Pages.Portfolio.TipCalculator
{
    
    public class TipCalculatorModel : PageModel
    {
        
        [BindProperty]

        public double tip {  get; set; }
        [BindProperty]

        public double bill { get; set; }
        [BindProperty]

        public string total { get; set; } 
        public void OnPostCalculateTip()
        {
          

            total = (bill * (1+ tip / 100)).ToString("0.00",CultureInfo.GetCultureInfo("en-US"));
            



        }
    }
}
