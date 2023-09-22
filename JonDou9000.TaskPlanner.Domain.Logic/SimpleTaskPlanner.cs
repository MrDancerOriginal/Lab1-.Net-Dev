using JonDou9000.TaskPlanner.Domain.Models.Models;
using TaskPlanner.DataAccess.Abstractions;

namespace JonDou9000.TaskPlanner.Domain.Logic;
public class SimpleTaskPlanner
{
    public SimpleTaskPlanner(IWorkItemsRepository workRepository)
    {
        WorkRepository = workRepository;
    }

    public IWorkItemsRepository WorkRepository { get; }

    public WorkItem[] CreatePlan()
    {
        return WorkRepository.GetAll()
        .Where(element => !element.IsCompleted)
        .OrderByDescending(element => element.Priority)
        .ThenBy(element => element.DueDate)
        .ThenBy(element => element.Title)
        .ToArray();
    }
}
