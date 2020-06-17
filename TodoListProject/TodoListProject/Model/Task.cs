using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TodoListProject.Controller;

namespace TodoListProject
{
    public class Task : ITask
    {
        int id;
        string title;
        string about;
        DateTime deadline;
        bool completed;
        DateTime created_at;
        DateTime updated_at;
        int project_id;
        TaskDAO taskdao = new TaskDAO();

        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string About { get => about; set => about = value; }
        public DateTime Deadline { get => deadline; set => deadline = value; }
        public bool Completed { get => completed; set => completed = value; }
        public DateTime Created_at { get => created_at; set => created_at = value; }
        public int Project_id { get => project_id; set => project_id = value; }
        public DateTime Updated_at { get => updated_at; set => updated_at = value; }

        public bool Create()
        {
            return taskdao.Create(_ = this);
        }

        public bool Delete()
        {
            throw new NotImplementedException();
        }

        public Project[] Index()
        {
            throw new NotImplementedException();
        }

        public List<Task> Show(int id)
        {
            return taskdao.Index(id);
        }

        public bool Update()
        {
            return taskdao.Update(_ = this);
        }
    }
}