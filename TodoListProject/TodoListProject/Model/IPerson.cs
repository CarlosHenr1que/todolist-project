using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TodoListProject
{
    public interface IPerson
    {
        bool Delete(int id);
        bool Index();
        bool Show(int id);
        Person SignIn(String email, String password);
        bool SignUp(String username, String email, String password);
        bool Update();
    }
}