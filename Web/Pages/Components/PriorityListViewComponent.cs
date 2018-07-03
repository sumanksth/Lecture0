using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Pages.Components
{
    public class PriorityListViewComponent : ViewComponent
    {

        public IViewComponentResult Invoke(
            int maxPriority, bool isDone)
        {
            var items = GetItemsAsync(maxPriority, isDone);
            return View("~/pages/demo.cshtml",items);
        }
        private DemoModel GetItemsAsync(int maxPriority, bool isDone)
        {
            var todo = new List<TodoItem>
            {
                new TodoItem{IsDone = false, Name = "Task 1", Priority = 1},
                new TodoItem{IsDone = true, Name = "Task 2", Priority = 5},
                new TodoItem{IsDone = false, Name = "Task 3", Priority = 33},
                new TodoItem{IsDone = true, Name = "Task 4", Priority = 2},
                new TodoItem{IsDone = false, Name = "Task 5", Priority = 44},
            };
            var items = todo.Where(x => x.IsDone == isDone &&
                                             x.Priority <= maxPriority).ToList();

            return new DemoModel{TodoItems = todo};
        }
    }
}
