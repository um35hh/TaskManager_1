using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager_1.Shared.Domain
{
    public class UserTask : BaseDomainModel 
    {

        [Required]
        [StringLength(100, ErrorMessage = "Task Name is too long.")]
        public string TaskName { get; set; }
        public Boolean IsCompleted { get; set; }

        public DateTime? DueDate { get; set; } 


    }
}

