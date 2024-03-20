using System.ComponentModel.DataAnnotations;

namespace IceTaskOne_CLVDA.Models.Tasks
{
    public class Tasks
    {
        [Key]
        public int taskId { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        [Display(Name = "Task Name")]
        public string? taskName { get; set; }

        [RegularExpression(@"^(To Do|Doing|Done)$", ErrorMessage = "Please enter: To Do, Doing or Done")]
        [Required]
        [Display(Name = "Task State")]
        public string? taskState { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [Display(Name = "Person assigned")]
        public string? taskGiver { get; set; }


        [DataType(DataType.Date)]
        [Display(Name = "Due date")]
        public DateTime TaskDueDate { get; set; }
    }
}
