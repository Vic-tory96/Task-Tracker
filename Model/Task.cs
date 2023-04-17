using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListEFCore.Model
{
    public class Task
    {
        [Key]
        public int Id { get; set; }

        [Required]

        [StringLength(150, ErrorMessage = "Name Max Length is 150")] public string Name { get; set; }
        public DateTime DueDate { get; set; }

        public int StatusId { get; set; }

         public Status Status { get; set; }
        

      
    }

}
