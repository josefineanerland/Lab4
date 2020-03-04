using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ITHS_DB_Lab4.Models
{
    class Exercise
    {
        public int ExerciseId { get; set; }
        [Required]
        public string Name { get; set; }

        public List<WorkoutExercise> WorkoutExercises { get; set; }
    }
}
