using WebApplication1_Assignment.Model;

namespace WebApplication1_Assignment.IRepo
{
    public interface ITaskListRepo
    {
        List<TaskList> GetAll();
        void Add(TaskList obj);
        bool Update(TaskList obj, int id);
        bool Delete(int id);
    }
}
