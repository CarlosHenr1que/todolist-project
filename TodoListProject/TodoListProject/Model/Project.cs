using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TodoListProject.Controller;

namespace TodoListProject
{
    public class Project : IProject
    {
        int id;
        string title;
        string about;
        DateTime deadline;
        bool completed;
        DateTime created_at;
        DateTime updated_at;
        DateTime deleted_at;
        int user_id;
        ProjectDAO projectdao = new ProjectDAO();

        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string About { get => about; set => about = value; }
        public DateTime Deadline { get => deadline; set => deadline = value; }
        public bool Completed { get => completed; set => completed = value; }
        public DateTime Created_at { get => created_at; set => created_at = value; }
        public DateTime Updated_at { get => updated_at; set => updated_at = value; }
        public int User_id { get => user_id; set => user_id = value; }
        public DateTime Deleted_at { get => deleted_at; set => deleted_at = value; }

        public bool Create(string title, String about, DateTime deadline, int user_id)
        {
            
            return projectdao.Create(title, about, deadline, user_id);
        }

        public bool Delete()
        {
            return projectdao.Delete(_ = this);
        }

        public Project[] Index()
        {
            throw new NotImplementedException();
        }

        public List<Project> Show(int id, bool completed)
        {
            
            return projectdao.Index(id, completed);
        }

        public bool Update()
        {
            return projectdao.Update(_ = this);
        }
    }
}