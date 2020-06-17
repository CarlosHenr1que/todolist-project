using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TodoListProject
{
    public interface ITask
    {
        bool Create();
        bool Update();
        bool Delete();
        List<Task> Show(int id);
        Project[] Index();
    }
}