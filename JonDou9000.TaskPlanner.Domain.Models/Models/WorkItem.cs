using JonDou9000.TaskPlanner.Domain.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//упні auto-implemented properties:
//a.CreationDate : DateTime
//Розробка проектів засобами платформи .NET / Практична робота №1 7
//b. DueDate : DateTime
//c.Priority : Priority(enum)
//d.Complexity : Complexity(enum)
//e.Title : string
//f.Description : string
//g.IsCompleted : bool


namespace JonDou9000.TaskPlanner.Domain.Models.Models;
public class WorkItem : ICloneable
{
    public Guid Id { get; set; }
    public DateTime CreationDate { get; set; }
    public DateTime DueDate { get; set; }
    public Priority Priority { get; set; }
    public Complexity Complexity { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public bool IsCompleted { get; set; }

    public object Clone() => new WorkItem()
    {
        Id = Id,
        CreationDate = CreationDate,
        DueDate = DueDate,
        Priority = Priority,
        Complexity = Complexity,
        Title = Title,
        Description = Description,
        IsCompleted = IsCompleted,
    };

    public override string ToString()
    {
        return $"Do {Title}: due {DueDate:f}, {Priority.GetName(Priority)} priority";
    }
}
