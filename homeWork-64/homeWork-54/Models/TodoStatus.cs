using System.ComponentModel.DataAnnotations;

namespace homeWork_54.Models;

public enum TodoStatus
{
    [Display(Name = "Новая")]
    New = 1,
    
    [Display(Name = "Открыта")]
    Opened = 2,
    
    [Display(Name = "Закрыта")]
    Closed = 3
}