using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TodoListProject
{
    public interface IProject
    {
        bool Create(String title, String about, DateTime deadline, int user_id);
        bool Update();
        bool Delete();
        List<Project> Show(int id, bool completed);
        Project[] Index(); 
    }
}