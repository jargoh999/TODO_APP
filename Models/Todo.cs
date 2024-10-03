using System.ComponentModel.DataAnnotations;
using Model.TodoEnums;
namespace TodoAPI.Models
{
    public class Todo
    {
        [Key]
        public Guid id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Status status { get; set; }
        public DateTime dueDate { get; set; }
        public Priority priority { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Todo()
        {
            this.status = Status.NOT_STARTED;
        }

    }
}