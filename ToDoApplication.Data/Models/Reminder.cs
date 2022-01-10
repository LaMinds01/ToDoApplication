using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApplication.Data.Models
{
    public  class Reminder
    {
        [Key]
        public int Id { get; set; }

        public Guid Guid { get; set; }

        [Column(TypeName="varchar(500)")]
        public string ReminderText { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
