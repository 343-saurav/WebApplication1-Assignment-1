using WebApplication1_Assignment.DataContext;
using WebApplication1_Assignment.IRepo;
using WebApplication1_Assignment.Model;

namespace WebApplication1_Assignment.Repo
{
    public class TaskListRepocs :ITaskListRepo
    {
        ApplicationContext _context;
        public TaskListRepocs(ApplicationContext context)
        {
            _context = context;

        }

        public List<TaskList> GetAll()
        {
            var data = _context.taskLists.ToList();
            return data;
        }
        public void Add(TaskList task)
        {
            _context.taskLists.Add(task);
            _context.SaveChanges();
        }

        public bool Update(TaskList task, int id)
        {
            var data = _context.taskLists.Where(e => e.taskid == id).SingleOrDefault();
            if (data == null)
            {
                return false;
            }
            else
            {
                data.taskname = task.taskname;
                data.taskstatus = task.taskstatus;
                data.taskdescription = task.taskdescription;
                _context.taskLists.Update(data);
                _context.SaveChanges();
                return true;

            }

        }

        public bool Delete(int taskid)
        {

            var data = _context.taskLists.Where(x => x.taskid == taskid).SingleOrDefault();
            if (data == null)
            {
                return false;
            }
            else
            {
                _context.taskLists.Remove(data);
                _context.SaveChanges();
                return true;
            }

        }
    }
}
