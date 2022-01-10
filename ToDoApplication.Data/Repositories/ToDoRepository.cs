using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApplication.Data.Context;
using ToDoApplication.Data.IServices;
using ToDoApplication.Data.Models;

namespace ToDoApplication.Data.Repositories
{
    public class ToDoRepository : IToDoRepository
    {
        private readonly ToDoDBContext _db;
        public ToDoRepository(ToDoDBContext db)
        {
            _db= db;
        }
        public Task<string> AddToDoList()
        {
            throw new NotImplementedException();
        }

        public Task<string> DeleteToDoList()
        {
            throw new NotImplementedException();
        }

        public async Task<List<Reminder>> GetToDoList()
        {
            return await _db.Reminders.ToListAsync();
        }

        public Task<string> UpdateToDoList()
        {
            throw new NotImplementedException();
        }
    }
}
