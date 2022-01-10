using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApplication.Data.Models;

namespace ToDoApplication.Data.IServices
{
    public interface  IToDoRepository
    {
        Task<List<Reminder>> GetToDoList();

        Task<string> AddToDoList();

        Task<string> UpdateToDoList();

        Task<string> DeleteToDoList();

    }
}
