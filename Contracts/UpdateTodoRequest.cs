using System.ComponentModel.DataAnnotations;
using Model.TodoEnums;
namespace TodoAPI.Contracts
{
    public class UpdateTodoRequest
    {
        [StringLength(100)]
        public string Title { get; set; }

        [StringLength(500)]
        public string Description { get; set; }
        public Status? status { get; set; }
        public DateTime? DueDate { get; set; }
        public Priority? priority { get; set; }
        public UpdateTodoRequest()
        {
            this.status = Status.NOT_STARTED;
        }
    }
}