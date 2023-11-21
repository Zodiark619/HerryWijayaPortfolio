using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HerryWijayaPortfolio.Pages.Portfolio.AgeCalculator
{
    public class AgeCalculatorInstance
    {
        public DateTime Age { get; set; }
        public string message { get; set; } 
    }
    public class AgeCalculatorModel : PageModel
    {
      
        [BindProperty]

        public AgeCalculatorInstance AgeCalculatorInstance { get; set; }=new AgeCalculatorInstance() { Age=DateTime.Now,message=""};
      
        public void OnPostCalculateAge()
        {
            var currentDate=DateTime.Now;
            var birthDate= AgeCalculatorInstance.Age.Date;
            var age=currentDate.Year-birthDate.Year;
            var month=currentDate.Month-birthDate.Month;

            if (month < 0 || (month == 0 && currentDate.Day < birthDate.Day))
            {
                age--;
            }
            var plural = age > 1 ? "years" : "year";
            AgeCalculatorInstance.message = $"Your age is {age} {plural}";
            
        }
    }
}
