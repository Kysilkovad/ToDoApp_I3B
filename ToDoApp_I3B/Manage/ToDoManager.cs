using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ToDoApp_I3B.Databaze;
using ToDoApp_I3B.Model;

namespace ToDoApp_I3B.Manage
{
    public class ToDoManager
    {
        private readonly ToDoDbContext _dbContext;

        public ToDoManager(ToDoDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(ToDo todo)
        {
            _dbContext.Add(todo);
            _dbContext.SaveChanges();
        }

        public void Remove (ToDo todo)
        {
            _dbContext.Remove(todo);
            _dbContext.SaveChanges();
        }

        public void Update(ToDo todo)
        {
            _dbContext.Update(todo);
            _dbContext.SaveChanges();
        }

        public ToDo GetById(int id)
        {
            ToDo? todo = _dbContext.Find<ToDo>(id);
            if(todo == null)
            {
                throw new Exception("Hledaný prvek není v DB");
            }
            return todo;

            public IList<ToDo> GetAll() => _dbContext.ToDos.ToList();
        }
    }
}
