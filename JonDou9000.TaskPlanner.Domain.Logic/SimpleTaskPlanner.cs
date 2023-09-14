using JonDou9000.TaskPlanner.Domain.Models.Models;

namespace JonDou9000.TaskPlanner.Domain.Logic;
public static class SimpleTaskPlanner
{
    public static WorkItem[] CreatePlan(this WorkItem[] items)
    {
        return items
        .OrderByDescending(element => element.Priority)
        .ThenBy(element => element.DueDate)
        .ThenBy(element => element.Title)
        .ToArray();
    }
}
