using JonDou9000.TaskPlanner.Domain.Logic;
using JonDou9000.TaskPlanner.Domain.Models.Enums;
using JonDou9000.TaskPlanner.Domain.Models.Models;

internal static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введіть кількість :");
        int amount = int.Parse(Console.ReadLine());
        WorkItem[] items = new WorkItem[amount];
        for (int i = 0; i < amount; i++)
            items[i] = InitItem();

        items = items.CreatePlan();

        foreach (var item in items)
        {
            Console.WriteLine(item.ToString());
        }
    }

    public static WorkItem InitItem()
    {
        try
        {
            WorkItem workItem = new();
            Console.WriteLine("Title:");
            workItem.Title = Console.ReadLine();

            workItem.CreationDate = DateTime.Now;
            workItem.IsCompleted = false;
            workItem.DueDate = workItem.CreationDate.AddDays(1);

            Console.WriteLine("Due Date");
            workItem.DueDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Description");
            workItem.Description = Console.ReadLine();
            Console.WriteLine("Complexity");
            workItem.Complexity = (Complexity)int.Parse(Console.ReadLine());
            Console.WriteLine("Priority");
            workItem.Priority = (Priority)int.Parse(Console.ReadLine());

            return workItem;
        }
        catch (Exception)
        {
            Console.WriteLine("Помилка введення!");
            throw;
        }
    }
}