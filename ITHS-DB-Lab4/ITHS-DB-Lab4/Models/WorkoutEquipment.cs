using System;
using System.Collections.Generic;
using System.Text;

namespace ITHS_DB_Lab4.Models
{
    class WorkoutEquipment
    {
        public int WorkoutId { get; set; }
        public int EquipmentId { get; set; }

        public Workout Workout { get; set; }
        public Equipment Equipment { get; set; }
    }
}
