using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ITHS_DB_Lab4.Models
{
    class User
    {
        public int UserId { get; set; }
        [Required]
        [MaxLength(255)]
        public string Firstname { get; set; }
        [Required]
        [MaxLength(255)]
        public string Lastname { get; set; }
        public string Email { get; set; }
        public List<Workout> Workouts { get; set; }
    }
}
