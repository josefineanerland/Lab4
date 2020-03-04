using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ITHS_DB_Lab4.Models
{
    class Equipment
    {
        public int EquipmentId { get; set; }
        [Required]
        public string Name { get; set; }

        public List<WorkoutEquipment> WorkoutEquipment { get; set; }
    }
}
