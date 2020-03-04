using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ITHS_DB_Lab4.Models
{
    class WorkoutExercise
    {
        public int WorkoutId { get; set; }
        public int ExerciseId { get; set; }
        public int? Reps { get; set; }

        [Range(0, 10)]
        public int? Strain { get; set; }
        public Workout Workout { get; set; }
        public Exercise Exercise { get; set; }
    }
}
