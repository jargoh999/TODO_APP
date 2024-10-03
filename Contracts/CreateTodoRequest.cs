using System.ComponentModel.DataAnnotations;
using Model.TodoEnums;
namespace TodoAPI.Contracts
{

    public class CreateTodoRequest
    {
        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [Required]
        public DateTime DueDate { get; set; }


        public Priority priority { get; set; }

    }
}