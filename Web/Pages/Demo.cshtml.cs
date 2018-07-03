using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web.Models;

namespace Web.Pages
{
    public class DemoModel : PageModel
    {
        public List<TodoItem> TodoItems { get; set; }   
        public void OnGet()
        {
        }
    }
}