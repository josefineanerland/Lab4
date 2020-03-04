using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ITHS_DB_Lab4.Models
{
    class Workout
    {
        public int WorkoutId { get; set; }
        public int UserId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public TimeSpan Time { get; set; }
        public string Type { get; set; }

        public User User { get; set; }
        public List<WorkoutEquipment> WorkoutEquipment { get; set; }
        public List<WorkoutExercise> WorkoutExercises { get; set; }
    }
}
