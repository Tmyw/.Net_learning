using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace ToDoList.Models;

public class ToDo
{   [Required]
    public int Id { get; set; }
    public string TaskName { get; set; }
    public bool IsDone { get; set; }
    public virtual IdentityUser User { get; set; }
}