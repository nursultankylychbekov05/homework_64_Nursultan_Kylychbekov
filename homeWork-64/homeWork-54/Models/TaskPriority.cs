using System.ComponentModel.DataAnnotations;

namespace homeWork_54.Models;

public enum TaskPriority
{
    [Display(Name = "Высокий")]
    High = 1,
    
    [Display(Name = "Средний")]
    Medium = 2,
    
    [Display(Name = "Низкий")]
    Low = 3
}