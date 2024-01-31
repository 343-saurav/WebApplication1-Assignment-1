using System.ComponentModel.DataAnnotations;

namespace WebApplication1_Assignment.Model
{
    public class TaskList
    {
        [Key]
        public int taskid { get; set; }
        public string taskname { get; set; }
        public string taskdescription { get; set; }
        public string taskstatus { get; set; }
    }
}
