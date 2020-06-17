using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TodoListProject.Controller;

namespace TodoListProject
{
    public class Person : IPerson
    {
        private int id;
        private String username;
        private String email;
        private String password;

        private UserDAO userdao;

        public int Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Index()
        {
            throw new NotImplementedException();
        }

        public bool Show(int id)
        {
            throw new NotImplementedException();
        }

        public Person SignIn(String email, String password)
        {
            userdao = new UserDAO();
            object[] retorno = userdao.SignIn(email, password);

            Person pessoa = new Person();
            if(retorno[0] != null)
            {
                pessoa.id = (int)retorno[0];
                pessoa.username = (string)retorno[1];
                pessoa.email = (string)retorno[2];
                return pessoa;
            }

            return null;

        }

        public bool SignUp(string username, string email, string password)
        {
            userdao = new UserDAO();
            return userdao.SignUp(username, email, password);
        }

        public bool Update()
        {
            userdao = new UserDAO();
            return userdao.Update(_ = this);
        }
    }
}