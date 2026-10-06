using System.ComponentModel.DataAnnotations;

namespace homeWork_54.Models;

public class TodoTask
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Введите название задачи")]
    [Display(Name = "Название задачи")]
    public string Title { get; set; } = string.Empty;

    [Display(Name = "Описание задачи")]
    public string? Description { get; set; }

    [Required(ErrorMessage = "Укажите имя исполнителя")]
    [Display(Name = "Имя исполнителя")]
    public string Assignee { get; set; } = string.Empty;

    [Display(Name = "Приоритет")]
    public TaskPriority Priority { get; set; } = TaskPriority.Medium;

    [Display(Name = "Статус")]
    public TodoStatus Status { get; set; } = TodoStatus.New;

    [Display(Name = "Дата создания")]
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

    [Display(Name = "Дата закрытия")]
    public DateTime? ClosedDate { get; set; }
}