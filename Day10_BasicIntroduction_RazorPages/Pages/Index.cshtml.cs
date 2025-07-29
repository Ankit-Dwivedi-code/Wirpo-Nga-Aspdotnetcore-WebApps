using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;


namespace Day10_BasicIntroduction_RazorPages.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public string CurrentTime { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }


        [BindProperty]
        public double Number1 { get; set; }

        [BindProperty]
        public double Number2 { get; set; }

        [BindProperty]
        public string Operation { get; set; }

        public string Result { get; set; }

        public void OnPost()
        {
            switch (Operation)
            {
                case "+":
                    Result = (Number1 + Number2).ToString();
                    break;
                case "-":
                    Result = (Number1 - Number2).ToString();
                    break;
                case "*":
                    Result = (Number1 * Number2).ToString();
                    break;
                case "/":
                    if (Number2 != 0)
                        Result = (Number1 / Number2).ToString();
                    else
                        Result = "Cannot divide by zero.";
                    break;
                default:
                    Result = "Invalid operation.";
                    break;
            }
        }

        public void OnGet()
        {
            CurrentTime = DateTime.Now.ToString("F");
        }
    }
}
